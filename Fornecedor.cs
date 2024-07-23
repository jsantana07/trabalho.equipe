public class Fornecedor : Pessoa
{
    string CNPJ;
    string email;

    public void GetCNPJ ()
    {
        return CNPJ;
    }
    public void SetCNPJ (string cnpj)
    {
       CNPJ=cnpj;
    }

     public void Getemail ()
    {
        return email;
    }
    public void Setemail (string e)
    {
       email=e;
    }
    
}