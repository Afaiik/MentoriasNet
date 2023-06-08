namespace PracticasMentoria1.Models.Vehiculos
{
    public class AutoElectrico : Auto
    {
        public AutoElectrico() : base(100)
        {

        }

        public AutoElectrico(int cantidadBateria, bool baul, int cantidadCombustible) : base(baul, cantidadCombustible)
        {
            CantidadBateria = cantidadBateria;
        }

        public int CantidadBateria { get; set; }

        public override void Acelerar()
        {
            CantidadCombustible -= 5;
        }
    }
}
