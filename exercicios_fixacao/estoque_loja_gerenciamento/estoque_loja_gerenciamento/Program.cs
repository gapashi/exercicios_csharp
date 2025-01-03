
/*Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos
 * e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.*/

Dictionary<string, int> estoqueLoja = new Dictionary<string, int>();
estoqueLoja.Add("Arroz", 56);
estoqueLoja.Add("Feijão", 15);
estoqueLoja.Add("Coca-Cola", 87);
estoqueLoja.Add("Detergente", 32);

MensagemEntrada();

void MensagemEntrada()
{
    TituloLoja();
    Console.WriteLine("Bem-vindo ao sistema!");

    VisualizarEstoque();
}
void TituloLoja()
{
    Console.WriteLine("SUPERMERCADOS SHIBATA");
}

void VisualizarEstoque()
{
    Console.Write("\nDigite o nome do produto: ");
    string produto = Console.ReadLine()!;
    
    if(estoqueLoja.ContainsKey(produto))
    {
        int quantidade = estoqueLoja[produto];
        Console.WriteLine($"\nQuantidade em estoque: {quantidade}");
        Console.Write("\nDigite qualquer tecla para voltar: ");
        Console.ReadKey();
        MensagemEntrada();
    }
    else
    {
        Console.WriteLine($"\nProduto {produto} não registrado");
        Console.Write("\nDigite qualquer tecla para voltar: ");
        Console.ReadKey();
        MensagemEntrada();
    }
}