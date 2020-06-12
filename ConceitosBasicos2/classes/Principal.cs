using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConceitosBasicos2
{
    class Principal
    {
        static void Main(string[] args)
        {
            Produto p = null;
            int op = 0;

            do
            {
                op = Menu();
                switch (op)
                {
                    case 1:
                        try
                        {
                            CadastrarProduto(p);
                        }
                        catch (ArgumentNullException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }                       
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                       

                        break;
                    case 2:


                        break;

                    case 3:

                        break;

                    case 4:

                        Console.WriteLine(" Programa encerrado ! \n");
                        break;
                }


            } while (op != 4);

            Console.Read();

        }


        public static int Menu()
        {
            Console.WriteLine(" Menu de Opções : \n" +
                "1- Cadastrar Produto : \n" +
                "2- Adicionar Produto : \n" +
                "3- Remover Produto : \n" +
                "4- Sair \n");

            return int.Parse(Console.ReadLine());
        }

        public static void CadastrarProduto(Produto p)
        {
           
                Console.WriteLine(" Entre com os dados do Produto \n");

              
                Console.WriteLine(" Entre com o preço do produto :");
                double preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // p.SetPreco(Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine(" Entre com a quantidade do estoque do produto :");
                int qtdEstoque = int.Parse(Console.ReadLine());
                //p.SetQtdEmEstoque(int.Parse(Console.ReadLine()));

                p = new Produto(preco, qtdEstoque);

               Console.WriteLine(" Entre com o nome do produto :");
               p.Nome = Console.ReadLine();

            // p.SetNome(Console.ReadLine());

            /* Sintaxe alternativa para criação de objeto sem utilizar os construtores 
             informando diretamente os valores 
            p = new Produto { Nome = " ventilador", Preco = 30, QtdEstoque = 2 }; */

            //MostrarProduto(p);
            ExibirProduto(p);
                AdicionarProduto(p);
                RemoverProduto(p);
           
           
        }

        public static void AdicionarProduto(Produto p)
        {
            Console.WriteLine(" Entre com a quantidade que será adicionada ao estoque : \n");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            //MostrarProduto(p);
            ExibirProduto(p);

        }

        public static void RemoverProduto(Produto p)
        {
            Console.WriteLine(" Entre com a quantidade que será removida do estoque : \n");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            MostrarProduto(p);
        }
       
         public static void ExibirProduto(Produto p)
         {
            Console.WriteLine("Dados do Produto : \n");
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.QtdEstoque);
            //Console.Write("\n");



        }


        public static void MostrarProduto(Produto p)
        {
            Console.WriteLine(" Produto :" + p);
            Console.WriteLine(" \n");
        }
    }
}

