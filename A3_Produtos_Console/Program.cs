using System;
using System.Collections.Generic;

/// <summary>
/// Clase produto
/// </summary>
class Produto
{
    public int Id;
    public string Nome;
    public double Preco;
}

/// <summary>
/// MAIN
/// </summary>
class Program
{
    //Testing GItHub
    static List<Produto> produtos = new List<Produto>();

    //Variável estática que controla o identificador quando adicionamos um produto
    static int proximoId = 1;

    static void Main()
    {

        //Variavel que controla a saída do loop
        bool continuar = true;

        while (continuar)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Opções do menu
            Console.WriteLine("-----------OPÇÕES-----------");
            Console.WriteLine("");
            Console.WriteLine(" 1 - Adicionar");
            Console.WriteLine(" 2 - Listar");
            Console.WriteLine(" 3 - Atualizar");
            Console.WriteLine(" 4 - Remover");
            Console.WriteLine(" 5 - Sair");
            Console.WriteLine("");
            Console.WriteLine("----------------------------");

            Console.Write("Escolha uma opção: ");

            //Leitura da opção
            string opcao = Console.ReadLine();

            //Adicionar
            if (opcao == "1")
            {
                Console.WriteLine("=== Adicionar Novo Produto ===\n");

                Produto p = new Produto();
                p.Id = proximoId;
                Console.Write("Informe o nome do produto: ");
                p.Nome = Console.ReadLine();
                Console.Write("Informe o preço do produto: ");
                p.Preco = double.Parse(Console.ReadLine());
                produtos.Add(p);

                //Incremento da variável estática do ID
                proximoId++;
                Console.WriteLine("Produto adicionado com sucesso!!!");
            }

            //Listar
            else if (opcao == "2")
            {
                Console.WriteLine("=== Listar produtos cadastrados ===\n");
                for (int i = 0; i < produtos.Count; i++)
                {
                    Console.WriteLine("ID: " + produtos[i].Id + " Nome: " + produtos[i].Nome + " Preço: " + produtos[i].Preco);
                }
            }

            //Atualizar
            else if (opcao == "3")
            {
                Console.Write("ID do produto: ");
                int id = int.Parse(Console.ReadLine());
                Produto encontrado = null;
                for (int i = 0; i < produtos.Count; i++)
                {
                    if (produtos[i].Id == id)
                    {
                        encontrado = produtos[i];
                        break;
                    }
                }
                if (encontrado != null)
                {
                    Console.Write("Novo nome: ");
                    encontrado.Nome = Console.ReadLine();
                    Console.Write("Novo preço: ");
                    encontrado.Preco = double.Parse(Console.ReadLine());
                    Console.WriteLine("Produto atualizado.");
                }
                else
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }
            //Remover item
            else if (opcao == "4")
            {
                Console.Write("ID do produto: ");
                int id = int.Parse(Console.ReadLine());
                Produto encontrado = null;
                for (int i = 0; i < produtos.Count; i++)
                {
                    if (produtos[i].Id == id)
                    {
                        encontrado = produtos[i];
                        break;
                    }
                }
                if (encontrado != null)
                {
                    produtos.Remove(encontrado);
                    Console.WriteLine("Produto removido.");
                }
                else
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }

            //Sair
            else if (opcao == "5")
            {
                continuar = false;
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

            Console.WriteLine();
        }
    }
}
