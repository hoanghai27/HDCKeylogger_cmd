csc /t:library /out:Logging.dll /recurse:*.cs
mkdir bin
move Logging.dll bin\Logging.dll