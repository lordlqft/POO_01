public class Projetor
{
    private string _marca;
    private string _resolucao;
    private string _entrada;

    public Projetor(string marca, string resolucao, string entrada)
    {
        _marca = marca;
        _resolucao = resolucao;
        _entrada = entrada;
    }
    public string getMarca() { return _marca; }

    public void setMarca(string marca) { this._marca = marca; }

    public string getResolucao() { return _resolucao; }

    public void setResolucao(string resolucao) { this._resolucao = resolucao; }

    public string getEntrada() { return _entrada; }

    public void setEntrada(string entrada) { this._entrada = entrada; }

    public void Ligar()
    {
        Console.WriteLine("Ligando o projetor...");
    }

    public void Projetar()
    {
        Console.WriteLine("Projetando...");
    }
}