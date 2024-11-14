using System.Security.Cryptography;

public class Cliente{
    public string _nome;
    private string _cpf;
    public string _sexo;
    public string _dataNas;
    public void setCpf(string cpf){
		try
		{
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");
            if (cpf.Length == 11)
            {
                _cpf = cpf;
            }
            else
            {
                throw new Exception("CPF incorreto");
            }
        }
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
    }
    public string getCpf()
    {
        return _cpf;
    }
}