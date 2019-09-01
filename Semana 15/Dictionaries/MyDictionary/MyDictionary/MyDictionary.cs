using System.Collections.Generic;

namespace MyDicitionary
{
    public class MyDictionary
    {
        //Criando um Dictionary de chave string e valor string
        IDictionary<string, string> hashCliente = new Dictionary<string, string>();
        hashCliente.Add("Douglas","22");
        hashCliente.Add("Camila","12");
        hashCliente.Add("Ricardo","15");


        //Localizando um cliente dentro do Dictionary
        MassageBox.Show(hashCliente["Ricardo"]);


        //Também é possivel percorrer todos os valores através das Keys
        foreach(String strKey in hashCliente.Keys){
            MassageBox.Show(hashCliente[strKey]);
        }

        //Também é possivel percorrer todos os valores através dos valores
        foreach(String strValue in hashCliente.Values){
            MassageBox.Show(hashCliente[strValue]);
        }
    }
}
