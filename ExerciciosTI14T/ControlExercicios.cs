using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ControlExercicios
    {
        //Ligar as duas classes
        ModelExercicios model;
        private int opcao;
        public double bas;
        public double altura;
        public ControlExercicios()
        {
            model = new ModelExercicios();//Chamando o construtor da classe Model Exercicios
        }//fim do construtor

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }
        public void Menu()
        {
            Console.WriteLine("---- Menu ----\n\n" +
                             "\n1. Exercício 1" +
                             "\n2. Exercício 2" +
                             "\n3. Exercício 3" +
                             "\n4. Exercício 4" +
                             "\n5. Exercício 5" +
                             "\n6. Exercício 6" +
                             "\n7. Exercício 7" +
                             "\n8. Exercício 8" +
                             "\n9. Exercício 9" +
                             "\n10. Exercício 10" +
                             "\n11. Exercício 11" +
                             "\n12. Exercício 12" +
                             "\n13. Exercício 13" +
                             "\n14. Exercício 14" +
                             "\n15. Exercício 15" +
                             "\n16. Exercício 16" +
                             "\n17. Exercício 17" +
                             "\n18. Exercício 18" +
                             "\n19. Exercício 19" +
                             "\n20. Exercício 20" +
                             "\n0. Sair 0");
            Console.WriteLine("Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Executar()
        {
            Menu();
            //Executar a ação
            switch (ConsultarOpcao)
            {
                case 1:
                    Console.WriteLine(model.Exercicio01());
                    break;

                case 2:
                    Console.WriteLine("Informe um número");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("O antecessor de " + num + " é: " + model.Exercicio02(num));
                    break;

                case 3:
                    do
                    {
                        Console.WriteLine("Informe a Base: ");
                        bas = Convert.ToDouble(Console.ReadLine());
                        if (bas <= 0)
                        {
                            Console.WriteLine("Base digitada não é valida, tente novamente!");
                        }
                    } while (bas <= 0);

                    do
                    {
                        Console.WriteLine("Informe a Altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        if (altura <= 0)
                        {
                            Console.WriteLine("Altura digitada não é valida, tente novamente!");
                        }
                    } while (altura <= 0);

                            Console.WriteLine("A área do retângulo é: " + model.Exercicio03(bas, altura));
                    break;

                    case 4:
                        Console.WriteLine("Informe quanto anos você tem: ");
                    int ano = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe quantos meses você tem: ");
                    int mes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe quantos dias você tem: ");
                    int dia = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Sua idade em dias é: " + model.Exercicio04(ano, mes, dia));
                    break;

                case 8:
                    Console.WriteLine("Informe sua primeira nota: ");
                    double nota1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe sua segunda nota: ");
                    double nota2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe sua terceira nota: ");
                    double nota3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Sua nota final é: " + model.Exercicio08(nota1, nota2, nota3));
                    break;
                case 0:
                    Console.WriteLine("Obrigado!");
                    break;

                default:
                    Console.WriteLine("Código digitado não é valido!");
                    break;



            }//fim do switch
        }//fim do executar
    }//fim da classe
}//fim do projeto
