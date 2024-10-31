public class VeiculoDAO {
public List<Veiculo> ListaVeiculos = new List<Veiculo> ();

    public void Cadastrar(Veiculo V)
    {
        ListaVeiculos.Add (V);
    }

    public List<Veiculo> ListarTodos()
    {
        return ListaVeiculos;
    }

    public void Romover(string placa)
    {
        Veiculo vExcluir = ListaVeiculos.First(p=> p._placa==placa);
        ListaVeiculos.Remove(vExcluir);
    }
    public Veiculo BuscarPlaca(string placa)
    {
        Veiculo veiculo = ListaVeiculos.First(p => p._placa == placa);
        return veiculo;
    }
}

