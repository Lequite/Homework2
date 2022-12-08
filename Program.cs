// Задание 1:
// int Test(){
//     int num = new Random().Next(100,1000);
//     Console.WriteLine(num);
//     int hund = num /100;
//     int ten = num /10 % 10;
//     int one = num % 10;
//     return (ten);
// }
// int res = Test();
// Console.WriteLine(res);



// Задание 2:
Console.Write("Введите Ваше число: ");
int n = Convert.ToInt32(Console.ReadLine());

void Test(){
    if(n > 99 && n < 999)
{
    Console.WriteLine(n % 10);
}
    else if(n > 999 && n < 9999)
{
    Console.WriteLine((n / 10) % 10);
}
else if(n > 9999 && n < 99999)
{
    Console.WriteLine((n / 100) % 10);
}
    else
    Console.WriteLine("Третье число не найдено.");
}
Test();



// Задание 3:
// Console.Write("Введи цифру, обозначающую день недели: ");
// int dayNum = Convert.ToInt32(Console.ReadLine());

// void WeekDay (int dayNum) {
//   if (dayNum == 6) {
//   Console.WriteLine("Этот день- выходной");
//   }
//   else if (dayNum == 7) {
//   Console.WriteLine("Этот день- выходной");
//   }
//   else if (dayNum < 1) {
//     Console.WriteLine("В неделе всего 7 дней!");
//   }
//   else if (dayNum > 7) {
//     Console.WriteLine("В неделе всего 7 дней!");
//   }
//   else Console.WriteLine("Этот день не выходной");
// }

// WeekDay(dayNum);
















// void Test(int a, int b){
// if (a>b){
//     Console.WriteLine($"{a} больше {b}");
// }
//     else{
//         Console.WriteLine($"{b} больше {a}");
//     }
// }

// int num1 = 6;
// int num2 = 5;
// Test(num1, num2);



// int Test (int a, int b){
//     if (a>b)
//         return a;
//     else
//         return b;
// }
// int num1 = 5;
// int num2 = 6;

// int result = Test(num1, num2);
// Console.WriteLine($"Результат - {result}");



// int Line(){
//     int num = new Random().Next(10,100);
//     Console.WriteLine($"Ваше число - {num}");
//     int dec = num /10;
//     int ed = num %10;
//     if (dec>ed)
//         return dec;
//     else if (dec == ed)
//         return ed;
//     else
//         return ed;
// }

// int res = Line();
// Console.WriteLine($"Большое число - {res}");



// void Test(){
//     int num = new Random().Next(100, 1000);
//     int num1 = num /100;
//     int num2 = num %10;
//     Console.WriteLine($"Ваше число сгенерированное - {num}");
//     Console.WriteLine($"Удалили вторую цифру числа - {num1} {num2}");
// }
// Test();



// int Test(){
//     int num = new Random().Next(100,1000);
//     Console.WriteLine(num);
//     int hund = num /100;
//     int ten = num /10 % 10;
//     int one = num % 10;
//     return ((hund*10) + one);
// }
// int res = Test();
// Console.WriteLine(res);



// void Test(int num1, int num2){
//     if (num2 % num1 == 0){
//         Console.WriteLine($"Число {num2} кратно числу {num1}");
//     }
//     else{
//         int res = num2 % num1;
//         Console.WriteLine($"Число {num2} не кратно числу {num1}. Остаток деления {res}");
//     }
// }
// Console.WriteLine("Введите первую переменную: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую переменную: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Test(num1, num2);

// void Test(int a, int b){
//     if ((a * a) == b){
//         Console.WriteLine("Первая переменная является квадратом второй переменной");
//     }
//     else if (b * b == a){
//         Console.WriteLine("Вторая переменная является квадратом первой переменной");
//     }
//     else
//         Console.WriteLine("Не является.");
// }
// Console.WriteLine("Введите первую переменную: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую переменную: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Test(a, b);