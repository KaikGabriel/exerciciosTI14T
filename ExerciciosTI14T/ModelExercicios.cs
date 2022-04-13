using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ModelExercicios
    {
        //Declaração de variáveis
        private int A;
        private int B;
        private int C;

        //Declarar o construtor
        public ModelExercicios()
        {
            ConsultarA = 10;
            ConsultarB = 20;
            ConsultarC = 0;
        }//fim do construtor

        public int ConsultarA
        {
            get
            {
                return A;
            }
            set
            {
                this.A = value;
            }
        }//fim do consultarA

        public int ConsultarB
        {
            get
            {
                return B;
            }
            set
            {
                this.B = value;
            }
        }//fim do consultarB

        public int ConsultarC
        {
            get
            {
                return C;
            }
            set
            {
                this.C = value;
            }
        }//fim do consultarC

        //Método Exercício01
        public string Exercicio01()
        {
            ConsultarC = ConsultarA;
            ConsultarA = ConsultarB;
            ConsultarB = ConsultarC;
            return "A: " + ConsultarA + "\nB: " + ConsultarB;
        }//fim do métodoExercicio01

        public int Exercicio02(int num)
        {
            return num - 1;
        }//fim do métodoExercicio02

        public double Exercicio03(double bas, double altura)
        {
            return bas * altura;
        }

        public int Exercicio04(int mes, int ano, int dia)
        {
            return (ano * 365) + (mes * 30) + dia;
        }



        public double Exercicio08(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

    }//fim da classe
}//fim do projeto

