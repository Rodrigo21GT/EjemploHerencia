namespace EjemploHerencia
{
	public class Padre
	{
		public string nombre { get; set; }

		public string apellido { get; set; }

		public int direccion { get; set; }

		public DateTime fecha { get; set; }

		public int age { get; set; }


		//Propiedad Privada, dato privado que no se hereda a otras clases 
		private string DatoPrivado { get; set; }

		//Propiedad Protegida, se hereda pero en la herencia
		//es privada, no se puede usar afuera de la clase
		//padre y las hijas se puede usar pero en el programa principal no

		protected string DatoProtegido { get; set; }


		//Con esto no tendria problemas con los valores nulos, se ejecuta cada vez que se crea un objeto de esta clase
		public Padre()
		{
			apellido = "";
			DatoPrivado = "Dato Privado";
		}
		public int CalcularEdad()
		{
			TimeSpan edad = fecha - DateTime.Now;

			return Convert.ToInt16(edad.TotalDays / 365);
		}

	}
}