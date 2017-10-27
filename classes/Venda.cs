using System;

namespace CadastroVendaPoo.classes{
    /// <summary>
    /// A classe Venda possui informações sobre as vendas dos produtos para os clientes
    /// </summary>'
    public class Venda{
        private string cpf;
        private int id;
        private DateTime datavenda;

        /// <summary>
        /// Constroi o Objeto Venda
        /// </summary>
        public Venda()
        {
            
        }
        public Venda(string cpf, int id, DateTime datavenda)
        {
            this.cpf = cpf;
            this.id = id;
            this.datavenda = datavenda;
        }

        public string Cpf{get{return cpf;} set{cpf=value;}}
        public int Id { get{return id;} set{id=value;} }
        public DateTime DataVenda{get{return datavenda;} set{datavenda=value;}}
    }
}