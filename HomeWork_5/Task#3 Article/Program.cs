using static System.Formats.Asn1.AsnWriter;

class Article
{
    private String productName;
    private String storeName;
    private decimal price;

    public Article(string productName, String storeName, decimal price)
    {
        this.productName = productName;
        this.storeName = storeName;
        this.price = price;
    }

    public String GetInfo()
    {
        return $"Товар: {productName}, Магазин: {storeName}, Ціна: {price} грн";
    }

    public bool IsProduct(String name)
    {
        return string.Equals(productName, name, StringComparison.OrdinalIgnoreCase);
    }
}
    class Store
    {
        private Article[] articles;

        public Store(int size)
        {
            articles = new Article[size];
        }


        public void AddArticle(int index, Article article)
        {

            if (index >= 0 && index < articles.Length)
            {
                articles[index] = article;
            }
            else
            {
                Console.WriteLine("Помилка: індекс виходить за межі масиву.");
            }
        }

        public void GetArticleByIndex(int index)
        {
            if (index >= 0 && index < articles.Length && articles[index] != null)
            {
                Console.WriteLine(articles[index].GetInfo());
            }
            else
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Товар із заданим індексом не знайдено.");
            }
        }
        public void GetArticleByName(string name)
        {
            foreach (var article in articles) {
                if (article != null! && article.IsProduct(name))
                        {
                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    Console.WriteLine(article.GetInfo());
                    return;
                }
            }
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"Товар із назвою \"{name}\" не знайдено.");

        }
    }


class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;


        Store store = new Store(3);

        store.AddArticle(0, new Article("Молоко", "Сільпо", 35.50m));
        store.AddArticle(1, new Article("Хліб", "АТБ", 18.00m));
        store.AddArticle(2, new Article("Кава", "Велмарт", 150.00m));
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Товар за індексом 1:");
        store.GetArticleByIndex(1);

        Console.WriteLine("\nПошук товару за назвою:");
        Console.Write("Введіть назву товару: ");
        string productName = Console.ReadLine();
        store.GetArticleByName(productName);

        Console.ReadKey();
    }
}