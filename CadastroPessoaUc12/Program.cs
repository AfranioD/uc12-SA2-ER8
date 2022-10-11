using CadastroPessoaUc12.Classes;

Console.Clear();
Console.WriteLine(@$"
=============================================
|    Bem vindo ao sistema de cadastro de    | 
|        Pessoas Físicas e Juridícas.       |
=============================================
");

Utils.BarraCarregamento("Iniciando", 100, 40);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
=============================================
|        Escolha uma das opções abaixo:     |
|-------------------------------------------|   
|            1 - Pessoa Física              |
|            2 - Pessoa Juridíca            |
|                                           |
|            0 - Sair                       |
=============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            string? opcaoPf;

            do
            {

                Console.Clear();
                Console.WriteLine(@$"
=============================================
|        Escolha uma das opções abaixo:     |
|-------------------------------------------|   
|            1 - Cadastrar Pessoa Física    |
|            2 - Listar Pessoas Física      |
|                                           |
|            0 - Voltar ao menu anterior    |
=============================================
");
                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar:");
                        novaPf.Nome = Console.ReadLine();

                        // bool dataValida;
                        // do
                        // {
                        //     Console.WriteLine($"Digite a data de nascimento Ex: DD/MM/AAAA");
                        //     string? dataNascimento = Console.ReadLine();

                        //     dataValida = metodosPf.ValidarDataNasc(dataNascimento);

                        //     if (dataValida)
                        //     {
                        //         DateTime DataConvertida;
                        //         DateTime.TryParse(dataNascimento, out DataConvertida);

                        //         novaPf.dataNasc = DataConvertida;
                        //     }
                        //     else
                        //     {
                        //         Console.ForegroundColor = ConsoleColor.DarkRed;
                        //         Console.WriteLine($"Data digitada inválida, por favor digite uma data válida");
                        //         Console.ResetColor();
                        //         Thread.Sleep(3000);

                        //     }

                        // } while (dataValida == false);

                        // Console.WriteLine($"Digite o número do CPF");
                        // novaPf.Cpf = Console.ReadLine();

                        // Console.WriteLine($"Digite o rendimento mensal (DIGITE SOMENTE NUMEROS)");
                        // novaPf.Rendimento = float.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o logradouro");
                        // novoEndPf.Logradouro = Console.ReadLine();

                        // Console.WriteLine($"Digite o numero");
                        // novoEndPf.numero = int.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio)");
                        // novoEndPf.complemento = Console.ReadLine();

                        // Console.WriteLine($"Este endereço é comercial? S/N");
                        // string endCom = Console.ReadLine().ToUpper();

                        // if (endCom == "S")
                        // {
                        //     novoEndPf.endComercial = true;
                        // }
                        // else
                        // {
                        //     novoEndPf.endComercial = false;
                        // }
                        // novaPf.Endereco = novoEndPf;

                        // listaPf.Add(novaPf);


                        // StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt");
                        // sw.WriteLine(novaPf.Nome);
                        // sw.Close();


                        using (StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt"))
                        {
                            sw.WriteLine(novaPf.Nome);
                        }


                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":

                        Console.Clear();

                        //                         if (listaPf.Count > 0)
                        //                         {
                        //                             foreach (PessoaFisica cadaPessoa in listaPf)
                        //                             {
                        //                                 Console.Clear();
                        //                                 Console.WriteLine(@$"                                                             
                        // Nome: {cadaPessoa.Nome}
                        // Endereço: {cadaPessoa.Endereco.Logradouro}, {cadaPessoa.Endereco.numero}
                        // Imposto a ser pago: {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C")}
                        // ");

                        //                                 Console.WriteLine($"Aperte 'ENTER' para continuar");
                        //                                 Console.ReadLine();

                        //                             }
                        //                         }
                        //                         else
                        //                         {
                        //                             Console.WriteLine($"Lista vazia");
                        //                             Thread.Sleep(3000);

                        //                         }

                        using (StreamReader sr = new StreamReader("Afranio.txt"))
                        {
                            string linha;
                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                            }
                        }

                        Console.WriteLine($"Aperte 'ENTER' para continuar");
                        Console.ReadLine();


                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida, por favor digite uma opção válida.");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;
                }


            } while (opcaoPf != "0");

            //condicao ? "Sim" : "Não"

            // exemplo de concatenação e interpolação
            // Console.WriteLine($"Nome: {novaPf.Nome} nome: {novaPf.Nome}");
            // Console.WriteLine("Nome: " + novaPf.Nome + "Nome: " + novaPf.Nome);


            break;

        case "2":

            string? opcaoPj;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=============================================
|        Escolha uma das opções abaixo:     |
|-------------------------------------------|   
|            1 - Cadastrar Pessoa Juridíca  |
|            2 - Listar Pessoas Juridícas   |
|                                           |
|            0 - Voltar ao menu anterior    |
=============================================                           
");

                opcaoPj = Console.ReadLine();
                PessoaJuridica metodosPj = new PessoaJuridica();

                switch (opcaoPj)
                {
                    case "1":

                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa juridíca que deseja cadastrar:");
                        novaPj.Nome = Console.ReadLine();

                        Console.WriteLine($"Digite a razão social da empresa:");
                        novaPj.RazaoSocial = Console.ReadLine();

                        Console.WriteLine($"Digite o número do CNPJ:");
                        novaPj.Cnpj = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (Apenas números)");
                        novaPj.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro:");
                        novoEndPj.Logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");
                        novoEndPj.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio)");
                        novoEndPj.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPj.endComercial = true;
                        }
                        else
                        {
                            novoEndPj.endComercial = true;
                        }

                        novaPj.Endereco = novoEndPj;

                        listaPj.Add(novaPj);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        metodosPj.Inserir(novaPj);


                        List<PessoaJuridica> ListaPj = metodosPj.LerArquivo();

                        break;


                    case "2":

                        Console.Clear();

                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica cadaPj in listaPj)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
Nome: {cadaPj.Nome}
Razão Social: {cadaPj.RazaoSocial}
CNPJ: {cadaPj.Cnpj}, Válido: {(metodosPj.ValidarCnpj(cadaPj.Cnpj) ? "Sim" : "Não")}
Endereço: {cadaPj.Endereco.Logradouro}, {cadaPj.Endereco.numero}, {cadaPj.Endereco.complemento}
Endereço Comercial: {(cadaPj.Endereco.endComercial ? "Sim" : "Não")}
Rendimento: {cadaPj.Rendimento} 
Imposto Devido: {metodosPj.PagarImposto(cadaPj.Rendimento).ToString("C")}                                                              
");

                                Console.WriteLine($"Opção Incorreta"!);
                                Console.ReadLine();
                                Console.ResetColor();

                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Lista Vazia!");
                            Thread.Sleep(3000);
                            Console.ResetColor();
                        }
                        break;


                    case "0":

                        break;

                    default:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida, por favor digite uma opção válida!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                }
                Console.ResetColor();
            } while (opcaoPj != "0");

            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");
            Thread.Sleep(1500);
            Utils.BarraCarregamento("Finalizando", 500, 20);

            break;

        default:

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção Inválida, por favor digite uma opção válida!");
            Console.ResetColor();
            Thread.Sleep(3000);

            break;
    }


} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo, int quantidade)
{
    //Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.DarkMagenta;

    System.Console.Write(texto);

    for (var contador = 0; contador < quantidade; contador++)
    {
        Console.Write(".");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}
