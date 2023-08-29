// utilizando índice de variáveis no print

int n1,n2,n3;
double valorCompra = 5.5;
double ValorVenda;
double lucro=.1;
string produto="Banana";

n1=10; n2=20; n3=30;

ValorVenda = valorCompra+(valorCompra*lucro);

Console.WriteLine("n1={0}\nn2={1}\nn3={2}\n\n",n1,n2,n3); // utilizando {i} dentro do print, conseguimos organizar de melhor forma o print das variáveis

Console.WriteLine("Produto..........:{0,15}", produto); // O segundo valor dentro das {} corresponde ao espaço entre o texto e o valor da var. q será printado
Console.WriteLine("Val. Compra......:{0,15:c}", valorCompra); // O 'c' dentro das {} corresponde o formato de saída (monetário)
Console.WriteLine("Lucro............:{0,15:p}", lucro); // O 'p' dentro das {} corresponde o formato de saída (porcentagem)
Console.WriteLine("Val. Venda.......:{0,15:c}", ValorVenda);
