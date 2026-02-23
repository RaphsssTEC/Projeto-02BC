using Proj02;
using Projeto02BC;

internal class Program
{
    static void Main(string[] args)
    {
        Banco meuBanco = new Banco();
        meuBanco.nome = "Banco do Brasil";
        meuBanco.codigoBacen = "001";

        ContaBancaria remetente = new ContaBancaria();
        remetente.agencia = "AG001";
        remetente.numeroConta = "214325";
        remetente.setSaldo(2500);

        ContaBancaria destinatario = new ContaBancaria();
        destinatario.agencia = "AG005";
        destinatario.numeroConta = "217925";
        destinatario.setSaldo(3500);

        Transacao transacao = new Transacao();
        transacao.contaOrigem = remetente;
        transacao.contaDestino = destinatario;
        transacao.valor = 1500m;
        transacao.data = DateTime.Now;
        transacao.tipo = "PIX";

        Console.WriteLine("--- REGISTRO BACEN ---");
        Console.WriteLine("Banco: " + meuBanco.nome);
        Console.WriteLine("Código: " + meuBanco.codigoBacen);
        Console.WriteLine("----------------------");
        Console.WriteLine("TRANSFERÊNCIA");
        Console.WriteLine("Origem: " + transacao.contaOrigem.agencia + " - " + transacao.contaOrigem.numeroConta + " | Saldo: R$ " + transacao.contaOrigem.saldo);
        Console.WriteLine("Destino: " + transacao.contaDestino.agencia + " - " + transacao.contaDestino.numeroConta + " | Saldo: R$ " + transacao.contaDestino.saldo);
        Console.WriteLine("Tipo: " + transacao.tipo);
        Console.WriteLine("Valor: R$ " + transacao.valor);
        Console.WriteLine("Data: " + transacao.data);

        if (transacao.contaOrigem.saldo >= transacao.valor)
        {
            transacao.contaOrigem.setSaldo(transacao.contaOrigem.saldo - transacao.valor);
            transacao.contaDestino.setSaldo(transacao.contaDestino.saldo + transacao.valor);
            Console.WriteLine("----------------------");
            Console.WriteLine("TRANSFERÊNCIA REALIZADA");
            Console.WriteLine("Novo saldo origem: R$ " + transacao.contaOrigem.saldo);
            Console.WriteLine("Novo saldo destino: R$ " + transacao.contaDestino.saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente na conta de origem.");
        }
    }

}