public class Conta
{
    public int Numero { get; set;}
    public double Saldo { get; private set; }

    public Cliente Titular { get; set; }

    public int Tipo { get; set; }

    public void Saca(double valor) 
    {
        if(this.Tipo == 1) 
        {
            this.Saldo -= valor + 0.10;
        }
        else 
        {
            this.Saldo -= valor;        
        }
    }

    public void Deposita(double valor) 
    {
        this.Saldo += valor;
    }
}