public class Garrafa
{
    private string _cor;
    private string _formato;
    private int _peso;

    public Garrafa(string cor, string formato, int peso)
    {
        _cor = cor;
        _formato = formato;
        _peso = peso;
    }
    public string getCor() { return _cor; }

    public void setCor(string cor) { this._cor = cor; }

    public string getFormato() { return _formato; }

    public void setFormato(string formato) { this._formato = formato; }

    public int getPeso() { return _peso; }

    public void setPeso(int peso) { this._peso = peso; }

    public void Beber()
    {
        Console.WriteLine("Bebendo...");
    }

    public void Encher()
    {
        Console.WriteLine("Garrafa cheia.");
    }
}