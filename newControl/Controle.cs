namespace PTI___Controle_de_Estoque;
class Program
{
    static void Main(string[] args)
    {
       
        //DECLARAÇÃO DA CLASSE PRODUTO
        Produto[] produtos = new Produto[5];

        int posicao = 0;
        int opcao = -1;

        
        //MENU
        while (opcao != 0)
        {
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("------------- CONTROLE DE ESTOQUE ------------");
        Console.WriteLine("----------------------------------------------");

        Console.WriteLine("[1] NOVO               [4] ENTRADA DE ESTOQUE");
        Console.WriteLine("[2] LISTAR PRODUTOS    [5] SAÍDA DE ESTOQUE");
        Console.WriteLine("[3] REMOVER PRODUTOS   [0] SAIR");

        opcao = Convert.ToInt32(Console.ReadLine());
        
        //1 = ADICIONAR UM NOVO PRODUTO
        if (opcao == 1)
        {
            Produto prod = new Produto();

         Console.WriteLine("\nDigite o Nome do produto: ");
         prod.Nome = Console.ReadLine();

         Console.WriteLine("\nDigite a quantia de entrada do produto: ");
         prod.Quantidade = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("\nDigite o Preço do produto: ");
         prod.Preco = double.Parse(Console.ReadLine());

         Console.WriteLine("\nDigite a Marca do produto: ");
         prod.Marca = (Console.ReadLine());

         Console.WriteLine("\nDigite o Código do produto: ");
         prod.Codigo = (Console.ReadLine());

         Console.WriteLine("\nDigite a data da Validade do produto: ");
         prod.Validade = (Console.ReadLine());

         Console.WriteLine(">>PRODUTO REGISTRADO<<");


         produtos [posicao] = prod;
         posicao++;

        }
         else if (opcao == 2)
        {
            for (int cont = 0; cont < posicao; cont++)
            
            {
                    Console.WriteLine(produtos[cont].Nome + " - Valor: R$ " + produtos[cont].Preco + " Quantidade em estoque: " + produtos[cont].Quantidade);
            }
        }

        else if (opcao == 3)
        {
          Console.WriteLine("\nDigite o Código do produto: ");
          string cod = (Console.ReadLine());

          
          int posicaoRemover = -1;
          for (int pos = 0; pos < posicao; pos++)
          {
            if (produtos[pos].Codigo == cod)
            {
              posicaoRemover = pos;
              break;
            }
          }

          if (posicaoRemover == (posicao - 1))
          {
            produtos[posicao - 1] = null;
            posicao--; 
          }
          else 
          {
            for (int pos = posicaoRemover +  1; pos < posicao; pos++)
            {
              produtos[pos - 1] = produtos[pos];
            }
            produtos[posicao - 1] = null;
            posicao--;
           }

           }



           else if (opcao == 4)
           {
           Console.WriteLine("\nDigite o Código do produto: ");
           string cod = Console.ReadLine();

            Console.WriteLine("\nDigite a quantidade de entrada do produto: ");
           int qtdEntrada = Convert.ToInt32(Console.ReadLine());

           bool produtoEncontrado = false;
           for (int i = 0; i < posicao; i++)
           {
           if (produtos[i].Codigo == cod)
           {
            produtos[i].Quantidade += qtdEntrada;
            produtoEncontrado = true;
            Console.WriteLine(">>ENTRADA DE PRODUTO REGISTRADA<<");
            break;
           }
           }

           if (!produtoEncontrado)
           {
           Console.WriteLine("Produto não encontrado!");
           }
           }

           
           else if (opcao == 5)
{
    Console.WriteLine("\nDigite o Código do produto: ");
    string cod = Console.ReadLine();

    Console.WriteLine("\nDigite a quantidade de saída do produto: ");
    int qtdSaida = Convert.ToInt32(Console.ReadLine());

    bool produtoEncontrado = false;
    for (int i = 0; i < posicao; i++)
    {
        if (produtos[i].Codigo == cod)
        {
            if (produtos[i].Quantidade >= qtdSaida)
            {
                produtos[i].Quantidade -= qtdSaida;
                produtoEncontrado = true;
                Console.WriteLine(">>SAÍDA DE PRODUTO REGISTRADA<<");
            }
            else
            {
                Console.WriteLine("Quantidade solicitada não disponível!");
            }
            break;
        }
    }

    if (!produtoEncontrado)
    {
        Console.WriteLine("Produto não encontrado!");
    }
}


        
       
           }  

            } 
           }