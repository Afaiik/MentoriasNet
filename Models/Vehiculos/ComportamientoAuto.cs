namespace PracticasMentoria1.Models.Vehiculos
{
    public class ComportamientoAuto
    {
        private AutoNaftero auto { get; set; }
        public ComportamientoAuto()
        {
            auto = new AutoNaftero();
        }

        public double CalcularCostoRuta(int cuantoGasta, AutoNaftero auto)
        {
            double resultado = auto.CantidadCombustible / cuantoGasta;

            return resultado;
        }
    }
}
