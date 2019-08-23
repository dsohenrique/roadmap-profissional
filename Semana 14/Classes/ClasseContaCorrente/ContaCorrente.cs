public class ContaCorrente
{
    private string titular;
    private int agencia;
    private int numero;
    private double saldo;

    public bool Sacar(double valor)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        
        this.saldo -= valor;
        return true;
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        
        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}