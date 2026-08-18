public class Camera
{
    private string _marca;
    private string _tamanho;
    private string _resolucao;

    public Camera(string marca, string tamanho, string resolucao)
    {
        _marca = marca;
        _tamanho = tamanho;
        _resolucao = resolucao;
    }
    public string getMarca() { return _marca; }

    public void setMarca(string marca) { this._marca = marca; }

    public string getTamanho() { return _tamanho; }

    public void setTamanho(string tamanho) { this._tamanho = tamanho; }

    public string getResolucao() { return _resolucao; }

    public void setResolucao(string resolucao) { this._resolucao = resolucao; }

    public void Gravar()
    {
        Console.WriteLine("Gravando...");
    }

    public void Ligar()
    {
        Console.WriteLine("Ligando a camera...");
    }
}