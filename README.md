# RLBotCSharpExample

Example of a Rocket League bot implemented in C#

## Usage Instructions

1. Make sure you've installed [Python 3.6 64 bit](https://www.python.org/ftp/python/3.6.5/python-3.6.5-amd64.exe). During installation:
   - Select "Add Python to PATH"
   - Make sure pip is included in the installation
2. Install Visual Studio 2017 or newer. It should come with .NET Framework 4.6.1 or newer.
3. Open RLBotCSharpExample\RLBotCSharpExample.sln in Visual Studio.
4. In Visual Studio, click the "Start" button, which should compile and run the bot. Leave it running.
5. Double click on run-gui.bat
6. Click the 'Run' button. Rocket League should open automatically!

### Notes

- Bot behavior is controlled by `RLBotCSharpExample/RLBotCSharpExample/ExampleBot.cs`
- Bot appearance is controlled by `CSharpPythonAgent/appearance.cfg`

### Tournament submissions

When submitting to a tournament, you will need to include several files. 

Some can be found under RLBotCSharpExample/RLBotCSharpExample/bin after you compile in Visual Studio:
- RLBotCSharpExample.exe
- FlatBuffers.dll
- RLBotDotNet.dll
- port.cfg

You should also include the entire CSharpPythonAgent folder. This folder also contains a port.cfg file. *Make sure their contents are identical!*

### Upgrades

This project uses a package manager called NuGet to keep track of the RLBot framework.
The framework will get updates periodically, and you'll probably want them, especially if you want to make sure
your bot will work right in the next tournament! To upgrade:

1. Open the project in Visual Studio.
2. Right click on the RLBotCSharpExample C# project, and choose "Manage NuGet Packages..."
3. Click on the "Installed" tab. You should see a package called "RLBot.Framework".
4. If an update is available, it should say so and give you the option to upgrade.


## Overview of how the C# bot interacts with Python

The C# bot executable is a server that listens for Python clients.
When `CSharpPythonAgent/CSharpPythonAgent.py` is started by the RLBot framework, it connects to the C# bot server and tells it its info.
Then the C# bot server controls the bot through the `RLBot_Core_Interface` DLL.
