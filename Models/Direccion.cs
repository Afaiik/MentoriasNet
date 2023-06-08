namespace PracticasMentoria1.Models
{
    public class Direccion
    {
        public string Calle { get; set; }
        public int Numero { get; set; }

        public override string ToString()
        {
            return Calle + " " + Numero;
        }
    }
}
