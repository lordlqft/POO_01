public class Maquininha
{
    private string _modelo;
    private string _marca;
    private string _cor;

    public Maquininha(string modelo, string marca, string cor)
    {
        _modelo = modelo;
        _marca = marca;
        _cor = cor;
    }

    public string getModelo() { return _modelo; }

    public void setModelo(string modelo) { this._modelo = modelo; }

    public string getMarca() { return _marca; }

    public void setMarca(string marca) { this._marca = marca; }

    public string getCor() { return _cor; }

    public void setCor(string cor) { this._cor = cor; }


    public void Carregar()
    {
        Console.WriteLine("Carregando a Maquininha...");
    }

    public void Inserir()
    {
        Console.WriteLine("Inserindo cartão na Maquininha...");
    }
}