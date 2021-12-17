@echo off
cd /d ConsoleApp1
rd /s /q trpo-core-cs
git clone https://github.com/rok9ru/trpo-core-cs.git
dotnet build ../ConsoleApp1.sln --output ./build_output


powershell -NoLogo -NoProfile -Command (Get-Item "build_output\ConsoleApp1.dll").VersionInfo.FileVersion > "build_output\version.txt"
pause