int[,] n = new int[3,5];  //linas x colunas
int[,] n = new int[2,2]{{10,20},{30,40}}; 

int linhas = 3;
int colunas = 4;
int[,] matriz = new int[linhas, colunas];

for (int i = 0; i < linhas; i++)
{
    for (int j = 0; j < colunas; j++)
    {
        // Atribuir um valor à célula da matriz
        matriz[i, j] = i * colunas + j + 1;
        Console.Write(matriz[i, j] + "\t"); // Imprime o elemento da matriz
    }
    Console.WriteLine(); // Pula para a próxima linha após cada linha da matriz
}
