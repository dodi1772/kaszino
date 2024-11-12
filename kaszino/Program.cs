namespace kaszino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HighLow();
        }
        static void HighLow()
        {
            Console.Write("Kérlek add meg a tétet: ");
            int tet=Convert.ToInt32(Console.ReadLine());
            bool fut = true;
            Random rand = new Random();
            int veletlen = rand.Next(1, 14);
            while (fut)
            {
                Console.WriteLine($"A szám: {veletlen}");
                int temp = veletlen;
                Console.Write("Nagyobb vagy kisebb(n/k): ");
                char tipp=Convert.ToChar(Console.ReadLine());
                veletlen = rand.Next(1, 14);
                switch (tipp)
                {
                    case 'k':
                        if (temp < veletlen)
                        {
                            Console.WriteLine($"Helytelen, a szám {veletlen} volt, elvesztetted a tétet.");
                            tet = 0;
                            break;

                        }
                        else if (temp>veletlen)
                        {
                            tet = tet * 2;
                            Console.WriteLine($"Helyesen tippeltél. Egyenleg: {tet}");
                            break;
                        }
                        break;
                    case 'n':
                        if (temp < veletlen)
                        {
                            tet = tet * 2;
                            Console.WriteLine($"Helyesen tippeltél. Egyenleg: {tet}");
                            break;

                        }
                        else if (temp > veletlen)
                        {
                            Console.WriteLine($"Helytelen, a szám {veletlen} volt, elvesztetted a tétet.");
                            tet = 0;
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Hiba, nem megfelelő bemenetet adtál.");
                        break;
                }
                Console.Write("Szeretnél még játszani(i/n): ");
                char folytkov=Convert.ToChar(Console.ReadLine());
                if (folytkov=='n')
                {
                    fut = false;
                }
                if (folytkov=='i')
                {
                    if (tet==0)
                    {
                        Console.Write("Add meg a tétet: ");
                        tet=Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        }

    }
}
