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
            Map = new List<Tile>(); // Map null here? Should be instantiated
            Random rnd = new Random();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    switch (rnd.Next(1, 5))
                    {
                        case 1:
                            Map.Add(new TileField(j, i));
                            break;
                        case 2:
                            Map.Add(new TileForest(j, i));
                            break;
                        case 3:
                            Map.Add(new TileMountain(j, i));
                            break;
                        case 4:
                            Map.Add(new TileOcean(j, i));
                            break;
                    }
                }
            }
        }
    }
}
