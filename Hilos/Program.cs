using System;
using System.Threading;

namespace Hilos
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//intancio la clase Tareas 3 veces
			// necesita dos parámetros: un String y un Int respectivamente
			//el primero será el nombre del proceso y el segundo argumento, los segundos de duración
			Tareas tarea1 = new Tareas("Hilo 1", 7);
			Tareas tarea2 = new Tareas("Hilo 2", 10);
			Tareas tarea3 = new Tareas("Hilo 3", 15);

			//creo 3 hilos
			// a cada uno le paso el mismo objeto 'tareas' pero con diferentes argumentos
			// Note que no utilicé ParameterizedThread porque el proceso
			//no requiere argumentos para iniciar
			Thread hilo1 = new Thread(tarea1.Imprimir);
			Thread hilo2 = new Thread(tarea2.Imprimir);
			Thread hilo3 = new Thread(tarea3.Imprimir);


			//inicio los hilos con Start
			hilo1.Start();
			hilo2.Start();
			hilo3.Start();



			Console.ReadKey();
		}
	}
}
