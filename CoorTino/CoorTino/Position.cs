using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoorTino
{
    class Position
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = Math.Abs(value);  } // sätter värde på x 
        }

        public int Y
        {
            get { return y; }
            set { y = Math.Abs(value); } // sätter värde på y
        }

        //Konstruktor
        public Position(int k, int t)
        {
            X = k;
            Y = t;
        }

        public double Lenght()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)); // returnerar en double som är kvadratiska roten ur 2
        }

        public bool Equals(Position p)
        {
            return (X == p.X && Y == p.Y);
        }

        public Position Clone()
        {
            return new Position(X, Y);   // returnerar ny instans av position som har värdet x,y
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ") ";
        }

        public static bool operator >(Position p1, Position p2) // jämför två positioners avstånd från origo(jämför storleken på bägge punkterna.)
        {
            if (p1.Lenght() > p2.Lenght())
            {
                return true;
            }
            else if (p1.Lenght() == p2.Lenght())
            {
                if (p1.X < p2.X)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator <(Position p1, Position p2) // jämför två positioners avstånd från origo(jämför storleken på bägge punkterna.)
        {
            if (p1.Lenght() < p2.Lenght())
            {
                return true;
            }
            else if (p1.Lenght() == p2.Lenght())
            {
                if (p1.X > p2.X)
                {
                    return true;
                }
            }
            return false;
        }

        public static Position operator +(Position p1, Position p2)
        {
            return new Position(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Position operator -(Position p1, Position p2)
        {
            return new Position(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static double operator %(Position pos1, Position pos2)
        {
            return Math.Sqrt(Math.Pow(pos1.X - pos2.X, 2) + Math.Pow(pos1.Y - pos2.Y, 2));

        }
    }
}


