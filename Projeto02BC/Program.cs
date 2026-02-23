using Proj02;
using Projeto02BC;

internal class Program
{
    static void Main(string[] args)
    {
        TransacaoPix meuPix = new TransacaoPix();
        meuPix.valor = 15000;
        meuPix.chavePix = "contato@gemini.com";

        TransacaoTed meuTed = new TransacaoTed();
        meuTed.Valor = 6000;

        Console.WriteLine($"PIX de R$ {meuPix.valor} é válido? {meuPix.validar()}");
        Console.WriteLine($"TED de R$ {meuTed.valor} é válido? {meuTed.validar()}");
    }

}