using System.Numerics;
using System.Security.Cryptography;

Console.WriteLine("praca z wielkimi liczbami:");
ulong wielka = ulong.MaxValue;
Console.WriteLine($"{wielka,40:N0}");
BigInteger wieksza = BigInteger.Parse("123456789012345678901234567890");
Console.WriteLine($"{wieksza,40:N0}");

Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");

Console.WriteLine("praca z liczbami zespolonymi");
Complex z1 = new(real: 4, imaginary: 2);
Complex z2 = new(real: 3, imaginary: 7);
var z3 = z1 + z2;
Console.WriteLine($"{z1} dodana do {z2} daje {z3}");
Console.WriteLine($"{0} + {1}i dodana to {2} + {3} i daje {4} + {5} i", z1.Real, z1.Imaginary, z2.Real, z2.Imaginary, z3.Real, z3.Imaginary);

Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");

Console.WriteLine("Rozdzial 8");
string miasto = "londyn";
Console.WriteLine($"{miasto} ma {miasto.Length} znaków");

Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");

Console.WriteLine($"pierwszy znak to {miasto[0]} a trzeci to {miasto[2]}");

Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");

Console.WriteLine("dzielenie ciągów znaków");
string miasta = "Paryż,Berlin,Lizbona,Warszawa,Nowy Jork, Tokyo, Oslo";
string[] tablicamiast = miasta.Split(',');
Console.WriteLine($"W kodzie zapisano {tablicamiast.Length} miast.");
foreach (string element in tablicamiast)
{
    Console.WriteLine(element);
}

Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");

string imieINazwisko = "Adam Nowak";
int indeksSpacji = imieINazwisko.IndexOf(' ');

string imie = imieINazwisko.Substring(startIndex: 0, length: indeksSpacji);

string nazwisko = imieINazwisko.Substring(startIndex: indeksSpacji + 1);
Console.WriteLine($"Oryginał: {imieINazwisko}");
Console.WriteLine($"Po zmianie: {nazwisko}, {imie} ");

Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");

string firma = "Microsoft";
bool zaczynasieod = firma.StartsWith("M");
bool zawieraN = firma.Contains("N");
Console.WriteLine($"Tekst: {firma}");
Console.WriteLine($"Zaczyna się od litery m: {zaczynasieod}, zawiera literę n: {zawieraN}");

Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");


