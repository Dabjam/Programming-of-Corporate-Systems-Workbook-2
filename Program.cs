using System;

class Program
{
    static void Main()
    {
        // Задание 1
        // Задание 2 (закомментировано, как у тебя)
        // ...

        // Задание 3
        // Console.Write("Введите числитель: "); 
        // int num1 = int.Parse(Console.ReadLine());

        // Console.Write("Введите знаменатель: ");
        // int num2 = int.Parse(Console.ReadLine());

        // if (num2 == 0)
        // {
        //     Console.WriteLine("На ноль делить нельзя");
        //     return;  
        // }

        // if (num1 == 0)
        // {
        //     Console.WriteLine("0");  
        //     return;
        // }

        // bool neg = false;
        // if (num1 < 0)
        // {
        //     neg = true;
        //     num1 = -num1;
        // }
        // if (num2 < 0)
        // {
        //     neg = !neg;  
        //     num2 = -num2;
        // }

        // int gcd = 1;
        // int min = Math.Min(num1, num2);
        // for (int i = min; i >= 1; i--)  
        // {
        //     if (num1 % i == 0 && num2 % i == 0)
        //     {
        //         gcd = i;
        //         break; 
        //     }
        // }

        // num1 /= gcd;
        // num2 /= gcd;

        // if (neg)
        //     num1 = -num1;

        // Console.WriteLine($"Результат: {num1} / {num2}");

        // Задание 4
        // int low = 0;
        // int high = 63;

        // while (low < high)
        // {
        //     int mid = (low + high) / 2;
        //     Console.Write($"Ваше число больше {mid}? (да - 1, нет - 0): ");
        //     int res = int.Parse(Console.ReadLine());

        //     if (res == 1)
        //     {
        //         low = mid + 1;
        //     }
        //     else
        //     {
        //         high = mid;
        //     }
        // }
        // Console.WriteLine($"Ваше число: {low} ");

        // Задание 5
        //американо требуется 300 мл воды (цена 150 рублей), а для латте 30
        // мл воды и 270 мл молока (цена 170 рублей)

        // Console.Write("Введите количество воды в мл: ");
        // int water = int.Parse(Console.ReadLine());
        // Console.Write("Введите количество молока в мл: ");
        // int milk = int.Parse(Console.ReadLine());

        // int americano_count = 0;
        // int latte_count = 0;
        // int earnings = 0;

        // while (true)
        // {

        //     bool can_me = (water >= 300) || (water >= 30 && milk >= 270);
        //     if (!can_me)
        //     {
        //         // Вывод отчёта
        //         Console.WriteLine("*Отчёт*");
        //         Console.WriteLine("Ингредиентов осталось:");
        //         Console.WriteLine($"Вода: {water} мл");
        //         Console.WriteLine($"Молоко: {milk} мл");
        //         Console.WriteLine($"Кружек американо приготовлено: {americano_count}");
        //         Console.WriteLine($"Кружек латте приготовлено: {latte_count}");
        //         Console.WriteLine($"Итого: {earnings} рублей.");
        //         break;
        //     }

        //     Console.Write("Выберите напиток (1 — американо, 2 — латте): ");
        //     int choice = int.Parse(Console.ReadLine());

        //     if (choice == 1)
        //     {
        //         if (water >= 300)
        //         {
        //             water -= 300;
        //             earnings += 150;
        //             americano_count++;
        //             Console.WriteLine("Ваш напиток готов.");
        //         }
        //         else
        //         {
        //             Console.WriteLine("Не хватает воды");
        //         }
        //     }
        //     else if (choice == 2)
        //     {
        //         if (water >= 30 && milk >= 270)
        //         {
        //             water -= 30;
        //             milk -= 270;
        //             earnings += 170;
        //             latte_count++;
        //             Console.WriteLine("Ваш напиток готов.");
        //         }
        //         else if (milk < 270)
        //         {
        //             Console.WriteLine("Не хватает молока");
        //         }
        //         else
        //         {
        //             Console.WriteLine("Не хватает воды");
        //         }
        //     }
        // }

        // Задание 6
        // Console.Write("Введите количество бактерий: ");
        // int bacteria = int.Parse(Console.ReadLine());
        // Console.Write("Введите количество антибиотика: ");
        // int antibiotic = int.Parse(Console.ReadLine());

        // int hour = 0;

        // while (bacteria > 0 && hour < 11)
        // {
        //     hour++;
        //     bacteria *= 2;
        //     int killPower = 11 - hour;
        //     int killed = antibiotic * Math.Max(0, killPower);
        //     bacteria -= killed;
        //     if (bacteria < 0) bacteria = 0;
        //     Console.WriteLine($"После {hour} часа бактерий осталось {bacteria}");
        // }

        // Задание 7
        // Console.Write("Введите n: ");
        // int n = int.Parse(Console.ReadLine());
        // Console.Write("Введите a: ");
        // int a = int.Parse(Console.ReadLine());
        // Console.Write("Введите b: ");
        // int b = int.Parse(Console.ReadLine());
        // Console.Write("Введите w: ");
        // int w = int.Parse(Console.ReadLine());
        // Console.Write("Введите h: ");
        // int h = int.Parse(Console.ReadLine());

        // int maxD = 0;

        // for (int d = 0; d <= 10000; d++)  
        // {
        //     bool canPlace = false;

        //     int modW1 = a + 2 * d;
        //     int modH1 = b + 2 * d;
        //     if (modW1 > 0 && modH1 > 0)
        //     {
        //         int cols1 = w / modW1;
        //         int rows1 = h / modH1;
        //         if (cols1 * rows1 >= n)
        //         {
        //             canPlace = true;
        //         }
        //     }

        //     int modW2 = b + 2 * d;
        //     int modH2 = a + 2 * d;
        //     if (modW2 > 0 && modH2 > 0)
        //     {
        //         int cols2 = w / modW2;
        //         int rows2 = h / modH2;
        //         if (cols2 * rows2 >= n)
        //         {
        //             canPlace = true;
        //         }
        //     }

        //     if (canPlace)
        //     {
        //         maxD = d;
        //     }
        //     else if (modW1 > w || modH1 > h || modW2 > w || modH2 > h)
        //     {
        //         break;
        //     }
        // }

        // Console.WriteLine($"Ответ d = {maxD}");
    }
}