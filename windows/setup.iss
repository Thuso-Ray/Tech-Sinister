; Inno Setup Script
[Setup]
AppName=Sinister Mail
AppVersion=1.0.0
DefaultDirName={pf}\Tech Sinister\Sinister Mail
OutputBaseFilename=Sinister_Mail_Setup
WizardImageFile=splash.bmp
WizardSmallImageFile=logo.bmp
[Files]
Source: "WebApp.exe"; DestDir: "{app}"
[Icons]
Name: "{group}\Sinister Mail"; Filename: "{app}\WebApp.exe"
