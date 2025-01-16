// Verificação de Idade 

Console.WriteLine("Digite sua idade : ");
int idade = int.Parse(Console.ReadLine());

if (idade <= 0)
{
    Console.WriteLine($"Idade invalida: {idade}.");
}
else if (idade <= 17)
{
    Console.WriteLine($"Menor de idade: {idade}.");
}

else
{

    Console.WriteLine($"Maior de idade: {idade} ");
}