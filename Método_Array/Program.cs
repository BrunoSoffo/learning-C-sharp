int[] v1=new int[5];
int[] v2=new int[5];
int[] v3=new int[5];
int[] v4=new int[5];
int[,] v1=new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};

Random random=new Random();
for(int i=0; i<v1.Length;i++){
    v1[1]=random.Next(50);
}

Console.WriteLine("Elementos do vetor  1");
foreach (int n in v1)
{
    Console.WriteLine(n);
}