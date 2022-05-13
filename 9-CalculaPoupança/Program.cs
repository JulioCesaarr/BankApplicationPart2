{ Console.WriteLine("Executando Projeto 10 - calculando poupança");
  double valorinvestido = 1000;
    int contadormes = 1; 

    while (contadormes <= 12) 

    {
        valorinvestido = valorinvestido + valorinvestido * 0.0036;   
        Console.WriteLine("após " + contadormes + " meses vocÊ terá " + valorinvestido);

        // contadormes = contadormes + 1; 
        //contadormes += 1;
        contadormes++;
    
    }
    
    
  

Console.ReadLine();
}
