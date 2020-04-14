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
- Ensure that a `mod` folder exists in the directory. If it does not
  exist, copy it over.  Note that it should currently be empty.

## Installing Item Randomizer (SoulsRandomizers/DS3Randomizer)

In the same directory that contains `DarkSoulsIII.exe`, do the
following:
- Ensure that the `randomizer` directory is in the same directory as
  `DarkSoulsIII.exe`.  If it is not, copy it there from the zip file.

## Installing the Enemy Randomizer (DarkSouls3EnemyRandomizer)

In the same directory that contains `DarkSoulsIII.exe`, do the
following:
- Ensure that the `DarkSouls3EnemyRandomizer` directory exists.  If it
  does not, copy it over from the zip file.

## Run the Enemy Randomizer (DarkSouls3EnemyRandomizer)

Change directories into the `DarkSouls3EnemyRandomizer` directory from
the `Game` folder where `DarkSoulsIII.exe` is located.

-In this folder, run `pooremma.exe`.  Check both boxes for recommended
settings, and press "Start Random". 
    - This will create a new "map" folder.
- Copy "map" "event" "script" "sfx" "Data0.bdt" into the '..\mod'
  directory.  (The `mod` directory in the main folder that contains
  `DarkSoulsIII.exe`.)
    - Note that the "mod" directory already contains "event",
      "script", "sfx", and Data0.bdt.  Its unclear if these need to
      be copied over every time, but at least the map directory does
      need to be copied.


## Run the Item Randomizer (DS3Randomizer)

Change directories into the `randomizer` directory.  Now run the
`DS3Randomizer.exe` program.  Make sure to run this after the Enemy
Randomizer.

Note that the Enemy Randomizer requires that the "Merge mods from normal
'mod' directory" setting must be selected!  After choosing the settings
you would like, you can click the "Randomize new run!" button.  

Note that running this randomizer will place a hints file in the `spoiler_logs` directory.


## Note: Old Enemy randomizer (StraySouls)

Note that there is a `StraySouls` folder in the distribution that none of the
above instructions reference.  This directory contains an alternate DS3
randomizer.  This can safely be ignored. However, it does have at least
one interesting feature that can be possibly be layered on top of the
other randomizer: "random -2" will go over the current maps and
duplicate the enemies.  You do have to point it at "..\mod\map\mapstudio\" for it to randomize the right map files.

At your own risk, the follow is a guide for using this feature: Run
`StraySouls.exe` from the `mod` directory.  Running StraySouls on its
own will prompt for input.  The first time you run it, give the
following input:
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
