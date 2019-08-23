public class ContaPoupanca : Conta 
{
    public override void Saca(double valor) 
    {
        this.Saldo -= (valor + 0.10);
    }
}