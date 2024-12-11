
using System.Runtime.CompilerServices;

public interface ICreature
{
    string CreatureType { get; }
}
public class MagicBag
{
    private List<string> _giftedToday = new List<string>();

    public string GetGift(ICreature creature)
    {
        if (_giftedToday.Contains(creature.CreatureType))
        {
            return $"Істота '{creature.CreatureType}' вже отримувала подарунок сьогодні.";
        }

        _giftedToday.Add(creature.CreatureType);
        return $"Подарунок для '{creature.CreatureType}': {GenerateGift()}";
    }

    private string GenerateGift()
    {
        string[] gifts = { "Ігрова консоль PlayStation 5 ", "Набір солодощів", "Мішок золота", "Діамантові прикраси", "Електронна читалка книг"  };
    
        
         Random random = new Random();
  return gifts[random.Next(gifts.Length)];
      
    }
}

public class Elf : ICreature
{
    public string CreatureType { get; } = "Ельф";
}

public class Shreck : ICreature
{
    public string CreatureType { get; } = "Шрек";
}

    class Program
{
    static void Main (string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        MagicBag magicBag = new MagicBag();

        Elf elf = new Elf();
        Shreck shreck = new Shreck();


        Console.WriteLine("Перший подарунок: " + magicBag.GetGift(elf));
        Console.WriteLine("Другий подарунок: " + magicBag.GetGift(shreck));
        Console.WriteLine( magicBag.GetGift(elf));

    }
}