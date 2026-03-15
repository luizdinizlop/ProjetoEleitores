int idade;

Console.WriteLine("Qual é a sua idade?");
idade = int.Parse(Console.ReadLine());

if (idade < 16)
    Console.WriteLine("Você não é eleitor.");
else if (idade >= 18 && idade <= 69)
    Console.WriteLine("Você é um eleitor orbigatório");
else
    Console.WriteLine("Você é um eleitor facultativo.");