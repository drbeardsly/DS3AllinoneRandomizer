# Installation guide for DS3 Item and Enemy Randomizers

## File Pre-requisite

Download the file `DS3AllinoneRanomizer-v0.0.1b.zip` and extract all of its contents into the same directory that has your `DarkSoulsIII.exe` executable.

## Using and running UXM 2.4

- Change directories to "UXM 2.4"
- Run "UXM.exe", then, in order:
    - Find your executable for `DarkSoulsIII.exe` (It will be in "DARK SOULS III\Game\DarkSoulsIII.exe"
    - Press "Unpack"
    - Press "Patch"

## Installing Mod Engine

In the same directory that contains `DarkSoulsIII.exe`, do the
following:
- Copy `dinput8.dll` into the directory
- Copy `modengine.ini` into the directory

## Installing Item Randomizer (SoulsRandomizers/DS3Randomizer)

In the same directory that contains `DarkSoulsIII.exe`, do the
following:
- Copy the `randomizer` directory into the directory

## Installing the Enemy Randomizer (StraySouls)

In the same directory that contains `DarkSoulsIII.exe`, do the
following:
- Copy the `mod` directory into the directory.  It should contain (oo2core_6_win64.dll, SoulsFormats.dll, StraySouls.exe).

## Run the Enemy Randomizer (StraySouls)

Make sure to run the enemy randomizer as the first mod that you run.  To do so,
run `StraySouls.exe` from the `mod` directory.  Running StraySouls on its own
will prompt for input.  The first time you run it, give the following input:
- "1"
- "..\map\mapstudio\"
- "backup"
- Enter

Now, every time you would like to rerun the Enemy randomizer, Run `StraySouls.exe` and run the following command:
- "1"
- "..\map\mapstudio\"
- "restore"
- "r"
- "random -s"
- Enter

Note that you can change `random -s` to `random -s -2` if you would like to
double the number of enemies.

There are also `-m`, `-f`, `-o`, and `-a` options, but they are poorly
documented, so it is unclear exactly what they do, and they may be incompatible
with the Item Randomizer.  Its unclear exactly what is happening, but the `-m`
and `-o` options lead to the game softlocking when used with the Item
Randomizer (Gundyr is already aggro'd and the doors after him will not open).

## Run the Item Randomizer (DS3Randomizer)

Change directories into the `randomizer` directory.  Now run the `DS3Randomizer.exe` program.  After choosing the settings you would like, you can click the "Randomize new run!" button.  Make sure to run this after the Enemy Randomizer.

Note that running this randomizer will place a hints file in the `spoiler_logs` directory.

