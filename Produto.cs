public class Produto : Pessoa
{
    string codigo;
    string estoque;

    public void GetCPF ()
    {
        return CPF;
    }
    public void SetCPF (string cpf)
    {
        CPF=cpf;
    }

     public void Getestoque ()
    {
        return estoque;
    }
    public void Setestoque (string est)
    {
        estoque=est;
    }
    
}