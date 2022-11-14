using System;

class Program
{
    public static double calcularPrecio(string tipoHelado, int topping) 
    {
double precio =0;

  if (tipoHelado == "chocolate" || tipoHelado == "vainilla" || tipoHelado == "fresa")
    {
        precio = 5;
    }
        else if (tipoHelado == "napolitano" || tipoHelado == "pistacho")
            {
                precio = 7;
            }

switch (topping)
{

    // cobertura de chocolate
    case 1:
        precio = precio +1;
    break;

    case 2: // cobertura de chocolate con mania
        precio = precio +2;
    break;

    case 3: // cobertura de chocolate con anicillos
        precio = precio +1;
    break;

 
}

return precio;
}
static void Main() 
{
    string helado;
        double total;
        Console.WriteLine("Escriba el tipo de helado que desea");
        string H=Console.ReadLine();
        
        Console.WriteLine("Indique el número de topping que desea");
        int t = int.Parse(Console.ReadLine());
        total=calcularPrecio(H,t);
        Console.WriteLine("Su total es: "+total);
        
    
}

       


}