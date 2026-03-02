using Projeto02BC;
using Projeto02BC.Entidades;
using Projeto02BC.Entidades.Conversor;
using Projeto02BC.Entidades.transacao;
using Projeto02BC.Services;

internal class Program
{
    static void Main(string[] args)
    {
        TransacaoPix pix = new TransacaoPix();
        pix.valor = 15000;
        pix.chavePix = "raphael@teste.com";
        pix.contaOrigem = new ContaCorrente();
        pix.contaDestino = new ContaCorrente();

        TransacaoTed ted = new TransacaoTed();
        ted.valor = 6000;
        ted.contaOrigem = new ContaCorrente();
        ted.contaDestino = new ContaCorrente();

        Console.WriteLine($"PIX de R$ {pix.valor} é válido? {pix.validar()}");
        Console.WriteLine($"TED de R$ {ted.valor} é válido? {ted.validar()}");

        Console.WriteLine("Pix convertido em bilhões.");
        exibirRelatorio(pix.valor, new ConversorBilhoes());

        Console.WriteLine("Ted convertido em Trilhões.");
        exibirRelatorio(ted.valor, new ConversorTrilhoes());
    }

    static void exibirRelatorio(decimal valorBruto, IConversorGrandeza conversorGrandeza)
    {
        decimal valorConvertido = conversorGrandeza.converter(valorBruto);
        string simbolo = conversorGrandeza.getSimbolo();
        Console.WriteLine($"Valor bruto: R$ {valorBruto}");
        Console.WriteLine($"Valor convertido: {valorConvertido} {simbolo}");
    }
}
