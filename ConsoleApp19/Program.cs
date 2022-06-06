using System.Linq;
int [] numer = { 9, 3, 4, 5, 6, 7, -8, -6, -7, -3, -5, 0 };
(int Min, int Max) GetExtremum(int[] array) => (array.Min(), array.Max());
Console.WriteLine(numer.Min()+numer.Max());