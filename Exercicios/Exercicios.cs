void ExibirMensagem(string mensagem)
{
    Console.WriteLine($"\n==== {mensagem} ====");
};

ExibirMensagem("Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela Nota suficiente para aprovação");
int nota1 = 6;
int nota2 = 9;
int nota3 = 5;
int nota4 = 3;
int notaMedia = (nota1 + nota2 + nota3 + nota4) / 4;

if (notaMedia >= 6) 
{
    Console.WriteLine($"Sua média foi {notaMedia} e você foi aprovado!");
} else if (notaMedia < 6 && notaMedia >= 5)
{
    Console.WriteLine($"Sua média foi {notaMedia} e você está de recuperação!");
} else
{
    Console.WriteLine($"Sua média foi {notaMedia} e você foi reprovado!");
}

List<string> linguagens = ["C#", "Java", "JavaScript"];

ExibirMensagem("Exibir o valor C# no console, utilizando uma lista criada.");
Console.WriteLine(linguagens[0]);

ExibirMensagem("Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.");
Console.Write("Digite uma posição: ");
int posicao = int.Parse(Console.ReadLine()!);
Console.WriteLine(linguagens[posicao]);