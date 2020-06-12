/*Conceito de Properties, Auto Properties, Modificadores de acessos.
 * Propriedades
• São definições de métodos encapsulados, porém expondo uma
sintaxe similar à de atributos e não de métodos

Uma propriedade é um membro que oferece um mecanismo flexível para ler,
gravar ou calcular o valor de um campo particular. As propriedades podem ser
usadas como se fossem atributos públicos, mas na verdade elas são métodos
especiais chamados "acessadores". Isso permite que os dados sejam
acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade
dos métodos.
 
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConceitosBasicos2
{
    class Produto
    {
        // Conceito de encapsulamento

        //DECLARAÇÃO DE PROPRIEDADES COM AUTOIMPLEMENTED
        //É uma forma simplificada de se declarar propriedades que não
        //necessitam lógicas particulares para as operações get e set.  ex:
       
        private String _nome;
        //private double _preco;
        public double Preco { get; private set; }
        //private int _qtdEstoque;
        public int QtdEstoque { get; private set; }

    // Por convençaõ da linguagem c# atributos privados utilizam este padrão  _nome

    //Construtores 

    // Referenciando outro Construtor em um Construtor com o uso da palavra this

    public Produto() //Construtor padrão
    {
            //_qtdEstoque = 0;
            /*por padrão os atributos já recebem o valor zero*/
            QtdEstoque = 0;
    }

    public Produto(String nome, double preco) : this() /*  this() referencia o construtor padrão*/
    {
        _nome = nome;
            //_preco = preco;
            Preco = preco;
    }

    public Produto(String nome, double preco, int qtdEstoque) : this(nome, preco) /*  this(nome, preco) referencia o construtor Produto(String nome, double preco) */
    {
            //_qtdEstoque = qtdEstoque;
            QtdEstoque = qtdEstoque;
    }

     public Produto(double preco, int qtdEstoque)
     {
            if(preco>0 && qtdEstoque >= 0)
            {
                //_preco = preco;
                //_qtdEstoque = qtdEstoque;
                Preco = preco;
                QtdEstoque = qtdEstoque;
            }
            else
            {
                Console.WriteLine(" Preco ou QtdEstoque com valor invalido ! ");
            }

     }
                
        // Properties customizada

            public String Nome
            {
             get { return _nome; }
              set
              {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
                else
                {
                    Console.WriteLine(" Nome invalido !");
                }

 
              }
            }

       

        //public double Preco { get { return _preco; } }

        

       // public int QtdEmEstoque { get { return _qtdEstoque; } }
    

    public double ValorTotalEmEstoque()
    {
        return Preco * QtdEstoque;
    }

    public void AdicionarProdutos(int quantidade)
    {
            QtdEstoque += quantidade;
    }

    public void RemoverProdutos(int quantidade)
    {
        if (quantidade <= QtdEstoque)
        {
                QtdEstoque -= quantidade;
        }
        else
        {
            Console.WriteLine(" Quantidade no estoque menor que a solicitada ! \n");
        }


    }

    
    public override string ToString() //Retorna uma cadeira de caracteres que representa o objeto atual 
    {//Aqui definimos como o objeto será retornado na forma de String
        return _nome +
            ", $ " +
            Preco.ToString("F2", CultureInfo.InvariantCulture) +
            " " + QtdEstoque +
            " unidade, total : $ " +
            ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

    }

    /* * ToString - converte um objeto para String  
    * Utilizando o método ToString podemos escolher como o objeto será representado na forma de String*/

}
}
