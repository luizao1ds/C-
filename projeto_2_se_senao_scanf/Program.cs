Console.Write("Qual é o seu nome?: ");
string nome = Console.ReadLine();


Console.Write("Qual é sua a idade?: ");
double idade = double.Parse(Console.ReadLine());

Console.Write("Olá jovem " + nome +" de " + idade + " de idade\n\n");

Console.Write("digite v para verdadeiro e f para falso\n");

string resposta;

Console.Write("Você ama o programador incrivel que fez esse código?: ");
resposta = Console.ReadLine();

switch (resposta)
{
    case "v":
        Console.WriteLine("Muito obrigado!");
        break;

    case "f":
        Console.WriteLine("Estou triste");
        break;

    default:
        Console.WriteLine("Desculpe, não entendi.");
        break;
}
