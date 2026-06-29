Console.Write("Qual é o seu nome?: ");
string nome = Console.ReadLine();


Console.Write("Qual é sua a idade?: ");
double idade = double.Parse(Console.ReadLine());

Console.Write("Olá jovem " + nome +" de " + idade + " de idade\n\n");

Console.Write("digite v para verdadeiro e f para falso\n");

Console.Write("Você ama o programador incrivel que fez esse código?: ");
bool c;

string resposta = Console.ReadLine();

c = resposta == "v";

if (c)
{
Console.Write("Muito obrigado!");
}
else
{
Console.Write("Estou triste");
}
