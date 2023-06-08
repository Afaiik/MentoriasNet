namespace PracticasMentoria1.Models.Vehiculos
{
    public class AutoNaftero : Auto
    {
        public AutoNaftero() : base(100)
        {

        }
        public AutoNaftero(bool tieneCaja, bool baul, int cantidadCombustible) : base(baul, cantidadCombustible)
        {
            TieneCaja = tieneCaja;
        }

        public bool TieneCaja { get; set; }

        public override void Acelerar()
        {
            CantidadCombustible -= 15;
        }
    }
}