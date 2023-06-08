using Microsoft.AspNetCore.Mvc;
using PracticasMentoria1.Models;
using PracticasMentoria1.Models.Vehiculos;

namespace PracticasMentoria1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            Usuario elias = new Usuario("Elias", 123, 1);

            return Ok(elias);
        }

        [HttpPost]
        public IActionResult Post(int dni)
        {
            Usuario uno = new Usuario("Pepe", 1, 0);
            var dos = new Usuario("Juan", 2, 0);
            Usuario tres = new("Bastian", 3, 2);

            List<Usuario> list = new List<Usuario>();
            list.Add(uno);
            list.Add(dos);
            list.Add(tres);

            var usuarioEncontrado = list.Where(x => x.Dni == dni).FirstOrDefault();

            return Ok(usuarioEncontrado);
        }

        [HttpGet("Prueba")]
        public IActionResult Prueba()
        {
            bool verdad = true;

            int numero = 0;
            double temperature = 0.3;

            string name = "Efra";
            char firstLetter = 'C';

            var num = 3;
            var texto = "texto";

            int[] source = { 0, 1, 2, 3, 4, 5 };
            string[] arr = { "", "", "", "", "" };

            List<string> list = new List<string>() { "", "", "", "", "" };

            //Usuario.PanchosComidos;

            Usuario user = new Usuario("Juan", 36546045);

            var user2 = new Usuario();

            Usuario bastian = new Usuario("Nombre", 123, 6);

            Usuario richard = new Usuario();


            var userTextoComer = bastian.Comer(4);

            userTextoComer = bastian.Comer(3);

            userTextoComer = richard.Comer(4);

            userTextoComer = user.Comer(4);

            var test = user.ToString();

            //user.Direccion.Numero = 3;

            var comidas = Comidas.ComidasClasicas;

            var sadf = "Registro modificado por " + user.ToString();
            //En un futuro
            //var query = from item in source
            //            where item <= limit
            //            select item;

            return Ok(userTextoComer);
        }

        [HttpGet("PruebaVehiculo")]
        public IActionResult PruebaVehiculo()
        {
            AutoElectrico elec = new AutoElectrico(1, true, 100);
            elec.CantidadBateria = 200;

            AutoNaftero nafti = new AutoNaftero(true, true, 100);
            elec.Acelerar();
            nafti.Acelerar();

            Auto padre = elec;
            Auto padreNafti = nafti;

            padre.Acelerar();
            padreNafti.Acelerar();

            List<AutoElectrico> listaElectricos = new List<AutoElectrico>();
            listaElectricos.Add(elec);
            //listaElectricos.Add(nafti);

            List<Auto> listaPadre = new List<Auto>();
            listaPadre.Add(elec);
            listaPadre.Add(nafti);

            elec = (AutoElectrico)padre;

            return Ok();
        }

        /*
         1- Crear una clase abstracta (Padre) con un metodo abstracto
         2- Crear 2 clases hijas que hereden de la 1
         3- Hacer un ejemplo en el que se note que hacen cosas diferentes
         */
    }
}
