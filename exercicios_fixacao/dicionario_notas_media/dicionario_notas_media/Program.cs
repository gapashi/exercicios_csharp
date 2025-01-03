
Dictionary<string, List<int>> notasAluno = new Dictionary<string, List<int>>();
notasAluno.Add("Jorge Lima", new List<int> { 10, 6, 5, 7, 8 });
notasAluno.Add("Ana Clara da Silva", new List<int> { 6, 9, 5, 7, 6 });

MostrarMedia();

void Mensagem()
{
    Console.WriteLine("Bem-vindo ao sistema de média do Colégio ABC!\n");
}

void MostrarMedia()
{
    Mensagem();

    Console.Write("Digite o nome do aluno(a) que deseja visualizar a média: ");
    string nomeAluno = Console.ReadLine()!;

    if (notasAluno.ContainsKey(nomeAluno))
    {
        List<int> media = notasAluno[nomeAluno];
        Console.WriteLine($"\nA média do(a) aluno(a) {nomeAluno} é: {media.Average()}.");
        Console.Write("Digite qualquer tecla para voltar: ");
        Console.ReadKey();
        Console.Clear();
        MostrarMedia();
    }
    else
    {
        Console.WriteLine("\nO nome do aluno não se encontra em nossos registros");
        Console.Write("Digite qualquer tecla para voltar: ");
        Console.ReadKey();
        Console.Clear();
        MostrarMedia();
    }
}