class Menu {

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
        Console.WriteLine("3. Sair");
        Console.Write("Escolha uma opção: ");

        if (!int.TryParse(Console.ReadLine(), out int opcoes))
        {
            Console.WriteLine("Opção inválida.");
            Thread.Sleep(1000);
            exibirMenu();
            Console.Clear();
            return;
        }

        switch (opcoes)
        {
            // no Menu
            case 1:
                new CadProdutoService().CadastrarProduto();
                break;

            case 2:
                new CadProdutoService().ListarProdutos();
                break;


            case 3:
                return;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

   
}







