int[] v1=new int[5];
int[] v2=new int[5];
int[] v3=new int[5];
int[,] matriz=new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};

Random random=new Random(); //gerar números aleatórios
for(int i=0; i<v1.Length;i++){
    v1[i]=random.Next(50); //geração de valores de 0 a 49
}

Console.WriteLine("Elementos do vetor  1");
foreach (int n in v1)
{
    Console.WriteLine(n);
}

//public static int BinarySearch(array,valor); // é um método da classe Array q retorna um int ralacionada a posição do elemento desejado (Obs: se o elemento n for encontrado o result é -1) 
Console.WriteLine("BinarySearch");
int procurado=33;
int pos=Array.BinarySearch(v1,procurado);
Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
Console.WriteLine("----------------------------------------------");

//public static void Copy(Ar_origen, Ar_destino, qtde_elementos); // é um método da classe Array, ele faz a cópia de elementos de um array para outro
Console.WriteLine("Copy");
Array.Copy(v1,v2,v1.Length);
foreach (int n in v2)
{
    Console.WriteLine(n);
}
Console.WriteLine("----------------------------------------------");

//public static void CopyTo(Ar_destino, a_partir_desta_pos); //método chamado a partir do vetor de origem
Console.WriteLine("CopyTo");
v1.CopyTo(v3,0);
foreach (int n in v3)
{
    Console.WriteLine(n);
}
Console.WriteLine("----------------------------------------------");

//public long GetLongLength(dimensão);
Console.WriteLine("GetLongLength");
long qtdeElementosVetor=v1.GetLongLength(0);
Console.WriteLine("Quantidade de elemnetos {0}", qtdeElementosVetor);
Console.WriteLine("----------------------------------------------");

//public int GetLowerBound(dimensão); // retorna o menor indice do array ouu matriz. Quando for um array, a dimensão será 0, de for matriz vc deverá indicar a dimensão
Console.WriteLine("GetLowerBound");
int MenorIndiceVetor=v1.GetLowerBound(0);
int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
Console.WriteLine("Menor índice do vetor 1 {0}", MenorIndiceVetor);
Console.WriteLine("----------------------------------------------");

//public int GetUpperBound(dimensão); // retorna o maior indice do array ouu matriz. Quando for um array, a dimensão será 0, de for matriz vc deverá indicar a dimensão
Console.WriteLine("GetUpperBound");
int MaiorIndiceVetor=v1.GetUpperBound(0);
int MaiorIndiceMatriz_D1=matriz.GetLowerBound(1);
Console.WriteLine("Maior índice do vetor 1 {0}", MaiorIndiceVetor);
Console.WriteLine("----------------------------------------------");

//public int GetValue(dimensão); // retorna um valor a partir de um índice. Ele retorna um object
Console.WriteLine("GetValue");
int valor0=Convert.ToInt32(v1.GetValue(3));
int valor1=Convert.ToInt32(matriz.GetValue(1,3));
Console.WriteLine("Valor da posição 3 no vetor 1 {0}", valor0);
Console.WriteLine("----------------------------------------------");

//public static int IndexOf(array, valor); // retorna o índice do valor desejado passado no parâmetro. Ele retorna o primeiro indice correspondente ao valor
Console.WriteLine("IndexOf");
int indice1=Array.IndexOf(v1,3);
Console.WriteLine("Índice do primeiro valor 3: {0}", indice1);
Console.WriteLine("----------------------------------------------");

//public static int LastIndexOf(array, valor); // retorna o índice do valor desejado passado no parâmetro. Ele retorna o último indice correspondente ao valor
Console.WriteLine("LastIndexOf");
int indice2=Array.LastIndexOf(v1,3);
Console.WriteLine("Índice do primeiro valor 33: {0}", indice2);
Console.WriteLine("----------------------------------------------");

//public static void Reverse(array); // esse método inverte as ordens dos elementos de um array
Array.Reverse(v1);
foreach(int n in v1)
{
    Console.WriteLine(n);
}

//public void SetValue(object valor, long pos); // permite definir um valor em uma posição no array
v2.SetValue(99,0); //setando 99 para a pos 0
for(int i=0; i<v2.Length;i++) //setando 0 para todas as posições
{
    v2.SetValue(0,i);
}
Console.WriteLine("Vetor 2");
foreach(int n in v2)
{
    Console.WriteLine(n);
}

//public static void Sort(array); // ordena em ordem crescente os elementos de uma lista
//para fazer decrescente, use os métodos Sort e depois o Reverse
Array.Sort(v1);
Array.Sort(v2);
Array.Sort(v3);
Console.WriteLine("Vetor 1");
foreach(int n in v1)
{
    Console.WriteLine(n);
}
Console.WriteLine("\nVetor 2");
foreach(int n in v2)
{
    Console.WriteLine(n);
}
Console.WriteLine("\nVetor 3");
foreach(int n in v3)
{
    Console.WriteLine(n);
}