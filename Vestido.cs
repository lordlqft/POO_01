public class Vestido
{
    private string _tamanho;
    private string _cor;
    private int _preço;

    public Vestido(string tamanho, string cor, int preço)
    {
        _tamanho = tamanho;
        _cor = cor;
        _preço = preço;
    }
    public string getTamanho() { return _tamanho; }

    public void setTamanho(string tamanho) { this._tamanho = tamanho; }

    public string getCor() { return _cor; }

    public void setCor(string cor) { this._cor = cor; }

    public int getPreço() { return _preço; }

    public void setPreço(int preço) { this._preço = preço; }

    public void Vestir()
    {
        Console.WriteLine("Vestiu o vestido...");
    }

    public void Tirar()
    {
        Console.WriteLine("Tirou o Vestido");
    }
}