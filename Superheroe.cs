using CommunityToolkit.Mvvm.ComponentModel;

namespace Superheroes;

public partial class Superheroe : ObservableObject
{
    [ObservableProperty]
    private string? nombre;

    [ObservableProperty]
    private string? imagenRuta;

    [ObservableProperty]
    private bool vengador;

    [ObservableProperty]
    private bool xmen;

    [ObservableProperty]
    private bool heroe;

    // Constructor vacío
    public Superheroe() { }

    // Constructor parametrizado
    public Superheroe(string nombre, string imagenRuta, bool vengador, bool xmen, bool heroe)
    {
        Nombre = nombre;
        ImagenRuta = imagenRuta;
        Vengador = vengador;
        Xmen = xmen;
        Heroe = heroe;
    }
}
