class Conta
{
    // O atributo "Saldo" está definido como PRIVATE ou seja apenas a classe conta pode acessar o saldo.
    private double saldo;

    // O atributo "titular" está definido como PROTECTED ou seja apenas a classe conta e classes filhas da classe conta podem acessar o saldo.
    protected string titular; 
    

     /* O método deposita está definido como PUBLIC então este método pode ser acessado externamente por meio de um objeto Exemplo:
    Conta conta = new Conta();
    conta.Deposita(360,00);
    ) */
     public void Deposita(double valor) {
        this.saldo += valor;
    }
}