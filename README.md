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

## Compilation instructions

The bot executable should work out of the box, however you'll want to recompile after making your own changes.

You won't need to recompile anything other than the bot but if you want the latest and greatest, you can also recompile `FlatBuffers.dll`, `RLBotDotNet.dll`, and `RLBot_Core_Interface.dll`. If you choose to recompile the DLLs, make sure that the bot project references the new DLLs you recompiled.

### Bot compilation

1. Open `RLBotCSharpExample/RLBotCSharpExample.sln` in Visual Studio 2015 or newer.
2. Click Build in the menu, then click Build Solution (or press Ctrl+Shift+B).
3. The compiled executable should appear in a folder in `RLBotCSharpExample/RLBotCSharpExample/bin`.

The example bot references both RLBotDotNet.dll and FlatBuffers.dll.

### FlatBuffers DLL compilation

1. Download/clone the [FlatBuffers repository](https://github.com/google/flatbuffers).
2. Open `FlatBuffers.csproj` (located in `net/FlatBuffers`).
3. Choose your configurations and build the project.

### RLBotDotNet DLL compilation

1. Download/clone TheBlocks' fork's [csharp-port branch](https://github.com/TheBlocks/RLBot/tree/csharp-port/src/main/cs/RLBotDotNet).
2. Open `RLBotDotNet.sln` (located in `src/main/cs/RLBotDotNet`).
3. Choose your configurations and build the solution.

### RLBot Core Interface DLL compilation

1. Download/clone the [RLBot repository](https://github.com/RLBot/RLBot/tree/master/src/main/cpp/RLBotInterface).
2. Open `RLBotInterface.sln` (located in `src/main/cpp/RLBotInterface`).
3. Choose your configurations and build the solution.

The instructions for building the interface should be in the README in the above repository's interface solution folder.

## Overview of how the C# bot interacts with Python

The C# bot executable is a server that listens for Python clients.
When `CSharpPythonAgent/CSharpPythonAgent.py` is started by the RLBot framework, it connects to the C# bot server and tells it its info.
Then the C# bot server controls the bot through the `RLBot_Core_Interface` DLL.