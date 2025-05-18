Console.Write("Ingrese el costo (c): ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el pago (p): ");
        int p = Convert.ToInt32(Console.ReadLine());

        if (p < c)
        {
            Console.WriteLine("El pago no puede ser menor al costo.");
            return;
        }

        // Cálculo del vuelto
        int vuelto = p - c;

        // Cálculo de billetes
        int billetes50 = vuelto / 50;
        vuelto %= 50;//vuelto = vuelto-billetes50*50

        int billetes25 = vuelto / 25;
        vuelto %= 25;

        int billetes10 = vuelto / 10;
        vuelto %= 10;

        int billetes5 = vuelto / 5;
        vuelto %= 5;

        int billetes1 = vuelto;

        // Salida
        Console.WriteLine("\nVuelto a entregar:");
        Console.WriteLine($"Billetes de 50: {billetes50}");
        Console.WriteLine($"Billetes de 25: {billetes25}");
        Console.WriteLine($"Billetes de 10: {billetes10}");
        Console.WriteLine($"Billetes de 5: {billetes5}");
        Console.WriteLine($"Billetes de 1: {billetes1}");



