namespace Hedgehogs
{


    class Program
    {
        static void Main(string[] args)
        {
            int desiredColor = 1; 
            int[] InitialPopulationOfHedgehogs =  { 8, 1, 9 };

         int totalCount = InitialPopulationOfHedgehogs[0] + InitialPopulationOfHedgehogs[1] + InitialPopulationOfHedgehogs[2]; 
          int desiredCount = InitialPopulationOfHedgehogs[desiredColor]; 

           int steps = 0;

            while (true)
            {
                int maxColor = Array.IndexOf(InitialPopulationOfHedgehogs, InitialPopulationOfHedgehogs.Max());
                int minColor = Array.IndexOf(InitialPopulationOfHedgehogs, InitialPopulationOfHedgehogs.Min());

                if (maxColor == desiredColor)
                {

                    break;

                }

                InitialPopulationOfHedgehogs[maxColor]--;
                InitialPopulationOfHedgehogs[minColor]++;
                steps++;


                if (InitialPopulationOfHedgehogs[desiredColor] == desiredCount)
                {
                    Console.WriteLine(steps);
                }
                else
                {
                    Console.WriteLine(-1);
                }






            }

        }
    }
}