# Overview UI Sprite Manager

### Introduction
After spending some years in Game Industry, I realize managing sprites in large projects is a headache, as artists have to iterate images a lot to make them better, cool and according to demand. While developers have to integrate those images and to show the feel of those images in the game.

Also, due to this hassle, artists and developers choose a messy workaround, and instead of working in spritesheet, they start working in individual sprites.

### Purpose
In big Unity projects, artists have to modify images frequently to make it better, and developers have to reflect that change, as the old reference becomes Missing (if the name of the updated sprite is not the same)

### Unity Asset Store Link

[https://www.assetstore.unity3d.com/#!/content/89387](https://www.assetstore.unity3d.com/#!/content/89387)

### Features
* Easily make reskin of your game, if the game is made using UI Sprite Manager
* Promotes the use of spritesheet/atlas
* Get full use of spritesheet and packaging tag
* Place images anywhere in Assets/, as if the images are placed in Assets/Resources packaging tag don't work
* Still you can change the sprite on runtime with ImageExtension public methods
* Easy to use, Plug n play
* Open Source code without any DLL
* Done by extending Image component

### Usage
* Add enum against your sprite in SpriteEnum.cs
* Add respective sprite in UISpriteManager.prefab
* Now, just add component ImageExtension.cs instead of Image in Unity UI and use it as is

![HowToUse-01.png](https://github.com/mohsinkhan26/UISpriteManager/blob/master/Screenshots/HowToUse-01.png)

![HowToUse-02.png](https://github.com/mohsinkhan26/UISpriteManager/blob/master/Screenshots/HowToUse-02.png)

![HowToUse-03.png](https://github.com/mohsinkhan26/UISpriteManager/blob/master/Screenshots/HowToUse-03.png)

![HowToUse-04.png](https://github.com/mohsinkhan26/UISpriteManager/blob/master/Screenshots/HowToUse-04.png)

### Remember
* Drag UISpriteManager.prefab in the first scene and it will persist

### TODO
* Check for duplicate entries in list and highlight with red background

### Special Thanks

* All the users who provide feedback and suggestions to improve
* All the users who gave reviews on Asset store


## Thanks for your support!