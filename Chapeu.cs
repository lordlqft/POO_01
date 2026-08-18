public class Chapeu
{
    private string _cor;
    private string _material;
    private int _preço;

    public Chapeu(string cor, string material, int preço)
    {
        _cor = cor;
        _material = material;
        _preço = preço;
    }
    public string getCor() { return _cor; }

    public void setCor(string cor) { this._cor = cor; }

    public string getMaterial() { return _material; }

    public void setMaterial(string material) { this._material = material; }

    public int getPreço() { return _preço; }

    public void setPreço(int preço) { this._preço = preço; }

    public void Vestir()
    {
        Console.WriteLine("Vestindo o chapéu...");
    }

    public void Tirar()
    {
        Console.WriteLine("Tirou o Chapéu");
    }
}