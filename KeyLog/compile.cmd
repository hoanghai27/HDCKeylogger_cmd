csc /t:library /r:..\WinAPI\bin\WinAPI.dll /out:KeyLog.dll /recurse:*.cs
mkdir bin
move KeyLog.dll bin\KeyLog.dll