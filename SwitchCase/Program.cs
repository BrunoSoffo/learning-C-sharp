int tempo;
char escolha;

inicio:  //label pata goto

Console.Clear();

Console.WriteLine("Belo Horizonte - MG e Vitória - ES");
Console.WriteLine("Escolha o meio de transporte: [a] Avião | [c] Carro | [o] Ônibus");

escolha = char.Parse(Console.ReadLine());

switch(escolha)
{
    case 'a':
    case 'A':
        tempo = 50;
        break;
    
    case 'c':
    case 'C':
        tempo = 480;
        break;
    
    case 'o':
    case 'O':
        tempo = 660;
        break;

    default:
        tempo = -1;
        break;
}

if(tempo<0)
{
    Console.WriteLine("Transporte indisponível");
}else{
    Console.WriteLine("Para o trnasporte escolhido o tempo é de {0} minutos", tempo);
}

Console.WriteLine("Calcular outro transporte? [s/n]");
escolha = char.Parse(Console.ReadLine());

if(escolha=='s' || escolha=='S'){
    goto inicio;

}else{
    Console.Clear();
    Console.WriteLine("Fim do programa");
}