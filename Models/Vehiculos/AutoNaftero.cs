namespace PracticasMentoria1.Models.Vehiculos
{
    public class AutoNaftero : Auto
    {
        public AutoNaftero() : base(100)
        {

        }

        public bool TieneCaja { get; set; }
        public int CantidadNafta { get; set; }

        public override int CargarCombustible(int cantidad)
        {
            CantidadNafta = cantidad;
            return CantidadNafta;
        }
    }
}