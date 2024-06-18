using System.Text;
using System.Security.Cryptography;

string input = "ckczppom";
int output = -1;
string hash;

do
{
  output++;
  byte[] bytes = Encoding.ASCII.GetBytes(input + output);
  byte[] hash = MD5.Create().ComputeHash(bytes);

  hash = string.Join("", hash.Select(a => a.ToString("x2")));
} while (!hash.StartsWith("000000"));

Console.WriteLine(output);
