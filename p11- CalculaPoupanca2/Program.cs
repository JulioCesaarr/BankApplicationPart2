{ Console.WriteLine("Executando projeto 11 - calculando poupança!");
    double valorinvestido = 1000; 
 
for (int contador = 1; contador <= 12; contador = contador + 1)
    {
        valorinvestido = valorinvestido + valorinvestido * 0.0036;
        Console.WriteLine(" o valor investido em " + contador + "  meses será de R$" + valorinvestido);
    }



    Console.ReadLine();
}