namespace EnglishUkrainianDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new List<dynamic>
            {
                new { English = "Apple", Ukrainian = "Яблуко" },
                new { English = "House", Ukrainian = "Будинок" },
                new { English = "Car", Ukrainian = "Автомобіль" },
                new { English = "Book", Ukrainian = "Книга" },
                new { English = "Dog", Ukrainian = "Собака" },
                new { English = "Cat", Ukrainian = "Кіт" },
                new { English = "Tree", Ukrainian = "Дерево" },
                new { English = "Water", Ukrainian = "Вода" },
                new { English = "Sun", Ukrainian = "Сонце" },
                new { English = "Moon", Ukrainian = "Місяць" }
            };
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Англо-Український словник:\n");
            foreach (var entry  in dictionary) 
            {

                Console.WriteLine($"{entry.English} - {entry.Ukrainian}");
        }
       
            Console.ReadLine();
        }
    }
}
