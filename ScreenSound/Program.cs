// ScreenSound
string mensagem = "=== Seja bem vindo ao Screen Sound! ===";

// funções
void PularLinha()
{
    Console.WriteLine("\n");
}

void ExibirMensagemDeBoasVindas() 
{
    Console.WriteLine("=======================================");
    Console.WriteLine(mensagem);
    Console.WriteLine("=======================================");
    PularLinha();
}

void ExibirMenu()
{
    Console.WriteLine("Digite 1 para registrar uma Banda.");
    Console.WriteLine("Digite 2 para listar as Bandas cadastradas.");
    Console.WriteLine("Digite 3 para avaliar uma Banda");
    Console.WriteLine("Digite 4 para exibir a média de uma Banda");
    Console.WriteLine("Digite 5 para sair do programa.");
    PularLinha();
};

// main
ExibirMensagemDeBoasVindas();
ExibirMenu();

Console.Write("Digite a opção desejada: ");
int opcaoEscolhida = int.Parse(Console.ReadLine()!);

switch (opcaoEscolhida)
{
    case 1: Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
        break;
    case 2: Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
        break;
    case 3: Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
        break;
    case 4: Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
        break;
    default: Console.WriteLine("Você escolheu sair do programa!");
        break;
}
