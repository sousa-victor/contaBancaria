using Banco.Model;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 9;

            /*Conta c1 = new Conta(1, 123, 1, "Gaspar", 1000000.0m);
            Conta c2 = new Conta(2, 321, 1, "Victor", 2300.0m);
            c1.Visualizar();
            c1.SetNumero(345);
            c1.Visualizar();

            c1.Sacar(1000);
            
            c1.Visualizar();

            c1.Depositar(5000);

            c1.Visualizar();*/

            ContaCorrente cc1 = new ContaCorrente(2, 123, 1, "Samantha", 100000000.00M, 1000);
            cc1.Visualizar();
            ContaCorrente cc2 = new ContaCorrente(3, 532, 1, "Daniel", 376.00m, 500);
            cc2.Visualizar();

            ContaPoupanca cp1 = new ContaPoupanca(65, 43, 2, "Victor", 320000.00m, 27);
            cp1.Visualizar();
            ContaPoupanca cp2 = new ContaPoupanca(54, 4, 2, "Gabriel", 500000.00m, 1);
            cp2.Visualizar();



            do
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("******************************************************************************************************");
                Console.WriteLine("*      _____  _____ _   _  ___________  ___ _____ _____ _____ _   _  ______  ___   _   _  _   __     *");
                Console.WriteLine("*     |  __ \\|  ___| \\ | ||  ___| ___ \\/ _ \\_   _|_   _|  _  | \\ | | | ___ \\/ _ \\ | \\ | || | / /     *");
                Console.WriteLine("*     | |  \\/| |__ |  \\| || |__ | |_/ / /_\\ \\| |   | | | | | |  \\| | | |_/ / /_\\ \\|  \\| || |/ /      *");
                Console.WriteLine("*     | | __ |  __|| . ` ||  __||    /|  _  || |   | | | | | | . ` | | ___ \\  _  || . ` ||    \\      *");
                Console.WriteLine("*     | |_\\ \\| |___| |\\  || |___| |\\ \\| | | || |  _| |_\\ \\_/ / |\\  | | |_/ / | | || |\\  || |\\  \\     *");
                Console.WriteLine("*      \\____/\\____/\\_| \\_/\\____/\\_| \\_\\_| |_/\\_/  \\___/ \\___/\\_| \\_/ \\____/\\_| |_/\\_| \\_/\\_| \\_/     *");
                Console.WriteLine("*                                                                                                    *");
                Console.WriteLine("******************************************************************************************************");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("                                 1 - Criar Conta");
                Console.WriteLine("                                 2 - Listar todas as Contas");
                Console.WriteLine("                                 3 - Buscar Conta por Numero");
                Console.WriteLine("                                 4 - Atualizar Dados da Conta");
                Console.WriteLine("                                 5 - Apagar Conta");
                Console.WriteLine("                                 6 - Sacar");
                Console.WriteLine("                                 7 - Depositar");
                Console.WriteLine("                                 8 - Transferir valores entre Contas");
                Console.WriteLine("                                 9 - Sair");
                Console.WriteLine();
                Console.WriteLine("******************************************************************************************************");
                
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Criar Conta\n\n");

                        break;
                    case 2:
                        Console.WriteLine("Listar todas as Contas\n\n");

                        break;
                    case 3:
                        Console.WriteLine("Consultar dados da Conta - por número\n\n");

                        break;
                    case 4:
                        Console.WriteLine("Atualizar dados da Conta\n\n");

                        break;
                    case 5:
                        Console.WriteLine("Apagar a Conta\n\n");

                        break;
                    case 6:
                        Console.WriteLine("Saque\n\n");

                        break;
                    case 7:
                        Console.WriteLine("Depósito\n\n");

                        break;
                    case 8:
                        Console.WriteLine("Transferência entre Contas\n\n");

                        break;

                    case 9:
                        Console.WriteLine("Programa encerrado!");
                        break;

                    default:
                        Console.WriteLine("\nOpção Inválida!\n");
                        break;
                }
            }
            while (opcao != 9);

            static void Sobre()
            {
                Console.WriteLine("\n*********************************************************");
                Console.WriteLine("Projeto Desenvolvido por: ");
                Console.WriteLine("Victor Patrick Reis de Sousa - victorprs@hotmail.com ");
                Console.WriteLine("github.com/sousa-victor");
                Console.WriteLine("*********************************************************");
            }
            Sobre();
        }
    }
}