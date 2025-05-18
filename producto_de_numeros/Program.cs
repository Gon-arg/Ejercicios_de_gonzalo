// Pedirle al usuario tres números y calcular su producto
double num1;
double num2;
double num3;
Console.WriteLine("ingrese el primer numero: ");
num1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese el segundo numero: ");
num2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese el segundo numero: ");
num3=Convert.ToDouble(Console.ReadLine());
double multiplicacion=num1*num2*num3;
Console.WriteLine($"el resultado es :{multiplicacion}");
