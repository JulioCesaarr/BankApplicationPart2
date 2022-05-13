{ Console.WriteLine("Executando projeto 8");
  
    int idadejoao = 11;
    int responsaveis = 0;
    bool acompanhado = true;
    string mensagemadicional;

    if (acompanhado == false)
    {
       mensagemadicional = "joão está acompanhado";
        Console.WriteLine(mensagemadicional);
    }
    else
    mensagemadicional = "joão não está acompanhado";
    
    if (idadejoao >= 18 || acompanhado == true)
    {
        Console.WriteLine("pode entrar ");
        Console.WriteLine(mensagemadicional);
    }
    else Console.WriteLine("não pode entrar ");


    Console.ReadLine();
}
