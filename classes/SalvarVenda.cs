using System.IO;
using System;

namespace CadastroVendaPoo.classes
{
    public class SalvarVenda
    {
        public string Salvar(Venda venda){
            string msg = "";
            StreamWriter arquivo = null;
            try{
                //if(cpfCadastrado){
                    arquivo = new StreamWriter("cadVendas.csv",true);
                    arquivo.WriteLine(
                        venda.Cpf+";"+
                        venda.Id+";"+
                        venda.DataVenda
                    );
                    msg="Arquivo salvo com sucesso!";
               // }
                //else{
                //    msg ="Cliente não cadastrado!";
                //}
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