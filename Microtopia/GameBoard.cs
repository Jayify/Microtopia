using Microtopia.Tiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microtopia
{
    public partial class GameBoard : Form
    {
        private int _tilePadding = 5; // Space between tiles
        private int tileSize = 25; // Height and width

        public GameBoard()
        {
            InitializeComponent();

            GameManager.GenerateMap(10, 10);
            DisplayMap();
        }

        private void DisplayMap()
        {
            foreach (Tile tile in GameManager.Map)
            {
                Debug.WriteLine("Tile");
                PictureBox currentTilePic = new PictureBox();
                currentTilePic.Width = tileSize;
                currentTilePic.Height = tileSize;
                currentTilePic.BackColor = tile.Color;
                currentTilePic.Location = new Point(tile.Col * (currentTilePic.Width + _tilePadding), tile.Row * (currentTilePic.Height + _tilePadding));
                currentTilePic.Click += new System.EventHandler(tile.TileClick);

                pnlGameBoard.Controls.Add(currentTilePic);
            }
        }
    }
}
