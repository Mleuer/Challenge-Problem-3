### Overview
For this programming challenge, you’ll be coding a simplified player character, input controller, and text output system for a video game.

### The Game
The game consists solely of a player-character that moves around a 2D grid. Though your game will not need to display any graphical output (only text, see below), your character will need to keep track of its own 2D coordinates, and will need the following abilities: move up, move down, move left, move right, and jump. Move up, down, left, and right each move the player-character by 1 unit in their respective directions; jump moves the character up 2 units (i.e. it’s the same as the character moving up twice in a row). The game should obey the same cartesian rules as screen coordinates in computer graphics: that is, “up” is negative movement along the y-axis, “right” is positive movement along the x-axis, etc. The player character always starts at (0,0).

### Input
Just as in any video game, your program will need to read in player input and translate those inputs into actions within the game. In this challenge, input will be delivered via a text file instead of a USB input stream, but the principles are otherwise the same. Each character read from the input file represents a keyboard input from the player. Each player input will be on its own line. The input mappings are as follows (⎵ is used as a stand-in for a spacebar input):

	W  	= Move up
	A  	= Move left
	S  	= Move down
	D  	= Move right
	⎵ 	= Jump

An example input might look like the following:

	S
	D
	S
	W
	S
	S
	D
	D
	D
	A
	S
	⎵

Your program will read its input from `PlayerInput.txt`.

### Output
Your program will need to parse the player input, apply the requested input command to the state of the game, and output the new state of the game (which, for these purposes, is simply the new location of the player character) for each player command entered. The game should also keep track of how many units the player has moved (each directional move counts as a single unit, and jumping counts as two units), and output the total once all inputs have been processed. Thus the output (corresponding to the above example input) should look like the following:

	Game Started
	Player location: (0, 0)
	Player location: (0, 1)
	Player location: (1, 1)
	Player location: (1, 2)
	Player location: (1, 1)
	Player location: (1, 2)
	Player location: (1, 3)
	Player location: (2, 3)
	Player location: (3, 3)
	Player location: (4, 3)
	Player location: (3, 3)
	Player location: (3, 4)
	Player location: (3, 2)
	Game over
	Player moved 13 units total

See `ExpectedOutput.txt` for the expected output corresponding to `PlayerInput.txt`.
