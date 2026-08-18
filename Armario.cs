public class Armario
{
    private string _tamanho;
    private string _capacidade;
    private string _marca;

    public Armario(string tamanho, string capacidade, string marca)
    {
        _tamanho = tamanho;
        _capacidade = capacidade;
        _marca = marca;
    }
    public string getTamanho() { return _tamanho; }

    public void setTamanho(string tamanho) { this._tamanho = tamanho; }

    public string getCapacidade() { return _capacidade; }

    public void setCapacidade(string capacidade) { this._capacidade = capacidade; }

    public string getMarca() { return _marca; }

    public void setMarca(string marca) { this._marca = marca; }

    public void Abrir()
    {
        Console.WriteLine("Abrindo o armário...");
    }

    public void Armazenar()
    {
        Console.WriteLine("Armazenando itens no armário...");
    }
}