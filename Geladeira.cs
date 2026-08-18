public class Geladeira
{
    private string _marca;
    private string _tamanho;
    private int _capacidade;

    public Geladeira(string marca, string tamanho, int capacidade)
    {
        _marca = marca;
        _tamanho = tamanho;
        _capacidade = capacidade;
    }

    public string getMarca() { return _marca; }

    public void setMarca(string marca) { this._marca = marca; }

    public string getTamanho() { return _tamanho; }

    public void setTamanho(string tamanho) { this._tamanho = tamanho; }

    public int getCapacidade() { return _capacidade; }

    public void setCapacidade(int capacidade) { this._capacidade = capacidade; }



    public void Abrir()
    {
        Console.WriteLine("Abrindo a Geladeira...");
    }

    public void Fechar()
    {
        Console.WriteLine("Fechando a Geladeira...");
    }
}