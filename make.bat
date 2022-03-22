@echo off
if "%~1" == "clean" goto clean


mkdir bin
csc /out:.\bin\now.exe .\now\now\Program.cs

copy q\q.bat bin\

:clean
    if "%1" equ "clean" rmdir /s/q bin

