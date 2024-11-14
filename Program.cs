VeiculoDAO vdao = new VeiculoDAO();

do
{
    Console.WriteLine("\n 1 para cadastrar um novo Veiculo" +
        "\n 2 para listar todos os veiculos" +
        "\n 3 para remover um veiculo da lista" +
        "\n 4 para buscar um veiculo"+
        "\n 5 atividade da sala veiculo"+
        "\n 6 atividade da sala cliente"
        );
    int opcao = int.Parse(Console.ReadLine());
    if (opcao == 1)
    {
        Console.WriteLine("Informe a placa: ");
        string placa = Console.ReadLine();
        Console.WriteLine("Informe o modelo: ");
        string modelo = Console.ReadLine();
        Console.WriteLine("Informe njv do veicuo: ");
        string niv = Console.ReadLine();
        Veiculo V = new Veiculo(placa,modelo,niv);
        Console.WriteLine("Informe o modelo: ");
        V._modelo = Console.ReadLine();
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
                $"\nNJV: {V._niv}" +
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
            $"\nnjv: {vplaca._niv}" +
            $"\nN° Motor: {vplaca._nMotor}" +
            $"\nMarca: {vplaca._marca}" +
            $"\nrenavan: {vplaca._renavan}");
        
    }
    if (opcao == 5)
    {
        try
        {
            Veiculov1 v1 = new Veiculov1();
            v1._placa = "QBE-8324";
            v1._modelo = "Saveiro G6";
            v1.SetNiv("1111111111111111");
            Console.WriteLine(v1.GetNiv());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        

        /*Tendo como base a classe veículo, crie uma objeto com nome v1
        com o NIV 0561561, placa QBE-8324, modelo Saveiro G6.
        
        O código da classe veículo possui uma falha, no código é possivel atribuir
        um valor ao NIV fora dos padrões, faça um controle de todos os valores que serão
        atribuidos ao atributo NIV, sendo obrigatório cada NIV possuir 17 caracteres.

        Caso esteja fora do padrão, o sistema deve lançar um exceção
         */

        
    }
    if (opcao == 6)
    {
        try
        {
            Cliente p = new Cliente();
            p._nome = "Alan Soares";
            p._sexo = "Masculino";
            p._dataNas = "29/09/1998";
            p.setCpf("029.555.422-18");
            Console.WriteLine(p.getCpf());
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }

    }
}
while (true);