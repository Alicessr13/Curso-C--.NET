using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Teste
    {
        //Definição de um campo
        private string _nome; //normalmente se define private para não acesso diretamente ao campo, para controlar seu acesso
        //padrão se inicia o nome do campo com _ 

        private string _sobrenome;

        private int _idade;

        public string Cpf { get; set; } //a propriedade é o proprio campo, propriedade define-se public para poder ter acesso 

        //pode ser definido somente o get ou somente o set não precisa ter os 2 
        public int Ano { get; } = 2023; //só retorna o número, não define valores, ja vem com um valor padrão
        
        //definição de uma propriedade
        public string Nome { get { return _nome; } set {  _nome = value; } } //mesma coisa que o de baixo só que na mesma linha 

        public string Sobrenome //por padrão não acessamos os campos diretamente, utilizamos get e set
        {
            get
            {
                return _sobrenome; //retorna o valor de sobrenome 
            }
            set
            {
                _sobrenome = value; //atribui valor a sobrenome 
            }
        }

        public int Idade { get { return _idade; } 
            set {   //regra para definir o valor da idade
                    if(value <18)
                    {
                        Console.WriteLine("idade não pode ser inferior a 18 anos");
                    }
                    else
                    {
                        _idade = value;
                    }
                } 
        }

        public void Apresentar() 
        {
            if(_nome != "")
            {
                Console.WriteLine("Bem vindo " + _nome);
            }
        }
    }
}
