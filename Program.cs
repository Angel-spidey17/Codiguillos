/*
 * Created by SharpDevelop.
 * User: hezie
 * Date: 02/10/2020
 * Time: 11:03 a. m.
 * Arreglos
 * Bloque de Memoria
 * 
 * | Espacio de memoria para un Entero 32 bits | => int 
 * 
 * Arreglos espacio en memoria del tamaño del tipo del variable
 * | int32 espacio 01 | [0] => int arreglo 
 * | int32 espacio 02 | [1] ...
 * 
 * */
using System;

namespace pruebas
{
	class Program
	{
		public static void Main(string[] args)
		{
		
			//Matrices
			
			int[,] matricilla;
			Random aleatorio = new Random(); // necesario para crear datos aleatorios
			matricilla = new int[8,8];
			
			for(int fila = 0; fila < 8; fila++)
			{
				for(int col =0; col < 8; col++)
				{
					matricilla[fila,col] = aleatorio.Next(0,64);//Estructura para llamar a la matriz con datos aleatorios
					//Console.WriteLine("Dame un numero: "); // Estructura para intrucir los valores con los que va a contar la matriz
					//matricilla[fila,col] = Convert.ToInt32(Console.ReadLine());
				}
			}
			
			Console.Clear();
			
			
			for(int fila = 0; fila < 8; fila++)
			{
				for(int col = 0; col < 8; col++)
				{
					Console.Write(" " + matricilla[fila, col]);
					
				}
				Console.WriteLine();
			}
			Console.ReadKey(true);
		}
	}
}