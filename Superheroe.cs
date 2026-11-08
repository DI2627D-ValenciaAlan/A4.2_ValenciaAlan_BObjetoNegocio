    public class Superheroe
    {
        public string Nombre { get; set; }
        public string ImagenRuta { get; set; }
        public bool Vengador { get; set; }
        public bool Xmen { get; set; }
        public bool Heroe { get; set; }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagenRuta, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            ImagenRuta = imagenRuta;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }
    }