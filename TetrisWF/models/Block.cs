using AS_Coursework.enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace AS_Coursework.models
{
    [Serializable]
    internal class Block
    {
        private int x;
        private int y;
        private BlockType type;
        public Image blockTile;
        bool idle;

        public Block(BlockType type, int rotation, int x, int y)
        {

            this.type = type;            
        }

        public void RenderNext(int x, int y)
        {

        }

        private static List<int[]> GenerateCoordinates(BlockType bT, int x, int y)
        {
            List<int[]> generatedCoordinates = new List<int[]>();
            switch (bT)
            {
                case BlockType.LINE:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x+1, y });
                    generatedCoordinates.Add(new int[] { x+2, y });
                    generatedCoordinates.Add(new int[] { x+3, y });
                    break;
                case BlockType.SQUARE:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x, y+1 });
                    generatedCoordinates.Add(new int[] { x+1, y });
                    generatedCoordinates.Add(new int[] { x+1, y+1 });
                    break;
                case BlockType.Z:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x+1, y });
                    generatedCoordinates.Add(new int[] { x, y+1 });
                    generatedCoordinates.Add(new int[] { x-1, y+1 });
                    break;
                case BlockType.S:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x-1, y });
                    generatedCoordinates.Add(new int[] { x, y+1 });
                    generatedCoordinates.Add(new int[] { x+1, y+1 });
                    break;
                case BlockType.L:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x, y+1 });
                    generatedCoordinates.Add(new int[] { x+1, y });
                    generatedCoordinates.Add(new int[] { x+2, y });
                    break;
                case BlockType.REVERSE_L:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x+1, y });
                    generatedCoordinates.Add(new int[] { x+2, y });
                    generatedCoordinates.Add(new int[] { x+2, y+1 });
                    break;
                case BlockType.T:
                    generatedCoordinates.Add(new int[] { x, y });
                    generatedCoordinates.Add(new int[] { x, y+1 });
                    generatedCoordinates.Add(new int[] { x+1, y });
                    generatedCoordinates.Add(new int[] { x-1, y });
                    break;
            }
            return generatedCoordinates;
    }
}
