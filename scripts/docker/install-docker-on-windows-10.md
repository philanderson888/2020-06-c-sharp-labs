

# Azure Install Win10

If you need `nested virtualization` make sure to choose D(CPU_COUNT)_v3 or Ev3 or higher.  See this article [here](https://docs.microsoft.com/en-us/azure/virtual-machines/windows/nested-virtualization#create-a-nesting-capable-azure-vm).

The actual list of virtual machines which supports nested virtualization is listed [here](https://docs.microsoft.com/en-us/azure/virtual-machines/acu)

Trying by experimentation these work

- E4s_v3 but is perhaps too big
- D8s_v3 which is £250 per month! 


```bash
# new VM E4s_v3 (too big)  AzureUser
# rdp to it
# enable hypervisor
Enable-WindowsOptionalFeature -Online -FeatureName Microsoft-Hyper-V -All
# plus also have to enable two other windows optional features (used the GUI here)
```

## Script Install Of Any File

Manually have to set this

```powershell
Set-ExecutionPolicy -ExecutionPolicy Unrestricted
```

Run this script as administrator to install Notepad++ silently!

```powershell
$url = "https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v7.8.9/npp.7.8.9.Installer.x64.exe"
$output = "notepadplusplus.exe"
$start_time = Get-Date
Invoke-WebRequest -Uri $url -OutFile $output
.\notepadplusplus.exe /S 
```

## Script Install Of Visual Studio 2019 Community Edition

```powershell
# install from personal channel
$url = "https://github.com/philanderson888/scripts/blob/master/devops/vs_community__1830954925.1587920606.exe?raw=true"
$output = "vs_community__831057064.1598087060.exe"
$start_time = Get-Date
Invoke-WebRequest -Uri $url -OutFile $output
./vs_community__831057064.1598087060.exe --quiet --passive --includeRecommended
```

## Silent Install Of Chocolatey

```powershell
Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))
```

or

```powershell
$url = "https://chocolatey.org/install.ps1"
$output = "install-chocolatey.ps1"
$start_time = Get-Date
Invoke-WebRequest -Uri $url -OutFile $output
./install-chocolatey.ps1
```



## Silent Install Of Docker

Have to enable Windows Subsystem For Linux which can be enabled, after a reboot, using

```powershell
# run this before docker works!
Enable-WindowsOptionalFeature -FeatureName Microsoft-Windows-Subsystem-Linux -Online -NoRestart -WarningAction SilentlyContinue
Restart-Computer -Force
```

or

```powershell
$url = "https://raw.githubusercontent.com/philanderson888/scripts/master/devops/install-windows-subsystem-for-linux.ps1"
$output = "install-windows-subsystem-for-linux.ps1"
$start_time = Get-Date
Invoke-WebRequest -Uri $url -OutFile $output
./install-windows-subsystem-for-linux.ps1
```

Can look into this method of executing a powershell script remotely as well 

```powershell
powershell -nop -c "iex(New-Object Net.WebClient).DownloadString('https://raw.githubusercontent.com/philanderson888/scripts/master/devops/install-windows-subsystem-for-linux.ps1')"
```


We also have to install the WSL2 Linux Kernel manually and then reboot

```powershell
$url = "https://wslstorestorage.blob.core.windows.net/wslblob/wsl_update_x64.msi"
$output = "install-windows-subsystem-for-linux-kernel.msi"
$start_time = Get-Date
Invoke-WebRequest -Uri $url -OutFile $output
./install-windows-subsystem-for-linux-kernel.msi
```



```powershell
# install chocolatey
$url = "https://chocolatey.org/install.ps1"
$output = "install-chocolatey.ps1"
$start_time = Get-Date
Invoke-WebRequest -Uri $url -OutFile $output
./install-chocolatey.ps1
# install docker
choco install docker-desktop --pre /y
```

We may also need to install git 

This command does need human intervention - can upgrade this to silent command

```powershell
# install git
choco install git.install --force

choco install git -y --params="'/GitAndUnixToolsOnPath /NoAutoCrlf'"
choco install git -y --params="'/GitAndUnixToolsOnPath /NoAutoCrlf'" --install-args="'/DIR=C:\git'"

```

Other examples
```powershell
choco install sysinternals
choco install notepadplusplus googlechrome atom 7zip
choco install notepadplusplus --force --force-dependencies
choco install notepadplusplus googlechrome -dvfy
choco install nodejs.install --version 0.10.35
```

```powershell
#  in the package for the installer itself

choco install git -s "'https://somewhere/out/there'"
choco install git -s "'https://somewhere/protected'" -u user -p pass
```