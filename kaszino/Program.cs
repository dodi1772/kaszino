namespace kaszino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\t1. HighLow\n\t2. Színkitalálós\n\t3. Számtippelős\n\t4. Jackpot\nAdd meg melyik játék: ");
            int opcio=Convert.ToInt32(Console.ReadLine());
            switch (opcio)
            {
                case 1:
                    HighLow();
                    break;
                case 2:
                    szinjatek();
                    break;
                case 3:
                    Tippelos();
                    break;
                case 4:
                    Jackpot();
                    break;
                default:
                    Console.WriteLine("Nem megfelelő bemenet.");
                    break;
            }
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

        static void szinjatek()
        {
            Console.Write("Adj meg egy tétet: ");
            int penz=Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy színt(b/r): ");
            char szin=Convert.ToChar(Console.ReadLine());
            int binaris = 0;
            if (szin=='r')
            {
                binaris = 1;
            }
            Random random = new Random();
            int rand = random.Next(0, 2);
            if (rand==binaris)
            {
                Console.WriteLine($"Eltaláltad a színt (a téted nőtt ennyivel: {penz} Egyenleg: {penz*2})");
                penz = penz * 2;
            }
            else
            {
                Console.WriteLine("Nem talált.");
            }
        }
        static void Tippelos()
        {
            Random random = new Random();
            int rand=random.Next(1,100);
            Console.Write("Add meg a kezdőértéket: ");
            int kezdo=Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg a végértéket: ");
            int veg=Convert.ToInt32(Console.ReadLine());
            if (rand>=kezdo&&rand<=veg)
            {
                Console.WriteLine($"Nyertél. A szám: {rand}");
            }
            else
            {
                Console.WriteLine($"Vesztettél. A szám: {rand}");
            }
        }
        static void Jackpot()
        {
            Console.Write("Adj meg egy tétet: ");
            int penz = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy számot 1 és 100 között: ");
            int bemenet=Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int rand= random.Next(1,100);
            if (bemenet==rand)
            {
                penz = penz * 10;
                Console.WriteLine($"Nyertél, gratulálok. A téted megtízszereződött. \nEgyenleg{penz}");
            }
            else
            {
                Console.WriteLine("Sajnos nem nyertél.");
            }
        }
    }
}
