using AS_Coursework.enums;
using AS_Coursework.forms.game;
using AS_Coursework.@internal;
using AS_Coursework.io;
using AS_Coursework.io.audio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AS_Coursework.models
{
    public class GameSession
    {
        // Session Information
        private readonly GameWindow gameWindow;
        private int BlocksSpawned;
        private bool RestrictHold;

        public int LinesCleared { get; set; }
        public int Score { get; private set; }
        public double Multiplier { get; set; }

        // Block Storage
        public Block CurrentBlock { get; private set; }
        public Block HeldBlock { get; private set; }
        public List<Block> BlockQueue { get; }
        public int BlocksPlaced => BlocksSpawned + 1;

        public GameSession(GameWindow gameWindow)
        {
            BlocksSpawned = 0;
            Score = 0;
            LinesCleared = 0;
            Multiplier = 1;
            BlockQueue = new List<Block>();
            for (var i = 0; i < 4; i++)
            {
                var type = (BlockType)new Random().Next(Enum.GetValues(typeof(BlockType)).Length);
                BlockQueue.Add(new Block(BlocksSpawned, type, gameWindow.boardWidth, gameWindow.boardHeight));
                BlocksSpawned += 1;
            }

            RestrictHold = false;
            this.gameWindow = gameWindow;
        }

        public GameSession(GameWindow gameWindow, GameState gameState)
        {
            Score = gameState.Score;
            Multiplier = gameState.Multiplier;
            CurrentBlock = new Block(gameState.CurrentBlock.Id, gameState.CurrentBlock.Type, gameWindow.boardWidth,
                gameWindow.boardHeight)
            {
                Pos = gameState.CurrentBlock.Pos
            };
            HeldBlock = gameState.HeldBlock;
            BlockQueue = new List<Block>();
            foreach (var block in gameState.BlockQueue)
                BlockQueue.Add(new Block(block.Id, block.Type, gameWindow.boardWidth, gameWindow.boardHeight));
            BlocksSpawned = gameState.BlocksPlaced;
            LinesCleared = gameState.ClearedLines;
            this.gameWindow = gameWindow;
        }

        /// <summary>
        ///     This function executes every tick of the game loop. If the current block is null, set the current block to the next block.
        ///     If the current block is not null, move the current block down. If the current block is idle, set the current block to null.
        ///     If the current block is idle, check for lines.
        /// </summary>
        public void Tick()
        {
            if (gameWindow.Halt) return;
            if (!gameWindow.Tick) return;
            if (CurrentBlock == null)
            {
                gameWindow.Interval = (int)(1000 / Multiplier);
                CurrentBlock = BlockQueue[0];
                BlockQueue.RemoveAt(0);
                var type = (BlockType)new Random().Next(Enum.GetValues(typeof(BlockType)).Length);
                BlockQueue.Add(new Block(BlocksSpawned, type, gameWindow.boardWidth, gameWindow.boardHeight));
                BlocksSpawned += 1;
            }

            if (!gameWindow.Tick) return;
            if (gameWindow.Halt) return;
            CurrentBlock.MoveDown(gameWindow);
            if (gameWindow.Interval == 35)
            {
                AddScore(0, 1);
            }
            if (gameWindow.Interval == 1)
            {
                AddScore(0, 2);
            }
            if (CurrentBlock.Idle)
            {
                if (gameWindow.Interval == 1) AudioController.PlaySoundEffect("harddrop");
                else AudioController.PlaySoundEffect("softdrop");
                gameWindow.Interval = 100;
                CurrentBlock = null;
                RestrictHold = false;
                gameWindow.CheckLines();
                return;
            }
        }

        /// <summary>
        ///     If the block hasn't been held yet, hide the current block, set the held block to the current block,
        ///     set the current block to the next block in the queue, remove the next block from the queue, add a
        ///     new block to the queue, and set the usedHold variable to true
        /// </summary>
        public void Hold()
        {
            if (RestrictHold) return;
            if (HeldBlock == null)
            {
                CurrentBlock.Hide(gameWindow);
                HeldBlock = new Block(CurrentBlock.Id, CurrentBlock.Type, gameWindow.boardHeight, gameWindow.boardHeight);
                CurrentBlock = BlockQueue[0];
                CurrentBlock.MoveHorizontally(gameWindow, 0);
                BlockQueue.RemoveAt(0);
                var type = (BlockType)new Random().Next(Enum.GetValues(typeof(BlockType)).Length);
                BlockQueue.Add(new Block(BlocksSpawned, type, gameWindow.boardWidth, gameWindow.boardHeight));
                BlocksSpawned += 1;
            }
            else
            {
                CurrentBlock.Hide(gameWindow);
                var temp = new Block(CurrentBlock.Id, CurrentBlock.Type, gameWindow.boardHeight, gameWindow.boardHeight);
                CurrentBlock = new Block(HeldBlock.Id, HeldBlock.Type, gameWindow.boardHeight, gameWindow.boardHeight);
                CurrentBlock.MoveHorizontally(gameWindow, 0);
                HeldBlock = temp;
            }

            AudioController.PlaySoundEffect("hold");
            RestrictHold = true;
        }

        /// <summary>
        ///     Adjusts the X value of the current block by the supplied value.
        /// </summary>
        public void MoveHorizontally(int x) => CurrentBlock.MoveHorizontally(gameWindow, x);

        /// <summary>
        ///     Rotates the current block.
        /// </summary>
        public void RotateClockwise() => CurrentBlock.RotateClockwise(gameWindow);


        /// <summary>
        ///     It gets the current player from the session manager, records the relevant
        ///     player statistics, overwrites the SessionManager's player cache, and 
        ///     saves the player's data to a file
        /// </summary>
        public void GameOver()
        {
            /* Getting the current player from the session manager. */
            var Player = SessionManager.CurrentPlayer;
            if (Player == null) return;
            if (Player.IsGuest) return;
            /* Adding the score to the player's total score, and if the score is greater than the player's high
            score, it sets the player's high score to the score and increments the player's personal records. */
            Player.AllScore += Score;
            if (Score > Player.HighScore)
            {
                Player.HighScore = Score;
                Player.PersonalRecords += 1;
            }

            /* Recording other misc statistics. */
            Player.BlocksPlaced += BlocksPlaced;
            Player.Games += 1;
            Player.ClearedLines += LinesCleared;
            Player.ClearGameState();
            /* Overwriting the SessionManager's player cache and Saving the player's data to a file. */
            SessionManager.CurrentPlayer = Player;
            GameIOManager.OverwritePlayer(Player);
            GameIOManager.SavePlayers();
        }

        /// <summary>
        ///     Saves the current game state to a file
        /// </summary>
        /// <param name="GameWindow">The current gameWindow of the game window.</param>
        /// <param name="tiles">A list of strings that represent the tiles on the board.</param>
        /// <param name="tags">A list of strings that represent the tags of the blocks that are currently on the board.</param>
        public void Save(GameWindow gameWindow, List<string> tiles, List<string> tags)
        {
            var Player = SessionManager.CurrentPlayer;
            if (Player == null) return;
            if (Player.IsGuest) return;

            gameWindow.Hide();
            gameWindow.Dispose();

            var gameState = new GameState
            {
                Score = Score,
                Multiplier = Multiplier,
                CurrentBlock = CurrentBlock,
                HeldBlock = HeldBlock,
                BlockQueue = BlockQueue,
                BlocksPlaced = BlocksSpawned,
                ClearedLines = LinesCleared,
                Tiles = tiles,
                Tags = tags
            };

            Player.PreviousGameState = gameState;
            SessionManager.CurrentPlayer = Player;
            GameIOManager.OverwritePlayer(Player);
            GameIOManager.SavePlayers();
            MessageBox.Show("Your progress has been saved successfully.",
                "Blocks · Save Game Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            AudioController.PlaySoundEffect("ok");
            SessionManager.MainMenuForm.Show();
        }


        /// <summary>
        ///     Add the score based on the number of lines cleared and the adjustment value provided.
        /// </summary>
        /// <param name="lines">The number of lines cleared.</param>
        /// <param name="adj">The adjustment value.</param>
        public void AddScore(int lines, int adj)
        {
            var sc = 0;
            /* Adding the score based on the number of lines cleared. */
            switch (lines)
            {
                case 1:
                    sc += 100;
                    AudioController.PlaySoundEffect("single");
                    break;
                case 2:
                    sc += 300;
                    AudioController.PlaySoundEffect("_double");
                    break;
                case 3:
                    sc += 500;
                    AudioController.PlaySoundEffect("triple");
                    break;
                case 4:
                    sc += 800;
                    AudioController.PlaySoundEffect("tetris");
                    break;
            }

            /* Adding the score based on the number of lines cleared and the adjustment value. */
            Score += (int)Math.Round((sc + adj) * Multiplier);
        }
    }
}