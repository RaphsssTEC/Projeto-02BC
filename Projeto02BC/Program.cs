using Proj02;
using Projeto02BC;

internal class Program
{
    static void Main(string[] args)
    {
        TransacaoPix meuPix = new TransacaoPix();
        meuPix.valor = 15000;
        meuPix.chavePix = "raphael@teste.com";
        meuPix.contaOrigem = new ContaCorrente();
        meuPix.contaDestino = new ContaCorrente();

        TransacaoTed meuTed = new TransacaoTed();
        meuTed.valor = 6000;
        meuTed.contaOrigem = new ContaCorrente();
        meuTed.contaDestino = new ContaCorrente();

        Console.WriteLine($"PIX de R$ {meuPix.valor} é válido? {meuPix.validar()}");
        Console.WriteLine($"TED de R$ {meuTed.valor} é válido? {meuTed.validar()}");
    }
}
