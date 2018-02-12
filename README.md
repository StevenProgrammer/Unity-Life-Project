# Unity-Life-Project
A simple recreation of  Conway’s Game of Life done in unity
for this project i decided it best to make a simple recreation of the game of life using a grid and cubes
i used only 3 classes because i didnt see a huge need to make more for this project
the first class i made was the simplest yet most important one, the cell class.
within the cell class i set 2 main states, the alive and dead states i chose these states because the game of life uses only these two states.
i used two very important methods in the cell class the CellUpdate and the CellApplyUpdate.
the first one calculates a cells state and the second implements Conway’s Game of Life rules.
the second class i made was the GameOfLife script.
for all intents and purposes this class is the main game engine of the game of life.
it contains the grid where the game is played and all other nessasary fields for the game of life.
and my third class was the cameracont script and this script was where we can change the view from 3d to 2d for the most part.
when in the 2d mode the game is basically what most people should easily recognize but when the 3d is enabled it gains a form of psudo 3d and the camera changes positions to better show off this 3d version. 
i chose psudo 3d as i felt it would show off the strengths of 2d while the added dimentions made the game of life a little more interesting.
