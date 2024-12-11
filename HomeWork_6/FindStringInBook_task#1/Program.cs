using System;


    class Book
    {
        private string[] content;
        public Book(string[] content)
        {
            this.content = content;
        }

        public void FindNext(string str)
        {
            bool found = false;

            for (int i = 0; i < content.Length; i++)
            {
                if (content[i].Contains(str, StringComparison.OrdinalIgnoreCase))  // Ігноруючи регістр
                {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine($"Знайдено на сторінці {i + 1}: {content[i]}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Рядок не знайдено.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] bookContent = {
                "Це перша сторінка книги. Тут ми починаємо.",
                "Друга сторінка має більше тексту і важливу інформацію.",
                "Третя сторінка розповідає цікаву історію.",
                "Це четверта сторінка. Вона дуже важлива і містить різні факти."
            };

            Book myBook = new Book(bookContent);

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть рядок для пошуку: ");
            string searchString = Console.ReadLine();

            myBook.FindNext(searchString);

            Console.ReadKey();
        }
    }

