using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microtopia
{
    public abstract class Tile
    {
        // private int id;
        private int col;
        private int row;
        private Player? player;


        // public int Id { get => id; set => id = value; }
        public int Col { get => col; set => col = value; }
        public int Row { get => row; set => row = value; }
        private Player? Player { get => player; set => player = value; }
        public abstract Color Color { get; }



        public Tile(int col, int row)
        {
            Col = col;
            Row = row;
        }


        public void TileClick(object sender, EventArgs e)
        {
            PictureBox theOneClicked = (PictureBox)sender;
            MessageBox.Show($"Col: {Col.ToString()} Row: {Row.ToString()}");
        }


    }
}
