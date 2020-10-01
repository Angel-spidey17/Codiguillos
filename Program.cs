/*
 * Created by SharpDevelop.
 * User: hezie
 * Date: 30/09/2020
 * Time: 02:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace angelfornuñez
{
	class Program
	{
		public static void Main(string[] args)
		{
			 //int i;
		
		     /*
		      * while(true) 
		      * {
		      * 		if(condición)
		      * 			break;
		      * }
		      * */
		     /*
		      // Ciclo for, utilizado para hacer ciclos cuyo número esta bien definido
		      // la ejecución es la siguiente:
		      // for(inicio_de_variables, inicio_var01; condición; operaciones, operación01, operación02)
		      // {
		      //		Cuerpo del for
		      // }
		      // La ejecución es inicio_de_variables (se ejecuta solo una vez)
		      // posteriormente se prueba la condición
		      // luego el Cuerpo del for
		      // finalmente las operaciones y se regresa a condición y así sucesivamente
		      for(i = 0; i < 10; i++)
		      {
			      Console.WriteLine(i);
		      }
		
		      // Por otro lado, si el for realiza solo operaciones, se puede colocar todo
		      // dentro de la expresión
		      // Por ejemplo para sumar los números del 0 al 9
		      int total;
		      for(i = 0, total = 0; i < 10; total += i, i++);
		      // Es absolutamente importante colocar un ";" ya que no hay instrucciones debajo
		
		      Console.WriteLine("El valor es {0}", total);
		
		
		      // Sentencia foreach
		      // Es una sentencia de ciclo adicional a las existentes en C-ANSI
		      // la cual es utilizada para recorrer un arreglo
		      // Su uso es foreach(tipo nombreVariable in nombreArreglo)
		      string[] frutas = {"manzana", "naranja", "uva", "cereza"};
		      foreach(string c in frutas)
			       Console.WriteLine(c);
		      
		     Console.WriteLine("ENTRE EL NOMBRE DE USUARIO: ");
		     string usuario = Console.ReadLine();
		     while (usuario != "Angel Nuñez")
		     {
		     	Console.WriteLine("Usuario incorrecto");
		     	Console.WriteLine("Vuelva a introducir el nombre: ");
		     	usuario = Console.ReadLine();
		     }
		     Console.WriteLine("Bienvenido administrador");
		     
		     */
		     /*
		     string usuario;
		     string password;
		     do
		     {
		     	Console.WriteLine("Usuario: ");
		     	usuario = Console.ReadLine();
		     	Console.WriteLine("Contraseña:");
		     	password = Console.ReadLine();
		     	
		     } 
		     while (usuario != "Angel" || password != "admin");
		     Console.WriteLine("Bienvenido a feisbu");
		    */
		   /*
		     Console.WriteLine("NOMBRE DE USUARIO: ");
		     string usuario = Console.ReadLine();
		     Console.WriteLine("INGRESE SU CONTRASEÑA: ");
		     string password = Console.ReadLine();
		     while (usuario != "Angel Nuñez" || password != "admin")
		      {
		     	Console.WriteLine("NO SE HA PODIDO ACCEDER, INTENTE DE NUEVO: ");
		     	Console.WriteLine("NOMBRE DE USUARIO: ");
		     	usuario = Console.ReadLine();
		     	Console.WriteLine("INGRESE SU CONTRASEÑA: ");
		     	password = Console.ReadLine();
		      }
		     
		     Console.WriteLine("BIENVENIDO A FEISBU");
			*/
			
			  Console.ReadKey(true);
		}
	}
}