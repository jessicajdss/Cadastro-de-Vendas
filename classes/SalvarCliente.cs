using System;
using System.IO;

namespace CadastroVendaPoo.classes{
    public class SalvarCliente{
        public string Salvar(Cliente cliente){
            string msg = "";
            StreamWriter arquivo = null;
            try{
                if(cpfValido(cliente.Cpf)){
                    arquivo = new StreamWriter("cadClientes.csv",true);
                    arquivo.WriteLine(
                        cliente.Nome+";"+
                        cliente.Email+";"+
                        cliente.Cpf+";"+
                        cliente.DataCadastro
                    );
                    msg="Arquivo salvo com sucesso!";
                }
                else{
                    msg ="CPF inválido!";
                }
            }
            catch(Exception ex){
                msg = "Erro ao tentar gravar o arquivo"+ex.Message;
            }
            finally{
                arquivo.Close();
            }
            return msg;

        }
        private bool cpfValido(string cpfcnpjUsuario){

            bool retorno = true;
            string Calculo ="";

            int [] v1 = {10,9,8,7,6,5,4,3,2};
            int [] v2 = {11,10,9,8,7,6,5,4,3,2};
            int [] vcnpj1 ={5,4,3,2,9,8,7,6,5,4,3,2};
            int [] vcnpj2 = {6,5,4,3,2,9,8,7,6,5,4,3,2};

            int resultado = 0;
            int resto = 0;

            if (cpfcnpjUsuario.Length==11){

                Calculo = cpfcnpjUsuario.Substring(0,9);

                    for(int i = 0 ; i < Calculo.Length;i++){
                        resultado+=Int16.Parse(Calculo[i].ToString())*v1[i];                
                    }
                    
                    resto = resultado%11;
                    if (resto < 2)
                        Calculo += "0";
                    else
                        Calculo += (11-resto).ToString();
                    
                resultado = 0;

                Calculo = Calculo.Substring(0,10);

                    for(int i = 0 ; i < Calculo.Length;i++){
                        resultado+=Int16.Parse(Calculo[i].ToString())*v2[i];                
                    }
                    
                    resto = resultado%11;
                    if (resto < 2)
                        Calculo += "0";
                    else
                        Calculo += (11-resto).ToString();  
            }
            else if (cpfcnpjUsuario.Length == 14){

                    Calculo = cpfcnpjUsuario.Substring(0,12);

                    for(int i = 0 ; i < Calculo.Length;i++){
                        resultado+=Int16.Parse(Calculo[i].ToString())*vcnpj1[i];                
                    }
                    resto = resultado%11;
                    if (resto < 2)
                        Calculo += "0";
                    else
                        Calculo += (11-resto).ToString();
                    
                resultado = 0;

                Calculo = Calculo.Substring(0,13);

                    for(int i = 0 ; i < Calculo.Length;i++){
                        resultado+=Int16.Parse(Calculo[i].ToString())*vcnpj2[i];                
                    }
                    
                    resto = resultado%11;
                    if (resto < 2)
                        Calculo += "0";
                    else
                        Calculo += (11-resto).ToString(); 

            }
            
            
            if(cpfcnpjUsuario!=Calculo)
                retorno=false;     

        return retorno;
        }

    }
}