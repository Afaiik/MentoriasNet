namespace PracticasMentoria1.Models.Vehiculos
{
    public class AutoElectrico : Auto
    {
        public AutoElectrico() : base(100)
        {

        }

        public int CantidadBateria { get; set; }

        public override int CargarCombustible(int cantidad)
        {
            CantidadBateria = cantidad;
            return CantidadBateria;
        }

    }
}
