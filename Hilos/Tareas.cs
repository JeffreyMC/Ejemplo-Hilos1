using System;
using System.Threading;

namespace Hilos
{
	public class Tareas
	{
		//atributos de la clase
		private string name;
		private int second;

		//constructor de la clase
		public Tareas(string name, int second)
		{
			this.name = name;
			this.second = second;
		}

		//esta es la función que ejecutará cada hilo
		//primero el nombre y el tiempo que durará
		//luego el hilo 'duerme' por el tiempo que se pasó por
		//parámetro y se multiplica por 1000 (porque recuerde que se trabaja con
		//milisegundos). Un segundo equivale a 1000 milisegundos
		//por último se imprime el nombre del proceso y se indica que este terminó
		public void Imprimir()
		{
			Console.WriteLine(name + " durará " + second + " segundos");
			Thread.Sleep(second * 1000);
			Console.WriteLine("\n---------------------------------------\n");
			Console.WriteLine(name + " terminado");

		}

	}
}


//espero que le ayuden. Los hice lo más sencillos posibles