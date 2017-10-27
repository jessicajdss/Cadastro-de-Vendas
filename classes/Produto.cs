using System;

namespace CadastroVendaPoo.classes{
    /// <summary>
    /// A classe Produto possui informações sobre os produtos
    /// </summary>'
    public class Produto{
        private int id;
        private string nomeproduto;
        private string descricao;
        private double preco;

        /// <summary>
        /// Constroi o Objeto produto
        /// </summary>
        public Produto()
        {
            
        }
        /// <summary>
        /// Constroi o objeto produto e voce passa os parametros
        /// </summary>
        /// <param name="id">Passe o id do produto como numero inteiro</param>
        /// <param name="nomeproduto">Passe o nome do produto como texto</param>
        /// <param name="descricao">Passe a descricao do produto como texto</param>
        /// <param name="preco">Passe o preco como double</param>
        public Produto(int id, string nomeproduto, string descricao, double preco)
        {
            this.id = id;
            this.nomeproduto = nomeproduto;
            this.descricao = descricao;
            this.preco = preco;
        }
        public int Id { get{return id;} set{id=value;} }
        public string NomeProduto{get{return nomeproduto;} set{nomeproduto=value;}}
        public string Descricao{get{return descricao;} set{descricao=value;}}
        public double Preco{get{return preco;} set{preco = value;}}
    }
}