# What is This?
FF5 "Re Sprite" is a small tool that allows you to change the names and sprites for player characters and some NPCs in Final Fantasy V (Pixel Remaster) for Steam. 

It was developed as part of the Tournament held by White Giant RPG Studios, LLC (WGRPG), to allow us to personalize our parties while racing through FF5. (We're the folks who develop the [Last Dream](https://store.steampowered.com/app/266230/Last_Dream) series:)

In short, it turns the main game into this:

![Screenshot of the mod, with characters and names changed.](www_img/sample.png)

A writeup of this tool with some WGRPG perspective is here:

https://www.patreon.com/posts/custom-sprites-v-104445556?utm_campaign=patron_engagement&utm_source=post_link&utm_id=bd11a967-9675-4139-a76f-bac501b8676e

# License Notes
This project is licensed under the MIT License, but certain modules in the "in" folder have their own license files. Anything in the "sprites" folder is using a non-commercial license,
so please remove the "sprites" if you use this to make a commercial product. Please read all LICENSE files for the exact details.

# Installation
First, install the .NET runtime: https://dotnet.microsoft.com/en-us/download

Next, download the latest Release (https://github.com/sorlok/FF5ReSprite/releases) and unzip all of the files into some folder.

Now, click on "FF5_MultiTool.exe", and you will be greeted with a screen similar to the following:

![Screenshot of the mod's installation window.](www_img/01_install.png)

The "ACTION NEEDED" line will help guide you through the installation of the mod. If you have BepInEx and Magicite installed already, you may not see any "ACTION NEEDED" entries at all.
If so (or if you prefer to install these manually), then proceed to the next section. Otherwise, do the following:
1. Read the "ACTION NEEDED" text.
2. Click the Button to either "Install" some dependency or "Start FF5".
3. If you clicked "Start FF5", wait until you reach the title screen, then close FF5 (unless the game closes itself before that).
4. The "ACTION NEEDED" text should update; go back to 1.

Make sure you are patient --some of these steps can take a while! Eventually, you will see no more "ACTION NEEDED" text, and you can go on to the next section.

# Using the Mod
You'll know you're ready to start using the mod when you see the following:

![Screenshot of the mod's name/sprite change window.](www_img/03_main.png)

You can change each character's name by typing into each Text Box, and you can change their sprite by clicking the ">>" next to their image and choosing a new one.
In addition to mixing up the in-game graphics, you'll also see custom graphics for some of the members of WGRPG. 
Make whatever changes you want, then click "Apply Changes". You'll see some green confirmation text --at this point, you can load up FF5 and you'll see your
custom names and graphics!

If you want to revert the changes, you can click "(Cleanse)", and the custom names + art will be removed (but the mod will remain installed).
If you want to remove the mod entirely, you can click the "Un-Install" button at the top of the screen.
In rare cases, you may need to perform a Manual Uninstall; this is covered in a later section.

**Note on Name Changes**: Our code can only change a character's name **before** they join the party. So, you will need to use a save file from before
Bartz enters the Tycoon Meteor area if you want to change the names of Bartz, Lenna, or Galuf (and presumably similar restrictions apply for Faris and Krile.
Graphics changes (and NPC name changes) should take effect at any time. (If you wanted to change your party members names after they join, you'd have to edit your
save files --this is possible, but it's outside the scope of this project.)

**Note on Sprite Changes**: This program ONLY changes the map sprites for each character; it does not touch the battle sprites.
It would be pretty easy to extend this tool to modify battle sprites too, but I'd need 22 jobs X 6 WGRPG friends X 12 animation frames == way too much time/money for the end result.
If you want to do a total conversion mod for your FF5 friend group, more power to you!

# Custom Graphics
This mod allows you to add your own custom sprites to the drop-down menus! Here's how to do that:
* Make a copy of the "Custom_Template.png" file here: https://github.com/sorlok/FF5ReSprite/blob/main/Custom_Template.png
  * ...call it "Custom_Bob.png" if you are making a sprite for "Bob", and put it into the "sprites" folder.
* Edit your "Custom_Bob.png" file, and put a 16x16 sprite in each of the designated areas. I've put the in-game name of the "action" for each sprite, so "HandsUp_00", for example, is the first frame in the raised-hand animation.
  * If you're not sure what each "action" means, look at the existing sprites for inspiration (Andrew Sprite sheet.png, Josh Sprite sheet.png, etc.)
* Now restart the "FF5_MultiTool.exe" program --you should now see your custom sprite "Bob" in the drop-down list for each character or NPC!

# Manual UnInstall

If you ever get the program into a **really** weird state, you can **manually** uninstall everything via the following steps.
Note that this should rarely be necessary --most of the time, you can just click the "UnInstall" button from the MultiTool app.
1. Right-click on FF5 in Steam, and choose "Properties...", then click "Installed Files" in the window that opens.
2. Click on "Browse..." and Windows will open a File Explorer window showing you various FF5-related files and folders, including "FINAL FANTASY V.exe".
3. Delete ALL of the files shown in that folder. This includes the "FINAL FANTASY V.exe" file, the "FINAL FANTASY V_Data" folder, and others. (Don't worry, your save files are NOT stored here.)
4. Back in Steam, right-click on FF5 and choose "Properties...", then "Installed Files" again. Now, click "Verify integrity of game files". Steam will scan the folder you just deleted and re-download all of the necessary FF5 files. 

# Steam Directory Not Found?

If you have installed Steam into a non-default directory, the MultiTool may complain that it can't find your Steam installation of FF5.
If that happens, just click the "Choose..." button at the top of the screen and browse to the folder where you installed FF5.

# Disclaimer

This project is a "best effort" kind of thing --and I'm not really a frontend developer.
If you run into any problems, please raise an Issue and I'll do my best to look into it, unless
I've lost interest or am busy or FF17 just came out or I just don't feel like it.
I'd highly encourage you to expand this project to suit
your own needs if you're interested in that! (In which case, please follow the terms of the LICENSE.)

# Credits

First and foremost, thanks to our graphics artist Carvel, who made our custom sprites and was a pleasure to work with. Link:
* https://www.instagram.com/pixelcarvel/

In addition:
* Thanks to Silvris and the BepInEx team for the mod frameworks that make this possible (Magicite and BepInEx). Links:
  * https://github.com/Silvris/Magicite
  * https://github.com/BepInEx/BepInEx
* Thanks to Anub1sR0cks for the Pixel Remaster Save File Editor. We don't use it in this project, but it really helped me understand what was going on behind the scenes. Link:
  * https://github.com/Anub1sR0cks/FFPRSaveEditor

