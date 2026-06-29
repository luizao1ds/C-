Console.WriteLine("Hello, World!");

Console.Write("Qual é sua a nota?: ");
double nota= double.Parse(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine("Aprovado!");
}
else if (nota >= 5)
{
    Console.WriteLine("Em recuperação.");
}
else
{
    Console.WriteLine("Reprovado.");
}