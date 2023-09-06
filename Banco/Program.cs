using Banco.Controller;
using Banco.Model;
using System.Threading.Channels;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, agencia, tipo, aniversario, numero, numeroDestino;
            string? titular;
            decimal saldo, limite, valor;

            ContaController contas = new();

            ContaCorrente cc1 = new ContaCorrente(1, 123, 1, "Samantha", 100000000.00M, 1000);
            contas.Cadastrar(cc1);
            ContaPoupanca cp1 = new ContaPoupanca(2, 321, 2, "Victor", 4251m, 27);
            contas.Cadastrar(cp1);



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

                // Tratamento de Exceção para impedir inserção de strings
                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }catch (FormatException) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Deve ser digitado um valor inteiro entre 1 e 9");
                    opcao = 0;
                    Console.ResetColor();
                }


                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine("Criar Conta\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Número da Agência: ");
                        agencia = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o Nome do Titular: ");
                        titular = Console.ReadLine();

                        titular ??= string.Empty;


                        do
                        {
                            Console.WriteLine("Digite o Tipo da Conta (1-CC ou 2-CP): ");
                            tipo = Convert.ToInt32(Console.ReadLine());
                        } while (tipo != 1 && tipo != 2);


                        Console.WriteLine("Digite o Saldo da Conta: ");
                        saldo = Convert.ToDecimal(Console.ReadLine());

                        switch (tipo)
                        {
                            case 1:
                                Console.WriteLine("Digite o Limite da Conta");
                                limite = Convert.ToDecimal(Console.ReadLine());

                                contas.Cadastrar(new ContaCorrente(contas.GerarNumero(), agencia, tipo, titular, saldo, limite));
                                break;

                            case 2:
                                Console.WriteLine("Digite o dia do Aniversário da Conta: ");
                                aniversario = Convert.ToInt32(Console.ReadLine());

                                contas.Cadastrar(new ContaPoupanca(contas.GerarNumero(), agencia, tipo, titular, saldo, aniversario));
                                break;
                        }
                        

                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Listar todas as Contas\n\n");
                        Console.ResetColor();
                        contas.ListarTodas();

                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Consultar dados da Conta - por número\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da Conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        contas.ProcurarPorNumero(numero);

                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Atualizar dados da Conta\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da conta\n\n");
                        numero = Convert.ToInt32(Console.ReadLine());

                        var conta = contas.BuscarNaCollection(numero);

                        if (conta != null)
                        {
                            Console.WriteLine("Digite o número da Agência: ");
                            agencia = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o Nome do Titular: ");
                            titular = Console.ReadLine();

                            titular ??= string.Empty;

                            Console.WriteLine("Digite o Saldo da Conta: ");
                            saldo = Convert.ToDecimal(Console.ReadLine());

                            tipo = conta.GetTipo();

                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("Digite o Limite da Conta: ");
                                    limite = Convert.ToDecimal(Console.ReadLine());
                                    contas.Atualizar(new ContaCorrente(numero, agencia, tipo, titular, saldo, limite));
                                    break;

                                case 2:
                                    Console.WriteLine("Digite o dia do Aniversário da Conta: ");
                                    aniversario = Convert.ToInt32(Console.ReadLine());
                                    contas.Atualizar(new ContaPoupanca(numero, agencia, tipo, titular, saldo, aniversario));
                                    break;
                            }
                        }
                        else{
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nConta não encontrada!");
                            Console.ResetColor();
                        }
                        
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Apagar a Conta\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da conta");
                        numero = Convert.ToInt32(Console.ReadLine());

                        contas.Deletar(numero);
                        Console.WriteLine($"A conta número {numero} foi excluída com sucesso");
                        

                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Saque\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da Conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o valor do Saque: ");
                        valor = Convert.ToDecimal(Console.ReadLine());

                        contas.Sacar(numero, valor);

                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Depósito\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da Conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o valor do Depósito: ");
                        valor = Convert.ToDecimal(Console.ReadLine());

                        contas.Depositar(numero, valor);

                        break;
                    case 8:
                        Console.WriteLine("Transferência entre Contas\n\n");

                        Console.WriteLine("Digite o número da Conta de Origem: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o número da Conta de Destino: ");
                        numeroDestino = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o valor da Transferência: ");
                        valor = Convert.ToDecimal(Console.ReadLine());

                        contas.Transferir(numero, numeroDestino, valor);

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