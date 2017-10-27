using System.IO;
using System;

namespace CadastroVendaPoo.classes
{
    public class SalvarProduto
    {
        public string Salvar(Produto produto){
            string msg = "";
            StreamWriter arquivo = null;
            try{
                    arquivo = new StreamWriter("cadProdutos.csv",true);
                    arquivo.WriteLine(
                        produto.Id+";"+
                        produto.NomeProduto+";"+
                        produto.Descricao+";"+
                        produto.Preco
                    );
                    msg="Arquivo salvo com sucesso!\n";
            }
            catch(Exception ex){
                msg = "Erro ao tentar gravar o arquivo"+ex.Message;
            }
            finally{
                arquivo.Close();
            }
            return msg;    
        }

    }
}