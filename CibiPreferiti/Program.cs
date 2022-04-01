
string[] CibiPreferiti = { "Pizza", "patatine", "sushi", "pollo", "tonno", "salmone" };

Console.WriteLine("i miei cibi preferiti sono:"+ CibiPreferiti.Length);
Console.WriteLine();


Console.WriteLine("questi sono i cibi preferiti :");

for (int i = 0; i < CibiPreferiti.Length; i++)
{
    Console.WriteLine(CibiPreferiti[i]);
}

Console.WriteLine();

Console.WriteLine("il mio  cibo preferito TOP : " + CibiPreferiti[0]);

Console.WriteLine();
Console.WriteLine("il mio cibo meno preferito tra i preferiti è :" +CibiPreferiti[5]);