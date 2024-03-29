###################################################################################
# Install-Launcher
# Stefan Wehrli <wehrlist@ethz.ch>
# September 10th, 2010
###################################################################################

# CONTENTS

# - Get-launcherSecurity
# - Set-LauncherSecurity
# - Remove-LauncherSecurity

# - Get-EmbeddedBrowserVersion
# - Set-EmbeddedBrowserVersion
# - Remove-EmbeddedBrowserVersion

###################################################################################

# Quick steps to install Launcher for .Net 3.5
#
# Prerequisites:
# Windows XP, Windows Vista, or Windows 7
# Windows Management Framework 2 (PowerShell 2, .Net 3.5)
# 
# 1) Enable PsRemoting
# 2) Copy Launcher PsModule folder to PowerShell Module folder, 
#    name it Launcher 
# 3) Add Launcher Security
# 4) Set version of embedded browser in Registry
# 5) Enable AutoLogon 
# 6) Restrict profile / enforce Kiosk mode

###################################################################################
# On Windows 7 and higher, you have to add an URL reservation for the user who
# starts Launcher. Launcher will then expose a WebService on port 8000.
# This only secures it from being started. There is no option for access security
# at the moment. Everybody who has access to the URL can excute remote code.
# Beware. Set your firewall with care!

<# 
 .SYNOPSIS 
  Shows Launcher URL Reservations.

 .DESCRIPTION
  Shows Launcher URL Reservations, i.e. who can start a
  Launcher TunnelHost.

 .LINK
  about_Launcher
  Set-LauncherSecurity, Remove-LauncherSecurity
#>
function Get-LauncherSecurity([string]$Endpoint="PowerShellTunnel") {
  $b = netsh http show urlacl
  $j = 0
  for($i = 0; $i -lt $b.length; $i++) {
  
    if($b[$i].ToString().IndexOf($Endpoint) -gt 0)
    {
      $j = 1
    }
    if($j -gt 0 -and $j -lt 7) {
      write-host $b[$i]
      $j++
    }
    else
    {
      $j = 0
    }
  }
} 

<# 
 .SYNOPSIS 
  Add user, port, and endpoint to security whitelist

 .DESCRIPTION
  Add a (WCF) URL reservation for a user, i.e. the user is allowed to start
  Launcher as host/server/listener. You can specify a user or user group,
  a port (default 8000), and an endpoint (default: /PowerShellTunnel/Host1).
  The user or group parameter only restricts execution and not access rights.
  
  There is no security implemented for client access. Restrict access to 
  Launcher's TunnelHost by means of the firewall. As soon as Launcher runs 
  on a port, everybody can access it and execute command. 
  
  This command requires an elevated prompt, i.e. administrative rights.

 .LINK
  about_Launcher
  Get-LauncherSecurity, Remove-LauncherSecurity
#>
function Set-LauncherSecurity([string]$User="Everyone",[string]$Port="8000") {
  $hostmasklist = "http://+:$Port/PowerShellTunnel/Host1", "http://+:$Port/PowerShellTunnel/Host2"
  $hostmasklist | foreach-object { netsh http add urlacl url="$_" user=$User } 
}

<# 
 .SYNOPSIS 
  Remove user to security group

 .DESCRIPTION
  Removes the (WCF) URL reservation. 

 .LINK
  about_Launcher
  Get-LauncherSecurity, Set-LauncherSecurity
#>
function Remove-LauncherSecurity([string]$Port="8000") {
  $hostmasklist = "http://+:$Port/PowerShellTunnel/Host1", "http://+:$Port/PowerShellTunnel/Host2"
  $hostmasklist | foreach-object { netsh http delete urlacl url="$_" }
}

###################################################################################
# Launcher's WebControl (i.e. the browser) needs a registry hack,
# otherwise the control runs in IE7 compatibility mode.
# http://www.west-wind.com/weblog/posts/2011/May/21/Web-Browser-Control-Specifying-the-IE-Version

#Set-EmbeddedBrowserControlVersion "launcher.exe" "9999" "x86"
#Set-EmbeddedBrowserControlVersion "launcher.exe" "9999" "x64"
#Get-EmbeddedBrowserControlVersion "launcher.exe"
#Remove-EmbeddedBrowserControlVersion "launcher.exe"

#Set-EmbeddedBrowserControlVersion "launcher.exe" "10001" "x86"
#Set-EmbeddedBrowserControlVersion "launcher.exe" "10001" "x64"
#Get-EmbeddedBrowserControlVersion "launcher.exe"
#Remove-EmbeddedBrowserControlVersion "launcher.exe"

<# 
 .SYNOPSIS 
  Queries version of embedded webbrowser

 .DESCRIPTION
  Queries version of embedded webbrowser

 .LINK
  about_Launcher
  Set-EmbeddedBrowserVersion, Remove-EmbeddedBrowserVersion
#>
function Get-EmbeddedBrowserVersion($Application, $Platform="x86") {
  # $application: launcher.exe

  if($Platform -eq "x86")
  {
     $path = "HKLM:\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION"
  }
  else
  {
    $path = "HKLM:\SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION"
  }
  
  Get-ItemProperty $path -name $Application
}


<# 
 .SYNOPSIS 
  Set version of embedded webbrowser

 .DESCRIPTION
  Launcher Winform Application has an embedded Internet Explorer
  to display webpages in a secured, locked down kiosk environment.
  By default, the embedded IE runs in compatiblity mode, i.e. it 
  runs version 7. To enforce a newer version, you have to add a
  registery key to override browser emulation.
  
  10001 Use IE10, enforce it
  10000 Use IE10, allow compatibility mode
  9999  Use IE9, enforce it
  9000  Use IE9, allow compatibility mode
  8888  Use IE8, enforce it
  8000  Use IE8, allow compatibility mode
  etc.
  
 .Example
  Set-BrowserVersion "launcher.exe" "9000" "x86"
  
 .LINK
  about_Launcher
  Get-EmbeddedBrowserVersion, Remove-EmbeddedBrowserVersion
#>
function Set-EmbeddedBrowserVersion($Application, $Value, $Platform="x86") {
  # $application: launcher.exe
  # $value:       10000, 10001, 9999,9000,8888,8000,7000
  
  if($Platform -eq "x86")
  {
     $path = "HKLM:\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION"
  }
  else
  {
    $path = "HKLM:\SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION"
  }
  
  New-ItemProperty $path -name $Application -value $Value -propertyType dword
}

<# 
 .SYNOPSIS 
  Remove version of embedded webbrowser

 .DESCRIPTION
  Remove version of embedded webbrowser

 .LINK
  about_Launcher
  Set-EmbeddedBrowserVersion, Get-EmbeddedBrowserVersion
#>
function Remove-EmbeddedBrowserVersion($Application, $Platform="x86") {
  # $application: launcher.exe
  
  if($Platform -eq "x86")
  {
     $path = "HKLM:\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION"
  }
  else
  {
    $path = "HKLM:\SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION"
  }
  
  Remove-ItemProperty $path -name $Application
}

###################################################################################
# Exports

#Export-ModuleMember Get-LauncherSecurity, Set-LauncherSecurity, Remove-LauncherSecurity
#Export-ModuleMember Get-EmbeddedBrowserVersion, Set-EmbeddedBrowserVersion, Remove-EmbeddedBrowserVersion

###################################################################################