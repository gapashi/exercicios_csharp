

/*Criar um programa que simule um sistema de login utilizando
 * um dicionário para armazenar nomes de usuário e senhas.
 
 Plus adicionado por conta e risco da dev: função de cadastro de novos usuários.*/

Dictionary<string, List<string>> infosLogin = new Dictionary<string, List<string>>();
infosLogin.Add("gapashi", new List<string> { "Fanfic123" });

MenuPrincipal();

void MensagemInicial()
{
    Console.WriteLine("\nNewMoon Fanfics");
    Console.WriteLine("\nBem-vindo!\n");
}

void MenuPrincipal()
{
    MensagemInicial();
    Console.WriteLine("Selecione a opção desejada:\n");
    Console.WriteLine("1 - Login");
    Console.WriteLine("2 - Cadastrar novo usuário");

    Console.Write("\nEscolha e aperte 'ENTER': ");

    string opcao = Console.ReadLine()!;
    int numero = int.Parse(opcao);

    switch(numero)
    {
        case 1: Login();
            break;
        case 2: Cadastro();
            break;
        default: Console.WriteLine("Opção inválida! Tente novamente");
            MenuPrincipal();
            break;
    }
}

void Login()
{
    Console.Clear();
    MensagemInicial();

    Console.Write("Usuário: ");
    string usuario = Console.ReadLine()!;

    Console.Write("Senha: ");
    string senha = Console.ReadLine()!;

    if (infosLogin.ContainsKey(usuario))
    {
        if(infosLogin[usuario].Contains(senha))
        {
            Console.WriteLine("Login feito com sucesso! Redirecionando...");
            Thread.Sleep(5000);
            Console.Clear();
            MenuPrincipal();
        }
        else
        {
            Console.WriteLine("Senha errada! Tente novamente.");
            Thread.Sleep(4000);
            Console.Clear();
            MenuPrincipal();
        }
    } else
    {
        Console.WriteLine("Usuário errado! Tente novamente.");
        Thread.Sleep(4000);
        Console.Clear();
        MenuPrincipal();
    }
}

void Cadastro()
{
    Console.Clear();
    MensagemInicial();

    Console.Write("Digite o nonme de usuário: ");
    string usuario = Console.ReadLine()!;

    if (!infosLogin.ContainsKey(usuario))
    {
        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine()!;

        infosLogin.Add(usuario, new List<string> { senha });
        Console.WriteLine($"Usuário {usuario} cadastrado com sucesso. Redirecionando...");
        Thread.Sleep(5000);
        Console.Clear();
        MenuPrincipal();
    }
    else
    {
        Console.WriteLine($"Usuário {usuario} já existe. Tente novamente.");
        Thread.Sleep(4000);
        Console.Clear();
        MenuPrincipal();
    }
}