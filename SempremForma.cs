using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvPOO1
{
    internal class SempremForma
    {
        public class Pessoa
        {
            private double Peso;
            public double peso
            {
                get { return Peso; }
                set { Peso = value; }
            }

            private double Altura { get; set; }
            public double altura
            {
                get { return Altura; }
                set { Altura = value; }
            }
            private double IMC { get; set; }

            private string Nome;

            public string nome
            {
                get { return Nome; }
                set { Nome = value; }
            }


            public Pessoa(double peso, double altura, double imc)
            {
                Peso = peso;
                Altura = altura;
                IMC = imc;
            }
            public double calculaIMC()
            {
                IMC = Peso / (Altura * Altura);
                return IMC;
            }
            public void checkaIMC()
            {
                if (IMC < 18.5)
                {
                    Console.WriteLine("Seu IMC está BAIXO");
                }
                else if (IMC >= 18.5 && IMC < 25)
                {
                    Console.WriteLine("Seu IMC está NORMAL");
                }
                else
                {
                    Console.WriteLine("Seu IMC está ALTO");
                }
            }

        }
        
        
        
        static void Main(string[] args)
        {

            
            Pessoa p = new Pessoa(40,1.50,5);
            Console.WriteLine("Qual o seu peso?(em quilos)");
            p.peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o sua altura?(em metros)");
            p.altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu nome?");
            p.nome = Console.ReadLine();    
            
            Console.WriteLine(p.nome+", seu IMC é: {0}",p.calculaIMC());
            p.checkaIMC();
            Console.ReadKey();


        }
    }
}
