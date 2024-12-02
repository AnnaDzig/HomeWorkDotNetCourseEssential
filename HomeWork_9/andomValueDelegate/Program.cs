using System;

class Program
{
    delegate int RandomValueDelegate();

    static void Main()
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;


        RandomValueDelegate[] delegates = new RandomValueDelegate[5];

        Random random = new Random();
        for (int i = 0; i < delegates.Length; i++)
        {
            delegates[i] = () => random.Next(1, 100); 
        }

        Func<RandomValueDelegate[], double> calculateAverage = delegate (RandomValueDelegate[] delArray)
        {
            int sum = 0; 
            foreach (var del in delArray)
            {
                sum += del(); 
            }
            return (double)sum / delArray.Length; 
        };

        double average = calculateAverage(delegates);

        Console.WriteLine($"Середнє арифметичне значення: {average:F2}");
        Console.ReadKey();
    }
}

