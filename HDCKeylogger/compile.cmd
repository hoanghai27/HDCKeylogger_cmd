resgen frmAboutBox.resx HDCKeylogger.frmAboutBox.resources
resgen frmOptions.resx HDCKeylogger.frmOptions.resources
resgen frmReader.resx HDCKeylogger.frmReader.resources
resgen frmMain.resx HDCKeylogger.frmMain.resources
csc /t:winexe /r:..\KeyLog\bin\KeyLog.dll;..\Logging\bin\Logging.dll;..\Text\bin\Text.dll;..\WinAPI\bin\WinAPI.dll /resource:HDCKeylogger.frmReader.resources /resource:HDCKeylogger.frmMain.resources /resource:HDCKeylogger.frmOptions.resources /resource:HDCKeylogger.frmAboutBox.resources /appconfig:app.config /recurse:*.cs

mkdir bin
move Program.exe bin\HDCKeyLogger.exe
copy ..\KeyLog\bin\KeyLog.dll bin\KeyLog.dll
copy ..\Logging\bin\Logging.dll bin\Logging.dll
copy ..\Text\bin\Text.dll bin\Text.dll
copy ..\WinAPI\bin\WinAPI.dll bin\WinAPI.dll
mkdir bin\logs
copy logs\keys.xml bin\logs\keys.xml
