using Gestor_de_clientes_do_CMD.Models;

class Program
{
    static List<Cliente> clientes = new List<Cliente>();
    enum Menu { Listagem = 1, Adicionar = 2, Remover = 3, Sair = 4 }

    static void Main(string[] args)
    {

        bool escolheuSair = false;

        while (!escolheuSair)
        {
            Console.WriteLine("\nSistema de clientes - Bem vindo!");
            Console.WriteLine("1. Listagem\n2. Adicionar\n3. Remover\n4. Sair\n");

            int intOp = int.Parse(Console.ReadLine());
            Menu opcao = (Menu)intOp;

            switch (opcao)
            {
                case Menu.Listagem:
                    Listagem();
                    break;

                case Menu.Adicionar:
                    Adicionar();
                    break;

                case Menu.Remover:

                    break;

                case Menu.Sair:
                    escolheuSair = true;
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
            Console.Clear();
        }
    }

    static void Listagem()
    {
        if (clientes.Count > 0)
        {
            Console.WriteLine("Lista de clientes: ");
            int i = 1;
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"ID: {i} ");
                Console.WriteLine($"Nome: {cliente.Nome} | Email: {cliente.Email} | CPF: {cliente.Cpf}\n==================================================");
                i++;
            }
        }
        else
        {
            Console.WriteLine("Nenhum cliente cadastrado");
        }

        Console.WriteLine("Aperte qualquer tecla para continuar.");
        Console.ReadKey();
    }

    static void Adicionar()
    {
        Cliente cliente = new Cliente();
        Console.WriteLine("Cadastro de Cliente: ");
        Console.WriteLine("Digite o nome: ");
        cliente.Nome = Console.ReadLine();

        Console.WriteLine("Digite o email: ");
        cliente.Email = Console.ReadLine();

        Console.WriteLine("Digite o cpf: ");
        cliente.Cpf = Console.ReadLine();

        clientes.Add(cliente);

        Console.WriteLine("\nCadastro concluído. Aperte qualquer tecla para continuar");
        Console.ReadKey();

    }
}