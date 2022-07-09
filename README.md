# College Projects

Where it all began! (Minus some dabbling with Macromedia Flash in highschool)

These projects are all committed as they were when I started my journey as a programmer in college. Only changes made are to get them to build on a current system.

## Releases/Running
All of these projects have executables that are distributed in the releases section. The only exceptions are the Capstone project and Networking Lib.

Most can be run from command line or by double clicking the executable. If a given project requires special instructions it will be included in the relevant section.

## Year 1 - Visual Basic
That's right. I started with VB.Net. The horror!

### Text Editor
First project we worked on was to make a basic text editor using WinForms. I tried to go the extra mile and added some font and text styling features, along with the toolbar. It handles the typical keyboard shortcuts, like Ctrl+B for bold, etc. There's also a status bar with editing details and a clock in the lower right, just cause.

I had to redownload some icons for it after upgrading from Visual Studio 2005 so these are not the originals.

![TextEditor_T1QUWrrK8s](https://user-images.githubusercontent.com/32066077/178108857-b51434aa-cb1e-4f11-a967-380b9817ee89.gif)

### Heroless War (BattleShip)
The urge to make games was strong even at this point. It's a battleship clone using GDI, which is the basic Windows 2d rendering system. The controls are listed at the bottom of the screen and there's a rudimentary AI that will try to follow nearby squares when it gets a hit, but is random otherwise.

In retrospect this is the first game I've ever made, feels weird to think about.

![vUJ2WzynGV](https://user-images.githubusercontent.com/32066077/178108876-35d7c0aa-92c1-446d-8084-e991b9ce6e45.gif)

## Year 2 - C++
### Tic Tac Toe
This project was to teach basic control flow/logic and to get us used to C++. The basic assignment was to make it two player in the console, with extra credit for writing an AI. Since Tic Tac Toe has a specific set of board states, you can write a complete and unbeatable AI with just a large sequence of if statements.

Was also the project I started messing with the Windows console lib to clear and redraw the game state each move.

![TicTacToe_RCwxJ6SXCf](https://user-images.githubusercontent.com/32066077/178108830-1ccd9f51-4f3e-4b72-839c-233535308819.gif)

### Doodlebugs vs Ants
A simulation similar to Conway's Game of Life. Ants must survive and have space to reproduce. Doodlebugs must eat ants to reproduce or they starve.

In this one I took the console manipulation antics further by resizing the window, hiding the cursor, and using obscure ascii characters to make a grid. Also since this was a data structures class I made my own doubly linked list implementation, cause I'm cool like that.

![Doodlebugs_GgpcUNGMHA](https://user-images.githubusercontent.com/32066077/178108779-b38b84b2-2b7c-41c2-abb4-fb2f187457ca.gif)

### Algorithms and Data structures
These three are all pretty basic and don't have visuals, so gonna give them a brief description.

- Maze Solver: Finds a path through a maze in a text file by storing each visited location in a stack, following the right hand wall, and going backwards through the stack locations on a dead end. Try it next time you're lost in a corn maze! :corn:
- Merge Sorter: Sorts a table of employee records using mergesort. Which is where you split a list in half and merge them back together based on a comparison function until you detect the list is sorted.
- Spell Checker: Reads a list of words into a binary search tree, and then uses this tree as a "dictionary" to detect any misspelled words in a block of text.

## Year 2 - C#
### Console Chat
First steps into networking. It was exceiting to see this work the first time even though it was purely on the local machine and is only about 100 lines of rudimentary code.

Launch with -server to start the server listening, and start a second instance without to connect a client. You can then press i to start a message and enter to send.

![vw8eKIXQ9r](https://user-images.githubusercontent.com/32066077/178110770-80539e43-9a01-46df-ac8d-2bf98c713e18.gif)

### Network Lib
Somewhat an extension of the Console chat app, this was meant to be a generic library for network communications that I could use in games (Grandiose much?). It's obscenely basic but does cover the essentials of low level networking, with sockets, threading and data callbacks and such. I think there was a test app at one point that I've lost since. Was probably the plan to make the next project multiplayer but ran out of time.

### March of Doom (Game Project)
Final project of straight programming was your choice, so naturally I chose to make a game. You start on the bottom of the screen and make your way to the top, simple!

N to start a new game. You control the character with the arrow keys. Bit of a delay to him moving due to keyboard repeat delay, but hey its functional!

This project uses a tile based rendering system with sprite sheets, and the assets were repurposed from an ancient version of RPG Maker. It also has animation on the main character and collision detection with the paddles and end goal area.

Even though it feels really simple looking at the code now, I remember being really proud of it at the time.

![1ZVxs8LKpf](https://user-images.githubusercontent.com/32066077/178110854-28cf8704-c587-440e-8351-107c99873a2e.gif)

## Capstone Project - PromoGuru
This was the "Big" project, an online product order management system. It was done as part of a group using several of the architectural patterns taught. It contains a database, business and frontend layers, test cases, and a WinForm app.

I recall having to work on a large portion of it but have no idea which parts. As such I've no idea how to get it running in modern Visual Studio without rewriting parts of it in something like .Net Core. To avoid losing the archival nature of this repo and changing too much I've left it as it was.
