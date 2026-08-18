public class Bicicleta
{
    private string _cor;
    private int _quantidadeMarchas;
    private int _preço;

    public Bicicleta(string cor, int quantidadeMarchas, int preço)
    {
        _cor = cor;
        _quantidadeMarchas = quantidadeMarchas;
        _preço = preço;
    }
    public string getCor() { return _cor; }

    public void setCor(string cor) { this._cor = cor; }

    public int getQuantidadeMarchas() { return _quantidadeMarchas; }

    public void setQuantidadeMarchas(int quantidadeMarchas) { this._quantidadeMarchas = quantidadeMarchas; }

    public int getPreço() { return _preço; }

    public void setPreço(int preço) { this._preço = preço; }

    public void Pedalar()
    {
        Console.WriteLine("Pedalando...");
    }

    public void Montar()
    {
        Console.WriteLine("Montou na bicicleta");
    }
}