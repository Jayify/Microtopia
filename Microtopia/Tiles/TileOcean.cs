using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microtopia.Tiles
{
    internal class TileOcean : Tile
    {
        private readonly Color color = Color.DarkBlue;

        public override Color Color { get { return color; } }

        public TileOcean(int col, int row) : base(col, row)
        {

        }
    }
}
