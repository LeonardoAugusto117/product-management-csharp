class CadProdutoService
{
    public void CadastrarProduto(List<Produto> produtos)
    {
        
        Console.Clear();
        ExibirTituloDaOpcao("Cadastro do Produto");
        var opcao = "1";

        while (opcao == "1") {

            Produto produto = new Produto();

            Console.Write("Nome do produto: ");
            produto.Nome = Console.ReadLine();

            if (produtos.Exists(p => p.Nome.Equals(produto.Nome, StringComparison.OrdinalIgnoreCase)))
            {
                Console.Clear();
                Console.WriteLine("Já existe um produto com esse Nome. Por favor, tente novamente.");
                Console.WriteLine();
                Console.WriteLine("Deseja Refazer o cadastro ?");
                Console.WriteLine("1 - Sim / 2 - Não");
                opcao = Console.ReadLine();
                Console.Clear();
                continue;
            }

            Console.Write("Código do produto: ");
            produto.Codigo = Console.ReadLine();

            if (produtos.Exists(p => p.Codigo.Equals(produto.Codigo, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Já existe um produto com esse Código. Por favor, tente novamente.");
                Console.WriteLine();
                Console.WriteLine("Deseja Refazer o cadastro ?");
                Console.WriteLine("1 - Sim / 2 - Não");
                opcao = Console.ReadLine();
                Console.Clear();
                continue;

            }

            Console.Write("Preço: ");
            decimal.TryParse(Console.ReadLine(), out decimal preco);
            produto.Preco = preco;

            produtos.Add(produto);

            Console.WriteLine("Produto cadastrado com sucesso!");
            Console.WriteLine("Deseja cadastrar outro Produto? (1 - Sim / 2 - Não)");

            opcao = Console.ReadLine();
            Console.Clear();
        }

    }

    public void ListarProdutos(List<Produto> produtos)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Lista dos produtos");

        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
            return;
        }

        foreach (var produto in produtos)
        {
            Console.WriteLine(produto.Descricao);
        }

        Console.WriteLine("\nAperte qualquer tecla para voltar");
        Console.ReadKey();
    }

    public void RemoveProdutoList(List<Produto> produtos) 
    { 
        Console.Clear(); ExibirTituloDaOpcao("Remover Produto"); 
        var opcao = "1"; 
        
        while (opcao == "1") 
        
        { 
            Produto produto = new Produto(); Console.Write("Informe o nome do produto: "); 
            produto.Nome = Console.ReadLine(); 

            produtos.RemoveAll(p => p.Nome.Equals(produto.Nome, StringComparison.OrdinalIgnoreCase)); 

            Console.WriteLine("Produto removido com sucesso!"); 
            Console.WriteLine("Deseja cadastrar outro Produto? (1 - Sim / 2 - Não)"); 
            opcao = Console.ReadLine();
            Console.Clear(); 
        } 
    }



    void ExibirTituloDaOpcao(string titulo)
    {
        // Colocar o asteriscos do tamanho da frase
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

}
