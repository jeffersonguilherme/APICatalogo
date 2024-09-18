namspace APICatalogo.Models;

    public class Produto {

        public string? ProdutoId { get; set; }
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public string? ÍmagemUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }

}