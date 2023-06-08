namespace PracticasMentoria1.Models.Vehiculos
{
    public abstract class Auto : Vehiculo
    {
        public Auto(int cantidadCombustibleInicial)
        {
            CantidadCombustible = cantidadCombustibleInicial;
        }

        public bool TieneBaul { get; set; }

        public int CantidadCombustible { get; set; }

        public string Doblar()
        {
            return "Estoy Doblando";
        }

        public string[] FotoLink { get; set; }

        public abstract int CargarCombustible(int cantidad);

    }
}
