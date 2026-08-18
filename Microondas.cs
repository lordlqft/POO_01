public class Microondas
{
    private string _marca;
    private string _material;
    private int _voltagem;

    public Microondas(string marca, string material, int voltagem)
    {
        _marca = marca;
        _material = material;
        _voltagem = voltagem;
    }
    public string getMarca() { return _marca; }

    public void setMarca(string marca) { this._marca = marca; }

    public string getMaterial() { return _material; }

    public void setMaterial(string material) { this._material = material; }

    public int getVoltagem() { return _voltagem; }

    public void setVoltagem(int voltagem) { this._voltagem = voltagem; }

    public void Pressionar()
    {
        Console.WriteLine("Pressionando o microondas...");
    }

    public void Abrir()
    {
        Console.WriteLine("Abrindo o microondas");
    }
}