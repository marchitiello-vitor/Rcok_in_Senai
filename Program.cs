using System;
using System.Collections.Generic;

namespace logica
{
    class Program
    {
        static string respSim;
        static List<string> nomes = new List<string>();
        static void Main(string[] args)

        {

            Console.WriteLine("Bem vindo ao show Rock in SENAI!");
            do
            {
                Console.WriteLine("Qual é o seu nome, estrela do rock?");
                string nome = Console.ReadLine();
                nomes.Add(nome);
                Console.WriteLine("Qual a sua idade?");
                int idade = int.Parse(Console.ReadLine());


                if (idade >= 16)
                {
                    Console.WriteLine($"voce pode entrar");
                }
                else
                {

                    bool v = false;

                    do
                    {

                        Console.WriteLine($"voce tem " + idade + " e não pode participar. Tem para te acompanhar no show mais insano de sp alguns responsaveis? sim/não");
                        string resposta = Console.ReadLine().ToLower();


                        switch (resposta)
                        {
                            case "sim":
                                Console.WriteLine($"voce pode participar tambem então, mas tenha cuidado por favor, aproveita esta insana festança!!!");
                                // nomes.Add(nome);
                                v = true;
                                break;

                            case "nao":
                                Console.WriteLine($"voce não pode participar");
                                v = true;
                                break;

                            default:
                                Console.WriteLine($"digita uma opção validada!!!");
                                break;
                        }
                    } while (v == false);
                }

                Console.WriteLine($"deseja adicionar um amigo tambem? escreva s/nao para adicionar");
                respSim = Console.ReadLine();

            } while (respSim == "s");

            Console.WriteLine($"deseja rever a lista dos participantes? sim/nao");
            string participantes = Console.ReadLine();

            if (participantes == "sim")
            {
                ListarParticipantes();
            }

            Console.WriteLine($"obrigado!!");

            if (true)
            {

            }
            else
            {

            }
        }

        static void ListarParticipantes()
        {

            foreach (var cadaNome in nomes)
            {
                Console.WriteLine($"{cadaNome}");
            }

        }
    }
}


