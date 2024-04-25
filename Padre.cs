namespace EjemploHerencia
{
    public class Padre

    {
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Id { get; set; }
        public string Cadena { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DatoPrivado { get; set; }
        protected string DatoProtegido { get; set; }

        //Constructor: Se ejecuta cada vez que se crea un objeto de esuta clase
        public Padre()
        {
            Cadena = "";
            DatoPrivado = "DatoPrivado";
        }

        public int Edad()
        {
            TimeSpan edad = FechaNacimiento - DateTime.Now;
            return Convert.ToInt16(edad.TotalDays / 36);
        }
    }
}
