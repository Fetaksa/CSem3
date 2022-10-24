// Напишите программу, которая по заданному номеру четверти 
// показывет диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти от 1 до 4: ");
int q = Convert.ToInt32(Console.ReadLine());


string Coordinates(int qnum)
{
    if(qnum == 1) return "x > 0 и y > 0";
    if(qnum == 2) return "x < 0 и y > 0";
    if(qnum == 3) return "x < 0 и y < 0";
    if(qnum == 4) return "x < 0 и y < 0";
    return "Введён некорректный номер, введите номер от 1 до 4.";
}

string coordinates = Coordinates(q);
Console.WriteLine(coordinates);
