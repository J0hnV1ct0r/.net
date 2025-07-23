// See https://aka.ms/new-console-template for more information
using fundamentos_net.models;

// string apresentacao = "Olá, mundo!";
// int numero = 10;
// double altura = 1.75;
// decimal preco = 19.99m;
// bool ativo = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine($"Número: {numero}");
// Console.WriteLine($"Altura: {altura}");
// Console.WriteLine($"Preço: {preco}");
// Console.WriteLine($"Ativo: {ativo}");
DateTime dataAtual = DateTime.Now.AddDays(-5).AddHours(2).AddMinutes(30);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm:ss"));

// Pessoa pessoa = new Pessoa
// {
//     Name = "gustavo",
//     Idade = 22
// };
// pessoa.Apresentar();
