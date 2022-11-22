// See https://aka.ms/new-console-template for more information
int n1, n2;
string? strn1, strn2;

Console.Write("Введите число 1: ");
strn1 = Console.ReadLine();
    
Console.WriteLine();

Console.Write("Введите число 2: ");
strn2 = Console.ReadLine();

Console.WriteLine();

n1 = Convert.ToInt32(strn1);
n2 = Convert.ToInt32(strn2);

int qn = n1 * n1;

if (qn == n2){
    Console.WriteLine("Квадрат числа (n1 * n1) = " + qn + " является квадратом числа n2: " + n2 );
    
}else{
    Console.WriteLine("Квадрат числа (n1 * n1) = " + qn + " НЕ является квадратом числа n2: " + n2 );
}

