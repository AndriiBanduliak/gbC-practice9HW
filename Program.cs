/*
Задача 68: Напишите программу вычисления
 функции Аккермана с помощью рекурсии. Даны 
 два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/

using static System.Console;
Clear();


int m = InputNumbers("Enter m: ");
int n = InputNumbers("Enter n: ");

int functionAkkerman = Ack(m, n);

Write($"Function of Akkerman is  {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Write(input);
  int output = Convert.ToInt32(ReadLine());
  return output;
}