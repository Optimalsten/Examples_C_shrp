// Факториал
// 5! = 5 * 4 * 3 * 2 * 1
//      5 * 4!
//          4 * 3!
//              3 * 2!
// т.е. функция, которая вызывает сама себя

double Factorial(int n)
{
    // 1! = 1 (кстати 0! = 1 тоже)
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");    
}
