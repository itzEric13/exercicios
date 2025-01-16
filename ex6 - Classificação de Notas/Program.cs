// Classificação de Notas 
// Crie um programa que peça a nota de um aluno e classifique a nota em categorias: "Excelente" (nota >= 9), "Boa" (7 <= nota < 9), "Regular" (5 <= nota < 7) e "Baixa" (nota < 5). Exiba a classificação na tela. 

Console.WriteLine("Digite sua nota : ");
double nota = double.Parse(Console.ReadLine());

if (nota <= 5) {
    Console.WriteLine($"Reprovado - Baixa"{nota);
}

else if (nota <= 7) { 
        Console.WriteLine($"Regular{nota} ");
}
