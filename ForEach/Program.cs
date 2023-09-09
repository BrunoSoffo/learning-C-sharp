int[] n = new int[3]{11,22,33};


//lendo os elementos de uma lista com For
for(int i=0; i<n.Length; i++){
    Console.WriteLine(n[i]);
}

//lendo os elementos de uma lista com foreach
//obs: o foreach n é indicado para inicializar, atribuir valores para um array, apenas para ler
foreach(int j in n){ //a variável do for precisa ser do mesmo tipo da lista
    Console.WriteLine(j);
}