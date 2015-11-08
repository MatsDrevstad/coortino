using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoorTino
{
    class SortedPosList
    {
        private List<Position> positionList = new List<Position>();

        public SortedPosList() {}

        public SortedPosList(SortedPosList spl)
        {
            positionList = spl.positionList;
        }

        public int Count()
        {
            return positionList.Count();
        }

        public void Add(Position pos)
        {
            positionList.Add(pos);
            positionList = positionList
                .OrderBy(p => p.Lenght()).ToList();
        }

        public bool Remove(Position pos)
        {
            var element = positionList
                .FirstOrDefault(p => p.Equals(pos));
            if (element != null)
            {
                positionList.Remove(element);
                return true;
            }
            return false;
        }

        override public string ToString()
        {
            return string.Join(", ", positionList);
        }

        public SortedPosList Clone()
        {
            return new SortedPosList(this);
        }

        public static SortedPosList operator +(SortedPosList sp1, SortedPosList sp2)
        {
            foreach (var item in sp2.positionList)
            {
                sp1.Add(item);
            }
            return sp1.Clone();
        }

        public SortedPosList CircleContent(Position centerPos, double radius)
        {
            var temp = new SortedPosList();

            foreach (var item in positionList)
            {
                if (IsInside(item, centerPos, radius))
                {
                    temp.Add(item);
                }
            }
            return temp;
        }

        private bool IsInside(Position pos, Position centerPos, double radius)
        {
            if (Math.Pow((pos.X - centerPos.X), 2) + Math.Pow((pos.Y- centerPos.Y), 2) < Math.Pow(radius, 2))
            {
                return true;
            }
            return false;
        }
    }
}
