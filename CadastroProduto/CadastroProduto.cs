class Produto
{
    public string Nome { get; set; }
    public string Codigo { get; set; }
    public decimal Preco { get; set; }

    public string Descricao =>
        $"Produto: {Nome} | Código: {Codigo} | Preço: R$ {Preco}";
}