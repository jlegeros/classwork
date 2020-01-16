using System;

namespace TreasureHunt
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] startingPos = {0, 0};

            var newExplorer = new Explorer(startingPos);

            string[] instructions = { "N3", "E2", "S5", "W10"};

            for (int i = 0; i < instructions.Length; i++)
            {
                newExplorer.Move(instructions[i]);
            }

            Console.WriteLine(newExplorer.position[0] + " " + newExplorer.position[1]);
        }
    }

    class Explorer
    {
        public int[] position = new int [2];

        public Explorer(int[] start)
        {
            position[0] = start[0];
            position[1] = start[1];
        }

        public void Move(string vector)
        {
            //char[] moveVector = vector.ToCharArray();

            char direction = Convert.ToChar(vector.Substring(0, 1));

            //char[] tempMag = new char[moveVector.Length - 1];
            //
            //for (int i = 1; i < moveVector.Length; i++)
            //{
            //    tempMag[i - 1] = moveVector[i];
            //}
            //
            //string strMagnitude = String.Join("", tempMag);
            //
            //int magnitude = Int32.Parse(strMagnitude);

            int magnitude = Int32.Parse(vector.Substring(1));

            switch (direction)
            {
                case 'E':
                    position[0] += magnitude;
                    break;
                case 'W':
                    position[0] -= magnitude;
                    break;
                case 'N':
                    position[1] += magnitude;
                    break;
                case 'S':
                    position[1] -= magnitude;
                    break;
                default:
                    break;
            }
        }
    }
}
