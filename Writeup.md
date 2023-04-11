# James Wilkinson · AS Coursework Report

[🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩                            ] 80%

- [x] Chapter One
- [x] Chapter Two
- [ ] Chapter Three
   - [ ] Beta Test Feedback
- [ ] Chapter Four
   - [ ] Test Results
   - [x] User Requirements
   - [ ] Strengths, Weaknesses & Enhancements
   - [x] Performance

----

#### Chapter One · Background & User Requirements

## Background

#### **Title**

Blocks

#### **Audience**

Anyone with love for Puzzle Games, regardless of Age or Gender.

#### **Why Is It Needed?**

Tetris is a classic video game that players of all ages have enjoyed have enjoyed for decades. The recreation of Tetris in WinForms is a challenging and complex project that requires a deep understanding of the programming concepts learnt within the AS1 Software Systems Development course, such as Events, Objects, Exceptions and more. By completing this project, I hope to further develop my programming skills and expand my understanding of these concepts.

#### **Functionality**

In this game, players must fill up lines with falling blocks in order to earn points. As lines are filled up, they disappear, and players can earn even more points by clearing multiple lines at once. The game becomes more challenging as the board fills up with blocks, and players must use the arrow keys to move the blocks horizontally, rotate them, and make them fall faster. Space can be used to make the block fall instantly. The objective is to earn as many points as possible before the board is completely filled with blocks.

+ **Scoring Chart**

| **Lines Cleared** | **Score Granted** | **Action**             | **Score Granted** |
| ----------------- | ----------------- | ---------------------- | ----------------- |
| 1                 | 100               | Quick Fall (T = 35ms)  | 1 While Active    |
| 2                 | 300               | Instant Fall (T = 1ms) | 2 While Active    |
| 3                 | 500               |                        |                   |
| 4                 | 800               |                        |                   |

----

## User Requirements

1. #### Login & Registration
   1. The user should be able to log in to the application if they have registered an account.
   2. The user should be able to choose one of the seven available avatars for their account.
   3. The user should be able to proceed with registration unless the following criteria are met.
      1. The forename must be between one and twenty-four characters inclusive.
      2. The surname must be between one and twenty-four characters inclusive.
      3. The username must be between one and sixteen characters inclusive.
      4. The username must not be taken by another user.
      5. The username is not reserved.
      6. The password is less than eight characters long.
      7. The password is entered in the same manner two times.
      4. The user should be able to skip login and registration by clicking the "Play as Guest" button.
   2. #### Profile & Scoreboards
      1. The user should be able to view the statistics tied to their account by clicking the chart icon.
      2. The user can view their high score, all-time score, blocks placed, lines cleared, games played, and how many times they have beaten their high score in the statistics menu.
         1. The user should not be able to view the statistics menu when playing as a guest; the menu should indicate properly that this option is unavailable.
      3. The user should be able to view the top ten scoring players registered in the application.
         1. The top ten scoring players will be determined by the highest score.
   3. #### Main Menu
      1. The user should be able to start a new game session from the Main Menu by clicking "START".
      2. The user should be able to continue a previous game from the Main Menu by clicking "CONTINUE" if they have a saved game linked to their account.
      3. The user should be unable to continue a previous game if they do not have a saved game linked to the account; the menu should indicate that this option is unavailable.
   4. #### The Gameplay
      1. The user should be able to move the block horizontally with the left and right arrow keys.
      2. The user should be able to utilise the up arrow key to rotate the block.
      3. The user should be able to utilise the down arrow key to make the block fall faster.
      4. The user should be able to utilise the space key to make a block fall instantly.
      5. The user should be able to utilise the C key to hold a block and save it for later, allowing them to press the same key again to swap the current block for the held block.
      6. The user should be able to fill up a line and have the application clear it.
      7. The user should be able to gain points, adding a score for every line they clear, including bonuses for extended survival times.
      8. The application should utilise a timer to allow for the use of the GameTimer_Tick() method every 1000ms divided by the multiplier or "level", allowing for the game to run recurring tasks.
      9. The current block object should descend by one tile vertically every tick.
      10. The blocks that are rendered on-screen should be chosen randomly by the program and should not follow a set order or pattern.
      11. The application should trigger the GameOver() method if the board is filled up and there is nowhere available to place the next block.
      12. The user should be able to save their game session by holding the ESC key a time period.
      13. The user should be able to observe a visual cue informing them as to how long they will have to keep holding the button to save their game session or forfeit it if they are playing as a guest.
      14. The visual cue should use a timer to increment the progress bar by the number of seconds divided by the number of rows on the game board.
   5. #### Visual Design & Layout
      1. The game board is in the centre and takes up most of the screen.
      2. The held block is displayed on the top left side adjacent to the board.
      3. The block queue is displayed on the top right side adjacent to the board.
      4. The player's score is displayed at the bottom of the window.
      5. The player's avatar and username are displayed at the bottom left of the window.
   6. #### Game End
      1. The user should be able to view their final score on the game over form.
      2. The user should be able to view if their final score supersedes their previous high score.
         1. This feature will be hidden for users who are not logged in.
      3. The menu should return the user to the main menu in 15 seconds after opening using a timer.
      4. The user should be able to see their updated statistics after this screen closes.
   7. #### Sound Effects
      1. There will be a game soundtrack in the background.
         1. This should be able to be muted with a specified key.
      2. Sound effects will play when clearing lines, with special ones when removing four at once.
      3. Miscellaneous sound effects will play when browsing the menu.
   8. #### Error Handling
      1. Proper error handling will prevent the game from crashing if an error occurs.
      2. The player cannot make the block out of bounds as the board will stop rendering the new block position if an error returns, returning it to the previous position.
      3. The player cannot use invalid data in the registration form as it is strictly type-checked and will notify the user if it is invalid, refusing to proceed.
      4. The login form will show an error if the username and password do not match a valid account.

#### Chapter Two · Application Design

## Non-form Classes

----

#### Block

The Block Class is an essential component of the Game module in this application. It is responsible for managing and displaying the block on the screen, as well as verifying potential placement locations on the board. This validation process ensures that the block cannot be positioned on top of another block or outside of the game's boundaries.

### Fields

| **Signature**         | **Datatype** |
| --------------------- | ------------ |
| private position      | Position     |
| private r             | int          |
| private moves         | int          |
| private readonly maxR | int          |
| private readonly maxX | int          |
| private readonly maxY | int          |
| private id            | int          |
| private idle          | bool         |
| private tile          | Image        |
| private type          | BlockType    |

### Constructors

| **Signature**                                            | **Datatype** | **Description**                                                                                                     |
| -------------------------------------------------------- | ------------ | ------------------------------------------------------------------------------------------------------------------- |
| public Block()                                           | Block        | Allows for the creation of an empty block, enables the holding block and resuming game function of the application. |
| public Block(int id, BlockType type, int maxX, int maxY) | Block        | Instantiates fields with values provided in the parameters and default values dependant on the Blocks BlockType.    |

### Properties

| **Signature**                    | **Datatype** |
| -------------------------------- | ------------ |
| public Id { public get; set; }   | int          |
| public Type { public get; set; } | BlockType    |
| public Idle { public get; set; } | bool         |
| public Pos { public get; set; }  | Position     |

### Methods

| **Signature**                                                                              | **Datatype** | **Description**                                                                                                                                                                               |
| ------------------------------------------------------------------------------------------ | ------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| public MoveHorizontally(GameWindow gameWindow, int adjustment)                             | void         | Calls RenderNextFrame(gameWindow, position.x + adjustment, position.y, r) in order to change the horizontal position of the block on the board.                                               |
| public MoveDown(GameWindow gameWindow)                                                     | void         | Calls RenderNextFrame(gameWindow, position.x, position.y +1, r) in order to change the vertical position of the block on the board by one.                                                    |
| public RotateClockwise(GameWindow gameWindow)                                              | void         | Calls RenderNextFrame(gameWindow, position.x, position.y, newR) in order to change the rotation of the block on the board.                                                                    |
| private RenderNextFrame(GameWindow gameWindow, float x, float y, int rotation)             | void         | Takes the given parameters and usesGeneratePositions, ValidateTiles and RenderTile to render the next movement of the block, and then save the new values to the appropriate fields.          |
| private RenderTile(GameWindow gameWindow, float x, float y, Image tile, string tag)        | void         | If given [X, Y] coordinates, the function attempts to find the cell and then passses it on to the RenderTile(Cell, Image, String) method.                                                     |
| private RenderTile(GameWindow gameWindow, PictureBox cell, Image tile, string tag)         | void         | This method sets the image and tag held by the Cell specified as the Image and Tag passed into the method.                                                                                    |
| private GenerateGhostBlockPositions(GameWindow gameWindow, float x, float y, int rotation) | List         | Generates the lowest possible valid position where the block can be placed, this enables the ghost block functionality, which allows users to more easily see where a block is going to fall. |
| public Hide(GameWindow gameWindow)                                                         | void         | This scans the board for tiles of the same block by search each cell's tag and checking to see if the id matches this block. If it matches, that cell is set to empty.                        |
| private GeneratePositions(float row, float column, int r)                                  | List         | Generates position offsets from the base coordinates based on the BlockType and rotation value provided.                                                                                      |
| private ValidateTiles(GameWindow gameWindow, List positions)                               | bool[]       | Checks if a block placement is valid or not based on if all tiles are valid and unobstructed. If invalid, it returns a boolean array showing the axis causing the problem.                    |

### Pseudocode

#### constructor

```vbnet
When a new Block is created without any parameters:
  // do nothing
```

#### constructor (int, BlockType, int, int)

```vbnet
When a new Block is created with (int, BlockType, int, int) parameters:
  Set id to id parameter
  Set type to type parameter
  Set maxX to maxX parameter
  Set maxY to maxY parameter
  Set r to 0
  Set moves to 0
  set maxR to 3
  Create a new position object with default coordinates (4, 0)
  Switch on the BLockType of the type field:
    If BlockType is LINE:
      position.y = -1
      maxR = 1
    If BLockType is SQUARE:
      maxR = 0
    If BLockType is Z OR S:
      maxR = 1

  Set tile field to Image returns from GameIOManager.Tiles[(int) type]
  Set tile's tag to the returned valuefrom type.ToString();
```

#### MoveHorizontally

```vbnet
When MoveHorizontally is called:
  Call RenderNextFrame with the parameters:
    gameWindow
    position.x + adjustment
    position.y
    r
```

#### MoveDown

```vbnet
When MoveDownards is called:
  Call RenderNextFrame with the parameters:
    gameWindow
    position.x
    position.y + 1
    r
```

#### RotateClockwise

```vbnet
When RotateClockwise is called:
  Set newR to (r + 1) % (maxR + 1)
  Call RenderNextFrame with the parameters:
    gameWindow
    position.x
    position.y
    newR
```

#### RenderNextFrame

```vbnet
When RenderNextFrame function is called:
  Generate newBlockPositions using GeneratePositions(x, y, rotation)
  Generate positionValidation using ValidateTiles(gameWindow, newBlockPositions)
  
  If the next position is not a valid horizontal move:
    Return
  If the next position is not a valid vertical move:
    If moves equals 0:
      Call gameWindow.GameOver()
    Otherwise:
      Set idle to true
      Return
  
  If idle is True:
    Return

  Suspend gameWindow's layout
  Call Hide(gameWindow)
  Generate ghostBlockPositions using GenerateGhostBlockPositions(gameWindow, x, y, rotation)
  For each pos in ghostBlockPositions:
    Render tile using RenderTile(gameWindow, pos.x, pos.y, Resources.Ghost, id.ToString())

  For each pos in newBlockPositions:
    Render tile using RenderTile(gameWindow, pos.x, pos.y, tile, id.ToString())
  
  Resume gameWindow's layout with true

  If y is equal to position.y and rotation is equal to this.r:
    Call AudioController.PlaySoundEffect("move")
  Else If rotation is not equal to this.r:
    Call AudioController.PlaySoundEffect("rotate")
  
  Set position.x to x
  Set position.y to y
  Set this.r to rotation
  Increment moves by 1
```

#### RenderTile

```vbnet
When RenderTile function is called with (GameWindow, float, float, Image, string) parameters:
  Round x to the nearest integer value and assign it to variable roundedX
  Round y to the nearest integer value and assign it to variable roundedY
  Get the PictureBox cell from gameWindow using GetCellFromCoordinates(roundedX, roundedY) and assign it to variable cell
  Call RenderTile(cell, tile, tag)
```

#### RenderTile

```vbnet
When RenderTile function is called with (PictureBox, Image, string) parameters:
  If cell is not null:
    Set cell's Image to tile
    Set cell's Tag to tag
```

#### GenerateGhostBlockPositions

```vbnet
When GenerateGhostBlockPositions function is called:
  Round x to the nearest integer value and assign it to variable row
  Round y to the nearest integer value and assign it to variable column
  Call GeneratePositions function with row, column, and rotation parameters and assign the returned list of positions to variable positions

  Set ValidGhostPlacement to true
  While ValidGhostPlacement is true:
    Calculate newGhostBlock positions by calling GeneratePositions function with:
      x coordinate of the first position in positions list,
      y coordinate of the first position in positions list plus 1,
      and rotation parameters,
    and assign the returned list of positions to variable newGhostBlock
  
    Call ValidateTiles function with gameWindow and newGhostBlock parameters 
    and assign the returned boolean array to variable ValidGhostBlock
  
    If ValidGhostBlock[0] and ValidGhostBlock[1]:
      Set positions to newGhostBlock
    Else:
      Set ValidGhostPlacement to false

  Return positions
```

#### Hide

```vbnet
When Hide function is called with:
  Call SuspendLayout function on gameWindow

  Initialize an empty list OccupiedCells
  For each BoardCell in gameWindow.Cells do the following:
    If the Tag property of the BoardCell is equal to the id of the block:
      Add the BoardCell to the OccupiedCells list

  For each Cell in OccupiedCells:
    Call RenderTile function with (Cell, Resources.Empty, "Empty") parameters

  Call ResumeLayout function with true parameter on gameWindow
```

#### GeneratePositions

```vbnet
When GeneratePositions() is called with row, column, and r parameters:
  Instantiate a new list called tilePositions
  Set x to the integer value of the row parameter
  Set y to the integer value of the column parameter
  
  Switch on the type field:
    If type is LINE:
      Add positions to tilePositions to form the shape of a line block
    If type is SQUARE:
      Add positions to tilePositions to form the shape of a square block
    If type is Z:
      Add positions to tilePositions to form the shape of a Z block
    If type is S:
      Add positions to tilePositions to form the shape of an S block
    If type is L:
      Add positions to tilePositions to form the shape of an L block
    If type is REVERSE_L:
      Add positions to tilePositions to form the shape of a reverse L block
    If type is T:
      Add positions to tilePositions to form the shape of a T block
  
  Return the tilePositions list
```

#### ValidateTiles

```vbnet
When the private method ValidateTiles is called with GameWindow and List<Position> positions as parameters:
  Set baseX to the rounded value of positions[0].x
  Set horizontal to true
  Set vertical to true

  For each Position object pos in the positions list:
    Set h to true
    Set v to true
    Set x to the rounded value of pos.x
    Set y to the rounded value of pos.y
    Get the Cell from the gameWindow object with coordinates (x, y)
    Store in Cell variable

    If Cell is null:
      If y equals maxY:
      Set v to false
    Otherwise:
      Set h to false
    
    Else if tile.Tag does not equal "Empty" and does not equal the string representation of id:
      If baseX does not equal position.x:
        Set h to false
      Otherwise:
        Set v to false

    Set horizontal to the logical AND of horizontal and h
    Set vertical to the logical AND of vertical and v

  Return a boolean array containing the values of horizontal and vertical
```

#### GameSession

The GameSession class is responsible for managing the gameplay session of the application. It has fields for a GameWindow object, BlocksSpawned, and RestrictHold. Properties for LinesCleared, Score, and Multiplier are also available. GameSession has two constructors and several methods, including Tick(), Hold(), MoveHorizontally(), RotateClockwise(), GameOver(), Save(), and AddScore(). These methods allow for updating the game state, restricting player actions, and adding points to the player's score based on their actions.

### Fields

| **Signature**               | **Datatype** |
| --------------------------- | ------------ |
| private readonly gameWindow | GameWindow   |
| private BlocksSpawned       | int          |
| private RestrictHold        | bool         |

### Constructors

| **Signature**                                                  | **Datatype** | **Description**                                                                                                                                                                                                          |
| -------------------------------------------------------------- | ------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| public GameSession(GameWindow gameWindow)                      | GameSession  | Instantiates fields with default values; creates five random block objects and places them in the queue; saves the game window instance to a local field.                                                                |
| public GameSession(GameWindow gameWindow, GameState gameState) | GameSession  | Instantiates fields using values from saved GameState; also restoring the held block, the current block, blocks in the block queue and any player statistics. This also keeps the game window instance in a local field. |

### Parameters

| **Signature**                            | **Datatype** |
| ---------------------------------------- | ------------ |
| public LinesCleared { public get; set; } | int          |
| public Score { get; private set; }       | int          |
| public Multiplier { public get; set; }   | double       |
| public BlocksPlaced                      | int          |

### Methods

| **Signature**                                             | **Datatype** | **Description**                                                                                                                                                                         |
| --------------------------------------------------------- | ------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| public Tick()                                             | void         | Runs time-bound tasks every interval, including updating the game state, moving the current block down, and as handling scoring and full lines.                                         |
| public Hold()                                             | void         | Swaps the current block with a held block or holds the current block if no block has been held.                                                                                         |
| public MoveHorizontally(int x)                            | void         | Calls CurrentBlock.MoveHorizontally(x)                                                                                                                                                  |
| public RotateClockwise()                                  | void         | Calls CurrentBlock.RotateClockwise()                                                                                                                                                    |
| public GameOver()                                         | void         | Updates the player's statistics and saves it to a file.                                                                                                                                 |
| public Save(GameWindow gameWindow, List tiles, List tags) | void         | Creates a new GameState object using the values from this GameSession, then attaches it to the Player object and calls upon GameIOManager to save players to file.                      |
| public AddScore(int lines, int adj)                       | void         | Incremented the scores by the sum of the predetermined values selected by the number of lines cleared and the adjustment value, multiplied by the speed multiplier currently in effect. |

### Pseudocode

#### GameSession(GameWindow)

```vbnet
When GameSession is created with (GameWindow) parameter:
  Set BlocksSpawned to 0
  Set Score to 0
  Set LinesCleared to 0
  Set Multiplier to 1

  Create a new empty list BlockQueue
  Repeat 4 times:
    Set type to a random BlockType
    Add a new Block object with (BlocksSpawned, type, gameWindow.boardWidth, gameWindow.boardHeight) parameters to the BlockQueue list
    Add 1 to BlocksSpawned

  Set RestrictHold to false
  Set gameWindow field to the gameWindow parameter
```

#### GameSession(GameWindow, GameState)

```vbnet
When GameSession is created with (GameWindow, GameState) parameters:
  Set Score to Score field of gameState parameter
  Set Multiplier to Multiplier field of gameState parameter

  Create a new Block object and set its fields:
    Set Id to Id field of gameState's CurrentBlock
    Set Type to Type field of gameState's CurrentBlock
    Set maxX to gameWindow.boardWidth
    Set maxY to gameWindow.boardHeight
    Set Pos to Pos field of gameState's CurrentBlock

  Set HeldBlock to HeldBlock field of gameState parameter
  Create a new empty list called BlockQueue
  For each block in BlockQueue field of gameState parameter:
    Create a new Block object and add it to the BlockQueue list:
      Set Id to Id field of the current block
      Set Type to Type field of the current block
      Set maxX to gameWindow.boardWidth
      Set maxY to gameWindow.boardHeight

  Set BlocksSpawned to BlocksPlaced field of gameState parameter
  Set LinesCleared to ClearedLines field of gameState parameter
  Set gameWindow to gameWindow parameter
```

#### Tick()

```vbnet
When Tick() is called:
  If gameWindow.Halt is true, return
  If gameWindow.Tick is false, return
  If CurrentBlock is null:
    Set gameWindow.Interval to 1000 / Multiplier
    Set CurrentBlock to the first block in BlockQueue
    Remove the first block from BlockQueue
    Generate a new random BlockType
    Add a new Block with the new BlockType to BlockQueue with id BlocksSpawned
    Increment BlocksSpawned by 1
  If gameWindow.Tick is false:
    Return
  If gameWindow.Halt is true:
    Return
  Move CurrentBlock down using the MoveDown method with gameWindow as argument
  If gameWindow.Interval is 35:
    Call the AddScore method with parameters (0, 1)
  If gameWindow.Interval is 1: 
    Call the AddScore method with parameters (0, 2)
  If CurrentBlock is idle:
    If gameWindow.Interval is 1:
      Play "harddrop" sound effect
    Otherwise:
      Play "softdrop" sound effect

    Set gameWindow.Interval to 100
    Set CurrentBlock to null
    Set RestrictHold to false
    Call the CheckLines method of gameWindow
```

#### Hold()

```vbnet
When Hold() is called:
    If RestrictHold is true, return
    If HeldBlock is null:
        Hide CurrentBlock on the gameWindow
        Set HeldBlock to a new Block with the same id, type, boardHeight and boardHeight as CurrentBlock
        Set CurrentBlock to the next block in the BlockQueue and move it to the leftmost position
        Remove the previous CurrentBlock from BlockQueue and add a new block to the end with a random BlockType and the next available Id
    Otherwise:
        Hide CurrentBlock on the gameWindow
        Set temp to a new Block with the same id, type, boardHeight and boardHeight as CurrentBlock
        Set CurrentBlock to HeldBlock with the same id, type, boardHeight and boardHeight as HeldBlock and move it to the leftmost position
        Set HeldBlock to temp with the same id, type, boardHeight and boardHeight as CurrentBlock
    
    Play "hold" sound effect
    Set RestrictHold to true.
```

#### MoveHorizontally

```vbnet
When MoveHorizontally(x) is called:
  Call the MoveHorizontally function on the CurrentBlock object with parameters gameWindow and x
```

#### RotateClockwise

```vbnet
When RotateClockwise() is called:
  Call the RotateClockwise function on the CurrentBlock object with parameter gameWindow
```

#### GameOver

```vbnet
When GameOver() is called:
  Get the current player from the SessionManager and store it in the variable "Player"
  If "Player" is null or a guest, return

  Add the value of "Score" to "Player"'s total score
  If "Score" is greater than "Player"'s high score:
    Set "Player"'s high score to "Score"

  Increment "Player"'s personal records by 1
  Add the value of "BlocksPlaced" to "Player"'s blocks placed
  Increment "Player"'s games played by 1
  Add the value of "LinesCleared" to "Player"'s cleared lines
  Clear the game state of "Player"

  Set the SessionManager's current player to "Player"
  Overwrite the player data in GameIOManager
  Save the updated player data to a file
```

#### Save

```vbnet
When Save() is called:
  Set Player variable to the SessionManager's CurrentPlayer
  If Player is null, return
  If Player's IsGuest property is true, return
  Hide the gameWindow
  Dispose of the gameWindow

  Create a new gameState object with the following properties:
    Score set to Score property of the current object
    Multiplier set to Multiplier property of the current object
    CurrentBlock set to CurrentBlock property of the current object
    HeldBlock set to HeldBlock property of the current object
      BlockQueue set to BlockQueue property of the current object
    BlocksPlaced set to BlocksSpawned property of the current object
    ClearedLines set to LinesCleared property of the current object
    Tiles set to the tiles parameter
    Tags set to the tags parameter

  Set the Player's PreviousGameState property to the gameState object
  Set the SessionManager's CurrentPlayer to the Player variable
  Call the OverwritePlayer function of GameIOManager with Player parameter
  Call the SavePlayers function of GameIOManager
  Show a MessageBox with the message "Your progress has been saved successfully.", the title "Blocks · Save Game Confirmation", an OK button, and an exclamation icon
  Call the PlaySoundEffect function of AudioController with "ok" parameter
  Show the MainMenuForm property of the SessionManager
```

#### AddScore

```vbnet
When AddScore() is called:
    Set "sc" to 0.
    Create a switch statement based on the value of "lines".
    If "lines" is equal to 1, add 100 to "sc" and play the "single" sound effect.
    If "lines" is equal to 2, add 300 to "sc" and play the "double" sound effect.
    If "lines" is equal to 3, add 500 to "sc" and play the "triple" sound effect.
    If "lines" is equal to 4, add 800 to "sc" and play the "tetris" sound effect.
    Add the value of "(sc + adj) * Multiplier" (rounded to the nearest integer) to the "Score" variable.
```

#### GameState

The GameState class holds the saved game state in the GameSession class. It has fields for the current and held blocks, multiplier, block count, block queue, score, cleared lines, tags, and tiles. The properties in GameState allow for accessing and modifying the saved state. This class provides a way to save and restore the game state in the application.

### Fields

| **Signature**        | **Datatype** |
| -------------------- | ------------ |
| private current      | Block        |
| private held         | Block        |
| private multiplier   | double       |
| private blockCount   | int          |
| private queue        | List         |
| private score        | int          |
| private clearedLines | int          |
| private tags         | List         |
| private tiles        | List         |

### Constructors

| **Signature**      | **Datatype** | **Description**                    |
| ------------------ | ------------ | ---------------------------------- |
| public GameState() | GameState    | Creates an empty saved Game State. |

### Parameters

| **Signature**       | **Datatype** |
| ------------------- | ------------ |
| public Score        | int          |
| public Multiplier   | double       |
| public CurrentBlock | Block        |
| public HeldBlock    | Block        |
| public BlockQueue   | List<Block>  |
| public BlocksPlaced | int          |
| public ClearedLines | int          |
| public Tiles        | List<string> |
| public Tags         | List<string> |

### Methods

This class does not contain any methods.

#### Player

The Player class represents a player and has fields for their personal information and game statistics. It provides properties for accessing and modifying these attributes, such as AllScore, Avatar, HighScore, and ClearedLines. The ClearGameState method sets the previous game state to null.

### Fields

| **Signature**             | **Datatype** |
| ------------------------- | ------------ |
| private allScore          | int          |
| private avatar            | int          |
| private blocksPlaced      | int          |
| private forename          | string       |
| private games             | int          |
| private highScore         | int          |
| private isGuest           | bool         |
| private password          | string       |
| private personalRecords   | int          |
| private previousGameState | GameState    |
| private surname           | string       |
| private ticks             | int          |
| private username          | string       |
| private clearedLines      | int          |

### Constructers

| **Signature**   | **Datatype** | **Description**                 |
| --------------- | ------------ | ------------------------------- |
| public Player() | Player       | Creates an empty Player Object. |

### Properties

| **Signature**     | **Datatype** |
| ----------------- | ------------ |
| Username          | string       |
| Password          | string       |
| Forename          | string       |
| Surname           | string       |
| IsGuest           | biil         |
| Avatar            | int          |
| HighScore         | int          |
| AllScore          | int          |
| BlocksPlaced      | int          |
| Games             | int          |
| PersonalRecords   | int          |
| ClearedLines      | int          |
| PreviousGameState | GameState    |

### Methods

| **Signature**           | **Datatype** | **Description**                  |
| ----------------------- | ------------ | -------------------------------- |
| public ClearGameState() | void         | Set previous game state to null. |

### Pseudocode

#### ClearGameState

```vbnet
When ClearGameState() is called:
  set PreviousGameState to null
```

#### Position

The Position class aims to represent a two-dimensional coordinate point with x and y values and provides various methods to manipulate and calculate positions. It is used for block position calculations within the Block Class.

### Fields

| **Signature**      | **Datatype** |
| ------------------ | ------------ |
| public static ZERO | Position     |

### Constructors

| **Signature**                           | **Datatype** | **Description**                                       |
| --------------------------------------- | ------------ | ----------------------------------------------------- |
| public Position()                       | Position     | Make a new position with (x, y) coordinates of (0, 0) |
| public Position<br>(float _x, float _y) | Position     | Makes a new position with the supplied (x, y) values. |

### Properties

| **Signature** | **Datatype** |
| ------------- | ------------ |
| x             | float        |
| y             | float        |

### Methods

| **Signature**                                            | **Datatype** | **Description**                                                                                                                                             |
| -------------------------------------------------------- | ------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------- |
| public bool Equals(Position other)                       | bool         | Check if this position object matches the other object passed in as a parameter.                                                                            |
| public override string ToString()                        | string       | Returns a string containing information on the coordinates<br>set in the Position object.                                                                   |
| public float dot(Position other)                         | float        | Calculates the dot product of two positions by multiplying the two x values and the two y values and returns the result.                                    |
| public float magnitude()                                 | float        | Calculates the magnitude of the parent position object using Pythagorean theorem (a$$^2$$ + b$$^2$$ = c$$^2$$).                                             |
| public Position interp(Position other, float interp_amt) | Position     | Calculates the interpolated position between this Position object and another Position object passed as an argument, based on a given interpolation amount. |
| public Position midpoint(Position other)                 | Position     | Calculates the midpoint between this Position object and another Position object passed as an argument.                                                     |
| public Position unit()                                   | Position     | Returns a new Position object with the same direction as this Position object but with a magnitude of 1.                                                    |
| public Position rotate(float theta)                      | Position     | Returns a new Position object that is rotated around the origin by a given angle theta (in degrees).                                                        |

### Operators

This header is only present in this class as it is the only class to use operator methods.

| **Signature** | **Datatype** |
| ------------- | ------------ |
| [==]          | Position     |
| [!=]          | Position     |
| [+]           | Position     |
| [-]           | Position     |
| [*]           | Position     |
| [/]           | Position     |
| [implicit]    | PointF       |

### Pseudocode

#### Equals

```vbnet
When Equals is called:
    Return x equals to other.x AND y equals to other.y
```

#### ToString

```vbnet
When ToString is called:
    Set a string variable result to "Position {\v"
    Append new string('\b', 5) to result
    Append x to result
    Append ",\v" to result
    Append new string('\b', x.ToString().Length + 1) to result
    Append y to result
    Append "\v" to result
    Append new string('\b', y.ToString().Length + 4) to result
    Append "}"
    Return result
```

#### dot

```vbnet
When dot is called:
    Declare a float variable total and set it to 0.0f
    Add x multiplied by other.x to total
    Add y multiplied by other.y to total
    Return total
```

#### magnitude

```vbnet
When magnitude is called:
    Return the square root of (x squared plus y squared)
```

#### interp

```vbnet
When interp is called:
    Return this Position plus (other Position minus this Position) multiplied by interp_amt
```

#### midpoint

```vbnet
When midpoint is called:
    Return the average of this Position and other Position
```

#### unit

```vbnet
When unit is called:
    Declare a float variable mag and set it to the magnitude of this Position
    Return a new Position with x divided by mag and y divided by mag
```

#### rotate

```vbnet
When rotate is called:
    Multiply theta by 0.0174533f
    Return a new Position with x set to (x times the cosine of theta) minus (y times the sine of theta), and y set to (x times the sine of theta) plus (y times the cosine of theta)
```

#### SessionManager

The SessionManager class is a static class that manages the current session. It has fields for debug mode and properties for accessing and modifying the current player object, Login Form and Main Menu Form.

### Fields

| **Signature** | **Datatype** |
| ------------- | ------------ |
| debugMode     | bool         |

### Constructors

This is a static class and does not have a constructor.

### Properties

| **Signature** | **Datatype** |
| ------------- | ------------ |
| DebugMode     | bool         |
| CurrentPlayer | Player       |
| SplashForm    | Form         |
| MainMenuForm  | Form         |

### Methods

This class does not contain any methods.

#### GameIOManager

The purpose of this class is to provide methods for reading and writing player data to local files. It also contains public lists of commonly used resources throughout the application. Overall, the GameIOManager class is responsible for managing the input and output of data in the game.

#### Fields

| **Signature**             | **Data Type** |
| ------------------------- | ------------- |
| private static players    | List          |
| public static Backgrounds | List          |
| public static Tiles       | List          |
| public static Previews    | List          |
| public static Avatars     | List          |

#### Constructors

This is a static class and does not have a constructor.

#### Properties

This class does not contain any properties.

### Methods

| **Signature**                                                       | **Datatype** | **Description**                                                                                |
| ------------------------------------------------------------------- | ------------ | ---------------------------------------------------------------------------------------------- |
| public static AddPlayer(Player player)                              | void         | Adds a new player to the database                                                              |
| public static DoesPlayerExist(string username)                      | bool         | Querys the player list to check if a player with the provided username already exists          |
| public static IsPasswordCorrect(string password, string storedHash) | bool         | Checks if the hashed version of the provided string matches the stored hash                    |
| public static OverwritePlayer(Player player)                        | void         | Overwrites a player object in the player list                                                  |
| public static SavePlayers()                                         | void         | Writes the serialised list of cached players to a local JSON file called PlayerDetails.json    |
| public static ReadPlayers()                                         | void         | Deserialises the content of the file back into a list of player objects, and caches the result |
| public static GetPlayers()                                          | List         | Return a cached list of players                                                                |
| public static CreateHash(string inputString)                        | Byte[]       | Creates a SHA256 Hash of the provided string.                                                  |
| public static GetHashString(string inputString)                     | string       | Converts returns hash and converts it to hexadecimal text for storage and comparison.          |

### Pseudocode

#### AddPlayer

```vbnet
When AddPlayer is called:
  Check if a player with the same username exists
    If yes, throw an InvalidPlayerException with the message "A player with that username already exists."
  Add player to the list of players
  Call SavePlayers function
```

#### DoesPlayerExist

```vbnet
When DoesPlayerExist is called:
  For each player in players:
    If the player's username is the same as the provided string:
      Return true
  Return false
```

#### IsPasswordCorrect

```vbnet
When IsPasswordCorrect is called:
  Get the hashed string of the password using the GetHashString function
  If the hashed string is the same as the stored hash:
    Return true
  Otherwise:
    Return false
```

#### OverwritePlayer

```vbnet
When OverwritePlayer is called:
When DoesPlayerExist is called:
  For each player in players:
    If the player's username is the same as the provided string:
      Replace the player in the list with the parameter player
```

#### SavePlayers

```vbnet
When SavePlayers is called:
  Try to open a file stream to PlayerDetails.json with the FileMode.Create option
  Create a Utf8JsonWriter object with the stream
  Serialize the list of players to the writer
  Catch any IOException and display the message in a MessageBox
```

#### ReadPlayers

```vbnet
When ReadPlayers is called:
  Try to open a file stream to PlayerDetails.json with the File.OpenRead method
  Create a StreamReader object with the stream
  Deserialize the contents of the stream to the list of players
  Catch any FileNotFoundException and do nothing
  Catch any IOException and display the message in a MessageBox
```

#### GetPlayers

```vbnet
When CreateHash is called:
  Create a new SHA256 algorithm instance
  Compute the hash of the UTF8-encoded input string using the algorithm
  Return the hash as a byte array
```

#### CreateHash

```vbnet
When GetHashString is called:
  Create a new StringBuilder
  Loop through the byte array returned by the CreateHash function
    Append the hexadecimal representation of each byte to the StringBuilder
  Return the StringBuilder as a string
```

#### AudioController

The AudioManager class is responsible for managing audio playback within the application. It contains three essential methods, PlaySoundEffect, StartBackgroundMusic, and StopBackgroundMusic. These methods all other classes and methods within the program to play sound effects quickly and efficiently.

### Fields

| **Signature**                    | **Datatype** |
| -------------------------------- | ------------ |
| private static SoundtrackWaveOut | WaveOut      |

### Constructors

This is a static class and does not have a constructor.

### Methods

| Signature                                       | Datatype | Description                                       |
| ----------------------------------------------- | -------- | ------------------------------------------------- |
| public static PlaySoundEffect(string soundName) | void     | Plays a sound effect.                             |
| public static PlayBackgroundMusic()             | Task     | Starts the background music on a separate thread. |
| public static StopBackgroundMusic()             | void     | Stops/pauses the background music.                |

### Pseudocode

#### PlaySoundEffect

```vbnet
When PlaySoundEffect is called:
    Load the sound resource with the specified sound name
    Run a new task that does the following:
        Read the wave file format from the sound resource
        Create a new raw source wave stream from the sound resource and wave format
        Create a new WaveOut object
        Set the WaveOut object's DesiredLatency to 100
        Initialize the WaveOut object with the raw source wave stream
        Play the sound
```

#### PlayBackgroundMusic

```vbnet
When PlayBackgroundMusic is called:
    Load the soundtrack resource with Resources.soundtrack
    Create a new WaveFileReader object from the soundtrack resource
    Create a new LoopStream object from the WaveFileReader object
    Create a new WaveOut object
    Initialize the WaveOut object with the LoopStream object
    Play the soundtrack
    Wait for the function to complete with an awaitable task
```

#### StopBackgroundMusic

```vbnet
When StopBackgroundMusic is called:
    If the SoundtrackWaveOut object is not null:
        Stop playing the soundtrack
        Dispose of the SoundtrackWaveOut object
        Set SoundtrackWaveOut to null
```

#### LoopStream

This class is a custom object implementation of the WaveStream class in the NAudio library that enables the looping of sound effects.

### Fields

| **Signature**        | **Datatype** |
| -------------------- | ------------ |
| private sourceStream | WaveStream   |

### Constructors

| **Signature**                              | **Datatype** | **Description**                                             |
| ------------------------------------------ | ------------ | ----------------------------------------------------------- |
| public LoopStream(WaveStream sourceStream) | LoopStream   | Creates a new custom WaveStream object and enables looping. |

### Properties

| **Signature**              | **Datatype** |
| -------------------------- | ------------ |
| public EnableLooping       | bool         |
| public override WaveFormat | WaveFormat   |
| public override Length     | long         |
| public override Position   | long         |

### Methods

| **Signature**                                              | **Datatype** | **Description**                                                                                                                                                                        |
| ---------------------------------------------------------- | ------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| public override Read(Byte[] buffer, int offset, int count) | int          | Reads bytes from underlying WaveStream into the provided buffer until the end of the stream is reached. Upon reaching the end, the position will be set to zero if looping is enabled. |

### Pseudocode

#### constructor

```vbnet
When a new LoopStream is created:
    Set the value of the instance variable sourceStream to the value of the parameter sourceStream.
    Set the value of the instance variable EnableLooping to true.
```

#### Read

```vbnet
When Read is called:
    Initialize the variable totalBytesRead to 0.
    While the total number of bytes read (totalBytesRead) is less than the requested number of bytes to read (count):
        Read data from the sourceStream and store it in the buffer starting at the specified offset (offset + totalBytesRead), up to the number of bytes remaining to be read (count - totalBytesRead), and store the number of bytes actually read in the bytesRead variable.
        If bytesRead equals 0:
            If the current position of the sourceStream is at the beginning (position 0) or looping is not enabled (EnableLooping is false):
                Exit the while loop.
            Otherwise:
                Set the current position of the sourceStream to 0.
        Add the number of bytes read in the current iteration (bytesRead) to the total number of bytes read so far (totalBytesRead).
    Return the total number of bytes read (totalBytesRead).
```

#### BlockType

The BlockType class is an enum class representing the different types of blocks in the game, providing a simple and more convenient way to refer to each block type across the program's source code.

### Fields

| **Signature**          | **Datatype** |
| ---------------------- | ------------ |
| public const SQUARE    | BlockType    |
| public const LINE      | BlockType    |
| public const T         | BlockType    |
| public const Z         | BlockType    |
| public const S         | BlockType    |
| public const L         | BlockType    |
| public const REVERSE_L | BlockType    |

### Constructors

This class does not contain any constructers as it is a static class.

### Properties

This class does not contain any properties.

### Methods

This class does not contain any methods.

#### CircularPictureBox

This is a custom implementation of the PictureBox control that displays an image in a circular shape.

### Fields

This class does not contain any fields.

### Constructors

| **Signature**               | **Datatype**       | **Description**                                                                                           |
| --------------------------- | ------------------ | --------------------------------------------------------------------------------------------------------- |
| public CircularPictureBox() | CircularPictureBox | Sets the size mode to StretchImage and appends the _paint method to the Paint property of the base class. |

### Properties

This class does not contain any properties.

### Methods

| **Signature**                                   | **Datatype** | **Description**                                                       |
| ----------------------------------------------- | ------------ | --------------------------------------------------------------------- |
| private _paint(object sender, PaintEventArgs e) | void         | Changes the shape of the PictureBox to a circle rather than a square. |

### Pseudocode

#### constructor

```vbnet
When a CircularPictureBox is created:
  Set the SizeMode to StrechImage
  Append the _paint method to the Paint parameter of the base class.
```

#### _paint

```vbnet
When _paint is called:
    Create a new variable rc that holds the rectangle dimensions of the Client.
    Create a new variable gp that holds a new GraphicsPath object.
    Add an ellipse with the dimensions of rc to gp.
    Set Region to a new Region object with the value of gp.
```

#### InvalidPlayerException

This exception class is used to handle errors related to invalid player objects in the game. This class is used by both the DataManager class and the registration form to handle errors related to invalid player input.

### Fields

This class does not contain any fields.

### Constructors

| **Signature**                                 | **Datatype**           | **Description**                                                                |
| --------------------------------------------- | ---------------------- | ------------------------------------------------------------------------------ |
| public InvalidPlayerException(string message) | InvalidPlayerException | Creates a new exception, setting the exception message as the string provided. |

### Properties

This class does not contain any properties.

### Methods

This class does not contain any methods.

### Pseudocode

#### constructor

```vbnet
When a InvalidPlayerException is created:
  Set message to provided string parameter.
```

----

## Form Classes

----

#### General Properties

The following form and control properties are consistent throughout my designs and the application unless otherwise stated underneath an individual form design.

| **Control**            | **Background Colour** | **Fore Colour** | **Style**                  |
| ---------------------- | --------------------- | --------------- | -------------------------- |
| *Form*                 | AliceBlue             | \-----          | \-----                     |
| *Label (Heading)*      | AliceBlue             | \-----          | Segoe UI Black, 18pt, Bold |
| *Label (Body)*         | AliceBlue             | Black           | Segoe UI, 9pt              |
| *Button*               | White                 | Black           | Segoe UI, 9pt              |
| *Button (Exit Button)* | White                 | IndianRed       | Segoe UI Black, 9pt, Bold  |
| CircularPictureBox     | \-----                | \-----          | SizeMode: Zoom             |
| PictureBox (Sidebar)   | \-----                | \----           | SizeMode: Zoom             |
| *PictureBox (Title)*   | AliceBlue             | \----           | SizeMode: Zoom             |
| *TextBox*              | White                 | Black           | MaxLength: 18              |

#### General Functions

| Function    | Description                                                                                                                            |
| ----------- | -------------------------------------------------------------------------------------------------------------------------------------- |
| Exit Button | When clicked, hides the current window and shows the hidden GameMenu Form stored as a static variable within the SessionManager class. |

----

#### Login Form

The purpose of the login form is enable users to enter their login details. By entering their credentials, users can unlock the ability to save their game progress and track their statistics with an account. Alternatively, users can also choose to play as a guest if they don't wish to register an account. Either way, the login form is the gateway that allows users to gain access to the application.

### Starting Design

![Image.jpeg](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/05D3C03A-5CA0-4A8A-A481-77D28407DA6A_2/XUovNHUn7SWkG8i7AJyAzWiXoYs1sXc4qySarUJPQi0z/Image.jpeg)

### Final Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/4915ffc9-b9b4-435f-861e-3bf8822229a6)

### Changes Due To User Feedback

I added a header above game title, and added improved graphical elements to the login form based on user feedback to improve the overall user experience as these changes make the form more visually appearing, engaging, and help users quickly identify the purpose of the form.

### Form Control Properties

| **Key** | **Req #** | **Form Control** | **Properties** | **Control Purpose**                 |
| ------- | --------- | ---------------- | -------------- | ----------------------------------- |
| *2a*    | \-----    | lbl_Heading      | default        | Heading Text                        |
| *2b*    | \-----    | pic_Title        | default        | Title Image                         |
| *2c*    | \-----    | lbl_username     | default        | Labels Username Textbox             |
| *2d*    | 1.1       | txt_username     | default        | Allows user to enter username.      |
| *2e*    | \-----    | lbl_password     | default        | Labels Password Text Box            |
| *2f*    | 1.1       | txt_password     | MaxLength: 24  | Allows user to enter password.      |
| *2g*    | 1.1       | btn_login        | default        | Allows user to log-in.              |
| *2h*    | 1.3       | btn_register     | default        | Opens the register form.            |
| *2i*    | 1.4       | btn_guest        | default        | Allows the user to log-in as guest. |
| *2j*    | \-----    | pic_sidebar      | default        | Aesthetic                           |
| *2k*    | \-----    | btn_exit         | default        | Allows user to exit the program.    |

### Function Summary

| **Function**  | **Req #** | **Description**                                                                |
| ------------- | --------- | ------------------------------------------------------------------------------ |
| *constructor* | *-----*   | Sets the static variable LoginForm in SessionManager to an instance of itself. |

### Events

| **Method Name**           | **Req #** | **Description**                                                                                                                                                                                                                                                                                                                                            |
| ------------------------- | --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| *LoginButton_OnClick*     | 1.1, 8.4  | Checks the database of players for a set of valid credentials that match the credentials entered by the user. If matching credentials are found, it will play a positive sound cue and display a message, notifying the user of the successful login. Otherwise, it will play a negative sound cue, and let the user know the the credentials are invalid. |
| *RegisterButton_OnClick*  | 1.3       | Plays a sound effect, opens the registration form and hides the current form.                                                                                                                                                                                                                                                                              |
| *GuestButton_OnClick*     | 1.4       | Shows a message box to the user, explaining that saving your game and statistics will be unavailable when you play as a guest, if the user acknowledges this, then a new temporary player object is created allowing them to play without registering.                                                                                                     |
| *Form_OnVisibilityChange* | *-----*   | Clears the **txt_username** and **txt_password** fields.                                                                                                                                                                                                                                                                                                   |
| ExitButton_OnClick        | *-----*   | Exits the application with exit code 0.                                                                                                                                                                                                                                                                                                                    |

### Pseudocode

#### constructor

```vbnet
When the Login form is created:
    Initialize the form's components
    Set the SplashForm property of the SessionManager class to this form
```

#### LoginButton_OnClick

```vbnet
When the Login button is clicked:
    Set "valid" to false
    Set "loggedInPlayer" to null
    
    Loop through each player in the list of players:
        If the player's username matches the text in the "txt_username" field AND
           the player's hashed password matches the text in the "txt_password" field:
            Set "valid" to true
            Set "loggedInPlayer" to the current player
            Exit the loop
    
    If "valid" is true AND "loggedInPlayer" is not null:
        Play a sound effect
        Show a message box welcoming the user back and confirming successful login
        Set the current player in the session manager to "loggedInPlayer"
        Play another sound effect
        Show the game menu form and hide the login form
    Else:
        Play an error sound effect
        Show a message box indicating an invalid username/password combination
    
    Clear the text in the "txt_username" and "txt_password" fields
```

#### RegisterButton_OnClick

```vbnet
When the Register button is clicked:
    Play a select sound effect
    Create a new instance of the registration form
    Show the registration form and hide the current form
```

#### GuestButton_OnClick

```vbnet
When the Guest button is clicked:
    Play an alert sound effect
    Display a confirmation message box with the following text:
        "Are you sure you want to play as a Guest?
        The ability to save your game and publish your score will be disabled."
    If the user clicks "Yes" in the message box:
        Set the current player in the session manager to a new Player object with the following properties:
            Username = "Guest"
            Avatar = 7
            IsGuest = true
        Play a success sound effect
        Show the game menu form and hide the current form
    If the user clicks "No" in the message box:
        Play a cancellation sound effect
```

#### Form_OnVisibilityChange

```vbnet
When the visibility of the form changes:
    Clear the text in the "txt_username" text box
    Clear the text in the "txt_password" text box
```

#### ExitButton_OnClick

```vbnet
When the Exit button is clicked:
    Exit the application with a return code of 0
```

### Validation

- txt_username field must contain between one and eighteen characters inclusive.
- txt_password field must contain between eight and twenty-four characters inclusive.

#### Register Form

The purpose of the registration form is to allow users to register an account with the program. By entering their forename, surname, preferred username and password, they unlock the ability to save their game progress, track game statistics and publish their high score to the leaderboard.

### Starting Design

![Image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/4E51F938-4978-47EA-8123-0CED8785C0BE_2/p1ow7j3to1a51RRoyPA6ZoYSO1oKJL9b3ykC53IX1KEz/Image.png)

### Final Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/51e036f0-a4d6-456a-bd89-a4070ac7e7f3)

### Changes Due To User Feedback

I incorporated user feedback to improve the design of the form by adding a header and a title card to clarify its purpose and create a more compact layout that uses space efficiently while retaining full functionality. I also introduced enhanced graphical elements to make the form more visually appealing, resulting in an overall improved user experience.

### Form Control Properties

| **Key** | **Req #** | **Form Control** | **Properties** | **Control Purpose**               |
| ------- | --------- | ---------------- | -------------- | --------------------------------- |
| *3a*    | \-----    | lbl_Heading      | default        | Heading Text                      |
| *3b*    | \-----    | pic_Title        | default        | Title Image                       |
| *3c*    | \-----    | lbl_forename     | default        | Labels Forename Textbox           |
| *3d*    | 1.3.1     | txt_forename     | default        | Allows user to enter forename.    |
| *3e*    | \-----    | lbl_surname      | default        | Labels Surname Textbox            |
| *3f*    | 1.3.2     | txt_surname      | default        | Allows user to enter surname.     |
| *3g*    | \-----    | lbl_username     | default        | Labels Username Textbox           |
| *3h*    | 1.3.3-5   | txt_username     | default        | Allows user to enter username.    |
| *3i*    | \-----    | lbl_password     | default        | Labels Password Textbox           |
| 3j      | 1.3.6     | txt_password     | default        | Allows user to enter password.    |
| *3k*    | \-----    | lbl_pwdconfirm   | default        | Labels Password Confirm Textbox   |
| *3l*    | 1.3.7     | txt_pwdconfirm   | default        | Allows user to enter pwd twice.   |
| *3m*    | 1.2       | btn_caForward    | default        | Cycles avatar picker forward.     |
| *3n*    | 1.2       | pic_avatar       | default        | Shows preview of selected avatar. |
| *3o*    | 1.2       | btn_caBack       | default        | Cycles avatar picker backwards.   |
| *3p*    | 1.3       | btn_register     | default        | Allows user to register account.  |
| *3q*    | \-----    | pic_sidebar      | default        | Aesthetic                         |
| 3r      | \-----    | btn_exit         | default        | Allows user to exit the program.  |

### Function Summary

| **Function**   | **Req #** | **Description**                                              |
| -------------- | --------- | ------------------------------------------------------------ |
| *constructor*  | *-----*   | Instantiates validation booleans and renders avatar preview. |
| *ClearErrMsgs* | *-----*   | Hides error message placeholder text.                        |

### Events

| **Method Name**                    | **Req #** | **Description**                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| ---------------------------------- | --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| *RegisterPlayerButton_OnClick*     | 1.3, 8.3  | When the user clicks the register button, the program checks if all five validation conditions are met. If they are, the avatar index is added to the player object, and the player data is saved to the database. A success message with a positive sound effect is displayed to the user, and they are taken back to the main menu. If any of the validation conditions are not met, an error message is displayed to inform the user that the data provided is incorrect. |
| Forename_ValueChanged              | 1.3.1     | If the value in txt_forename is between one and twenty-eight characters inclusive, then ValidForename is set to true, otherwise it is set to false, displaying an error and preventing registration.                                                                                                                                                                                                                                                                         |
| Surname_ValueChanged               | 1.3.2     | If the value in txt_surname is between one and twenty-eight characters inclusive, then ValidSurname is set to true, otherwise it is set to false, displaying an error and preventing registration.                                                                                                                                                                                                                                                                           |
| Username_ValueChanged              | 1.3.3-5   | If the value in txt_username is between one and eighteen characters inclusive, then ValidUsername is set to true, otherwise it is set to false, displaying an error and preventing registration.                                                                                                                                                                                                                                                                             |
| Password_ValueChanged              | 1.3.6     | If the value in txt_password is between eight and twenty-four characters inclusive, then ValidPassword is set to true, otherwise it is set to false, displaying an error and preventing registration.                                                                                                                                                                                                                                                                        |
| PasswordConfirm_ValueChanged       | 1.3.7     | If txt_passwordConfirm's value equals txt_password's value, then ValidPasswordConfirm is set to true, otherwise it is set to false, displaying an error and preventing registration.                                                                                                                                                                                                                                                                                         |
| CycleAvatarBackwardsButton_OnClick | 1.2       | Decreases the avatar index by one, moving making the avatar preview display the preview avatar in the predefined list. If the beginning of the list is reached, it goes to the end of the list.                                                                                                                                                                                                                                                                              |
| CycleAvatarForwardButton_OnClick   | 1.2       | Increases the avatar index by one, moving making the avatar preview display the next avatar in the predefined list. If the end of the list is reached, it goes back to index 0.                                                                                                                                                                                                                                                                                              |
| *Form_OnClosing*                   | \-----    | Shows the login screen stored in the static LoginScreen property found in the SessionManager class.                                                                                                                                                                                                                                                                                                                                                                          |
| ExitButton_OnClick                 | *-----*   | Plays a "cancel" sound effect and closes the form.                                                                                                                                                                                                                                                                                                                                                                                                                           |

### Pseudocode

#### constructor

```vbnet
When the Login form is created:
  Initialise the form's components
  Set NewPlayer to a new instance of the Player class
  Set AvatarIndex to a random integer between 0 and 5
  Set the image of pic_playerAvatar to the Avatar at index AvatarIndex in the GameIOManager's Avatars list
  Set ValidForename, ValidSurname, ValidUsername, ValidPassword, and ValidPasswordConfirm to false
  Call the ClearErrMsgs() method to hide error placeholder text.
```

#### ClearErrMsgs

```vbnet
When the ClearErrMsgs() function is called:
  Set the error label text for forename to an empty string
  Set the error label text for surname to an empty string
  Set the error label text for username to an empty string
  Set the error label text for password to an empty string
  Set the error label text for password confirmation to an empty string
```

#### RegisterPlayerButton_OnClick

```vbnet
When the Register Player button is clicked:
  Set valid variable to true
  If valid forename is not entered, set valid variable to false
  If valid surname is not entered, set valid variable to false
  If valid username is not entered, set valid variable to false
  If valid password is not entered, set valid variable to false
  If valid password confirmation is not entered, set valid variable to false
  If all fields are valid:
    Set the new player's avatar to the chosen avatar index
    Play a sound effect
    Add the new player to the list of players
    Display a welcome message with the new player's username
    Play a sound effect
    Show the splash form
    Close the registration form
  Else if there are invalid fields:
    Play a sound effect
    Display an error message with instructions to review and correct the errors
```

#### Forename_ValueChanged

```vbnet
When the forename value changes:
    Attempt to set the NewPlayer's forename to the text in the txt_forename field
    If successful:
      Clear the forename error label
      Set ValidForename to True
    Otherwise:
      Set the forename error label to the exception message 
      Set ValidForename to False
```

#### Surname_ValueChanged

```vbnet
When the surname value changes:
    Attempt to set the NewPlayer's surname to the text in the txt_surname field
    If successful: 
      Clear the surname error label 
      Set ValidSurname to True
    Otherwise:
      Set the surname error label to the exception message 
      Set ValidSurname to False
```

#### Username_ValueChanged

```vbnet
When the username value changes:
    Attempt to set the NewPlayer's username to the text in the txt_username field
    If successful:
      clear the username error label and mark ValidUsername as true
    Otherwise:
      Set the username error label to the exception message 
      Set ValidUsername to False
```

#### Password_ValueChanged

```vbnet
When the password value changes:
    If the length of the text in the txt_password field is less than 8:
      Set the password error label notifying the user of this rule
      Set ValidPassword to False
    Otherwise:
      Set the NewPlayer's password to the hashed version of the value in the txt_password field
      Clear the password error label
      Mark ValidPassword to True
```

#### PasswordConfirm_ValueChanged

```vbnet
When the password confirm value changes:
    If the text in the txt_password field does not match the text in the txt_passwordConfirm field:
      set the password confirm error label to a message 
      Set ValidPasswordConfirm to False
    Otherwise:
      Clear the password confirm error label
      Set ValidPasswordConfirm to True
```

#### CycleAvatarBackwardsButton_OnClick

```vbnet
When the Cycle Avatar Backwards Button is clicked:
  Play the "rotate" sound effect
  If AvatarIndex is not 0:
    decrease AvatarIndex by 1
  Otherwise:
    Set AvatarIndex to 6
  If AvatarIndex is less than or equal to 6:
    Set the player avatar image to the corresponding avatar in the game's list of avatars
```

#### CycleAvatarForwardButton_OnClick

```vbnet
When the Cycle Avatar Forward Button is clicked:
  Play the "rotate" sound effect
  If AvatarIndex is not 6:
    Increase AvatarIndex by 1
  Otherwise:
    Set AvatarIndex to 0
  If AvatarIndex is less than or equal to 6: 
    Set the player avatar image to the corresponding avatar in the game's list of avatars
```

#### *Form_OnClosing*

```vbnet
When the form is closing:
    Show the login form
```

#### ExitButton_OnClick

```vbnet
When the Exit button is clicked:
    Close the register form
    Play the "cancel" sound effect
```

### Validation

- txt_forname must contain between eight and twenty-four characters inclusive.
- txt_surname must contain between eight and twenty-four characters inclusive.
- txt_username field must contain between one and eighteen characters inclusive.
- txt_password field must contain between eight and twenty-four characters inclusive.
- txt_passwordConfirm confirm field must match the content of the txt_password field.

#### GameMenu Form

The game menu form serves as a central hub for users to access various features and forms within the game. It provides access to functions such as starting or resuming game sessions, viewing the leaderboard, checking game statistics, and accessing the help menu. Overall, the game menu form is an essential tool for players to fully utilize the game's features.

### Starting Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/bced18d2-60b2-4814-aba1-ee320de52813)

### Final Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/ef9cb700-f55e-44ad-9a23-83044e521a08)

### Changes Due To User Feedback

Multiple modifications were made to the final design of the main game menu due to user feedback and testing. Based on these factors, several changes were implemented to improve the user experience. Firstly, a dedicated statistics button was added underneath the username label instead of double-clicking the player avatar to allow for more clarity on navigating to this form, enabling easier access. Additionally, the help button was moved beside the statistics button to improve the layout, and the "logout" button has been changed to "Change User". Secondly, a header was added above the title card, making the form now read "Welcome To BLOCKS", enhancing the visual appeal and the menu and providing clarity to the user. The start, continue, and leaderboard buttons were also changed to be different colours and shapes to make the form more appealing graphically. Finally, the exit button has been resized and changed to red, designed to be a wide banner underneath the main controls for better visibility, allowing users to exit the application safely and efficiently. These changes aim to improve the user experience and address specific issues regarding layout and accessibility.

### Form Control Properties

| **Key** | **Req #** | **Form Control** | **Properties**        | **Control Purpose**                              |
| ------- | --------- | ---------------- | --------------------- | ------------------------------------------------ |
| *1a*    | \-----    | lbl_Heading      | default               | Heading Text                                     |
| *1b*    | \-----    | pic_Title        | default               | Title Image                                      |
| *1c*    | 3.1       | btn_start        | BackColor: Lime       | Allows user to start a new game of blocks.       |
| *1d*    | 3.2-3     | btn_continue     | BackColor: Gold       | Allows user to continue a previously saved game. |
| *1e*    | 2.3       | btn_scoreboard   | BackColor: DodgerBlue | Opens the scoreboard form.                       |
| 1f      | \-----    | btn_exit         | BackColor: Red        | Allows user to exit the program.                 |
| *1g*    | 5.5       | pic_avatar       | default               | Shows the player's avatar.                       |
| *1h*    | \-----    | lbl_loggedinas   | default               | Logged In As Text                                |
| *1i*    | 5.5       | lbl_player       | Bold                  | Shows the player's username.                     |
| *1j*    | 2.1-2     | btn_statistcs    | default               | Opens the Profile Pane Form                      |
| *1k*    | \-----    | btn_help         | default               | Opens the Help Pane Form                         |
| *1l*    | \-----    | btn_changeuser   | default               | Brings user back to login screen.                |
| *1m*    | \-----    | pic_sidebar      | default               | Aesthetic                                        |

### Function Summary

| **Function**  | **Req #** | **Description**                                                                   |
| ------------- | --------- | --------------------------------------------------------------------------------- |
| *constructor* | *-----*   | Sets the static variable MainMenuForm in SessionManager to an instance of itself. |

### Events

| **Method Name**            | **Req #** | **Description**                                                                                                                                                                                                                                                                                                               |
| -------------------------- | --------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| StartButton_OnClick        | 3.1       | Creates a new GameWindow and hides the current window, making a new GameSession. It will notify the user before continuing if they already have a saved game state, as this action will overwrite it.                                                                                                                         |
| ContinueButton_OnClick     | 3.2-3     | Creates a new GameWindow with a previously saved game state and hides the current form. Unless one is unavailable, which then it will alert the user that there is no saved game to continue.                                                                                                                                 |
| ChangeUserButton_OnClick   | \-----    | Closes the current form.                                                                                                                                                                                                                                                                                                      |
| *StatisticsButton_OnClick* | 2.1       | Opens the profile pane form and hides the current form if the user is logged in and is not a guest.                                                                                                                                                                                                                           |
| LeaderboardButton_OnClick  | 2.3       | Opens the leaderboard form and hides the current form.                                                                                                                                                                                                                                                                        |
| HelpButton_OnClick         | \-----    | Opens the help pane form and hides the current form.                                                                                                                                                                                                                                                                          |
| Form_OnClosing             | \-----    | Players a sound effect and opens the previous login form in the LoginForm property stored within the SessionManager.                                                                                                                                                                                                          |
| *Form_OnVisibilityChange*  | *-----*   | Fetches the current player from the CurrentPlayer property within SessionManager. If the player is a guest or doesn't have a saved game state linked to their account, the continue button is greyed out to indicate it is unavailable. If the user is playing as a guest, the statistics menu is also marked as unavailable. |
| ExitButton_OnClick         | *-----*   | Prompts the user to confirm if they wish to exit the application; if yes, exit the application with exit code 0, "otherwise play a "cancel" sound effect."                                                                                                                                                                    |

### Other Pseudocode

#### constructor

```vbnet
When the GameMenu form is created:
    Initialise the form's components    
    Set the MainMenuForm property of the SessionManager class to this form
```

#### StartButton_OnClick

```vbnet
When the Start button is clicked:
  If there is a previous game state for the current player:
    Play "alert" sound effect
    Show a message box with a warning icon, asking if the player wants to overwrite the previous game state
    If the player chooses Yes:
      Play "OK" sound effect
      Clear the previous game state of the current player
      Show a new game window
      Hide the current form
  Otherwise:
    Play "cancel" sound effect
  Else:
    Show a new game window
    Hide the current form
```

#### ContinueButton_OnClick

```vbnet
When the Continue button is clicked:
  If CurrentPlayer has a previous game state:
    Play the "select" sound effect
    Create a new instance of GameWindow using the previous game state and show it
    Hide the current form
  Otherwise:
    Play the "alert" sound effect
    Display a message box with the alert "You don't have a saved game to continue."
    Play the "cancel" sound effect when they acknowledge or close the alert
```

#### ChangeUserButton_OnClick

```vbnet
When the Change User button is clicked:
  Close the form
```

#### StatisticsButton_OnClick

```vbnet
When the Statistics button is clicked:
  If the current player is a guest:
    do nothing.
  Otherwise: 
    Play the "select" sound effect.
    Create and show a new ProfilePane form 
    Hide the current form
```

#### LeaderboardButton_OnClick

```vbnet
When the Leaderboard button is clicked:
  Play the "select" sound effect
  Create and show a new Leaderboard form, and 
  Hide the current form
```

#### HelpButton_OnClick

```vbnet
When the Help button is clicked:
  Play a sound effect
  Create and show a new HelpPane form
  Hide the current form
```

#### Form_OnClosing

```vbnet
When the form is closing:
  Play the "select" sound effect
  Show the Login Form
```

#### Form_OnVisibilityChange

```vbnet
When the form's visibility changes:
  Get the current player from the session manager
  If there is a current player:
    Set the text of the lbl_currentPlayer label to the current player's username
  If the current player has an avatar:
    Set the image of the pic_PlayerAvatar picture box to the corresponding avatar image from the GameIOManager
  Otherwise:
    Set the text of the lbl_currentPlayer label to "Guest"
  If the current player is a guest:
      Set the text of the btn_OpenStatisticsForm button to "🚫" and its foreground color to IndianRed
  Otherwise:
      Set the text of the btn_OpenStatisticsForm button to "📊" and its foreground color to Black
  If the current player has a previous game state:
      Set the background colour of the btn_ContinueGame button to Gold
  Otherwise:
      Set the background colour of the btn_ContinueGame button to Gray.
```

#### ExitButton_OnClick

```vbnet
When ExitButton is clicked:
    Play "caution" sound effect
    Show confirmation dialogue box with message "Are you sure you want to quit?" and title "Blocks · Confirmation Dialouge" and with Yes/No options.
    If user clicks Yes:
        Play "ok" sound effect
        Exit the application by calling Environment.Exit(0)
    Otherwise, play "cancel" sound effect.
```

### Validation

- If the user is a guest, do not continue with the opening of the statistics form.
- If the user is a guest, do not continue trying to resume a saved game.
- If the logged-in user does not have a saved game accosted with 
their account, do not continue trying to resume a saved game.

#### Leaderboard Form

The purpose of the leaderboard form is to display the top-scoring users in the game. By showing an easy-to-understand ranking of the top ten users. Users can see how they measure up to other users who have played on that machine, allowing users to be competitive as it encourages them to strive to achieve better scores and compete against others for higher rankings.

### Starting Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/fc6800b5-6ec7-443c-9822-72f499835921)

### Final Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/b73b590d-1c24-46e7-8cb3-6de819b86125)

### Changes Due To User Feedback

I utilised user feedback to improve the design of the form by completely changing the layout of how the top ten high scores were displayed. Before, it was just ten labels in the "**[1-10]. [Player] - [Score]"**  format, which was difficult to read and visually unappealing. Now, the form has been redesigned to use a table layout panel to display the information in the format **[|RANK|PLAYER|SCORE]**, with distinct header and body labels, improving readability and the visual appeal of the form.

### Form Control Properties

| **Key** | **Req #** | **Form Control** | **Properties** | **Control Purpose**           |
| ------- | --------- | ---------------- | -------------- | ----------------------------- |
| *4a*    | \-----    | lbl_Heading      | default        | Heading Text                  |
| *4b*    | \-----    | pic_Title        | default        | Title Image                   |
| *4c*    | 2.3       | tlp_Scores       | default        | Table showing top 10 players. |
| *4d*    | 2.3       | lbl_Heading      | default        | Shows Header text in Table    |
| *4e*    | 2.3       | lbl_Body         | default        | Shows body text in Table      |
| *4f*    | \-----    | pic_sidebar      | default        | Aesthetic                     |
| *4g*    | \-----    | btn_exit         | default        | Navigates user to game menu   |

### Function Summary

| **Function**                 | **Req #** | **Description**                                                                                                                     |
| ---------------------------- | --------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| *constructor*                | *-----*   | Creates a new sorted player list from the database from highest to lowest score and then prints the top ten players onto the table. |
| *GetLabelFrom* *Coordinates* | *-----*   | Gets the label control from the specified cell using the [x, y] coordinates provided by the calling method.                         |

### Events

| **Method Name**    | **Req #** | **Description**                                                                                                             |
| ------------------ | --------- | --------------------------------------------------------------------------------------------------------------------------- |
| *Form_OnClosing*   | *-----*   | Plays a sound effect and reopens the Main Menu Form stored in the MainMenuForm static property found within SessionManager. |
| ExitButton_OnClick | *-----*   | Closes the scoreboard form.                                                                                                 |

### Pseudocode

#### constructor

```vbnet
When the Scoreboard Form is created:
  Initialize the form's components
  Retrieve a sorted list of players from the GameIOManager
  Sort the list by a high score in descending order
  For each row in the scoreboard:
    Retrieve the player for the current row
    If there is no player for the current row:
      Set the player to a new player with a default username of "-----"
    Set the username label for the current row to the player's username
    If the player's high score is not 0:
      Set the score label for the current row to the player's high score 
    Otherwise:
      Set the score label to "-----"
```

#### GetLabelFromCoordinates

```vbnet
When the GetLabelFromCoordinates(x, y) function is called:
  Attempt to retrieve the control at the specified position from the scoreboard table layout panel
  If the control cannot be retrieved:
    Return null
  Otherwise:
    Cast the control to a label and return it
```

#### ExitButton_OnClick

```vbnet
When the Exit button is clicked:
    Close the scoreboard form
    Play the "cancel" sound effect
```

#### Form_OnClosing

```vbnet
When the form is closing:
    Show the Main Menu form
```

### Validation

- If there are not sufficient players to fill all ten slots, fill the empty 
player and score labels with "-----" to indicate they are empty.

#### GameEnd Form

The purpose of the GameEnd form is to inform the user of their performance in their last GameSession and congratulate them or give condolences depending on how they performed.

### Starting Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/fa8b0487-1b01-41d1-aac5-45f0ee2781ec)

### Final Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/215dc504-99d3-40a6-afd5-8235753c322c)

### Changes Due To User Feedback

User feedback has influenced modifications to the GameEnd form. The exit button was changed to a skip button, and the header, game status label, and sidebar pictures were modified. Changes include different colour schemes, text and imagery depending on the player's performance and if the player is logged in. This is done to provide users with a move engaging experience.

### Form Control Properties

| **Key** | **Req #** | **Form Control** | **Properties**       | **Control Purpose**                                                                 |
| ------- | --------- | ---------------- | -------------------- | ----------------------------------------------------------------------------------- |
| *6a*    | \-----    | lbl_Heading      | default              | Heading Text                                                                        |
| *6b*    | \-----    | pic_Title        | default              | Title Image                                                                         |
| *6c*    | \-----    | lbl_GameStatus   | 25.5pt               | Positive or Negative Message Relating to Game Performance                           |
| *6d*    | 6.1       | lbl_ScoreText    | 16pt                 | Displays Text "You Scored…"                                                         |
| *6e*    | 6.1       | lbl_Score        | 19pt, Bold           | Displays Player's Score                                                             |
| *6f*    | 6.2       | lbl_HighScore    | 11.25pt, Bold        | Display's Player's High Score                                                       |
| *6g*    | \-----    | lbl_Remaining    | 9pt, Bold            | Displays remaining seconds until automatic return to main menu                      |
| *6h*    | \-----    | btn_Skip         | ForeColor: IndianRed | Allows users to skip countdown and return immediately.                              |
| *6i*    | \-----    | pic_sidebar      | default              | Changes based on game performance, can be •ᴗ• or •∧• with a green or red background |
| *6j*    | \-----    | btn_exit         | default              | Navigates user to game menu                                                         |
| *-----* | 6.3       | ReturnTimer      | Interval: 1000       | Counts down for fifteen seconds before calling Close()                              |

### Function Summary

| **Function**  | **Req #** | **Description**                                                                                                                                                                                                                 |
| ------------- | --------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| *constructor* | *-----*   | Changes the label text depending on how the player performed during the GameSession. If they beat their high score, the game congratulates them, otherwise, it displays a message of encouragement and motivation to try again. |

### Events

| **Method Name**    | **Req #** | **Description**                                                                                                                  |
| ------------------ | --------- | -------------------------------------------------------------------------------------------------------------------------------- |
| ReturnTimer_Tick   | \-----    | Counts down from fifteen seconds, and when the timer reaches zero, the screen automatically closes and returns to the main menu. |
| *Form_OnClosing*   | *-----*   | Plays a sound effect and reopens the Main Menu Form stored in the MainMenuForm static property found within SessionManager.      |
| SkipButton_OnClick | *-----*   | Closes the form.                                                                                                                 |

### Pseudocode

#### constructor

```vbnet
When the GameEnd Form is created:
    Initialize the form's components
    Set the score label text to the score from the session
    Determine if the score is a new high score
    If the current player is not a guest:
      If it is a new high score:
        Set the game status label text to "That's too bad..."
        Set the colour variable to green
        Set the header label text to "NEW HIGH SCORE"
        Set the high score label text to "Your new high score is - {score}!"
        Set the side bar image to a green block and a smiley face
        Play a "win" sound effect
      Otherwise:
        Set the game status label text to "Well Done!"
        Set the colour variable to crimson
        Set the high score label text to "Your current high score is - {hs}!"
        Set the side bar image to a red block and a frowning face
        Play a "game_over" sound effect
    Else:
      Set the game status label text to "━━━━━"
      Hide the high score label
      Set the colour variable to grey
      Play a "game_over" sound effect

  Set the colour of certain elements to the determined colour
  Start a timer to close the form in 15 seconds
```

#### ReturnTimer_Tick

```vbnet
When the Return Timer Ticks:
  Increment the exit timer
    If the exit timer is greater than or equal to 15:
      Close the form
    Otherwise: 
      Update the seconds remaining label with the remaining time.
```

#### SkipButton_OnClick

```vbnet
When the Skip button is clicked:
    Close the GameEnd form
```

#### Form_OnClosing

```vbnet
When the form is closing:
    Show the Main Menu form
    Play the "cancel" sound effect
```

### Validation

- No validation is needed as the GameSession object has no user input data and should not contain any erroneous data that will cause the program to throw an exception.

#### GameWindow Form

The Game Window Form is the main form of the application. It serves as the game's main interface, allowing users to interact with the game elements and providing visual feedback on the Game Session. The GameWindow form also handles user input from the keyboard, allowing the user to control the movement and rotation of the falling Blocks.

### Starting Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/dcb649f2-072b-4169-8a53-bfceaad9eb52)

### Final Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/2e40a5a3-d4da-4151-b5ed-76efe1ee4d67)

### Changes Due To User Feedback

I used user feedback to improve the design of the form by adding more information to the side of the game board, informing users of the current block speed and how many lines they have cleared. On top of that, several graphical elements were introduced or enhanced, such as an artificial countdown at the beginning of the game, borders around board components to enhance visual quality and high-quality backgrounds to give the form a much more professional and high-quality feel. These changes help create a more engaging and enjoyable gameplay experience.

### Form Control Properties

| **Key** | **Req #** | **Form Control**   | **Properties**                             | **Control Purpose**                                                              |
| ------- | --------- | ------------------ | ------------------------------------------ | -------------------------------------------------------------------------------- |
| *5a*    | 4.5       | pic_HoldBorder     | SizeMode: Stretch                          | Aesthetic                                                                        |
| *5b*    | 4.5       | lbl_HoldText       | BackColor: White<br>Bold                   | Block Hold Text                                                                  |
| *5c*    | 4.5       | pic_HeldBlock      | default                                    | Shows block in hold.                                                             |
| *5d*    | 5.1       | tlp_GameBoard      | Columns: 10<br>Rows: 20<br>BackColor: Form | Structures cells to allow for a coordinate-based working 2D game board.          |
| *5d*    | 4.15      | tlp_GameIndicator  | Columns: 10<br>Rows: 20<br>BackColor: Form | Allows for indication of pause hold progress when user is holding ESC            |
| *5d*    | 4         | pic_Cell[1-200]    | DockStyle: Fill<br>SizeMode: Stretch       | Allows for rendering of blocks onto table                                        |
| *5e*    | 4.6       | pic_QueueBorder    | SizeMode: Stretch                          | Aesthetic                                                                        |
| *5f*    | 4.6       | pic_QueueText      | BackColor: White<br>Bold                   | Block Queue Text                                                                 |
| *5g*    | 4.6       | pic_NextUp         | default                                    | Shows next block to be spawned onto the board                                    |
| *5h*    | 4.6       | pic_Queue1         | default                                    | Shows the second block in the queue                                              |
| *5i*    | 4.6       | pic_Queue2         | default                                    | Shows the third block in the queue                                               |
| *5j*    | 4.6       | pic_Queue3         | default                                    | Shows the forth block in the queue                                               |
| *5k*    | \-----    | lbl_GameSpeed      | 15.75pt, Bold                              | Shows current speed multiplier of the game                                       |
| *5l*    | \-----    | lbl_LinesCleared   | 15.75pt, Bold                              | Shows the amount of lines cleared by the user                                    |
| *5m*    | \-----    | lbl_GameCountdown  | 48pt, Bold                                 | A label that counts down before the game starts.                                 |
| *5n*    | 5.4       | lbl_GameScore      | 20.25pt, Bold                              | Shows the user's current score in the GameSession                                |
| *5o*    | 5.5       | pic_PlayerAvatar   | default                                    | Shows the user's avatar                                                          |
| *5p*    | 5.5       | lbl_PlayingAsText  | default                                    | Playing As Text                                                                  |
| *5q*    | 5.5       | lbl_PlayerUsername | Bold                                       | Shows the username of the current player                                         |
| *-----* | \-----    | lbl_IndicatorText1 | 36pt, Bold                                 | Displays information whilst the game indicator is visible.                       |
| *-----* | \-----    | lbl_IndicatorText2 | 36pt, Bold                                 | Displays information whilst the game indicator is visible.                       |
| *-----* | \-----    | lbl_IndicatorText3 | 36pt, Bold                                 | Displays information whilst the game indicator is visible.                       |
| *-----* | \-----    | lbl_IndicatorText4 | 36pt, Bold                                 | Displays information whilst the game indicator is visible.                       |
| *-----* | 4.9       | GameTimer          | Interval: 1000 / Multiplier                | A timer that executes game logic every interval                                  |
| *-----* | 4.13-15   | ExitTimer          | Interval: 250                              | A timer that counts towards the pausing and saving of the game when ESC is held. |
| *-----* | \-----    | Form               | BackColor: Black                           | \-----                                                                           |

### Function Summary

| **Function**              | **Req #**      | **Description**                                                                                                                                                                                                                                                                                                                                  |
| ------------------------- | -------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| *constructor*             | 5.5            | Initialises the GameBoard and GameIndicator, filling both table layout panels with PictureBoxes, with the default "Empty" image. A new GameSession is created, the player details are displayed in the bottom-left of the window, and a random background is chosen.                                                                             |
| *constructor (gameState)* | 3.2            | Initialises the GameBoard and GameIndicator, filling both table layout panels with PictureBoxes, with the default "Empty" image. A GameSession is instantiated with the previous GameState, and the GameTiles restores all previous tiles; the player details are displayed in the bottom-left of the window, and a random background is chosen. |
| *GetTiles*                | 4.13           | Retrieves a List of Images of all tiles currently on the Game Board, used for the implementation of the save functionality.                                                                                                                                                                                                                      |
| *GetTags*                 | 4.13           | Retrieves a List of Tags of all tiles currently on the Game Board for implementing the save functionality.                                                                                                                                                                                                                                       |
| *HidePauseIndicator*      | 4.13           | Hides the GameIndicator Table Layout Panel.                                                                                                                                                                                                                                                                                                      |
| *ClearPauseIndicator*     | 4.13           | Resets all Cells to have the "Empty" image.                                                                                                                                                                                                                                                                                                      |
| *CheckLines*              | 4.7            | Checks for any full lines on the GameBoard.                                                                                                                                                                                                                                                                                                      |
| *RemoveRow*               | 4.7            | Removes the row specified in the method parameters.                                                                                                                                                                                                                                                                                              |
| *GameOver*                | \-----         | Stops the game and saves player statistics.                                                                                                                                                                                                                                                                                                      |
| *GameOverCutscene*        | \-----         | Forces all tiles on the board to be red.                                                                                                                                                                                                                                                                                                         |
| *PlayStartCutscene*       | \-----         | Plays a countdown before the start of the game with a randomly generated, colourful background.                                                                                                                                                                                                                                                  |
| *ForceRender*             | 4.7,<br>4.13   | Forcefully renders tiles onto the board using provided lists of Images and Tags for clearing lines and saving the game.                                                                                                                                                                                                                          |
| *ForceRenderIndicator*    | 4.13           | Forcefully renders tiles onto the GameIndicator table layout panel with a specified tile, used to Pause/Exit Confirmations.                                                                                                                                                                                                                      |
| *UpdateHud*               | 4.5-6<br>5.2-4 | *Updates the information in the player HUD.*                                                                                                                                                                                                                                                                                                     |
| *ChangeWallpaper*         | \-----         | Changes the background of the Form.                                                                                                                                                                                                                                                                                                              |

### Events

| **Method Name**                | **Req #**   | **Description**                                                                                            |
| ------------------------------ | ----------- | ---------------------------------------------------------------------------------------------------------- |
| *GameWindow_VisibilityChanged* | \-----      | Plays the Starting Cutscene, Starts the GameTimer and starts the Soundtrack AudioPlayer.                   |
| *GameTimer_Tick*               | 4.9         | Calls session.Tick() and updates the HUD.                                                                  |
| *GameWindow_KeyDown*           | 4.1-5       | Allows the player to manipulate the block with the keys on their keyboard and access other game functions. |
| *GameWindow_KeyUp*             | 4.1-5, 4.13 | Allows the player to manipulate the block with the keys on their keyboard and access other game functions. |
| *ExitTimer_Tick*               | 4.13-15     | Counts towards the end of the time period required for holding the ESC key to pause and save the game.     |
| *Form_OnClosing*               | \-----      | Calls GameOver if the player closes form prematurely.                                                      |

### Pseudocode

#### constructor

```vbnet
When the GameWindow Form is created without parameters:
    Initialize the form's components
    For each tile in the game board:
        Create a new picture box
        Set the image of the picture box to an empty image
        Set the size mode of the picture box to stretch image
        Set the dock style of the picture box to fill
        Set the margin of the picture box to 0
        Set the tag of the picture box to "Empty"
        Add the picture box to the game board
    For each tile in the game indicator:
        Create a new picture box
        Set the image of the picture box to an empty image
        Set the size mode of the picture box to stretch image
        Set the dock style of the picture box to fill
        Set the margin of the picture box to 0
        Add the picture box to the game indicator
    Set the variable musicMuted to false
    Create a new game session
    Set the label of the current player to the username of the current player
    Set the image of the player's avatar to the image of the current player's avatar
    Set the game interval to the interval of the game timer
    Set the background image of the game window to a random background from the game IO manager
```

#### constructor (parameterised)

```vbnet
When the GameWindow Form is created with the GameState parameter:
    Initialise the form's components
    For each cell in the game board:
        Create a new picture box
        Set the image of the picture box to an empty image
        Set the size mode of the picture box to stretch image
        Set the dock style of the picture box to fill
        Set the margin of the picture box to 0
        Set the tag of the picture box to "Empty"
        Add the picture box to the game board
    For each cell in the game indicator:
        Create a new picture box
        Set the image of the picture box to an empty image
        Set the size mode of the picture box to stretch image
        Set the dock style of the picture box to fill
        Set the margin of the picture box to 0
        Add the picture box to the game indicator
    Create a new game session with the given game state
    Set the label of the current player to the username of the current player
    Set the image of the player's avatar to the image of the current player's avatar
    Set the game interval to the interval of the game timer
    Render the board using tiles and tags from the given game state
```

#### GetTiles

```vbnet
When a method gets from the Tiles Parameter:
  Create a new list of images called tiles
  For each cell in the game board:
    Get the tile from the cell
    If the cell's tag is empty:
      Add the "Empty" tag to the tile
    Add the tile to the list of tiles
  Return tiles
```

#### GetTags

```vbnet
When a method gets from the Tags Parameter:
  Create a new list of strings called tags
  For each cell in the game board:
    Get the tag from the cell
    Add the tag to the list of tags
  Return tags
```

#### HidePauseIndicator

```vbnet
When HidePauseIndicator is called:
  Hide the Game Indicator Table
  Hide the text informing the user to keep holding ESC
```

#### ClearPauseIndicator

```vbnet
When ClearPauseIndicator is called:
  For each cell in indicator board:
    Set cell's image to "Empty"
```

#### CheckLines

```vbnet
When CheckLines is called:
  Set lines to 0
  For i = 0 to the height of the board:
    Set full to true
    For each cell in the current row:
      If the cell's tag equals "Empty" or "Ghost":
        Set full to false
    If full is true
      Call RemoveRow with the current row as the parameter
      Add 1 to lines
  Call session.AddScore with the amount of cleared lines as the parameter
  Update the player hud
```

#### RemoveRow

```vbnet
When RemoveRow is called:
  Create a new list of images called tiles from the tiles returned from GetTiles
  Create a new list of strings called tags from the tags returned from GetTags
  Remove the tiles and tags in the row to be removed from both lists
  Add an empty row and the beginning of both lists
  Rerender the board by passing these lists to ForceRender

  Increment the lines cleared in the session
  If the amount of lines cleared is more than five
    and the amount modulus 10 equals zero
    and the multiplier is less than 9.90:
    Add 0.2 to the session speed multiplier
    Play a "LevelUp" sound effect
```

#### GameOver

```vbnet
When GameOver is called:
  Stop the GameTimer from ticking
  Set Halt to true
  Play the Game Over Cutscene
  Show the GameEnd Form
  Call session.GameOver
  Hide this form
  Safely dispose of this form to free up resources
```

#### GameOverCutscene

```vbnet
When GameOverCutscene is called:
  Hide the current block
  Stop the background music
  Wait 0.25s
  For each cell in the game board:
    If the cell tag indicates it is not empty:
      Set that cell to the colour red
  Wait 2.25s
```

#### PlayStartCutscene

```vbnet
When PlayStartCutscene is called:
  Make the game indicator board visible
  For i = 3 to 1:
    Randomise the colours of every cell and the countdown label
    Set the countdown label text to i
    Play the "count" sound effect
    Wait 1s
  Clear the game indicator board
  Make the game indicator board invisible
  Play the "start" sound effect
  Set the countdown label text to "GO!"
  Randomise the colours of the countdown label
  Wait 1s
  Make the countdown label invisible
```

#### ForceRender

```vbnet
When ForceRender is called:
  For each cell in Game Board:
    Replace tile with tile in provided list
    Replace tag with tag in provided list
```

#### ForceRenderIndicator

```vbnet
When ForceRenderIndicator:
  For each cell in Game Indicator Board:
    Replace tile with tile provided
```

#### UpdateHud

```vbnet
When UpdateHud is called:
  If there is a block in hold:
    Set Hold image to the preview of the block

  Update queue images to preview the following four upcoming blocks
  Set the score label to the current score in this session
  Set the lines cleared label to the current lines cleared in this session
  Set the speed multiplier label to the current speed multiplier in this session
```

#### ChangeWallpaper

```vbnet
When ChangeWallpaper is called:
  Set the Form background to a random background in GameIOManager.Backgrounds
```

#### GameWindow_VisibilityChanged

```vbnet
When the GameWindow's visibility changes:
    If the GameWindow is not visible:
        Stop the background music
    Otherwise:
        Update the HUD by calling UpdateHud
        Call PlayStartCutscene and wait for it to finish
        Start the GameTimer
        Start playing the background music
```

#### GameTimer_Tick

```vbnet
When the visibility of the Game Window Changes:
  if Halt is true:
    Return
  Perform game loop tasks by calling session.Tick
  Update the HUD by calling UpdateHud
```

#### GameWindow_KeyDown

```vbnet
When a key is pressed down on the GameWindow:
    If there is no current block in the session, return
    If the GameTimer is not enabled, return
    Switch on the KeyCode of the pressed key:
        If the key is Left arrow or A:
            Move the current block horizontally to the left
        If the key is Right arrow or D:
            Move the current block horizontally to the right
        If the key is Down arrow or S:
            Set the GameTimer interval to 35
        If the key is M:
            If the music is muted:
              Play the background music
              Set musicMuted to false, 
            Otherwise:
              Stop the background music
              Set musicMuted to true
        If the key is Tab:
            If debug mode is not enabled, return
            Stop the GameTimer
        If the key is Space:
            Set the GameTimer interval to 1
        If the key is C:
            Hold the current block and update the HUD
        If the key is Escape:
            If the ExitTimer is not enabled, start it
```

#### GameWindow_KeyUp

```vbnet
When a key is released on the GameWindow:
  If there is no current block in the session, return
  Switch on the KeyCode of the released key:
    If the key is Up arrow or W:
      If the GameTimer is not enabled, return
      Rotate the current block clockwise
    If the key is Down arrow or S:
      If the GameTimer is not enabled, return
      Set the GameTimer interval to gameInterval / session.Multiplier
    If the key is Tab:
      Start the GameTimer
    If the key is F10:
      If debug mode is not enabled:
      Enable debug mode
      Show the debug mode enabled label
    Else:
      Disable debug mode
      Hide the debug mode enabled label
    If the key is Enter:
      Change the wallpaper
    If the key is Q:
      If debug mode is not enabled or GameTimer is enabled, return
      Hide the current block
      Remove the bottom row of the board
      Make the current block visible again
    If the key is Escape:
      If the ExitTimer is not enabled, return
      Stop the ExitTimer
      Start the GameTimer
      Hide the pause indicator
      Clear the pause indicator
      Reset the exitTicks counter
```

#### ExitTimer_Tick

```vbnet
When the ExitTimer ticks:
    If exitTicks is less than boardHeight:
        If ExitTimer is enabled:
            Stop GameTimer
            Increment exitTicks by 1
            Set hold to pause labels and the Game Indicator Board to visible
            Set totalTiles to the product of boardWidth and boardHeight
            Set startIndex to totalTiles minus boardWidth multiplied by exitTicks
            For i = startIndex to totalTiles:
                Set the image of Cell i in the Game Indicator Board to a random tile from GameIOManager.Tiles
            Play the "rotate" sound effect
    Otherwise:
        Stop ExitTimer
        Hide hold to pause labels and the Game Indicator Board
        Stop the background music
        If the current player is a guest:
            Call ForceRenderIndicator with the grey tiles
            Force a game over event by calling GameOver
        Otherwise:
            Call ForceRenderIndicator with the green tile
            Wait for 2.5 seconds
            Save the game using the session.Save function
```

#### Form_OnClosing

```vbnet
When the form is closing:
  Stop the background music
  Cause a GameOver Event by calling GameOver
```

### Validation

- This form has a part in validating where tiles can be placed, as it has the "GetCellFromCoordinate" function, allowing the block object to see if the cell is occupied or invalid.

#### ProfilePane Form

The purpose of the ProfilePane form is to provide users with various statistics about their Gameplay within the Application. It informs them of their high score, the total score they've ever gained, the total number of times they've beaten their high score, the total blocks they've placed, the total games they've played and the total number of lines they've cleared.

### Starting Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/0d64c868-5db4-49f9-8950-7191f381b955)

### Final Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/4920f36a-a17b-4db9-8ff3-999400537208)

### Changes Due To User Feedback

User feedback played an essential role in the design of the ProfilePane Form. I added the statistics "Personal Records" and "All Score" stats based on requests for more comprehensive performance data. I also added the user's actual name and avatar adjacent to their username to create a more personalised exerpierence within the app.

### Form Control Properties

| **Key** | **Req #** | **Form Control** | **Properties** | **Control Purpose**         |
| ------- | --------- | ---------------- | -------------- | --------------------------- |
| *8a*    | \-----    | pic_Avatar       | default        | Shows user's avatar         |
| *8b*    | \-----    | lbl_FullName     | 12pt, Bold     | Shows user's name           |
| *8c*    | \-----    | lbl_Username     | default        | Shows user's username       |
| *8d*    | \-----    | btn_exit         | default        | Navigates user to game menu |
| *8e*    | 2.1       | lbl_Categories   | Bold           | Categories Text             |
| *8f*    | 2.1       | lbl_Statistics   | default        | Show User's Statistics      |

### Function Summary

| **Function**  | **Req #** | **Description**                                                                                                                   |
| ------------- | --------- | --------------------------------------------------------------------------------------------------------------------------------- |
| *constructor* |           | Gets current player from SessionManager and modifies the relevant labels to display the statistics associated with their account. |

### Events

| **Method Name**    | **Req #** | **Description**                                                                                                             |
| ------------------ | --------- | --------------------------------------------------------------------------------------------------------------------------- |
| *Form_OnClosing*   | *-----*   | Plays a sound effect and reopens the Main Menu Form stored in the MainMenuForm static property found within SessionManager. |
| ExitButton_OnClick | *-----*   | Closes the form.                                                                                                            |

### Pseudocode

#### constructor

```vbnet
When the ProfilePane Form is created:
  Initialize the form's components
  Retrieve the current player from the session manager
  Set the profile picture to the current player's avatar image
  Set the name label to the current player's forename and surname
  Set the username label to the current player's username
  Set new variable "statistics" to ""
  Append the current player's high score to statistics
  Append the current player's all score to statistics on a new line
  Append the current player's personal records to statistics on a new line
  Append the current player's blocks placed to statistics on a new line
  Append the current player's games played to statistics on a new line
  Append the current player's cleared lines plus the string " Lines" to statistics on a new line
  Set the lbl_Statistics label text to the string stored in statistics.
```

#### ExitButton_OnClick

```vbnet
When the Exit button is clicked:
    Close the profile pane form
    Play the "cancel" sound effect
```

#### Form_OnClosing

```vbnet
When the form is closing:
    Show the Main Menu form
```

### Validation

- No validation is needed as the Player object already goes through validation when registered.

#### HelpPane Form

The purpose of the HelpPane form is to provide users with information on the game's rules and how the user can control what is happening within the game. The HelpPane Form is there to quickly familiarise players with how to play to help them get started as soon as possible.

### Starting Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/95032368-3f5a-4954-ab9a-a2255fac8a6c)

### Final Design

![image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/8666e41d-48f3-48f0-a173-9a3377ab0cec)

### Changes Due To User Feedback

User feedback led to changes in the HelpPane Form. A graphical title card was added to make the form more engaging, and the header was changed from "HELP" to "HOW TO PLAY" to reflect the form's content better and improve user understanding.

### Form Control Properties

| **Key** | **Req #** | **Form Control**   | **Properties** | **Control Purpose**  |
| ------- | --------- | ------------------ | -------------- | -------------------- |
| *7a*    | \-----    | lbl_Heading        | default        | Heading Text         |
| *7b*    | \-----    | btn_Exit           | default        | Return to Main Menu  |
| *7c*    | \-----    | pic_Title          | default        | Title Image          |
| *7d*    | \-----    | lbl_RulesHeader    | 15.75pt, Bold  | Rules Header Text    |
| *7e*    | \-----    | lbl_Rules          | default        | Rules Text           |
| *7f*    | \-----    | lbl_ControlsHeader | 15.75pt, Bold  | Controls Header Text |
| *7g*    | \-----    | lbl_Controls       | default        | Controls Text        |

### Function Summary

| **Function**  | **Req #** | **Description** |
| ------------- | --------- | --------------- |
| *constructor* | \-----    | \-----          |

### Events

| **Method Name**    | **Req #** | **Description**                                                                                                             |
| ------------------ | --------- | --------------------------------------------------------------------------------------------------------------------------- |
| *Form_OnClosing*   | *-----*   | Plays a sound effect and reopens the Main Menu Form stored in the MainMenuForm static property found within SessionManager. |
| ExitButton_OnClick | *-----*   | Closes the form.                                                                                                            |

### Pseudocode

#### constructor

```vbnet
When the HelpPane Form is created:
  Initialize the form's components
```

#### ExitButton_OnClick

```vbnet
When the Exit button is clicked:
    Close the help pane form
    Play the "cancel" sound effect
```

#### Form_OnClosing

```vbnet
When the form is closing:
    Show the Main Menu form
```

### Validation

- No validation is needed as this form is static and has no dynamic content.

#### Chapter Three · Testing The Application

#### Login Form

![Image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/35B51986-AB8B-4396-98D6-158F10459AAF_2/mZxpA4BAwsevGcrJM44SozZKMVDJD67lLOrvtytj8wAz/Image.png)

| **Test #** | **Description**                                                                    | **Req #** | **Test Data**                              | **Expected Outcome**                                                                                |
| ---------- | ---------------------------------------------------------------------------------- | --------- | ------------------------------------------ | --------------------------------------------------------------------------------------------------- |
| *LOG1*     | Using correct credentials to log into the applicaiton.                             | 1.1       | Username:<br>user<br>Password:<br>password | Displays "Welcome Back, user! You are now logged in.", and shows the main menu.                     |
| *LOG2*     | Using the incorrect password for an account to attemp to log into the application. | 1.1       | Username:<br>user<br>Password:<br>passw0rd | "You have entered an invalid username/password combination."                                        |
| *LOG3*     | Using non existant credentials to attempt to log into the application.             | 1.1       | Username:<br>usr<br>Password:<br>password  | "You have entered an invalid username/password combination."                                        |
| *LOG4*     | Leaving fields blank                                                               | 1.1       | \-----                                     | "You have entered an invalid username/password combination."                                        |
| *LOG5*     | Clicking "Play as Guest"                                                           | 1.4       | \-----                                     | Shows the main menu, the user has been logged in with a temporary player with the username "Guest". |
| *LOG6*     | Clicking "Register"                                                                | 1.2-3     | \-----                                     | Shows the registration form.                                                                        |

#### Register Form

![Image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/90A3C61F-7317-4793-9554-FD0CACF593F4_2/6dj81WRKE9XRBZ6qwUB0dSiU1qiX7hwYBCpgeEzMKWEz/Image.png)

| **Test #** | **Description**                                                  | **Req #** | **Test Data**                                                   | **Expected Outcome**                                                                                                            |
| ---------- | ---------------------------------------------------------------- | --------- | --------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- |
| *REG1*     | Clicking register button with full data entry.                   | 1.3       | Fill in fields as normal.                                       | Registration Success, and player object added to database cache. SavePlayers() will then be invoked to save players to storage. |
| *REG2*     | Clicking register button with no data entry.                     | 1.3.1-7   | No data entered.                                                | "Please review the errors on-screen."                                                                                           |
| *REG3*     | Clicking register button with partial data entry.                | 1.3.1-7   | Forename: John<br>Username:<br>JohnDoe17<br>Password: Pa55w0rd! | "Please review the errors on-screen."                                                                                           |
| *REG4*     | Clicking register button with a username that is already in use. | 1.3.4     | Username: james                                                 | "An account with this username already exists."                                                                                 |
| *REG5*     | Clicking register button with a reserved username.               | 1.3.5     | Username: Guest                                                 | "You cannot register with this username."                                                                                       |
| *REG6*     | Clicking the left and right arrow buttons to select an avatar.   | 1.2       | \-----                                                          | Avatar preview cycles back and forward as expected.                                                                             |

#### GameMenu Form

![Image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/1F69A80F-B32D-4C5F-A117-C05A3AA94AC2_2/dGMxOBbOnfzb2xkhRrMqqitkyHIhSmA4zovyQxe3Nd0z/Image.png)

| **Test #** | **Description**                                                                                        | **Req #** | **Test Data**                     | **Expected Outcome**                                                                                      |
| ---------- | ------------------------------------------------------------------------------------------------------ | --------- | --------------------------------- | --------------------------------------------------------------------------------------------------------- |
| *MNU1*     | Clicking the Start Button to start a new game.                                                         | 3.1       | \-----                            | A game window should be shown with a newly created GameSession.                                           |
| *MNU2*     | Clicking the Continue Button to resume a previous game when a saved GameState is tied to the account.  | 3.2       | \-----                            | A game window should be shown with the saved GameSession loaded.                                          |
| *MNU3*     | Clicking the Continue Button to resume a previous game when no saved GameState is tied to the account. | 3.3       | SavedGameState: [GameState]       | The Continue button should be faded and present an alert to the user "There is no saved game to continue" |
| *MNU4*     | Clicking the Leaderboard Button.                                                                       | 2.3       | SavedGameState: null              | Application should show the Leaderboard Form.                                                             |
| *MNU5*     | Clicking the Exit Button.                                                                              | \-----    | \-----                            | Should prompt the user if they want to exit the program, if yes, the program exits safely.                |
| *MNU6*     | Clicking the statistics button when not logged in as a guest.                                          | 2.1       | Player {<br>IsGuest: False<br>}   | The application should show the ProfilePane Form.                                                         |
| *MNU7*     | Clicking the statistics button when logged in as a guest.                                              | 2.2.1     | Player {<br>IsGuest:<br>True<br>} | The statistics icon should be replaced with a no entry icon, and do nothing when clicked.                 |
| *MNU8*     | Clicking the Help Button.                                                                              | \-----    | \-----                            | Application should show the HelpPane Form.                                                                |
| *MNU9*     | Clicking the Change User Button.                                                                       | \-----    | \-----                            | Application should close the Menu Form and reopen the previous Login Form.                                |

#### Leaderboard Form

![Image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/68A1650C-CC86-4C56-9C47-ED2F809337AC_2/Fc1b7x0STMivxuug3LiZissLd7yPvtHeI0Seq4xe4f8z/Image.png)

| **Test #** | **Description**                                                        | **Req #** | **Test Data** | **Expected Outcome**                                             |
| ---------- | ---------------------------------------------------------------------- | --------- | ------------- | ---------------------------------------------------------------- |
| *SCO1*     | Does the Leaderboard correctly sort players by the top ten high scores | 2.3       | \-----        | A correctly structured list of the top ten best scoring players. |

#### GameEnd Form

![Image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/F609CF00-F9A3-44CD-B249-105BBE8EF29E_2/TGb8tZ4Ir0XAc9XU6kkGIYymeiiiJy5Rv9ZX81EMWQwz/Image.png)

| **Test #** | **Description**                                            | **Req #** | **Test Data**                      | **Expected Outcome**                                                                 |
| ---------- | ---------------------------------------------------------- | --------- | ---------------------------------- | ------------------------------------------------------------------------------------ |
| *END1*     | Player beats their high score in the last session.         | \-----    | Score: 1000<br>High Score:<br>500  | **NEW HIGH SCORE** Well Done!                                                        |
| *END2*     | Player does not beat their high score in the last session. | \-----    | Score: 1000<br>High Score:<br>2000 | **GAME OVER** That's too bad...                                                      |
| *END3*     | Player is logged in as a guest.                            | \-----    | Score: 1000                        | **GAME OVER** (No further comment)                                                   |
| *END4*     | Player finishes a game.                                    | 6.1-2     | \-----                             | The form should display their game score and their high score if they are logged in. |
| *END5*     | Wait 15 seconds once the form opens.                       | 6.3       | \-----                             | Form should automatically dismiss and bring user back to Main Menu.                  |

#### GameWindow Form

![Image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/931B239B-F788-4561-9C58-35D52CF0895D_2/lfhdkBrrSofs9b9225Qi9OEDI3ylXWlRA4QiTcBMnGIz/Image.png)

| **Test #** | **Description**                                                              | **Req #** | **Test Data**                                                             | **Expected Outcome**                                                                                                                                                                                                                                        |
| ---------- | ---------------------------------------------------------------------------- | --------- | ------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| *GME1*     | Attempt to manipluate the block before the countdown finishes.               | \-----    | Any key relating to movement.                                             | The block should remain idle.                                                                                                                                                                                                                               |
| *GME2*     | Check if blocks correctly stack upon one another and do not collide.         | \-----    | \-----                                                                    | Blocks should respect other occupied cells and shouldn't infringe upon other placed blocks and should instead place above it.                                                                                                                               |
| *GME3*     | Move block horizontally.                                                     | 4.1       | Key_Down:<br>- R Arrow<br>- L Arrow                                       | The block should move left or right dependent on the arrow key pressed.                                                                                                                                                                                     |
| *GME4*     | Move block out of bounds or into another block.                              | \-----    | Key_Down:<br>- R Arrow<br>- L Arrow                                       | The block should not move beyond the borders of the board or into occupied cells.                                                                                                                                                                           |
| *GME5*     | Place block in hold when no other block is in the hold.                      | 4.5       | Key_Up:<br>- C                                                            | The current block should be hidden and placed in the hold, the next block in queue should be spawned immediately afterward.                                                                                                                                 |
| *GME6*     | Place block in hold when another block is in the hold.                       | 4.5       | Key_Up:<br>- C                                                            | The current block should swapped with the block already in the hold.                                                                                                                                                                                        |
| *GME7*     | Rotate block.                                                                | 4.2       | Key_Up:<br>- Up Arrow                                                     | The block should rotate clockwise on screen.                                                                                                                                                                                                                |
| *GME8*     | Make block fall quicker.                                                     | 4.3       | Key_Down:<br>- Down Arrow                                                 | The block's rate of descent should increase.                                                                                                                                                                                                                |
| *GME9*     | Make block fall faster/instantly.                                            | 4.4       | Key_Up:<br>- Space                                                        | The block's rate of descent should increase rapidly.                                                                                                                                                                                                        |
| *GME10*    | Mute the background music.                                                   | 7.1.1     | Key_Up:<br>- M                                                            | The music should stop playing, sound effects remain unaffected.                                                                                                                                                                                             |
| *GME11*    | Fill up line(s) using the falling blocks on screen.                          | 4.7-8     | Between one to four filled rows of tiles on the Game Board.               | The line(s) should disappear and the player should be granted more score dependant on the amount of lines cleared at one time.                                                                                                                              |
| *GME12*    | Fill up the board with blocks until there is no more room for any more.      | 4.12      | Let blocks fall until there is not enough space for another one to spawn. | All tiles on the board that are not empty should turn red to indicate that the player lost, the game then should end and the GameEnd form displayed to the user, the new player statistics will be saved to the player list.                                |
| *GME13*    | Exit the game by holding ESC for a period of time whilst logged in.          | 4.13      | Key_Down:<br>- ESC                                                        | The board should turn green before notifying the user the game has been saved, and then return the user to the Main Menu.                                                                                                                                   |
| *GME14*    | Exit the game by holding ESC for a period of time whilst playing as a guest. | \-----    | Key_Down:<br>- ESC                                                        | The board should turn grey and show the Game Over screen as it impossible to save the game to a non-existant account.                                                                                                                                       |
| *GME15*    | Continuing a saved game with no blocks present on the board.                 | 3.2       | GameState with no blocks present on the board.                            | The game should restore the current block, the held block, the block queue and session statistics.                                                                                                                                                          |
| *GME16*    | Continuing a saved game with some blocks present on the board.               | 3.2       | GameState with some blocks present on the board.                          | The game should restore the current block, the held block, the block queue, session statistics and all blocks that were present on the board at the time of saving.                                                                                         |
| *GME17*    | Continuing a saved game where the board is full.                             | 3.2       | GameState where the board is full.                                        | The game should restore the current block, the held block, the block queue, session statistics and all blocks that were present on the board at the time of saving. The game may instantly end if there is not enough room for the next block to be placed. |
| *GME18*    | The game ticks at the correct interval.                                      | 4.8       | \-----                                                                    | The game should tick every (1000 / multiplier)ms and execute recurring tasks, such as the block falling by one cell every tick.                                                                                                                             |

#### ProfilePane Form

![Image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/19CE435C-7F2E-4F8B-82D4-ED12F977C5E9_2/kybugkxzeBSEGD7xhQyC4lxeRWGwXyc6COSX98tbyloz/Image.png)

| **Test #** | **Description**                                                 | **Req #** | **Test Data**                                                                                                                                                                                   | **Expected Outcome**                                                                                                                |
| ---------- | --------------------------------------------------------------- | --------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| *PRO1*     | Does the form correct load and display the player's statistics? | 2.2       | Player:<br>- Username: user<br>- Forename: John<br>- Surname: Doe<br>- High Score: 5000<br>- All Score: 10000<br>- PRs: 10<br>- Blocks Placed: 200<br>- Games Played: 5<br>- Lines Cleared: 100 | John Doe (user)<br>High Score: 5000<br>Total Score: 10000<br>PRs: 10<br>Blocks Placed: 200<br>Games Played: 5<br>Lines Cleared: 100 |

#### HelpPane Form

![Image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/7D4B591B-87BF-4F11-90CA-CE34766D420F_2/jgXsgoooTKBwcB8OUS6OiQRtrXsnpzkE35aQ47vd1vwz/Image.png)

No specific testing necessary, this is a static form with no dynamic content.

----

### Test Results

----

| **Tests Passed** | 41 |
| ---------------- | -- |
| **Tests Failed** | 5  |

#### Failed Tests

| **Test #** | **Error**             | **Issue**                                                                                                                                  |
| ---------- | --------------------- | ------------------------------------------------------------------------------------------------------------------------------------------ |
| *LOG5*     | Username is reserved. | Clicking "Play as Guest" attempts to create a temporary player object named Guest, but is stopped by the standard registration validation. |
| *GME4*     | \-----                | Blocks ignore board boundaries, also caused gand hosting when moving to the left side, no error is produced.                               |
| *GME8*     | \-----                | Music continues playing despite the function to stop it being called, no error is produced.                                                |
| *GME12*    | \-----                | Game does not show Game End Form, remains on grey screen, no error is produced.                                                            |
| *END5*     | \-----                | Countdown doesn't change and remains at 15 seconds, no error is produced, form is still dismissed.                                         |

### Resolving Failed Tests

#### \#LOG5

![Image.tiff](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/2532C806-9859-46CD-AB0E-BA837F5A20A6_2/KFBtZDV7DWldbDQ2glb1jtOtRy380rMrlX8B0SgTRykz/Image.tiff)

Solving this error was relatively simple; the only real change was adding an extra check to the IF statement, which changed it from this `if (value.ToLower() == "guest")` to `if (value.ToLower() == "guest" && !IsGuest)`.

This allows for the method calling this function to first set the `IsGuest` property to `True` in order enable the ability to set the username property of the Player object to "Guest".

The complete function is now:

```cs
public string Username
{
  get => username;
  set {
    if (string.IsNullOrEmpty(value))
      throw new InvalidPlayerException("Username cannot be empty.");
    if (GameIOManager.DoesPlayerExist(value))
      throw new InvalidPlayerException("Username is already in use.");
    if (value.ToLower() == "guest" && !IsGuest)
      throw new InvalidPlayerException("This username is reserved.");
    username = value;
  }
}
```

With these changes, test #LOG5 now passes.

#### \#GME4

![Image.tiff](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/5CB93FFA-734F-4989-B1F4-AD551D53FDC4_2/jkxHG66XWmqFDjXeHpWa9r1XQtRgwXoRPIt6XOorebUz/Image.tiff)

(The block is off-screen to the left, it now has an x value of -3)

Solving this issue was more on the challenging side; it was a major issue with the validation logic within the code, making it so that the block ignoring horizontal boundaries entirely. In order to fix this, I had to rewrite my validation logic.

The old function is:

```cs
private bool[] ValidatesTiles(GameWindow gameWindow, List<int[]> coordinates)
        {
            bool validX = true;
            bool validY = true;
            foreach (int[] pos in coordinates)
            {
                int x = pos[0];
                int y = pos[1];
                try
                {
                    PictureBox tile = gameWindow.GetTileFromCoordinates(x, y);
                    if (!tile.Tag.Equals("Empty"))
                    {
                        Console.WriteLine($"Tile @ [{x},{y}] is NOT Valid.");
                        if (x != this.x)
                        {
                            validX = false;
                        } else
                        {
                            validY = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Tile @ [{x},{y}] is Valid.");
                    }
                } catch
                {
                    Console.WriteLine($"Tile @ [{x},{y}] out of bounds!");
                    validX = false;
                }

            }
            return new bool[] { validX, validY };
        }
```

This function had several issues, it didn't check if the tiles were instances of itself, so a block could leave ghost trails when moving side to side. The catch block was also not valid because GetTileFromCoordinates() would return null if the coordinates specified a coordinate out of bounds, so no exception was thrown.

The new function is completely redesigned to eliminate all of these issues, it now checks for:

- If the tile it is encountered is an instance of itself.
- If a tile is out of bounds, using maxY as reference.

Fixes all issues describes above, and ultimately solving collision checking within the game.

This complete function is now:

```cs
private bool[] ValidateTiles(GameWindow gameWindow, List positions) 
{ 
  int baseX = (int)Math.Round(positions[0].x); 
  bool horizontal = true; 
  bool vertical = true;
  
  foreach (Position pos in positions)  
  {  
    bool h = true;  
    bool v = true;  
    int x = (int)Math.Round(pos.x);  
    int y = (int)Math.Round(pos.y);  
    var cell = gameWindow.GetCellFromCoordinates(x, y);

    if (cell == null)  
    {  
      if (y > maxY)  
      {  
        v = false;  
      }  
      else  
      {  
        h = false;  
      }  
    }  
    else if (!cell.Tag.Equals("Empty") && !cell.Tag.Equals(id.ToString()))  
    {  
      if (baseX != position.x)  
      {  
        h = false;  
      }  
      else  
      {  
        v = false;  
      }  
    }

    horizontal &= h;  
    vertical &= v;  
  }

  return new bool[] { true, vertical };  
}
```

With these changes, test #GME4 now passes.

#### \#GME8

Music continues playing despite the function to stop it being called; due to the use of Thread.Abort() was not functioning as expected, causing an exception that disallowed this method of stopping the music thread, meaning a different approach had to be used.

This new approach involves using an async Task method to play the soundtrack on another thread and a global private field to start and stop the background soundtrack.

### Old Approach

Private field → Thread? SoundtrackThread;

```cs
private static Thread? SoundtrackThread;
```

PlayBackgroundMusic();

```cs
public static void PlayBackgroundMusic()  
{  
  using (var soundEffectStream = Resources.soundtrack)  
  using (var soundEffectReader = new WaveFileReader(soundEffectStream))  
  using (var loopStream = new LoopStream(soundEffectReader))  
  {  
    SoundtrackThread = new Thread(() => {
      Waveout SoundtrackWaveOut = new 
      Waveout SoundtrackWaveOut.Init(loopStream);  
      Waveout SoundtrackWaveOut.Play();  
    });
    SoundtrackThread.Start()
  }
}
```

StopBackgroundMusic();

```cs
public static void StopBackgroundMusic()
{
  if (SoundtrackThread != null)
  {
    SoundtrackThread.Abort();
    SoundtrackThread = null;
  }
}
```

### New Approach

Private field → WaveOut? SoundtrackWaveOut;

```cs
private static WaveOut? SoundtrackWaveOut;
```

PlayBackgroundMusic();

```cs
public static async Task PlayBackgroundMusic()  
{  
  using (var soundEffectStream = Resources.soundtrack)  
  using (var soundEffectReader = new WaveFileReader(soundEffectStream))  
  using (var loopStream = new LoopStream(soundEffectReader))  
  {  
    SoundtrackWaveOut = new WaveOut();  
    SoundtrackWaveOut.Init(loopStream);  
    SoundtrackWaveOut.Play();  
    await Task.Delay(-1).ConfigureAwait(false);  
  }
}
```

StopBackgroundMusic();

```cs
public static void StopBackgroundMusic()
{
  if (SoundtrackWaveOut != null)
  {
    SoundtrackWaveOut.Stop();
    SoundtrackWaveOut.Dispose();
    SoundtrackWaveOut = null;
  }
}
```

With all of these new changes, test #GME8 passes.

#### \#GME12

![Image.png](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/C84B1843-D7AF-42DE-9F94-9ECDFAC3CC80_2/1XsTtMDBQ2c2wvYyZSOjGUjsuUifThSg970dbuUyjfUz/Image.png)

This issue was another easy fix, normally, when you save your game, it saves the game state and closes the window, however, as the user is a guest, it should be calling GameOver() and returning, but instead its calling GameSession.Save() instead, which won't work as GameSession.Save() stops executing if the IsGuest flag is set to true on the Player object.

In order to fix this, I've changed this:

```cs
if (SessionManager.CurrentPlayer.IsGuest)  
  {  
    lbl_IndicatorText3.Visible = false;  
    ForceRenderIndicator(Resources.Ghost);  
} else  
{  
  ForceRenderIndicator(Resources.Board_S);  
}

await Task.Delay(2500);  
session.Save(this, TilesToString(Tiles), Tags);
```

Into this:

```cs
if (SessionManager.CurrentPlayer.IsGuest)  
{  
  lbl_IndicatorText3.Visible = false;  
  ForceRenderIndicator(Resources.Ghost);  
  GameOver(); // Starts GameOver sequence.
  return;  // Stops and returns.
}

ForceRenderIndicator(Resources.Board_S);  
await Task.Delay(2500);  // Artificial 2.5s delay, to give user time to stop holding ESC.
session.Save(this, TilesToString(Tiles), Tags);
```

With these changes, test #GME12 now passes.

#### \#END5

![Image.tiff](https://res.craft.do/user/full/980f7942-2870-cf65-9cb1-806c4d74eb08/doc/752B08EA-8C41-4FD7-B5EF-2CBB363C2A4F/C2CDCC11-2C9B-43C1-9592-206F0678A023_2/yh3x0XApntsBOirooiY2bi8xNumaa1hxI5VouJmRuvAz/Image.tiff)

Solving this error was easy; the only change needed was the addition of a statement that changes the value displayed in the countdown timer.

Inserting the line `lbl_CountdownTimer.Text = $"{exitTimer} seconds...";` fixes this issue, making the timer update every tick.

The complete function is now:

```cs
private void ReturnTimer_Tick(object sender, EventArgs e)  
{  
  exitTimer++;  
  if (exitTimer >= 15)  
  {  
    Close();  
  }  
  else  
  {  
    lbl_SecondsRemaining.Text = $"{15 - exitTimer} seconds...";  
  }  
}
```

With these changes, test #END5 now passes.

----

### Beta Testing Feedback

----

#### Chapter Four · Evaluation

### Evaluation of Test Results

----

----

### Evaluation Against User Requirements

----

🟩 Fully Met · 🟧 Partially Met · 🟥 Not Met

| **Req #** | **Description**                                                                                                                 | **Met?** | **Comments/Evidence**                                                                                                                                            |
| --------- | ------------------------------------------------------------------------------------------------------------------------------- | -------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| *1.1*     | User can log on if registered.                                                                                                  | 🟩       | When the application is launched, they are presented with a log in screen, with the options Login, Register, Play As Guest. This is evident in tests #LOG1-4.    |
| *1.2-1.3* | User can register an account.                                                                                                   | 🟩       | The user can fill their details into the form shown when register is clicked, which allows them to register an account. This is evident in tests #LOG6, #REG1-6. |
| *1.4*     | User can play as a guest.                                                                                                       | 🟩       | The user can click play as guest to skip registration if they do not wish to register an account. This is evident in the test #LOG5.                             |
| *2.1-2*   | User can view their stats.                                                                                                      | 🟩       | The user can click the chart icon in the Main Menu to view their statistics in a seperate pane. As evident in tests #MNU6, #PRO1.                                |
| *2.2.1*   | Guests cannot view their stats.                                                                                                 | 🟩       | Users logged in as guest cannot view their statistics as they do not exist. This is evident in the test #MNU7.                                                   |
| *2.3*     | Users can view the top 10 players.                                                                                              | 🟩       | The user can view the top 10 ranked players by clicking the leaderboard button in the Main Menu. Evident in tests #MNU4, #SCO1.                                  |
| *3.1*     | Users can start a new game.                                                                                                     | 🟩       | Users can start a new game by clicking the start button within the main menu. This is evident in the passing test #MNU1.                                         |
| *3.2-3*   | Users can continue a saved game.                                                                                                | 🟩       | Users can continue a saved game by clicking the continute button within the main menu. This is evident in the passing test #MNU2-3.                              |
| *4.1*     | The user can move the block horizontally by using arrow keys.                                                                   | 🟩       | Users can move the blocks left and right using the arrow keys, evident in the test #GME3.                                                                        |
| *4.2*     | The user can rotate the block by using the up arrow key.                                                                        | 🟩       | Users can rotate the current block on screen using the up arrow, evident in the test #GME7.                                                                      |
| *4.3*     | The user can make the block fall faster by holding the down arrow.                                                              | 🟩       | Users can make blocks fall at a faster rate evident in the test #GME8.                                                                                           |
| *4.4*     | The user can use the space key to make the block fall instantly.                                                                | 🟧       | Users can make blocks fall at the fastest rate evident in the test #GME9.                                                                                        |
| *4.5*     | The user can hold a block using the C key and save it for later.                                                                | 🟩       | Users can hold the current block on screen using the C key, evident in the test #GME5-6.                                                                         |
| *4.6-7*   | The user can fill up lines and clear them to gain score.                                                                        | 🟩       | The user can fill up lines using the falling blocks and gain a  score, with bonuses if they clear multiple at one time. Evident in the test #GME11.              |
| *4.8-9*   | The game should "tick" every (1000/multiplier)ms and execute recurring tasks, such as the block falling by one cell every tick. | 🟩       | The game executes tick cycles at expected intervals, as shown in test #GME18.                                                                                    |
| *4.10*    | Blocks are chosen randomly and without any pattern.                                                                             | 🟩       | The game randomly picks blocks to spawn onto the board during the tick cycle, which is tested under test #GME18.                                                 |
| *4.11*    | The user will get a game over form if no more space is available for more blocks to spawn.                                      | 🟩       | The game correctly gives the user a game over screen when the board has no more room for new blocks, as evident in test #GME12.                                  |
| *4.12-14* | The user should be able to pause and exit the game, and continute it later (if logged in).                                      | 🟩       |                                                                                                                                                                  |
| *5.1*     | The user can easily observe the game board in the centre.                                                                       | 🟩       |                                                                                                                                                                  |
| *5.2*     | The user can easily see the held block to the left of the board.                                                                | 🟩       |                                                                                                                                                                  |
| *5.3*     | The user can see the upcoming blocks to the right of the board.                                                                 | 🟩       |                                                                                                                                                                  |
| *5.4*     | The users score is displayed at the bottom of the screen at all times.                                                          | 🟩       |                                                                                                                                                                  |
| *5.5*     | The user can who they are logged in as in the bottom left corner.                                                               | 🟩       |                                                                                                                                                                  |
| *6.1*     | The user can view their final score in the game over screen.                                                                    | 🟩       |                                                                                                                                                                  |
| *6.2*     | The user can see if their score beats their high score, unless they are logged in as a guest user.                              | 🟩       |                                                                                                                                                                  |
| *6.3*     | The user will be returned to the menu after a time period of viewing the game over screen.                                      | 🟩       |                                                                                                                                                                  |
| *6.4*     | The user can see their updated statistics after the game over screen is hidden.                                                 | 🟩       |                                                                                                                                                                  |
| *7.1*     | A soundtrack will play in the background for the user to hear.                                                                  | 🟩       |                                                                                                                                                                  |
| *7.2*     | Sound effects will be played when clearing lines, special sounds are played if a combo is achieved.                             | 🟩       |                                                                                                                                                                  |
| *7.3*     | Sound effects will play when browsing the game's menus.                                                                         | 🟩       |                                                                                                                                                                  |
| *8.1*     | Error handling is in place to prevent the game from crashing.                                                                   | 🟩       |                                                                                                                                                                  |
| *8.2*     | The player can not move a block out of bounds or move it into another block.                                                    | 🟩       |                                                                                                                                                                  |
| *8.3*     | The player cannot enter invalid data in the register form.                                                                      | 🟧       |                                                                                                                                                                  |
| *8.4*     | The login form will show an error if the credentials are not valid.                                                             | 🟩       |                                                                                                                                                                  |

----

### Evaluation of Strengths, Weaknesses & Enhancements

----

----

### Evaluation of Own Performance

----

To evaluate my performance, I would like to first discuss my time management and the development of my skills during the planning and production of this project. Regarding time management, I used a virtual task board to track what I needed to work on in different project areas. However, I noticed some areas for improvement in my time management abilities, especially in the early stages of the project. I often needed help prioritising tasks and spent much more time than necessary on specific project chunks. I also faced some other bottlenecks while working on the project, such as unexpected bugs and broken components that took far longer than expected to fix.

Moving on to personal skills, I have improved my problem-solving, organisational, and research abilities while working on this project. I came across various challenges, such as debugging and documenting my complex code, designing easy-to-navigate, usable user interfaces and finding solutions to the most obscure problems, requiring me to use these skills to discover and conclude on appropriate solutions for the issues I was facing. I also improved my organisational skills by making better use of project management software like Todoist, Trello and GitHub, which allowed me to keep track of tasks that I had to complete and what I had already done, allowing me to tackle chunks of work at a faster rate as it started to take less time to figure out what I had to do next. If I were to do this project again, I would want to work more and focus on further improving my organisational and research skills, so I can spend less time researching and trying to organise my project and more time getting work done.

In conclusion, while I managed my time to the best of my ability, there is room for improvement, as too much time was spent in certain areas fixing a simple bug or obsessing over minor details. I also developed valuable personal practical skills when working on future projects, such as problem-solving, organisation and research skills. If I were to do this project again, I would prioritise my tasks better, allocate more time for testing and debugging my program and focus on developing these essential skills for project development.

Overall, I am proud of my work while working on this project. I've learnt a lot about project management and planning, and I have improved as a software developer by refining and implementing my practical abilities. In the future, I plan to work on more similar projects that will allow me to hone these crucial qualities and further develop my skills. By continuing to push myself to get better, I am confident that I can succeed in any tasks I take on in the future.

