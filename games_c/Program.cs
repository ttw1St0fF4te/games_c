namespace Program
{
    class Games
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter game code: \n" +
                    "1. Guess numer \n" +
                    "2. Multiplication table \n" +
                    "3. Number division \n" +
                    "4. Quit program \n");
                }
                catch
                {
                    Console.WriteLine("Wrong code.");
                    break;
                }
                int code = int.Parse(Console.ReadLine());
                switch (code)
                {
                    case 1:
                        Guessnum();
                        break;
                    case 2:
                        Multtab();
                        break;
                    case 3:
                        Console.WriteLine("Введите число: ");
                        int pnum = int.Parse(Console.ReadLine());
                        NumDiv(pnum);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Wrong code. ");
                        break;
                }
            }
              
        }
        static void Multtab()
        {
            int[,] matrix = new int[9, 9];
            int l = 1;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    matrix[i, j] = (j + 1) * l;
                l++;
            }
            for (int i = 0; i < 9; i++)
            {
                for (int k = 0; k < 9; k++)
                    Console.Write(matrix[i, k] + " ");
                Console.WriteLine();
            }
        }
        static void Guessnum()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 101);
            Console.WriteLine("Try to guess number: ");
            int pnum = int.Parse(Console.ReadLine());
            while (pnum != num)
            {
                if (pnum > num)
                {
                    Console.WriteLine("Remove");
                    pnum = int.Parse(Console.ReadLine());
                }

                else if (pnum < num)
                {
                    Console.WriteLine("Add");
                    pnum = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Congratulations");
            return;
        }
        static void NumDiv(int num)
        {
            int[] massive = new int[num];
            int delitel = 1;
            int i = 0;
            while (num >= delitel)
            {
                if (num % delitel == 0)
                {
                    massive[i] = delitel;
                    i++;
                }
                delitel++;
            }
            for (int j = 0; j < i; j++)
                Console.Write(massive[j]+ "     ");
            Console.WriteLine();
        }
    }
}
