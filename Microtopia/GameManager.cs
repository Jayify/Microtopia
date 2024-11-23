using Microtopia.Tiles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microtopia
{
    internal static class GameManager
    {
        private static GameBoard _gameBoard = new();

        public static List<Tile> Map = new List<Tile>();


        public static GameBoard Load()
        {
            return _gameBoard;
        }


        public static void GenerateMap(int width, int height)
        {
            Map = new List<Tile>(); // Map null here? Shoud be instantiated
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Map.Add(new TileField(j, i));
                    // Random rnd = new Random();
                }
            }
        }
    }
}
