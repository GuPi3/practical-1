using System;

namespace Lib_8
{
    public class ProgramModules
    {
        //Random random = new Random();
        public static void SumEvenWithOut(int count, out int max, out string numbers)
        {
            Random random = new Random();
            max = 0;
            numbers = string.Empty;

            for (int i = 0; i < count; i++)
            {
                int number = random.Next(0, count);
                numbers += number.ToString() + " ";
                if (max <= number)
                {
                    max = number;
                }



            }
        }


        public (int sum, string numbers) SumEvenWithTuple(int count)
        {
            Random random = new Random();
            int max = 0;
            string numbers = string.Empty;

            for (int i = 0; i < count; i++)
            {
                int number = random.Next(0, count);
                numbers += number.ToString() + " ";
                if (max <= number)
                {
                    max = number;
                }
            }

            return (max, numbers);
        }
    }
}
