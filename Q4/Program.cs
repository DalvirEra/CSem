Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
try{
    Convert.ToInt32(a);
    if (a.Length == 3) Console.WriteLine(a[2]);
    else Console.WriteLine("Чото ни то");
}   
catch {Console.WriteLine("Чото ни то");}

Console.WriteLine("Второй вариант, полегче ");
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a%10);