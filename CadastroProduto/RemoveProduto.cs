using System.Reflection;
using System.Reflection.Metadata;

class RemoveProduto
{
    CadProdutoService cadProdutoService = new CadProdutoService();

   
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