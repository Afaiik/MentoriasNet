namespace PracticasMentoria1.Models.Vehiculos
{
    public abstract class Vehiculo
    {
        public int CantidadRuedas { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public string Patente { get; set; }

        public bool EstaPrendido { get; set; }

        public void Prender()
        {
            EstaPrendido = true;
        }

        public void Apagar()
        {
            EstaPrendido = false;
        }
    }
}
