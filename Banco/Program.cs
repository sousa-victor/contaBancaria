namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 9;
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