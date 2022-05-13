{ Console.WriteLine("Executando Projeto 12 - calculando investimento longo prazo!");
    double valorinvestido = 1000; 
    double fatorrendimento = 1.0036; 

for (int contadorano = 1; contadorano <= 10; contadorano++)
    {
        for (int contadormes = 1; contadormes <= 12;  contadormes++)
        {
            valorinvestido *= fatorrendimento;
        }
        fatorrendimento += 0.0010;
    }
    Console.WriteLine("Ao término do investimento, você terá R$" +valorinvestido);

Console.ReadLine();
}
