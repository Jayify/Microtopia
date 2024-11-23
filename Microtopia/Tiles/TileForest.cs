using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microtopia.Tiles
{
    internal class TileForest : Tile
    {
        private readonly Color color = Color.DarkGreen;

        public override Color Color { get { return color; } }

        public TileForest(int col, int row) : base(col, row)
        {

        }

        public override string ToString()
        {
            return $"Col: {Col} Row: {Row} Type: Forest";
        }
    }
}
