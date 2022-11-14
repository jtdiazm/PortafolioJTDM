using System;

class Program
{
    static void Main() {
        int[] edificio =new int [5];
        int imin=0;
        for (int i=0; i<5;i++)
        {
            Console.WriteLine("Nivel "+i);
            Console.WriteLine(edificio[i]);
        }
        
        for (int i=0; i<5; i++)
        {
            Console.WriteLine("Ingrese la cantidad de personas por nivel: "+(i+1));
            edificio[i]=int.Parse(Console.ReadLine());
            
        }
        //impresión
        for (int i=0;i<5; i++)
        {
            Console.WriteLine("En este nivel viven: "+(i+1)+" personas.");
            Console.WriteLine(edificio[i]);
        }
         int min=edificio[0];
         for (int i=0;i<5; i++)
        {
            if (edificio[i]<min)
            {
            min=edificio[i];
            imin=i;
            }
        }
        Console.WriteLine("el nivel con menos personas es el "+(imin+1));
        Console.ReadKey();
    }
}