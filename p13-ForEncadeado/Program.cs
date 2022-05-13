{ Console.WriteLine("Executando projeto 13 - ForEncadeado");
    for (int multiplicador = 0; multiplicador < 10; multiplicador++)
    {
        for ( int contadorcoluna = 0; contadorcoluna <= 10;contadorcoluna++)
        {
            Console.Write(multiplicador + "*" + contadorcoluna +"="+ multiplicador * contadorcoluna );
            if (contadorcoluna >= multiplicador)
                break; 
        }
            Console.Write("*");
        {
            Console.WriteLine();
        }

    }


Console.ReadLine();
}
