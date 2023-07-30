// See https://aka.ms/new-console-template for more information
int[] dizi = {23, 12, 4, 86, 72, 3,11, 17};
foreach(var sayi in dizi)
{
    Console.WriteLine(sayi);
}
Array.Sort(dizi);
foreach(var sayi in dizi)
{
    Console.WriteLine(sayi);
}
Array.Clear(dizi,2,2);
foreach(var sayi in dizi)
{
    Console.WriteLine(sayi);
}
Array.Reverse(dizi);
foreach(var sayi in dizi)
{
    Console.WriteLine(sayi);
}
Console.WriteLine(Array.IndexOf(dizi, 23));
Array.Resize<int>(ref dizi, 9);
dizi[8] = 99;
foreach(var sayi in dizi)
{
    Console.WriteLine(sayi);
}