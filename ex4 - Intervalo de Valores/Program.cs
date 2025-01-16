// Intervalo de Valores

Console.WriteLine("Digite um número : ");
int numero = int.Parse(Console.ReadLine());

if (numero < 1)
{
    Console.WriteLine($"O número não está entre 1 e 100: {numero}.");
}
else if (numero <= 100)
{
    Console.WriteLine($"O número está entre 1 e 100: {numero}.");
}

else
{

    Console.WriteLine($"Número acima de 100: {numero} ");
}