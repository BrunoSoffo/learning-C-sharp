// Exemplo de código para inputs string
string nome;

Console.WriteLine("Digite seu nome");
nome=Console.ReadLine();

Console.WriteLine("Seu nome é {0}",nome);



// Exemplo de código para valores numéricos
int v1, v2, soma;

Console.WriteLine("Digite o primeiro valor");
v1 = int.Parse(Console.ReadLine()); // Para passarmos um input numérico, é preciso converter o dado q escrevemos

Console.WriteLine("Digite o segundo valor");
v2 = Convert.ToInt32(Console.ReadLine()); // Outra forma de converter o input

soma = v1+v2;
Console.WriteLine("A soma de {0} + {1} é igual a {2}",v1, v2, soma);