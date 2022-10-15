namespace RoleplayGame;
using Library;
public class Staff:IItemsArma
{
        public string GetNombre()
    {
        return this.Nombre;
    }
    public int GetDamage()
    {
        return this.Damage;
    }

    public string GetDescripcion()
    {
        return this.Descripcion;
    }
    public string Nombre;
    public int Damage;
    public string Descripcion;
    public Staff(string Nombre, int Damage, string Descripcion)
    {
        this.Nombre=Nombre;
        this.Damage=Damage;
        this.Descripcion=Descripcion;
    }
}