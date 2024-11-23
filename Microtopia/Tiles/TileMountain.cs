using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microtopia.Tiles
{
    internal class TileMountain : Tile
    {
        private readonly Color color = Color.Gray;

        public override Color Color { get { return color; } }

        public TileMountain(int col, int row) : base(col, row)
        {

        }
    }
}
