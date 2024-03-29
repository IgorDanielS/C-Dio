using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Models
{
    public class Pessoa
    {
        //construtores:
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        
        private string _nome;
        private string _sobrenome;
        private int _idade;
        public string Nome{ 
            
            get => _nome.ToUpper();
            // get{
            //     return _nome.ToUpper();
            // } 
            set{
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                _nome = value;
            } 
        }
        public int Idade{ 
            
            get => _idade;
            
            set{
                if(value < 0){
                    throw new ArgumentException("A idade não pode ser menor que 0.");
                }
                _idade = value;
            } 
        }
        public string Sobrenome { 
            get => _sobrenome.ToUpper(); 
            set => _sobrenome = value;
            }
        
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        // public string NomeCompleto { 
        //     get => Nome +  " " + Sobrenome;
        // } 

        public void Apresentar(){
        Console.WriteLine($"Olá, meu nome é {NomeCompleto}, e eu tenho {Idade} anos!");
    }

    }
}