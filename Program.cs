using System;


public class MainClass
{
    public static void Main()
    {
        // put your c# code here
         // put your c# code here
        for(int i = 0; i < 1;)
        {
        double a, b;
        char c;
        Console.WriteLine("Введите число 1:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число 2:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
        c = char.Parse(Console.ReadLine());
        
        switch (c)
        {
            case '+':
                double i = a + b;
                Console.WriteLine("a + b = " + i);
                break;
                
            case '-':
                double ii = a - b;
                Console.WriteLine("a - b = " + ii);
                break;  
                
            case '*':
                double j = a * b;
                Console.WriteLine("a * b = " + j);
                break;
                
             case '/':
                double jj = a / b;
                Console.WriteLine("a / b = " + jj);
                break;
         
            default:
                    Console.WriteLine("Попробуйте еще раз..");
                break;
        }
        Console.WriteLine("Хотите продолжить выполнение программы?");
        Console.WriteLine("ДА - 1. НЕТ - 2.");
            int o = intParse(Console.ReadLine());
           if(o == 1)
            {
            continue;
            }
            else
            {
            break;
            }
        }
    }
}