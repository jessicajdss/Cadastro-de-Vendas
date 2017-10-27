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
                        venda.Prec"+o+";
                        venda.DataVenda
                    );
                    msg="Arquivo salvo com sucesso!\n";
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

        private bool cpfCadastrado(string verificacpf){
            
            //string retorno = "";
            string[] retornacpf = null; 
            bool retorno = true;

            StreamReader ex = null;
            ex = new StreamReader("cadCliente.csv");                    

            string linha;
            int contLin=0;

            while(ex.ReadLine()!= null){
                contLin++;
            }

            string[,]dados = new string [contLin,4];

            // while((linha = ex.ReadLine())!= null){
            //     retornacpf = linha.Split(';');
// posicao 2 cpf
//listar os produtos
linha = ex.ReadLine();
            for(int lin = 0;lin < dados.GetLength(0);lin++){
               for(int col = 0; col < dados.GetLength(1);col++){
                    retornacpf= linha.Split(';'); 
                    if(retornacpf[lin] == verificacpf){

                    }
                        // if (dados[lin,col] == verificacpf){
                        //     Console.WriteLine("Dados do Cliente: \n");
                        //     Console.Write(dados[lin,0]+"\t");
                        //     Console.Write(dados[lin,1]+"\t");
                        //     Console.Write(dados[lin,2]+"\t");
                        //     retorno = true;
                        // }
                        // else{
                        //     Console.WriteLine("Cliente não encontrado.");
                        //     retorno=false;
                        // }
                }
            }

        return retorno;    
        }

    }
}