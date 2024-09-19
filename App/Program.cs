using System;


Console.WriteLine("Hello World!");

Console.WriteLine("Olá, como posso ajudar?");
Console.WriteLine("1 - Acessar minha conta");
Console.WriteLine("2 - Registrar uma conta");
int escolhaInicial = int.Parse(Console.ReadLine());

double saldoLogado = 1412.69;
bool continuar = true;


/* bool registrar = true;     <---- VERIFICAR PARTE DE REGISTRO  */


    Console.Write("Digite a senha da conta (apenas números): ");
    int senhaEntrando = int.Parse(Console.ReadLine());
    Console.Write("Digite novamente a sua senha: ");
    int senhaEntrandoNovamente = int.Parse(Console.ReadLine());
    if (senhaEntrando == senhaEntrandoNovamente)

while (continuar)
{
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Olá, bem vindo(a)!");
    Console.WriteLine("O que você gostaria de fazer?");
    Console.WriteLine("1 - Verificar saldo");
    Console.WriteLine("2 - Enviar dinheiro");
    Console.WriteLine("3 - Receber dinheiro");


    /* Console.WriteLine("4 - Fechar script."); */

    
    Console.WriteLine("-----------------------------------");

    int escolhaLogado = int.Parse(Console.ReadLine());

    if (escolhaLogado == 1)
    {
        Console.WriteLine($"Você possui R${saldoLogado}");
        Console.WriteLine("Deseja voltar para o menu? (S/N)");
        string resposta = Console.ReadLine();
        if (resposta.ToLower() == "s")
        {
            continuar = true;
        }

        if (resposta.ToLower() == "n")
        {
            Console.WriteLine("Fechando script...");
            break;
        }

    }

    if (escolhaLogado == 2)
    {
        Console.WriteLine("Para quem você gostaria de enviar o dinheiro?");
        Console.WriteLine("1 - Mãe / SANTANDER");
        Console.WriteLine("2 - PAI / CAIXA ECONOMICA");
        Console.WriteLine("3 - AVÓ / ITAÚ");
        Console.WriteLine("4 - Voltar para o menu.");
        int enviarDinheiroQuem = int.Parse(Console.ReadLine());


        if (enviarDinheiroQuem == 1) 
{
        Console.WriteLine("Qual a quantia que deseja enviar?");
        double quantiaEnviarMae = double.Parse(Console.ReadLine());


    if (quantiaEnviarMae > saldoLogado)
        {
            Console.WriteLine("Você não tem dinheiro para fazer essa transação.");
        }


        else
        {
            Console.WriteLine($"A quantia de R${quantiaEnviarMae} foi enviada.");
            saldoLogado -= quantiaEnviarMae;
        }


    if (enviarDinheiroQuem == 2)
    {
        Console.WriteLine("Qual a quantia que deseja enviar?");
            double quantiaEnviarPai = double.Parse(Console.ReadLine());
                if (quantiaEnviarPai > saldoLogado)
                    {
                        Console.WriteLine("Saldo insuficiente para efetuar a transação.");
                    }

                else
                {
                    Console.WriteLine($"A quantia de R${quantiaEnviarPai} foi enviada.");
                    saldoLogado -= quantiaEnviarPai;
                }


        if (enviarDinheiroQuem == 3)
        {
            Console.WriteLine("Qual a quantia que deseja enviar?");
            double quantiaEnviarAvo = double.Parse(Console.ReadLine());
                if (quantiaEnviarAvo > saldoLogado)
                {
                    Console.WriteLine("Saldo insuficiente para efetuar a transação.");
                }
                else
                {
                    Console.WriteLine($"A quantia de R${quantiaEnviarAvo} foi enviada.");
                }
        }

        if (enviarDinheiroQuem == 4)
        {
            continue;
        }
    }

        /*
            if (escolhaLogado == 4)
            {
                Console.WriteLine("Fechando script...");        <----------------------------------------------------------------------
                {                                                               VERIFICAR ESSA PARTE DO CODIGO
                    continuar = false;                          <----------------------------------------------------------------------
                continuar = true;
            }
        */

}

    Console.WriteLine("Deseja fazer outra operação? (S/N)");
    string resposta = Console.ReadLine();
    if (resposta.ToLower() != "s")
    {
        continuar = false;
    }

}
}


/*
    while (registrar)
{

        Console.Write("Digite seu CPF: ");
        string cpfRegistro = Console.ReadLine();

        Console.WriteLine("Digite sua senha (apenas numeros)");
        int senhaNova = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite novamente sua senha.");
        int senhaNovaNovamente = int.Parse(Console.ReadLine());
        if (senhaNova == senhaNovaNovamente)

        // Sessão de conta nova
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Olá, bem vindo(a) CPF: {cpfRegistro}!");
        Console.WriteLine("O que você gostaria de fazer?");
        Console.WriteLine("1 - Verificar saldo");
        Console.WriteLine("2 - Enviar dinheiro");
        Console.WriteLine("3 - Receber dinheiro");
        Console.WriteLine("-----------------------------------");
        continue;

}
*/