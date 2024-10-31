VeiculoDAO vdao = new VeiculoDAO();
do
{
    Console.WriteLine("\n 1 para cadastrar um novo Veiculo" +
        "\n 2 para listar todos os veiculos" +
        "\n 3 para remover um veiculo da lista" +
        "\n 4 para buscar um veiculo");
    int opcao = int.Parse(Console.ReadLine());
    if (opcao == 1)
    {
        Console.WriteLine("Informe a placa: ");
        string placa = Console.ReadLine();
        Console.WriteLine("Informe o modelo: ");
        string modelo = Console.ReadLine();
        Veiculo V = new Veiculo(placa,modelo);
        Console.WriteLine("Informe o modelo: ");
        V._modelo = Console.ReadLine();
        Console.WriteLine("Informe njv do veicuo: ");
        V._njv = Console.ReadLine();
        Console.WriteLine("Informe N° do Motor: ");
        V._nMotor = Console.ReadLine();
        Console.WriteLine("Informe a marca do Veiculo: ");
        V._marca = Console.ReadLine();
        Console.WriteLine("Informe o Renavan do Veiculo: ");
        V._renavan = Console.ReadLine();

        vdao.Cadastrar(V);
    }else if(opcao == 2)
    {
        List<Veiculo> veiculos = vdao.ListarTodos();
        foreach (Veiculo V in veiculos)
        {
            Console.WriteLine($"\nModelo: {V._modelo}" +
                $"\nPlaca: {V._placa}" +
                $"\nNJV: {V._njv}" +
                $"\nN° do Motor: {V._nMotor}" +
                $"\nMarca: {V._marca}" +
                $"\nRenavan: {V._renavan}");
        }
    }
    if (opcao == 3)
    {
        Console.WriteLine("Informe a placa do veiculo: ");
        string placa = Console.ReadLine();
        vdao.Romover(placa);
        
    }
    if (opcao == 4)
    {
        Console.WriteLine("Informe a placa do veiculo: ");
        string placa = Console.ReadLine();
        Veiculo vplaca = vdao.BuscarPlaca(placa);
        Console.WriteLine($"\nModelo: {vplaca._modelo}" +
            $"\nPlaca: {vplaca._placa}" +
            $"\nnjv: {vplaca._njv}" +
            $"\nN° Motor: {vplaca._nMotor}" +
            $"\nMarca: {vplaca._marca}" +
            $"\nrenavan: {vplaca._renavan}");
        
    }
}
while (true);