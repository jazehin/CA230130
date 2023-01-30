using System.Security.Cryptography;
using System.Text;

string password = "Asdfgh123";

using SHA256 sha256 = SHA256.Create();

byte[] buffer = Encoding.ASCII.GetBytes(password);

byte[] hashValue = sha256.ComputeHash(buffer);

string hvs = String.Empty;
for (int i = 0; i < hashValue.Length; i++)
{
    hvs += $"{hashValue[i]:X2}";
    if ((i+1) % 4 == 0) hvs += " ";
}

Console.WriteLine($"input:  {password}");
Console.WriteLine($"output: {hvs}");