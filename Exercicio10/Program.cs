using System;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        List<bool> concluidas = new List<bool>();
        int opcao;

        Console.WriteLine("=== LISTA DE TAREFAS ===");

        do
        {
            Console.WriteLine("\nOpções:");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Marcar tarefa como concluída");
            Console.WriteLine("3 - Listar todas as tarefas");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            while (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.Write("Por favor, digite um número válido: ");
            }

            switch (opcao)
            {
                case 1: 
                    Console.Write("Digite a tarefa: ");
                    string novaTarefa = Console.ReadLine();
                    tarefas.Add(novaTarefa);
                    concluidas.Add(false);
                    Console.WriteLine("Tarefa adicionada!");
                    break;

                case 2: 
                    if (tarefas.Count == 0)
                    {
                        Console.WriteLine("Não há tarefas para marcar.");
                        break;
                    }

                    Console.WriteLine("\nTarefas pendentes:");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        if (!concluidas[i])
                        {
                            Console.WriteLine($"{i + 1} - {tarefas[i]}");
                        }
                    }

                    Console.Write("Digite o número da tarefa concluída: ");
                    int indice;
                    while (!int.TryParse(Console.ReadLine(), out indice) || indice < 1 || indice > tarefas.Count || concluidas[indice - 1])
                    {
                        Console.Write("Número inválido. Digite novamente: ");
                    }

                    concluidas[indice - 1] = true;
                    Console.WriteLine("Tarefa marcada como concluída!");
                    break;

                case 3: 
                    if (tarefas.Count == 0)
                    {
                        Console.WriteLine("Nenhuma tarefa cadastrada.");
                        break;
                    }

                    Console.WriteLine("\n=== LISTA DE TAREFAS ===");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = concluidas[i] ? "[CONCLUÍDA] " : "[PENDENTE]  ";
                        Console.WriteLine($"{i + 1} - {status}{tarefas[i]}");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 4);
    }
}
