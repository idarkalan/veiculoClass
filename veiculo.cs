public class Veiculo
{
    public string _placa;
    public string _nMotor;
    public string _niv;
    public string _renavan;
    public string _modelo;
    public string _marca;

    public Veiculo(string placa, string modelo,string niv) { 
        _placa = placa;
        _modelo = modelo;
        _niv = niv;
    }
}

public class Veiculov1
{
    public string _placa;
    public string _modelo;
    private string _niv;
    
    public void SetNiv(string niv)
    {
        try
        {
            if (niv.Length == 17)
            {
                _niv = niv;
            }
            else
            {
                throw new Exception("NIV incorreto!");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        
    }
    public string GetNiv()
    {
        return _niv;
    }
}


