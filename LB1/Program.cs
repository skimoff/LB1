using StreamWriter = System.IO.StreamWriter;

namespace LB1;

class Program
{
    
    public static double task1()
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
        numerator = Math.Log(x + Math.Pow(x, 3));
        if (numerator != 1E-8)
        {
            result = (denominator / numerator) - Math.Pow(Math.Tan(a), 3);
        }
        else
        {
            result = 0;
        }
        
        return result;
    }

    public static void task2()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        double y;
        double x = 0;
        
        StreamWriter input = new StreamWriter("in.txt");
        StreamReader output = new StreamReader("out.txt");
        input.WriteLine("Отримано");
        for (int i = 0; i < 9; i++)
        {
            x = Convert.ToDouble(output.ReadLine());
            y = Math.Pow(x, 2) - 3 * Math.Sin(x);
            input.WriteLine($"Для заданої функції Y({x}) = " + y);
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
        {
            test.Add(Convert.ToString(input.ReadLine()));
        }
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

    public static void task4()
    {
        
    }

    static void Main(string[] args)
    {
        //double result = task1();
        //Console.WriteLine(result);
        //task2();
        task3();
        Console.ReadKey();
    }
}