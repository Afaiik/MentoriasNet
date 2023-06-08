namespace PracticasMentoria1.Models.Vehiculos
{
    public abstract class Auto : Vehiculo
    {
        public Auto(int cantidadCombustibleInicial)
        {
            CantidadCombustible = cantidadCombustibleInicial;
        }

        public Auto(bool tieneBaul, int cantidadCombustibleInicial)
        {
            TieneBaul = tieneBaul;
            CantidadCombustible = cantidadCombustibleInicial;
        }

        public bool TieneBaul { get; set; }

        public int CantidadCombustible { get; set; }

        //public abstract int CargarCombustible(int cantidad);

        public abstract void Acelerar();
    }
}
