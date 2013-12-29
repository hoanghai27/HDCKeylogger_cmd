csc /t:library /out:WinAPI.dll /recurse:*.cs
mkdir bin
move WinAPI.dll bin\WinAPI.dll