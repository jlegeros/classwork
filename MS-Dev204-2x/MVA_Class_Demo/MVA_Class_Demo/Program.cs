using System;

namespace MVA_Class_Demo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine("Kitchen", "Brand", "DM1000");
            //myMachine.Location = "Kitchen";
            //myMachine.Model = "DM1000";

            Console.WriteLine(myMachine.Location);
            Console.WriteLine(myMachine.Make);
            Console.WriteLine(myMachine.Model);
            myMachine.MakeCappuccino();
        }
    }
}
