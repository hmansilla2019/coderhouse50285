// See https://aka.ms/new-console-template for more information


// Condicional simple
//Supongamos que debemos hacer un control básico del stock de nuestros productos en un 
//depósito
//Nos brindan la cantidad de productos en depósito y la cantidad de productos vendidos.
//Entonces debemos preguntarnos si no existen productos en nuestro depósito, 
//entonces debemos reponerlos.  
//Aquí utilizamos Console.ReadLine() para obtener la cantidad a vender
//y seguir trabajando con variables, en la cual como dicha función retorna
//un string y la cantidad es un entero tuvimos que convertir utilizando la 
//función Convert que me permite convertir entre diversos tipos de datos.


// Condicional compuesto
//Basándonos en el ejemplo anterior debemos preguntarnos si no existen productos
//en nuestro depósito, entonces debemos reponerlos.  
//De lo contrario, notificar al área de ventas que aún siguen productos sin vender.
//Nótese que solo existe una condición y dos valores posibles.

// Anidado
//Basándonos en el ejemplo anterior:
//Se debe informar que no existen productos si no hay.
//En caso de Haber productos
//si  hay 5 o menos notificar a Logística que Se encuentra en los 
// márgenes de Stock Mínimo y se debe reponer y informar a ventas que 
//hay disponibilidad para vender
// caso contrario solo informar a ventas que hay disponibilidad para vender.
//Observar que en este caso tenemos dos condiciones, cantidad == 0 por un lado 
//y cantidad <= 5 por otro lado, noten que ya tendremos en este caso al menos 3
//resultados posibles. 


//int cantidadProductosVendidos;
//int cantidadProductosDEposito = 50;
int stock = 0;

//Console.WriteLine("Ingrese cantidad de productos vendidos");

//cantidadProductosVendidos = Convert.ToInt32(Console.ReadLine());

//stock = cantidadProductosDEposito - cantidadProductosVendidos;

bool condicion = stock == 0;

//if (stock == 0)
//{
//    Console.WriteLine("Reponer stock de productos");
//   // cantidadProductosDEposito = cantidadProductosDEposito + 10;
//    cantidadProductosDEposito += 10;
//    Console.WriteLine("Productos cargados al deposito");
//}
//else
//{

//    if (stock <=5)
//    {
//        Console.WriteLine("Stock minimo, reponer stock de productos");
//        cantidadProductosDEposito += 5;
//        Console.WriteLine("Productos cargados al deposito");
//    }
   
//        Console.WriteLine("Informar a ventas {0} productos sin vender", stock);
// }

//Console.ReadKey();


//Supongamos que tenemos un listado de Empleados y queremos
//mostrar a qué categoría corresponden según su código a saber:
//A es Administrativo
//B es Profesional
//C es Maestranza
//Ninguno de los anteriores es Sin Categoria

//Observar el uso de ReadLine() en este caso al asignarse
// a una variable string no fue necesario convertir.

string categoria;

Console.WriteLine("Ingrese Categoria A, B o C");

categoria = Console.ReadLine();

switch (categoria)
{
    case "A":
        Console.WriteLine("Empleado Administrititativo.");
        break;
    case "B":
        Console.WriteLine("Empleado Profesional.");
        break;
    case "C":
        Console.WriteLine("Empleado Maestranza.");
        break;

    default:
        Console.WriteLine("Sin categoria");
        break;
}

Console.ReadKey();