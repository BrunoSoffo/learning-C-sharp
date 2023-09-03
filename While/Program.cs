int[] num = new int[10];

int i = num.Length-1; // precisamos usae o -1 pois sem ele, o indice do array irá de 0 a 10, totalizando 11 posições

while(i>0){
    num[i]=i;
    Console.WriteLine(num[i]);
    i--;
}