
string[] CibiPreferiti = { "Pizza", "patatine", "sushi", "pollo", "tonno","salmone" };
 int mediana= CibiPreferiti.Length/2;


Console.WriteLine();

Console.WriteLine("i miei cibi preferiti sono:" + CibiPreferiti.Length);
Console.WriteLine();


Console.WriteLine("questi sono i cibi preferiti :");

for (int i = 0; i < CibiPreferiti.Length; i++)
{
    Console.Write(i + 1);
    Console.Write(":");
    Console.Write("  ");
    Console.WriteLine(CibiPreferiti[i]);
}

Console.WriteLine();

Console.WriteLine("il mio  cibo preferito TOP : " + CibiPreferiti[0]);

Console.WriteLine();

Console.WriteLine("il mio cibo meno preferito tra i preferiti è :" + CibiPreferiti[CibiPreferiti.Length - 1]);

Console.WriteLine();

if(CibiPreferiti.Length % 2 == 0)
{
    Console.WriteLine("il cibo di metà classifica è :");
        Console.WriteLine(CibiPreferiti[mediana - 1]);
    Console.WriteLine(CibiPreferiti[mediana]);
    
}
else
{
    Console.WriteLine("il cibo di metà classifica è :" + CibiPreferiti[mediana]);

}










