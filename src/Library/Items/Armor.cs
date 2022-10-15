namespace RoleplayGame;
using Library;
public class Armor: IItemsArmadura
{
    public string Nombre;
    public int Defensa;
    public string Descripcion;
    public Armor(string Nombre, int Defensa, string Descripcion)
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
