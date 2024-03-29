###################################################################################
# Launcher Pool
# Stefan Wehrli
# September 10th, 2010
###################################################################################

# CONTENTS

#  - about_LauncherPool       Send commands to clients (wrapper for PowerShellTunnel)
#  - Select-Pool
#  - Register-Pool
#  - Invoke-Pool
#  - Remove-Pool
#  - Get-PoolData

#  - about_LauncherTunnel     Send a command to a single client, setup a listener
#  - Add-Tunnel
#  - Invoke-Tunnel
#  - Remove-Tunnel
#  - Add-TunnelHost
#  - Remove-TunnelHost

###################################################################################
<# 
 .SYNOPSIS 
  Commands for controlling Pools and Tunnels 

 .DESCRIPTION
  A Launcher pool is a set of computers with established tunnels. 
  The master can execute commands on the clients.
  
  The pool gets stored in the global variable $LauncherPool. Use the 
  following commands to work with a Launcher pool:
  
  - Select-Pool
  - Register-Pool
  - Invoke-Pool
  - Remove-Pool
  - Get-PoolData
    
 .LINK
  about_Launcher
  about_Tunnel
#>
function about_Pool {}

###################################################################################
<# 
 .SYNOPSIS 
  Start LauncherSelector GUI to select computers

 .DESCRIPTION
  Start the LauncherSelector Winform Application. The function looks
  for a 'LauncherSelector.exe' in the module folder and executes it.
  Returns a list of computer names.

 .LINK
  about_Pool
#>
function Select-Pool([bool]$Interactive=$true, [string]$FileName, [switch]$All, [switch]$Selected) {
  $module = get-module launcher
  $exe = join-path $module.modulebase "LauncherPool.exe"

  if($Interactive) {
    $ret = (. $exe -i)
  }

  if($ret.length -gt 0) {
    $ret = $ret.Split(',')
    return $ret
  }
}

###################################################################################
<# 
 .SYNOPSIS 
  Adds a list of computers to a pool.

 .DESCRIPTION
  Takes a list of computers and opens a LauncherTunnel to 
  each of the computers. After the pool is registered,
  send commands to the clients with Invoke-Pool. 
  
  The list of tunnels to the computer in the pool
  is stored in the global variable $LauncherPool.  
  
 .Example
  Register-Pool "remotehost01", "remotehost02"
  
 .LINK
  about_Pool
  about_Tunnel
  Invoke-Pool, Remove-Pool
#>
function Register-Pool([string[]]$ComputerName) {
  [PowerShellTunnel.Client.ITunnel[]]$global:LauncherPool = $null;
  foreach($computer in $ComputerName) {
    $endpoint = "http://" + $computer + ":" + $LauncherPort + "/" + $LauncherEndpoint + "/Host1";
    $global:LauncherPool += Add-Tunnel $endpoint;
   }
   Invoke-Pool { Get-LauncherVersion }
}

###################################################################################
<# 
 .SYNOPSIS 
  Invokes a script block on remote computers.

 .DESCRIPTION
  Invokes a script block on remote computers that
  have been registered in a pool. Use Register-Pool
  to setup a pool. After that you can send commands
  to the pool with Invoke-Pool { ... } where [...]
  can be a Dos-Command or a PowerShell Command.
  
 .Example
  Invoke-Pool { dir }
 
 .Example
  Invoke-Pool { notepad }
  
 .LINK
  about_Pool
  Register-Pool, Remove-Pool
#>
function Invoke-Pool([string]$Cmd,[switch]$PipeOutput) {
  for($i = 0; $i -lt $global:LauncherPool.count; $i++) {
    if (!$Cmd) {
      $input | Invoke-Tunnel {Invoke-Expression $input} -tunnel $global:LauncherPool[$i];
    } else {
      $sb = [scriptblock]::Create($Cmd);
      if ($PipeOutput.isPresent) {
        Invoke-Tunnel $sb -tunnel $global:LauncherPool[$i] -PipeOutput;
      } else {
        Invoke-Tunnel $sb -tunnel $global:LauncherPool[$i];
      }
    }
  }
}

###################################################################################
<# 
 .SYNOPSIS 
  Removes a pool.

 .DESCRIPTION
  Recycles a LauncherPool which is stored in $LauncherPool
  
 .Example
  Remove-Pool
  
 .LINK
  about_Pool
  Register-Pool, Invoke-Pool
#>
function Remove-Pool {
  for($i = 0; $i -lt $global:LauncherPool.count; $i++) {
    Remove-Tunnel $global:LauncherPool[$i];
  }  
}

###################################################################################
<# 
 .SYNOPSIS 
  Commands for controlling Tunnels and Pools

 .DESCRIPTION
  PowerShellTunnel allow to build up a connection between runspaces. 
  Since a connection to the PowerShell user session on a remote 
  machine is blocked by design, we need to establish a listener on
  the remote machine. The LauncherTunnel binary module provides a 
  tunnel host and tunnel client, which serializes/deserializes objects
  between the two sessions.
  
  Server:
  - Add-TunnelHost
  - Remove-TunnelHost
  
  Client:
  - Add-Tunnel
  - Select-Tunnel
  - Invoke-Tunnel
  - Remove-Tunnel
  
 .Example
  $host = Add-TunnelHost "http://localhost:8000/PowerShellTunnel/Host1"
  
 .Example
  $tunnel = Add-Tunnel "http://localhost:8000/PowerShellTunnel/Host1"
  
 .Example
  Invoke-Tunnel {notepad}
  
 .LINK
  about_Launcher
  See PowerShellTunnel:
  http://code.msdn.microsoft.com/PowerShellTunnel/
#>
function about_Tunnel {}

###################################################################################
# Function to import the LauncherTunnel as Binary Module

function Import-LauncherTunnel {
  $module = get-module Launcher -listavailable
  if($module.Count -gt 1)
  {
    #$module.Count should be $null, but it's not in the embedded runtime
    #this if condition is just to fix this.
    $dll = join-path $module[0].modulebase "PowerShellTunnel.dll"
  }
  else {
    $dll = join-path $module.modulebase "PowerShellTunnel.dll"
  }
  Import-Module $dll -Global
}

###################################################################################
# Exports

#Export-ModuleMember about_Pool
#Export-ModuleMember Select-Pool, Register-Pool, Invoke-Pool, Remove-Pool, Get-PoolData

#Export-ModuleMember about_Tunnel
#Export-ModuleMember -Cmdlet Add-Tunnel, Remove-Tunnel, Invoke-Tunnel, Select-Tunnel, Add-TunnelHost, Remove-TunnelHost

###################################################################################