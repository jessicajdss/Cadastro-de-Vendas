using System;
using System.IO;
using CadastroVendaPoo.classes;

namespace CadastroVendaPoo
{
    class Program
    {
        static void Main(string[] args)
        {      
            
        int opcao = 0;     
        
        while(opcao!=9){
           //Console.Clear();
           Console.WriteLine("###################################################");
           Console.WriteLine("#                                                 #");
           Console.WriteLine("#              Programa de Vendas                 #");
           Console.WriteLine("#                                                 #"); 
           Console.WriteLine("###################################################");
               
               Console.WriteLine("Informe:\n1 - Cadastro de Clientes\n2 - Cadastro de Produtos\n3 - Cadastro de Venda\n4 - Extrato de Cliente\n9 - Sair\n");
               opcao = int.Parse(Console.ReadLine());
               
               Console.Clear();
                switch(opcao){
                    case 1:

                        Console.WriteLine("Digite o nome do cliente:");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Digite o email do cliente:");
                        string email = Console.ReadLine();
                        
                        Console.WriteLine("Digite o cpf do cliente: ");
                        string cpf = Console.ReadLine();

                        Cliente cl = new Cliente(nome, email, cpf,DateTime.Now.Date);
                        SalvarCliente sc = new SalvarCliente();
                        //Console.WriteLine(new SalvarCliente().Salvar(cl));
                        Console.WriteLine(sc.Salvar(cl));
                        break;

                    case 2:

                        Console.WriteLine("Digite o código do produto:");
                        int codproduto = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o nome do produto:");
                        string nomeproduto = Console.ReadLine();

                        Console.WriteLine("Descreva o produto:");
                        string descricao = Console.ReadLine();

                        Console.WriteLine("Digite o preço do produto: R$ ");
                        double precoproduto = double.Parse(Console.ReadLine());

                        Produto pr = new Produto(codproduto,nomeproduto,descricao,precoproduto);
                        SalvarProduto sp = new SalvarProduto();
                        Console.WriteLine(sp.Salvar(pr));
                        
                        break;

                    case 3:
                        Console.WriteLine("Digite o cpf do cliente: ");
                        string cpfvenda = Console.ReadLine();

                        // StreamReader ex = null;
                        // ex = new StreamReader("cadProdutos.csv"); 
                        // int numeroLinhas = System.IO.File.ReadAllLines("cadProdutos.csv").Length; 
                        // string[,]dados = new string [numeroLinhas,4];

                        // for(int lin = 0;lin < dados.GetLength(0);lin++){
                        //     for(int col = 0; col < dados.GetLength(1);col++){
                        //         Console.WriteLine("\nLista de Produtos: ");
                        //         Console.Write("Código: "+ dados[lin,0]+"\t");
                        //         Console.Write("Produto: "+ dados[lin,1]+"\t");
                        //         Console.Write("Preço: "+ dados[lin,3]+"\t");
                        //     }
                        // }

                        Console.WriteLine("Digite o código do produto:");
                        int codprod_venda = int.Parse(Console.ReadLine());

                        Venda vv = new Venda(cpfvenda, codprod_venda, DateTime.Now.Date);
                        SalvarVenda sv = new SalvarVenda();
                        Console.WriteLine(sv.Salvar(vv));
 
                        break;


                    default:
                    break;
                }

           }

        }
    }
}
