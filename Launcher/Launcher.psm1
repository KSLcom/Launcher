###################################################################################
# Launcher
# Stefan Wehrli <wehrlist@ethz.ch>
# September 10th, 2010
###################################################################################

# GLOABAL VARIABLES
$global:LauncherEndpoint = "PowerShellTunnel"
$global:LauncherPort = "8000"
$global:ScreenShotPath = "c:\home\scratch\temp"
$global:ScreenShotPath2 = "file:///c:/home/"
$global:ScreenShotCounter = 1
$global:poolData = $null

###################################################################################
# CONTENTS

# Launcher main commands
# - about_Launcher               General Information, type 'help about_Launcher'
# - Start-Launcher
# - Stop-Launcher
# - Restart-Launcher
# - Start-Program

# Command in external files
# - about_Browsers               See file Browsers.ps1
# - about_Install                See file Install.ps1
# - about_Pool                   See file Pool.ps1

# Commands of embedded runtime
#   - Show-Launcher
#   - Hide-Launcher
#   - Get-LauncherData
#   - Enable-Launcher
#   - Disable-Launcher

#   - Show-WaitForm
#   - Send-WaitForm
#   - Hide-WaitForm
#   - Get-WaitData
#   - Send-Notificat

#   - Start-ScreenSaver
#   - Stop-ScreenSaver
#   - Enable-Keyboard
#   - Disable-Keyboard
#   - Enable-Mouse
#   - Disable-Mouse
#   - Enable-KioskFilter
#   - Disable-KioskFilter

#   - Get-ScreenShots
#   - Get-LauncherLog
#   - Add-LauncherLog
#   - Close-Window
#   - Get-LauncherVersion

###################################################################################
<# 
 .SYNOPSIS 
  An embedded PowerShell runspace to execute remote commands.

 .DESCRIPTION
  Launcher is a .Net 3.5 Windows Forms applications sitting in the system
  notification area of a windows computer. On start, it opens a
  tunnelhost on http://localhost:8000/PowerShellTunnel/Host1 and listens
  for remote command by a master.
  
  With a double click on the icon, you can access the Launcher remote 
  console to remote control a pool of computers equipted with Launcher.
  
  Launcher comes with a PowerShell module and scripting environment
  to integrate and automate comman tasks in a computer lab. Use the
  following commands to start and stop launcher from a PowerShell:
    
  - Start-Launcher, Stop-Launcher
  
  Use the following commands to send commands to remote computers:
  - Register-Pool, Invoke-Pool, Remove-Pool, Get-PoolData
  
  The following commands are used to control the embedded runtime:
  - Show-Browser, Send-Browser, Hide-Browser, Get-BrowserData
  - Show-WaitForm, Send-WaitForm, Hide-WaitForm, Get-WaitData
  - Show-AuthForm, Hide-AuthForm, Get-AuthData, Set-AuthData
  - Show-Launcher, Hide-Launcher, Enable-Launcher, Disable-Launcher
  - Enable-KioskFilter, Disable-KioskFilter
  - Enable-Keyboard, Disable-Keyboard, Enable-Mouse, Disable-Mouse
  - Get-Screen, Get-ScreenShot, Show-ScreenShot
  - Get-ScreenShotFiles, Clear-ScreenShotFiles
  
 .Example
  Register-Pool localhost            Define a pool / tunnel
  Invoke-Pool { notepad }            Start notepad on pool computers
  Invoke-Pool { dir }                Return directory listing
  Invoke-Pool { Get-LauncherData }   Query the slaves.
  
 .Example 
  Invoke-Pool { Show-Launcher }
  Invoke-Pool { Hide-Launcher }
  Invoke-Pool { Disable-Launcher }
  Invoke-Pool { Enable-Launcher }
  
 .LINK
  about_Pool
  Start-Launcher, Stop-Launcher
  Register-Pool, Invoke-Pool, Remove-Pool
#>
function about_Launcher {}

###################################################################################
<# 
 .SYNOPSIS 
  Initialize Launcher

 .DESCRIPTION
  Initialize Launcher by setting the global variables

 .LINK
  about_Launcher
#>
function Initialize-Launcher([string]$BaseAddress, [int]$Port, [string]$ScreenShotPath)  {

  # See more global variables at the end of this file
  $global:LauncherEndpoint = "PowerShellTunnel"
  $global:LauncherPort = "8000"
  $global:screenShotPath = "c:\home\scratch\temp"
  $global:screenShotPath2 = "file:///c:/home/"
  $global:screenShotCounter = 1
  $global:poolData = $null
  
  # Global Variables
  [PowerShellTunnel.Client.ITunnel[]]$global:LauncherPool = $null
  [PowerShellTunnel.Client.ITunnel[]]$global:LauncherPool2 = $null

}

###################################################################################
<# 
 .SYNOPSIS 
  Start Launcher

 .DESCRIPTION
  Start the Launcher Winform Application. The function looks
  for a 'launcher.exe' in the module folder and executes it.
  Switch -i shows the windows, otherwise Launcher runs in the
  system notification area.

 .LINK
  about_Launcher
#>
function Start-Launcher([switch]$Interactive) {
  $module = get-module launcher
  $exe = join-path $module.modulebase "launcher.exe"
  if ($Interactive.isPresent) {  
    . $exe -i 
  } else {
    . $exe
  }
}

###################################################################################
#<# 
# .SYNOPSIS 
#  Start Launcher on Remote Host 
#
# .DESCRIPTION
#  Start Launcher on Remote Host by
#  Start-Program
#
# .LINK
#  about_Launcher
##>
#function Start-RemoteLauncher([string[]]$ComputerName,[string]$User) {
#  $module = get-module launcher
#  $exe = join-path $module.modulebase "launcher.exe"
#  Start-Program -c $ComputerName -p $exe -u $User
#}

###################################################################################
<# 
 .SYNOPSIS 
  Stops Launcher in the pool.

 .DESCRIPTION
  Stop Launcher Winform Applications on one or more computers 
  by setting up a PowerShell remote session and simply killing 
  the process.
  
  If no list of computers is found, the function will be executed
  on localhost. You need sufficient rights to execute this command.

 .LINK
  about_Launcher
#>
function Stop-Launcher ([string[]]$ComputerName) {
  
  #Embedded execution
  if($launcher) {
    $launcher.Shutdown()
    return
  }
  
  #Local execution
  if($ComputerName -eq $null)
  {
    $ComputerName = "localhost"
    Stop-Process -name "Launcher" -force
    return
  }
  
  # Remote execution
  $a = invoke-command { Stop-Process -name "Launcher" -force } -computername $ComputerName -asJob
  $b = wait-job -id $a.ID
  $c = receive-job -id $a.ID
  return $c
}

<# 
 .SYNOPSIS 
  Restart Launcher.

 .DESCRIPTION
  Restart Launcher.

 .LINK
  about_Launcher
#>
function Restart-Launcher {
  # Gets loaded automatically within Launcher
  $launcher.Restart();
}

###################################################################################
<# 
 .SYNOPSIS 
  Show Launcher window.

 .DESCRIPTION
  Show Launcher window.

 .LINK
  about_Launcher
  Hide-Launcher
#>
function Show-Launcher {
  # Gets loaded automatically within Launcher
  $launcher.ShowGui();
}

<# 
 .SYNOPSIS 
  Hides the Launcher window.

 .DESCRIPTION
  Hides the Launcher window.

 .LINK
  about_Launcher
  Show-Launcher
#>
function Hide-Launcher {
  # Gets loaded automatically within Launcher
  $launcher.HideGui();
}

<# 
 .SYNOPSIS 
  Unlocks the Launcher console window.

 .DESCRIPTION
  Unlocks the Launcher console window.

 .LINK
  about_Launcher
  Disable-Launcher
#>
function Enable-Launcher {
  # Gets loaded automatically within Launcher
  $launcher.EnableGui();
}

<# 
 .SYNOPSIS 
  Locks the Launcher console window.

 .DESCRIPTION
  Locks the Launcher console window.

 .LINK
  about_Launcher
  Enable-Launcher
#>
function Disable-Launcher {
  # Gets loaded automatically within Launcher
  $launcher.DisableGui();
}

###################################################################################
<# 
 .SYNOPSIS 
  Get Launcher data.

 .DESCRIPTION
  Get Launcher data. 

 .LINK
  about_Launcher
  Get-BrowserData, Get-AuthData, Get-WaitData
#>
function Get-LauncherData {
  $object = New-Object Object | 
  Add-Member NoteProperty Host "" -PassThru | 
  Add-Member NoteProperty Version "" -PassThru |            
  Add-Member NoteProperty IsLauncherVisible "" -PassThru |
  Add-Member NoteProperty IsWaitFormVisible "" -PassThru |
  Add-Member NoteProperty IsAuthFormVisible "" -PassThru |
  Add-Member NoteProperty IsBrowserFormVisible "" -PassThru | 
  Add-Member NoteProperty IsLauncherEnabled "" -PassThru |  
  Add-Member NoteProperty IsKioskEnabled "" -PassThru | 
  Add-Member NoteProperty IsScreenEnabled "" -PassThru |  
  Add-Member NoteProperty IsKeyboardEnabled "" -PassThru | 
  Add-Member NoteProperty IsMouseEnabled "" -PassThru |
  Add-Member NoteProperty Login "" -PassThru |
  Add-Member NoteProperty LoginUid "" -PassThru |
  Add-Member NoteProperty LoginTime "" -PassThru |
  Add-Member NoteProperty LoginTrials "" -PassThru |
  Add-Member NoteProperty BrowserUrl "" -PassThru |
  Add-Member NoteProperty BrowserLastClick "" -PassThru |
  Add-Member NoteProperty BrowserLastEntry "" -PassThru
  
  $object.Host = $hostname
  $object.Version = $version
  $object.IsLauncherVisible = $launcher.IsLauncherVisible
  $object.IsWaitFormVisible = $launcher.IsWaitFormVisible
  $object.IsAuthFormVisible = $launcher.IsAuthFormVisible
  $object.IsBrowserFormVisible = $launcher.IsBrowserFormVisible
  $object.IsLauncherEnabled = $launcher.IsLauncherEnabled
  $object.IsKioskEnabled = $launcher.IsKioskEnabled
  $object.IsScreenEnabled = $launcher.IsScreenEnabled
  $object.IsKeyboardEnabled = $launcher.IsKeyboardEnabled
  $object.IsMouseEnabled = $launcher.IsMouseEnabled
  $object.Login = $authform.Login
  $object.LoginUid = $authform.Uid
  $object.LoginTime = $authform.LoginTime
  $object.LoginTrials = $authform.Trials
  $object.BrowserUrl = $browser.Url
  $object.BrowserLastClick = $browser.LastClick
  $object.BrowserLastEntry = $browser.LastEntry
  return $object
}

<# 
 .SYNOPSIS 
  Get pool data.

 .DESCRIPTION
  Invokes Get-LauncherData on the registered pool, collects all 
  data and stores results in the global variable $poolData. with
  the switch -silent data get only stored in the variable and will
  not be return to console. Use this function for polling the pool 
  status.

 .LINK
  about_Launcher
#>
function Get-PoolData ([switch]$Silent) {
  $stack = Invoke-Pool { Get-LauncherData }
  $i = 0
  $data = Get-LauncherData
  [System.Object[]]$result = $data
  foreach($line in $stack) {
    
    if($line.length -gt 0) {
      if($i -eq 0) {
        $data.Host = $line.SubString($line.IndexOf(":")+1).Trim()
      }
      if($i -eq 1) {
        $data.Version = $line.SubString($line.IndexOf(":")+1).Trim()
      }
      if($i -eq 2) {
        if($line.IndexOf("True") -gt 0) {$temp = $true } else {$temp = $false}
        $data.IsLauncherVisible = $temp
      }
      if($i -eq 3) {
        if($line.IndexOf("True") -gt 0) {$temp = $true } else {$temp = $false}
        $data.IsWaitFormVisible = $temp
      }
      if($i -eq 4) {
        if($line.IndexOf("True") -gt 0) {$temp = $true } else {$temp = $false}
        $data.IsAuthFormVisible = $temp
      }
      if($i -eq 5) {
        if($line.IndexOf("True") -gt 0) {$temp = $true } else {$temp = $false}
        $data.IsBrowserFormVisible = $temp
      }
      if($i -eq 6) {
        if($line.IndexOf("True") -gt 0) {$temp = $true } else {$temp = $false}
        $data.IsLauncherEnabled = $temp
      }
      if($i -eq 7) {
        if($line.IndexOf("True") -gt 0) {$temp = $true } else {$temp = $false}
        $data.IsKioskEnabled = $temp
      }
      if($i -eq 8) {
        if($line.IndexOf("True") -gt 0) {$temp = $true } else {$temp = $false}
        $data.IsScreenEnabled = $temp
      }
      if($i -eq 9) {
        if($line.IndexOf("True") -gt 0) {$temp = $true } else {$temp = $false}
        $data.IsKeyboardEnabled = $temp
      }
      if($i -eq 10) {
        if($line.IndexOf("True") -gt 0) {$temp = $true } else {$temp = $false}
        $data.IsMouseEnabled = $temp
      }
      if($i -eq 11) {
        if($line.IndexOf("True") -gt 0) {$temp = $true } else {$temp = $false}
        $data.Login = $temp
      }
      if($i -eq 12) {
        $data.LoginUid = $line.SubString($line.IndexOf(":")+1).Trim()
      }
      if($i -eq 13) {
        $data.LoginTime = $line.SubString($line.IndexOf(":")+1).Trim()
      }
      if($i -eq 14) {
        $data.LoginTrials = $line.SubString($line.IndexOf(":")+1).Trim()
      }
      if($i -eq 15) {
        $data.BrowserUrl = $line.SubString($line.IndexOf(":")+1).Trim()
      }
      if($i -eq 16) {
        $data.BrowserLastClick = $line.SubString($line.IndexOf(":")+1).Trim()
      }
      if($i -eq 17) {
        $data.BrowserLastEntry = $line.SubString($line.IndexOf(":")+1).Trim()
      }      
      $i++
      if($i -eq 18) {
        $result += $data
        $data = Get-LauncherData
        $i = 0 
      }
    }
  }
  $global:poolData = $result[1..$result.length]
  if ($Silent.isPresent) {
    return
  }
  return $poolData
}

####################################################################
# BROWSER

<# 
 .SYNOPSIS 
  Show a web browser.

 .DESCRIPTION
  Opens a browser window. The browser is a maximized windows form
  with an embedded Internet Explorer without address line, toolbars,
  or context menus, i.e. the form is in kiosk mode. Launcher exposes
  the browser as an object in the run space. You can access all it's 
  methods and properties in the following way:
  
  $browser | Get-Member
  
  Or you can access its methods like below:
  
  $browser.Navigate("www.google.com")
  $browser.GoBack()
  $browser.GoForward()
  $browser.GoHome()
  $browser.PrintPage()
  $browser.RefreshPage()
  $browser.Stop()
  
  $browser.BrowserWindowState = "maximized"
  $browser.BrowserWindowState = "normal"
  
  $browser.ScriptErrorSuppressed = $true  
  $browser.ScrollBarsEnabled = $true
  $browser.DocumentText = "Hello World"
  
 .LINK
  about_Launcher
  Hide-Browser, Send-Browser, Get-BrowserData
#>
function Show-Browser ([string]$Url) {
  if($Url.length -eq 0)
  {
     $launcher.ShowBrowser
  }
  else
  {
     $launcher.ShowBrowser($Url)
  }
}

<# 
 .SYNOPSIS 
  Hides the browser.

 .DESCRIPTION
  Hides the browser.

 .LINK
  about_Launcher
  Show-Browser, Send-Browser, Get-BrowserData
#>
function Hide-Browser {
  $launcher.HideBrowser()
}


<# 
 .SYNOPSIS 
  Sends a browser windows for x seconds.

 .DESCRIPTION
  
 .LINK
  about_Launcher
  Show-Browser, Hide-Browser, Get-BrowserData
#>
function Send-Browser ([string]$Url, [int]$Seconds=5) {
  if($Url.length -eq 0)
  {
    $Url.Text = "http://www.ethz.ch/"
  }
  $browser.SecondsToClose = $Seconds
  $launcher.ShowBrowser($Url)
}

<# 
 .SYNOPSIS 
  Gets browser form data.

 .DESCRIPTION
  Gets browser form data.
  
 .LINK
  about_Launcher
  Show-Browser, Hide-Browser, Send-Browser
#>
function Get-BrowserData {

  $object = New-Object Object | 
  Add-Member NoteProperty Host "" -PassThru | 
  Add-Member NoteProperty Url "" -PassThru |             
  Add-Member NoteProperty LastClick "" -PassThru |   
  Add-Member NoteProperty LastEntry "" -PassThru |
  Add-Member NoteProperty IsFromVisible "" -PassThru
  
  $object.Host = $hostname
  $object.Url = $browser.Url
  $object.LastClick = $browser.LastClick
  $object.LastEntry = $browser.LastEntry
  $object.IsFromVisible = $launcher.IsBrowserFormVisible
  return $object
  
}

####################################################################
# WAIT FORM

<# 
 .SYNOPSIS 
  Show wait form

 .DESCRIPTION
  Shows a wait form with "Bitte warten / Please Wait".
  This can be useful if you want to make a short break during
  a session. The wait form is displayed topmost and cannot
  be closed. It can be combined with device locks, i.e.
  
  Show-WaitForm "Please Wait"
  Disable-Keyboard
  Disable-Mouse
  
  The waitform has some public properties that can be queried
  with Get-WaitData.
  
  $waitform.fontsize = 25
  $waitform.borders = 10

 .LINK
  about_Launcher
  Hide-WaitForm, Send-WaitForm, Get-WaitData
#>
function Show-WaitForm([string]$Text="Please wait`nBitte warten") {
    $launcher.ShowWaitForm($Text)
}

<# 
 .SYNOPSIS 
  Hide wait form

 .DESCRIPTION
  Hide wait form

 .LINK
  Show-WaitForm, Send-WaitForm
  about_Launcher
#>
function Hide-WaitForm {
  $launcher.HideWaitForm()
}

<# 
 .SYNOPSIS 
  Show a wait form for x seconds.

 .DESCRIPTION
  Show a black wait screen. You can set a text 
  message with will be displayed in white color
  on the screen by setting the -text parameter.
  The screen will be displayed for -seconds $x.

 .LINK
  Show-WaitForm, Hide-WaitForm, Get-WaitData
  about_Launcher
#>
function Send-WaitForm ([string]$Text="", [int]$Seconds=3) {
  $launcher.SendWaitForm($Text, $Seconds)
}

<# 
 .SYNOPSIS 
  Gets wait form data.

 .DESCRIPTION
  Gets wait form data. 
  
  FontSize can be adjusted with:  
  $waitform.FontSize = 100
  
  Borders is the percentage of the left and
  right colums besides the centeral text. A 
  border of 5 means, 5% left and 5% right border
  and 90% of the width for the text.
  
  $waitform.Border = 5
  
 .LINK
  about_Launcher
  Show-WaitForm, Hide-WaitForm, Send-WaitForm
#>
function Get-WaitData {

  $object = New-Object Object | 
  Add-Member NoteProperty Host "" -PassThru | 
  Add-Member NoteProperty WaitText "" -PassThru |             
  Add-Member NoteProperty FontSize "" -PassThru |   
  Add-Member NoteProperty Borders "" -PassThru |
  Add-Member NoteProperty IsFromVisible "" -PassThru
  
  $object.Host = $hostname
  $object.WaitText = $waitform.WaitText
  $object.FontSize = $waitform.FontSize
  $object.Borders = $waitform.Borders
  $object.IsFromVisible = $launcher.IsWaitFormVisible
  return $object
  
}

####################################################################
# Notify
<# 
 .SYNOPSIS 
  Send a message to client.

 .DESCRIPTION
  Sends a message to the client. Message will be displayed with
  a balloon in the system notification area for -time x seconds.
  Often the notification area is hidden is computer pools. Test it!
  
  Alternatively, use Send-WaitForm for a full screen message.

 .LINK
  about_Launcher
#>
function Send-Notification ([string]$Text, [string]$Title="Notice from the Supervisor", [int]$Time=5) {
  $launcher_notify.balloontiptitle = $Title;
  $launcher_notify.balloontiptext = $Text;
  $launcher_notify.showballoontip($Time*1000);
}

####################################################################
# INPUT DEVICE LOCKS

<# 
 .SYNOPSIS 
  Locks unwanted keys.

 .DESCRIPTION
  Locks 'unwanted' keys to enforce a kiosk mode.
  Useful in combination with standard browsers,
  like Firefox and Chrome. The Kiosk-Filter handels 
  the following KeyDown-Events:
  
  - ALT-F4
  - CTRL-F4
  - F1-F12
  - LWin, RWin (Windows Keys)
  - Apps (Context Menu)
  - Print, Scroll, Pause

 .LINK
  about_Launcher
  Disable-KioskFilter
#>
function Enable-KioskFilter {
  $launcher.EnableKioskFilter();
}

<# 
 .SYNOPSIS 
  Unlocks unwanted keys.

 .DESCRIPTION
  Unlocks dangerous keys.

 .LINK
  about_Launcher
  Enable-KioskFilter
#>
function Disable-KioskFilter {
  $launcher.DisableKioskFilter()
}

<# 
 .SYNOPSIS 
  Unlocks the keyboard.

 .DESCRIPTION
  Unlocks the keyboard.

 .LINK
  about_Launcher
  Disable-Keyboard
#>
function Enable-Keyboard {
  $launcher.EnableKeyboard()
}

<# 
 .SYNOPSIS 
  Locks the keyboard.

 .DESCRIPTION
  Locks the keyboard completely. After
  the launcher process has stoped, the lock
  will be gone.

 .LINK
  about_Launcher
  Enable-Keyboard
#>
function Disable-Keyboard {
  $launcher.DisableKeyboard()
}

<# 
 .SYNOPSIS 
  Unlocks the mouse.

 .DESCRIPTION
  Unlocks the mouse.

 .LINK
  about_Launcher
  Disable-Mouse
#>
function Enable-Mouse {
  $launcher.EnableMouse()
}

<# 
 .SYNOPSIS 
  Unlocks the mouse from Global Hook

 .DESCRIPTION
  Unlocks the mouse from Global Hook

 .LINK
  about_Launcher
  Disable-Mouse
#>
function Enable-MouseExt {
  $launcher.EnableMouseExt()
}

<# 
 .SYNOPSIS 
  Locks the mouse.

 .DESCRIPTION
  Locks the mouse.

 .LINK
  about_Launcher
  Enable-Mouse
#>
function Disable-Mouse {
  $launcher.DisableMouse()
}

<# 
 .SYNOPSIS 
  Locks the mouse based on Global Hook.

 .DESCRIPTION
  Locks the mouse based on Global Hook.
  Beware! Not stable.

 .LINK
  about_Launcher
  Enable-Mouse
#>
function Disable-MouseExt {
  $launcher.DisableMouseExt()
}

<# 
 .SYNOPSIS 
  Turns on the monitor.

 .DESCRIPTION
  Turns on the monitor.

 .LINK
  about_Launcher
  Disable-Screen
#>
function Stop-ScreenSaver {
  $launcher.EnableScreen()
}

<# 
 .SYNOPSIS 
  Turns off the monitor.

 .DESCRIPTION
  Turns off the monitor.

 .LINK
  about_Launcher
  Enable-Screen
#>
function Start-ScreenSaver {
  $launcher.DisableScreen()
}

####################################################################
# SCREEN SHOTS

<# 
 .SYNOPSIS 
  Take screenshots from remote computers

 .DESCRIPTION
  Take screenshots from remote computers. Expects a launcher pool
  to be present, i.e. it just calls Invoke-Pool 

 .LINK
  about_Launcher
  Show-ScreenShot, Get-ScreenShotFiles, Clear-ScreenShotFiles
#>
function Get-ScreenShots([int]$group) {
  if($group) {
    $global:screenShotCounter = $group
  } else {
     $global:screenShotCounter = get-date -Format "yyMMddhhmmss"
  }
  Invoke-Pool "Get-ScreenShot $global:screenShotCounter"
  Write-Host "Wait a second until screenshots are generated..."
  sleep -s 3
  Show-Screenshot $global:screenShotCounter
  #$global:screenShotCounter = $global:screenShotCounter + 1
}

<# 
 .SYNOPSIS 
  Take a screenshot of localhost

 .DESCRIPTION
  Takes a screenshot of localhost.

 .LINK
  about_Launcher
  Get-Screen, Show-ScreenShot
  Get-ScreenShotFiles, Clear-ScreenShotFiles
#>
function Get-ScreenShot ([string]$Group, [string]$Path=$screenShotPath) {
  if(!$Group)
  {
    $rand = New-Object System.Random
    $Group = $rand.next(1,1000)
  }
  $launcher.ScreenShot($Path, $Group)
  return $Group
}

<# 
 .SYNOPSIS 
  Show screen shots

 .DESCRIPTION
  Show screen shots

 .LINK
  about_Launcher
  Get-Screen, Get-ScreenShot
  Get-ScreenShotFiles, Clear-ScreenShotFiles
#>
function Show-ScreenShot([string]$Group, [string]$Path=$screenShotPath) {
  $elements = "" 
  $a = Get-ScreenShotFiles $Group $Path
  foreach($f in $a)
  {
    #$path = $f.fullname.Replace($screenShotPath, $screenShotPath2)
    $path = $f
    $groupTag = "-" + $group + "-"    
    $computer = $f.name.substring(0, $f.name.indexof($groupTag))
    $element = Get-ScreenShotHtmlElement $path $computer $group
    $elements = $elements + $element
  }
  $html = Get-ScreenShotHtml
  $html = $html.replace("<!-- Input -->", $elements)
  $filename = "screenshot-" + $group + ".html"
  $filepath = $global:screenShotPath + $filename
  $html > $filepath
  $filepath = $global:screenShotPath2
  $filepath = $filepath + $filename  
  Start-Chrome $filepath
  return $filename
}

<# 
 .SYNOPSIS 
  List screen shot files

 .DESCRIPTION
  List screen shot files

 .LINK
  about_Launcher
  Clear-ScreenShotFiles
#>
function Get-ScreenShotFiles ([string]$Group="", [string]$Path=$screenShotPath) {
  $list = Get-ChildItem $Path
  if($Group.length -ne 0)
  {
    $Group = "-" + $Group + "-"
    $list = $list | where {$_.name.IndexOf($Group) -gt 0}
  }
  $list
}


<# 
 .SYNOPSIS 
  Delete screen shots files

 .DESCRIPTION
  Delete screen shots files

 .LINK
  about_Launcher
  Get-ScreenShotFiles
#>
function Clear-ScreenShotFiles ([string]$Group="", [string]$Path=$screenShotPath) {
  $list = Get-ChildItem $path
  if($Group.length -ne 0)
  {
    $Group = "-" + $Group + "-"
    $list = $list | where {$_.name.IndexOf($Group) -gt 0}
  }
  if($list.length -gt 0)
  {
    foreach($f in $list)
    {
      Remove-Item $f.fullname
    }
  }
}

<# 
 .SYNOPSIS 
  Html element for a screenshot
  
 .DESCRIPTION
  Private function to generate Html elements for
  the ScreenShot Html page.
#>
function Get-ScreenShotHtmlElement ([string]$Path, [string]$ComputerName, [string]$Group)  {
  $html = ""
  $html = $html + '    <a href="<!--Path-->" class="lightview" rel="gallery[myset]" title="<!--Computer--> : <!--Group-->">'
  $html = $html + '        <img src="<!--Path-->" width="200" alt="<!--Computer--> : <!--Group-->" />'
  $html = $html + '        <br />'
  $html = $html + '        <div><!--Computer--></div>'
  $html = $html + '    </a>'
  
  $html = $html.Replace("<!--Path-->", $Path)
  $html = $html.Replace("<!--Computer-->", $ComputerName)
  $html = $html.Replace("<!--Group-->", $Group)

  return $html
}

<# 
 .SYNOPSIS 
  Page Html for a set of screenshot
 
 .DESCRIPTION
  Private function to generate the Html body for
  the ScreenShot Html page.
#>
function Get-ScreenShotHtml {
  $html = ""
  $html = $html + '<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">'
  $html = $html + '<html xmlns="http://www.w3.org/1999/xhtml">'
  $html = $html + '<head>'
  $html = $html + '    <title>Launcher ScreenShots</title>'
  $html = $html + '    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/prototype/1/prototype.js"></script>'
  $html = $html + '    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/scriptaculous/1/scriptaculous.js"></script>'
  $html = $html + '    <script type="text/javascript" src="http://www.descil.ethz.ch/styles/modules/lightview/js/lightview.js"></script>'
  $html = $html + '    <link rel="stylesheet" href="http://www.descil.ethz.ch/styles/modules/lightview/css/lightview.css"'
  $html = $html + '        type="text/css" media="screen" />'
  $html = $html + '</head>'
  $html = $html + '<body>'
  $html = $html + '    <h1>Launcher Screen Shots</h1>'
  $html = $html + '    <!-- Input -->'
  $html = $html + '</body>'
  $html = $html + '</html>'
  return $html
}

####################################################################
<# 
 .SYNOPSIS 
  Add entry to Launcher log.

 .DESCRIPTION
  Add entry to Launcher log.

 .LINK
  about_Launcher
#>
function Add-LauncherLog([string]$LogEntry) {
  # Gets loaded automatically within Launcher
  $launcher.AddLogEntry($LogEntry);
}

<# 
 .SYNOPSIS 
  Get launcher log entries.

 .DESCRIPTION
  Get launcher log entries.

 .LINK
  about_Launcher
#>
function Get-LauncherLog {
  $launcher.Log
}

###################################################################################
<# 
 .SYNOPSIS 
  Get launcher version.

 .DESCRIPTION
  Get launcher version.

 .LINK
  about_Launcher
#>
function Get-LauncherVersion {
  return "Launcher $version is running on " + $env:computername.ToLower()
}


###################################################################################
#Import and Expose Cmdlets
Import-LauncherTunnel

# Global Variables (add if not yet there)
[PowerShellTunnel.Client.ITunnel[]]$global:LauncherPool = $null
[PowerShellTunnel.Client.ITunnel[]]$global:LauncherPool2 = $null

#Initialize-Launcher

###################################################################################
# General Overview

# Launcher Winform Application
Export-ModuleMember about_Launcher
Export-ModuleMember Start-Launcher, Start-RemoteLauncher, Stop-Launcher, Restart-Launcher

#Launcher Embedded Runtime
Export-ModuleMember Show-Launcher, Hide-Launcher, Enable-Launcher, Disable-Launcher
Export-Modulemember Show-Browser, Send-Browser, Hide-Browser, Get-BrowserData
Export-ModuleMember Show-WaitForm, Send-WaitForm, Hide-WaitForm, Get-WaitData, Send-Notification
Export-ModuleMember Enable-KioskFilter, Disable-KioskFilter, Enable-Keyboard, Disable-Keyboard
Export-ModuleMember Enable-Mouse, Disable-Mouse, Enable-MouseExt, Disable-MouseExt
Export-ModuleMember Start-ScreenSaver, Stop-ScreenSaver
Export-ModuleMember Get-ScreenShots, Get-ScreenShot, Show-ScreenShot, Get-ScreenShotFiles
Export-ModuleMember Get-LauncherData, Get-LauncherLog, Add-LauncherLog
Export-ModuleMember Get-LauncherVersion

# Launcher Pool
Export-ModuleMember about_Pool
Export-ModuleMember Select-Pool, Register-Pool, Invoke-Pool, Remove-Pool, Get-PoolData

#Launcher Tunnel / will be hidden
Export-ModuleMember about_Tunnel
Export-ModuleMember -Cmdlet Add-Tunnel, Remove-Tunnel, Invoke-Tunnel, Select-Tunnel, Add-TunnelHost, Remove-TunnelHost

#Launcher Installation
Export-ModuleMember Get-LauncherSecurity, Set-LauncherSecurity, Remove-LauncherSecurity
Export-ModuleMember Get-EmbeddedBrowserVersion, Set-EmbeddedBrowserVersion, Remove-EmbeddedBrowserVersion

#External Applications / Browsers.ps1
Export-ModuleMember about_Browsers
Export-ModuleMember Start-Ie, Stop-Ie
Export-ModuleMember Start-Firefox, Stop-Firefox
Export-ModuleMember Start-Chrome, Stop-Chrome, Get-ChromeVersion
Export-ModuleMember Start-Opera, Stop-Opera
Export-ModuleMember Close-Window, Stop-Window

# Aliases
Set-Alias -name Spo -value Select-Pool
Set-Alias -name Rpo -value Register-Pool
Set-Alias -name Ipo -value Invoke-Pool
Export-ModuleMember -Alias Spo, Rpo, Ipo

###################################################################################