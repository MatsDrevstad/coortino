using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoorTino
{
    class SortedPosList
    {
        private List<Position> positions = new List<Position>();

        public int Count()
        {
            return positions.Count();
        }

        public void Add(Position pos)
        {
            positions.Add(pos);
            positions.OrderBy(p => p.Lenght()).ToList();
        }

        public bool Remove(Position pos)
        {
            return false;
        }
    }
}
