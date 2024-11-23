using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microtopia.Tiles
{
    internal class TileField : Tile
    {
        private readonly Color color = Color.GreenYellow;

        public override Color Color { get { return color; } }

        public TileField(int col, int row) : base(col, row)
        {

        }
    }
}
