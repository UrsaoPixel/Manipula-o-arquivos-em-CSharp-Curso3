using ByteBankIO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var linhas = File.ReadAllLines("contas.txt");
        Console.WriteLine(linhas.Length);

        /*
        foreach (var linha in linhas) 
        {
            Console.WriteLine(linha);
        }
        */

        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"Arquivo contas.txt está com {bytesArquivo.Length} bytes");

        File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllTexte");
        
        Console.WriteLine("Aplicação Finalizada ...");

        Console.ReadLine();
    }
}
