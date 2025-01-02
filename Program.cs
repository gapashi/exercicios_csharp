// SCREEN SOUND
// O C# é uma linguagem fortemente tipada, ou seja, sempre é necessário declarar o tipo de dado das variáveis
string mensagemBoasVindas = "\nBoas vindas ao Screen Sound"; //toda instrução no C# precisa terminar com ';' + variável deve ser declarada sempre antes de ser usada
//List<string> BandasRegistradas = new List<string> { "BABYMETAL", "Ghost", "POWERWOLF" }; //precisa-se definir o tipo de dados que vai compor a lista, neste caso strings
// referente a lista, caso precise que ela comece vazia, colocar parenteses no final (); se ela deve começar com algum valor, colocar os valores entre chaves {}

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("BABYMETAL", new List<int> { 10, 5, 9 });
bandasRegistradas.Add("Linkin Park", new List<int>());

ExibirMensagem();

//Quando a função não tem retorno, usa-se a palavra "void" no início da função
//O padrão de nomenclatura utilizada para escrever o nome das funções é PascalCase
void ExibirMensagem()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemBoasVindas); //ao trabalhar com variáveis, deve-se usar o padrão Camel Case
    
} //verbatim literal = @ para poder colcoar a string do jeito que você que ela apareça, caso a exibição seja diferente como a do caso acima

void Logo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; //O ponto de exclamação é colocado para que a resposta do ReadLine não venha nula
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida); //Parse: função que pega uma variável string e tenta converter para int

    switch (opcaoEscolhidaNum)
    {
        case 1: RegistrarBandas(); break; //palavra reservada para finalizar a opção do case
        case 2: ListarBandasRegistradas(); break;
        case 3: AvaliarBanda(); break;
        case 4: ExibirMedia(); break;
        case -1: Console.WriteLine("Finalizando o programa"); break;
        default: Console.WriteLine("Opção inválida. Tente novamente."); break;
    }
}

string cursoDev = "\nCriando sua primeira aplicação com CSharp";
string nome = "Gabriella";
string sobrenome = "Shibata";

Console.WriteLine(cursoDev);
Console.WriteLine(nome + " " + sobrenome);
 
// O C# é uma linguagem Case Sensitive, ou seja, se escrever a função em letras maiusculas e chamar em minusculas, ele não vai achar
void RegistrarBandas()
{
    Console.Clear();
    Logo();
    DecoracaoTitulo("Registro das bandas:\n");
    Console.Write("Digite o nome da banda a ser cadastrada: ");

    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso"); //essa é a sintaxe de interpolação de string que permite variáveis diretamente em uma string usando chaves {}
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    //BandasRegistradas.Add(nomeDaBanda); //o .Add serve para adicionar itens à lista criada de forma global

    Thread.Sleep(2000); //função que faz o código aguardar, nesse caso 2 milissegundos, para depois continuar executando os comandos
    Console.Clear();
    ExibirMensagem();
    ExibirOpcoesMenu();
}

void ListarBandasRegistradas()
{
    Console.Clear();
    Logo();
    DecoracaoTitulo("Bandas Registradas:\n");

    //no bandasRegistradas.Keys, o .Keys está especificando que o foreach deve pegar apenas os valores das Keys do dicionário
    foreach (string banda in bandasRegistradas.Keys) // "para cada item (tipo de dado variável "na/no" Dicionário) executar X comando"
    {
        Console.WriteLine($"Banda: {banda}");
    }

    //for (int i = 0; i < BandasRegistradas.Count; i++)  //enquanto o i for menor que a contagem das bandas da lista, enquanot eu tiver banda, continua executando isso e a cada loop feito, incrementa 1 na lista
    //{
    //    Console.WriteLine($"Banda: {BandasRegistradas[i]}");
    //} //esse é o loop for tradicional utilizado nas codificações; também econtrado e visto em Python e JavaScript (nota mental)

    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirMensagem();
    ExibirOpcoesMenu();
}

void DecoracaoTitulo(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string decoracao = string.Empty.PadLeft(quantidadeLetras, '#');
    Console.WriteLine(decoracao);
    Console.WriteLine(titulo);
}


void AvaliarBanda()
{

    //Como vai fucnionar essa função?:
    //1 - campo para pesquisa da banda que se deseja avaliar;
    //2 - precisamos saber se a banda existe, então precisa buscar no dicionário
    //3 - se a banda existir, poderá atribuir nota
    //4 - se a banda não existir, exibir mensagem de alerta e voltar ao menu principal

    Console.Clear();
    Logo();
    DecoracaoTitulo("Avaliar banda:\n");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda)) //metodo utilizado para verificar se aquela chave/item contém no dicionario
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"/nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
        Thread.Sleep(5000); 
        Console.Clear();
        ExibirMensagem();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nERRO: A banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
        ExibirMensagem();
        ExibirOpcoesMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    Logo();
    DecoracaoTitulo("Exibir média da banda:\n");
    Console.Write("Digite o nome da banda que deseja exibir a média de avaliações: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notas = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média de avaliações da banda {nomeDaBanda} é {notas.Average()}."); //o metodo Average eh pertecncente ao C# e realiza a media diretamente
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
        ExibirMensagem();
        ExibirOpcoesMenu();
    } else
    {
        Console.WriteLine($"\nERRO: A banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
        ExibirMensagem();
        ExibirOpcoesMenu();
    }
}

ExibirOpcoesMenu();

