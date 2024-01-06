
int num1 = 0;
int num2 = 0;

Console.WriteLine("Ingrese primer numero ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese segundo numero ");
num2 = Convert.ToInt32(Console.ReadLine());

saludar();
saludar();

Console.WriteLine("La suma es " + sumar(num1, num2));

Console.ReadKey();

void saludar()
{
    Console.WriteLine("Hola soy una funcion");
}


int sumar(int numero1, int numero2)
{
    return numero1 + numero2; 
}
