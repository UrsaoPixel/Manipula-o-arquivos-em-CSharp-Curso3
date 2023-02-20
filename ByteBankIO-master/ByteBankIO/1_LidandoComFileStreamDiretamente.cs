using ByteBankIO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024]; //1KB

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            // Devoluções:
            // 0 número total de bytes lidos do buffer. Isso poderá ser menor que o número de
            // bytes solicitado se esse número de bytes não estiver disponível no momento, ou
            //zero, se o final do fluxo for atingido

            // public override int Read(byte[]array, int offset, int count);
            fluxoDoArquivo.Close();

            Console.ReadLine();
        }
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {

        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, bytesLidos);

        // public virtual string GetString(byte[], int index, int count);
        Console.Write(texto);

        /*
        foreach(var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
        */
    }
}