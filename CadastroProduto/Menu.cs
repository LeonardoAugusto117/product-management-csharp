class Menu {

    List<Produto> produtos = new List<Produto>();


    void exibirLogo()
    {
        Console.WriteLine(@"
 *    _________             .___                __                      .___       __________                   .___      __          
 *    \_   ___ \_____     __| _/____    _______/  |________  ____     __| _/____   \______   \_______  ____   __| _/_ ___/  |_  ____  
 *    /    \  \/\__  \   / __ |\__  \  /  ___/\   __\_  __ \/  _ \   / __ |/ __ \   |     ___/\_  __ \/  _ \ / __ |  |  \   __\/  _ \ 
 *    \     \____/ __ \_/ /_/ | / __ \_\___ \  |  |  |  | \(  <_> ) / /_/ \  ___/   |    |     |  | \(  <_> ) /_/ |  |  /|  | (  <_> )
 *     \______  (____  /\____ |(____  /____  > |__|  |__|   \____/  \____ |\___  >  |____|     |__|   \____/\____ |____/ |__|  \____/ 
 *            \/     \/      \/     \/     \/                            \/    \/                                \/                   
 ");
    }

   public void exibirMenu()
    {
        CadProdutoService cadProdutoService = new CadProdutoService();


        exibirLogo();

        Console.WriteLine("\n=== Menu de Cadastro de Produtos ===");
        Console.WriteLine();
        Console.WriteLine("1. Cadastrar Produto");
        Console.WriteLine("2. Listar Produtos");
        Console.WriteLine("3. Remover Produto");
        Console.WriteLine("4. Sair");
        Console.Write("Escolha uma opção: ");

        


        if (!int.TryParse(Console.ReadLine(), out int opcoes))
        {
            Console.WriteLine("Opção inválida.");
            Console.Clear();
            return;
        }

        switch (opcoes)
        {
            // no Menu
            case 1:
                cadProdutoService.CadastrarProduto(produtos);
                break;
            case 2:
                cadProdutoService.ListarProdutos(produtos);
                break;
            case 3:
                cadProdutoService.RemoveProdutoList(produtos);
                break;
            case 4:
                Console.WriteLine("Saindo do programa...");
                return;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        exibirMenu();
    }

   
}







