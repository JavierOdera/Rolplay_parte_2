namespace RoleplayGame;
using Library;

public class Helmet: IItemsArmadura
{
        public string Nombre;
    public int Defensa;
    public string Descripcion;
    public Helmet(string Nombre, int Defensa, string Descripcion)
    {
        this.Nombre=Nombre;
        this.Defensa=Defensa;
        this.Descripcion=Descripcion;
    }

    public int GetDefensa()
    {
        return this.Defensa;
    }
    public string GetNombre()
    {
        return this.Nombre;
    }
    public string GetDescripcion()
    {
        return this.Descripcion;
    }
}
