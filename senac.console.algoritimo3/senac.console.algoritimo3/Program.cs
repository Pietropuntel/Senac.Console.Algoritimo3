using System.Globalization;
Console.Write("informe seu nome completo !");
// criar a variavel nome e recebe o seu valor
string nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.Write("quantos quartos tem na sua casa ? ");
// conververte o texto digitado para um numero int
int quartos = int.Parse(Console.ReadLine());
Console.Write("Informe o preco da sua internet !");
double precoInternet = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine();
Console.WriteLine("informe seu ultimo nome, ideda e altura");
// Puntel 15 1.75
string linha = Console.ReadLine();
// vetor de texto - divisão quando encontrar um espaco
string[] vetor = linha.Split(' ');
string sobreNome = vetor[0];
int idade = int. Parse(vetor[1]);
double altura = double.Parse(vetor[2]);
Console.WriteLine(nomeCompleto);
Console.WriteLine(quartos);
Console.WriteLine(precoInternet.ToString("F2"));
Console.WriteLine(sobreNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2"));

