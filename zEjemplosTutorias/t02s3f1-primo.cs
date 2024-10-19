// Tutoría del tema 2, semana 3 (for, bucles anidados)
// Ejercicio 6a

/* Pide un número al usuario y responde si es primo o no, 
 * con la ayuda de un bucle "for".
 */

using System;

class Primo
{
    static void Main() 
    {
        int n;
        int divisores = 0;
        
        Console.WriteLine("Dime un número");
        n = Convert.ToInt32( Console.ReadLine() );
        
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                divisores ++;
        }
        
        if (divisores == 2)
            Console.WriteLine("Es primo");
        else
            Console.WriteLine("No es primo");
    }
}
