namespace EjemploHerencia
{
	public class HijaA : Padre //Simplemente con esto es como si haya copiado los datos de otra clase y se los haya asignado a esta 
	{
		public string carne { get; set; }

		public int numNotas { get; set; }

		public HijaA()
		{
			carne = string.Empty; //Otra manera de poner las comillas o el valor nulo
		}
	}
}