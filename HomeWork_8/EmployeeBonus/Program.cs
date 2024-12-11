<<<<<<< HEAD
﻿    public enum Post
    {
        Manager = 160,      
        Developer = 180,    
        Accountant = 140,   
        Clerk = 120         
    }

    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if (hours > (int)worker)
            {
                Console.WriteLine($"Премія надається. Співробітник {worker} відпрацював більше годин.");
                return true;
            }
            else
            {
                Console.WriteLine($"Премія не надається. Співробітник {worker} не відпрацював достатньо годин.");
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Accountant accountant = new Accountant();

            Console.WriteLine("Введіть посаду співробітника (Manager, Developer, Accountant, Clerk): ");
            string position = Console.ReadLine();

            Console.WriteLine("Введіть кількість годин, які відпрацював співробітник за місяць: ");
            int hoursWorked = int.Parse(Console.ReadLine());

            Post workerPost;
            if (Enum.TryParse(position, true, out workerPost))
            {
                accountant.AskForBonus(workerPost, hoursWorked);
            }
            else
            {
                Console.WriteLine("Невірно введена посада.");
            }

            Console.ReadKey();
        }
    }

=======
﻿    public enum Post
    {
        Manager = 160,      
        Developer = 180,    
        Accountant = 140,   
        Clerk = 120         
    }

    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if (hours > (int)worker)
            {
                Console.WriteLine($"Премія надається. Співробітник {worker} відпрацював більше годин.");
                return true;
            }
            else
            {
                Console.WriteLine($"Премія не надається. Співробітник {worker} не відпрацював достатньо годин.");
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Accountant accountant = new Accountant();

            Console.WriteLine("Введіть посаду співробітника (Manager, Developer, Accountant, Clerk): ");
            string position = Console.ReadLine();

            Console.WriteLine("Введіть кількість годин, які відпрацював співробітник за місяць: ");
            int hoursWorked = int.Parse(Console.ReadLine());

            Post workerPost;
            if (Enum.TryParse(position, true, out workerPost))
            {
                accountant.AskForBonus(workerPost, hoursWorked);
            }
            else
            {
                Console.WriteLine("Невірно введена посада.");
            }

            Console.ReadKey();
        }
    }

>>>>>>> 50792e4c69b764846a3cd6eb627f283771be85a0
