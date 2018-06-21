# RLBotCSharpExample

Example of a Rocket League bot implemented in C#

## Usage Instructions

1. Make sure you've installed [Python 3.6 64 bit](https://www.python.org/ftp/python/3.6.5/python-3.6.5-amd64.exe). During installation:
   - Select "Add Python to PATH"
   - Make sure pip is included in the installation
2. Make sure you've installed the [.NET Framework 4.6.1](https://www.microsoft.com/en-us/download/details.aspx?id=49981) (or newer)
3. Open Rocket League
4. Double click on the bot executable (`RLBotCSharpExample/RLBotCSharpExample/bin/x64/Release/RLBotCSharpExample.exe`) and leave it running.
5. Double click on run-gui.bat
6. Click the 'Run' button

### Notes

- Bot behavior is controlled by `RLBotCSharpExample/RLBotCSharpExample/ExampleBot.cs`
- Bot appearance is controlled by `CSharpPythonAgent/appearance.cfg`
- The bot executable's folder MUST contain `FlatBuffers.dll` and `RLBotDotNet.dll`.
- The bot executable's folder MUST contain a folder called `dll` containing `RLBot_Core_Interface.dll`.
- The port given in `port.cfg` MUST match the port given to BotManager in the C# project.

## Bot compilation instructions

1. Open `RLBotCSharpExample/RLBotCSharpExample.sln` in Visual Studio 2015 or newer.
2. Click Build in the menu, then click Build Solution (or press Ctrl+Shift+B).
3. The compiled executable should appear in a folder in `RLBotCSharpExample/RLBotCSharpExample/bin`.

## Overview of how the C# bot interacts with Python

The C# bot executable is a server that listens for Python clients.
When `CSharpPythonAgent/CSharpPythonAgent.py` is started by the RLBot framework, it connects to the C# bot server and tells it its info.
Then the C# bot server controls the bot through the `RLBot_Core_Interface` DLL.