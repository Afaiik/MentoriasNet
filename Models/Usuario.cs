namespace PracticasMentoria1.Models
{
    public class Usuario : object
    {
        public Usuario()
        {
        }

        public Usuario(string nombre, int dni)
        {
            Nombre = nombre;
            Dni = dni;
        }

        public Usuario(string nombre, int dni, int panchosComidos)
        {
            Nombre = nombre;
            Dni = dni;
            PanchosComidos = panchosComidos;
        }

        public string Nombre { get; set; }
        public int Dni { get; set; }
        public Direccion Direccion { get; set; }

        public static int PanchosComidos { get; set; }

        //Metodos
        public string Comer(int cantidad)
        {
            if (EstoyDieta())
            {
                return "No puedo, ya comí " + PanchosComidos + " panchos";
            }

            PanchosComidos += cantidad;

            return "Comí " + PanchosComidos + " panchos";
        }

        private bool EstoyDieta()
        {
            return PanchosComidos > Comidas.CantidadPanchosParaDieta;
        }

        //Acceso    TipoDatoDevuelve       NombreFuncion      Parametros de entrada
        // public     void/int/string       Comer                 (tipoDato  nombre)
        //            void = no devuelvo
        //                       nada

        public override string ToString()
        {
            return "Nombre: " + Nombre + " Dni: " + Dni;
        }
    }
}