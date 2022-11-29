int a,b;
Console.WriteLine("Введите два числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a == b*b){
    Console.WriteLine("Yes");
}
else {
    Console.WriteLine("No");
}