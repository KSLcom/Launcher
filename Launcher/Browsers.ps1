####################################################################
# Launcher Browsers
# Stefan Wehrli <wehrlist@ethz.ch>
# September 10th, 2010
####################################################################

# CONTENTS

# about_Browsers
# Start-Ie, Stop-Ie
# Start-Firefox, Stop-Firefox
# Start-Chrome, Stop-Chrome, Get-ChromeVersion
# Start-Opera, Stop-Opera
# Close-Window, Stop-Window

####################################################################
<# 
 .SYNOPSIS 
  Browser startup scripts

 .DESCRIPTION
  Standardized startup scripts for browser software
  
  o Internet Explorer
  o Firefox
  o Chrome
  o Opera
  o Close-Window, Stop-Window
  
 .EXAMPLE
  Start-Ie www.ethz.ch

 .EXAMPLE 
  Stop-Ie
  
 .LINK
  about_Launcher
#>
function about_Browsers {}

####################################################################
# Internet Explorer

<# 
 .SYNOPSIS 
  Starts a Internet Explorer browser.

 .DESCRIPTION
  Start an Internet Explorer browser. Internet Explorer will start 
  full screen. 
  
  Please note that useres still can close the brower and fiddle around 
  in the settings. If you want a real kiosk, please use Launcher's 
  embedded IE or enforce Kiosk-Mode.
  
 .Example
  Start-Ie www.google.com
  
 .LINK
  about_Browsers
  Stop-Iexplore
  about_Launcher, Show-Browser, Enable-KioskFilter
#>
function Start-Ie([string]$url, [switch]$kiosk) {

  if(IsX64)
  {
    $ie = "C:\Program Files (x86)\Internet Explorer\iexplore.exe"
  }
  else
  {
    $ie = "C:\Program Files\Internet Explorer\iexplore.exe"
  }
  
  $p = "-private"
  $k = "-k"

  if ($kiosk) {  
    . $ie $k $url
  } else {
    . $ie $url
  }
}

<# 
 .SYNOPSIS 
  Close Internet Explorer browser.

 .DESCRIPTION
  Close Internet Explorer browser.
   
 .Example
  Stop-Iexplore
  
 .LINK
  about_Browsers
  Start-Ie
#>
function Stop-Ie {
  Close-Window "iexplore"
}

####################################################################
# Firefox 
# http://kb.mozillazine.org/Command_line_arguments
#
# -private, -preferences
# -new-tab URL
# -new-window URL
# -search "andreas diekmann"
#
# firefox "www.google.ch"
# firefox -new-tab "www.bing.com"

<# 
 .SYNOPSIS 
  Starts a Firefox browser.

 .DESCRIPTION
  Starts a Firefox browser. Please note that useres still
  can close the brower and fiddle around in the settings. 
  If you want a real kiosk, please use Launcher's embedded 
  IE or enforce Kiosk-Mode. There is no option to start 
  firefox in full screen.
  
 .Example
  Start-Firefox www.google.com
  
 .LINK
  about_Browsers
  Stop-Firefox
#>
function Start-Firefox([string]$url) {
  if(IsX64) {
    $firefox = "C:\Program Files (x86)\Mozilla Firefox\firefox"
  }
  else {
    $firefox = "C:\Program Files\Mozilla Firefox\firefox"
  }
  . $firefox $url
}

<# 
 .SYNOPSIS 
  Close Firefox browser.

 .DESCRIPTION
  Closes the Firefox browser.
   
 .Example
  Stop-Firefox
  
 .LINK
  about_Browsers
  Start-Firefox
#>
function Stop-Firefox {
  Close-Window "firefox"
}

####################################################################
# Google Chrome

<# 
 .SYNOPSIS 
  Starts a Google Chrome browser.

 .DESCRIPTION
  Starts a Chrome browser in kiosk mode. Please note that useres
  still can close the brower and fiddle around in the settings. 
  If you want a real kiosk, please use Launcher's embedded 
  IE or enforce Kiosk-Mode to filter key combinations.
  
 .Example
  Start-Chrome www.google.com
  
 .LINK
  about_Browsers
  Stop-Chrome
#>
function Start-Chrome([string]$url,[switch]$kiosk) {
  if(IsX64)
  {
    $chrome = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
  } else {
    $chrome = "C:\Program Files\Google\Chrome\Application\chrome.exe"
  }
  if($kiosk) {
    . $chrome --kiosk $url
  } else {
    . $chrome $url
  }
}

<# 
 .SYNOPSIS 
  Close Chrome browser.

 .DESCRIPTION
  Closes the Chrome browser.
   
 .Example
  Stop-Chrome
  
 .LINK
  about_Browsers
  Start-Chrome
#>
function Stop-Chrome  {
  Close-Window "chrome"
}

<# 
 .SYNOPSIS 
  Gets the current version of chrome.

 .DESCRIPTION
  Gets the current version of chrome.
   
 .Example
  Get-ChromeVersion
  
 .LINK
  about_Browsers
  Start-Chrome
#>
function Get-ChromeVersion {
  if(IsX64)
  {
    $chromepath = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
  } else {
    $chromepath = "C:\Program Files\Google\Chrome\Application\chrome.exe"
  }
  $a = dir $chromepath
  $b = [System.Diagnostics.FileVersionInfo]::GetVersionInfo($a.FullName).FileVersion
  $c = $env:computername + " is running Google Chrome $b"
  return $c
}

####################################################################
# Opera

<# 
 .SYNOPSIS 
  Starts a Opera browser.

 .DESCRIPTION
  Starts a Opera browser in kiosk mode. Please note that useres
  still can close the brower and fiddle around in the settings. 
  If you want a real kiosk, please use Launcher's embedded 
  IE or enforce Kiosk-Mode to filter key combinations.
  
 .Example
  Start-Opera www.google.com
  
 .LINK
  about_Browsers
  Stop-Opera
#>
function Start-Opera([string]$url,[switch]$kiosk) {
  if(IsX64)
  {
    $opera = "C:\Program Files\Opera x64\opera.exe"
  } else {
    $opera = "C:\Program Files (x86)\Opera\opera.exe"
  }
  if($kiosk) {
    . $opera /KioskMode $url
  } else {
    . $opera $url
  }
}

<# 
 .SYNOPSIS 
  Close the Opera browser.

 .DESCRIPTION
  Close the Opera browser.
   
 .Example
  Stop-Opera
  
 .LINK
  about_Browsers
  Start-Opera
#>
function Stop-Opera  {
  Close-Window "opera"
}

####################################################################
<# 
 .SYNOPSIS 
  Close windows

 .DESCRIPTION
  Gets the windows handle of program and tries to close it. If the
  program tries to save on exit, Close-Window will hang.
  
 .Example
  Close-Window notepad
  
 .LINK
  about_Apps
  Stop-Window
#>
function Close-Window($ProcessName){
  get-process $processName | % { $_.CloseMainWindow() }
}

<# 
 .SYNOPSIS 
  Stops a process by name.

 .DESCRIPTION
  Kill a process by name.
  
 .Example
  Stop-Window notepad
  
 .LINK
  about_Browsers
  Close-Window
#>
function Stop-Window($ProcessName){
  Stop-Process -name $processName
}

####################################################################
<# 
 .SYNOPSIS 
  Returns true if Architecture is X64
#>
function IsX64 {
  if($env:PROCESSOR_ARCHITECTURE -eq "x86")
  {
    return $false
  }
  else
  {
    return $true
  }
}

####################################################################
# Exports

#Export-ModuleMember about_Browsers
#Export-ModuleMember Start-Ie, Stop-Ie
#Export-ModuleMember Start-Firefox, Stop-Firefox
#Export-ModuleMember Start-Chrome, Stop-Chrome, Get-ChromeVersion
#Export-ModuleMember Start-Opera, Stop-Opera
#Export-ModuleMember Close-Window, Stop-Window

####################################################################
