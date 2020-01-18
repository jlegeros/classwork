using System;
using System.Collections.Generic;

namespace TreasureHunt
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var aExplorer = new Explorer(23, 10);
            List<Trap> traps = new List<Trap>();

            traps.Add(new Trap(3, 15));
            traps.Add(new Trap(25, 80));
            traps.Add(new Trap(27, 13));

            string[] instructions = { "N3", "E2", "S5", "W10"};

            for (int i = 0; i < instructions.Length; i++)
            {
                if (!Move(aExplorer, instructions[i], traps))
                {
                    break;
                }
            }

            if (aExplorer.location != null)
            {
                Coord.Print(aExplorer.location);
            }
            else
            {
                Console.WriteLine("null");
            }
        }

        public static bool Move(Explorer explorer, string vector, List<Trap> traps)
        {
            char direction = Convert.ToChar(vector.Substring(0, 1));

            int magnitude = Int32.Parse(vector.Substring(1));

            for (int i = 0; i < magnitude; i++)
            {
                switch (direction)
                {
                    case 'E':
                        explorer.location.Update(1, 0);
                        break;
                    case 'W':
                        explorer.location.Update(-1, 0);
                        break;
                    case 'N':
                        explorer.location.Update(0, 1);
                        break;
                    case 'S':
                        explorer.location.Update(0, -1);
                        break;
                    default:
                        break;
                }

                foreach (Trap aTrap in traps)
                {
                    if (Coord.Compare(aTrap.location, explorer.location))
                    {
                        explorer.location = null;
                        Console.WriteLine("IT'S A TRAP!!");
                        return false;
                    }
                }
            }
           
            return true;
        }
    }

    class Coord
    {
        int xPos;
        int yPos;

        public Coord()
        {
            xPos = 0;
            yPos = 0;
        }
        public Coord(int x, int y)
        {
            xPos = x;
            yPos = y;
        }

        public static bool Compare(Coord a, Coord b)
        {
            if (a.xPos == b.xPos && a.yPos == b.yPos)
            {
                return true;
            }
            return false;
        }

        public static void Print(Coord a)
        {
            Console.WriteLine(a.xPos + " " + a.yPos);
        }

        public void Update(int xDelta, int yDelta)
        {
            xPos += xDelta;
            yPos += yDelta;

            if (xPos < 0 || yPos < 0)
            {
                Console.WriteLine("You fell off the map!!");
            }
        }
    }

    class Explorer
    {
        public Coord location = new Coord();

        public Explorer(int x, int y)
        {
            location.Update(x, y);
        }
    }

    class Trap
    {
        public Coord location = new Coord();

        public Trap(int x, int y)
        {
            location.Update(x, y);
        }
    }
}
