namespace EjemploHerencia
{
    public class HijaA : Padre
    {
        public string Carnet {  get; set; }
        public string OtraCadena { get; set; }

        public HijaA() 
        { 
            OtraCadena = string.Empty; //""
        }
    }
}
