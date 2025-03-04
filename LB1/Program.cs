using StreamWriter = System.IO.StreamWriter;

namespace LB1;

class Program
{
    
    public static void task1()
    {
        double a, x, c;
        Console.WriteLine("Enter first number: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        c = Convert.ToDouble(Console.ReadLine());
        double denominator, numerator;
        double result;
        denominator = Math.Sqrt(Math.Abs(-a * x + c));
        numerator = Math.Log(Math.Abs(x + Math.Pow(x, 3)));
        if (Math.Abs(numerator) > 1E-8)
        {
            result = (denominator / numerator) - Math.Pow(Math.Tan(a), 3);
            Console.WriteLine("The result is: " + result);
        }
        else
            Console.WriteLine("Result = 0");
        
    }

    public static void task2()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        double y;
        double x;
        
        StreamWriter input = new StreamWriter("in.txt");
        StreamReader output = new StreamReader("out.txt");
        input.WriteLine("Отримано");
        for (int i = 0; i < 9; i++)
        {
            x = Convert.ToDouble(output.ReadLine());
            y = Math.Pow(x, 2) - 3 * Math.Sin(x);
            input.WriteLine($"Для заданої функції Y({x}) = {y}");
        }
        input.WriteLine("Розрахував студент Мякушка Олександр Вячеславович");
        input.Close();
        output.Close();
    }

    public static void task3()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        StreamReader input = new StreamReader("test.txt");
        int correctAnswers = 0;
        int x = 0;
        int[] answerCorrect = [1,50,2,11,30,1,1];
        int[] answer = new int[7];
        List<string?> test = new List<string?>();
        for (int i = 0; i < 7; i++)
            test.Add(Convert.ToString(input.ReadLine()));
        Console.WriteLine("Тест «Перевір свої можливості»");
        foreach (string s in test)
        {
            Console.WriteLine(s);
            answer[x] = Convert.ToInt32(Console.ReadLine());
            ++x;
        }
        for (int i = 0; i < 7; i++)
            if (answerCorrect[i] == answer[i])
                correctAnswers++;
        
        switch (correctAnswers)
        {
            case 7:
            {
                Console.WriteLine("Геній");
                break;
            }
            case 6:
            {
                Console.WriteLine("Ерудит");
                break;
            }
            case 5:
            {
                Console.WriteLine("Нормальний");
                break;
            }
            case 4:
            {
                Console.WriteLine("Здібності середні");
                break;
            }
            case 3:
            {
                Console.WriteLine("Здібності нижче середнього");
                break;
            }
            default:
            {
                Console.WriteLine("Вам треба відпочити!");
                break;
            }
        }
        input.Close();
    }

    public static int GetFuelConsumption(int weight)
    {
        if (weight > 2000) return -1;
        if (weight > 1500) return 9;
        if (weight > 1000) return 7;
        if (weight > 500) return 4;
        return 1;
    }
    public static void task4()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        StreamReader input = new StreamReader("fly.txt");
        int fuelCapacity = Convert.ToInt32(input.ReadLine());
        int distanceAB = Convert.ToInt32(input.ReadLine());
        int distanceBC = Convert.ToInt32(input.ReadLine());
        int cargoWeight = Convert.ToInt32(input.ReadLine());
        
        int fuelConsumption = GetFuelConsumption(cargoWeight);
        
        if (fuelCapacity == -1)
            Console.WriteLine("Літак не може підняти такий вантаж.");
        
        int fuelNeededAB = distanceAB * fuelConsumption;
        int fuelNeededBC = distanceBC * fuelConsumption;
        
        if (fuelNeededAB > fuelCapacity)
            Console.WriteLine("Літак не може долетіти до пункту B.");
        
        int remainingFuel = fuelCapacity - fuelNeededAB;
        
        int refuelNeeded = Math.Max(0, fuelNeededBC - remainingFuel);
        
        if (refuelNeeded + remainingFuel > fuelCapacity)
            Console.WriteLine("Літак не може долетіти до пункту C навіть після дозаправки.");
        
        
        input.Close();
    }

    static void Main(string[] args)
    {
        //task1();
        //task2();
        //task3();
        task4();
        Console.ReadKey();
    }
}