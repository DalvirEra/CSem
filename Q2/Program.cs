int i = 1;
do {
    i = 1;
Console.WriteLine("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1){
    Console.WriteLine("ПОНИдельник");
}
else if (a == 2) {
    Console.WriteLine("вТОрНИК");
}
else if (a == 3) {
    Console.WriteLine("Окружающая СРЕДА");
}
else if (a == 4) {
    Console.WriteLine("Четвертый Верг");
}
else if (a == 5) {
    Console.WriteLine("Пятница-развратница");
}
else if (a == 6) {
    Console.WriteLine("СУБбота");
}
else if (a == 7) {
    Console.WriteLine("ВОСКРЕС и нье");
}


switch (a) {
case 1:
    Console.WriteLine("ПОНИдельник");
    break;
case 2:
    Console.WriteLine("вТОрНИК");
    break;
case 3:
    Console.WriteLine("Окружающая СРЕДА");
    break;
case 4:
    Console.WriteLine("Четвертый Верг");
    break;
case 5:
    Console.WriteLine("Пятница-развратница");
    break;
case 6:
    Console.WriteLine("СУБбота");
    break;
case 7:
    Console.WriteLine("ВОСКРЕС и нье");
    break;
default:
    Console.WriteLine("ЭТО НЕ ТО");
    i = 0;
    break;
}
}
while (i != 1);