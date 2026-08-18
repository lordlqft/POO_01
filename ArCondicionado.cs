public class ArCondicionado
{
    private string _marca;
    private string _tamanho;
    private int _quantidadePas;

    public ArCondicionado(string marca, string tamanho, int quantidadePas)
    {
        _marca = marca;
        _tamanho = tamanho;
        _quantidadePas = quantidadePas;
    }

    public string getMarca() { return _marca; }

    public void setMarca(string marca) { this._marca = marca; }

    public string getTamanho() { return _tamanho; }

    public void setTamanho(string tamanho) { this._tamanho = tamanho; }

    public int getQuantidadePas() { return _quantidadePas; }

    public void setQuantidadePas(int quantidadePas) { this._quantidadePas = quantidadePas; }

    public void Ventilar()
    {
        Console.WriteLine("Ventilando...");
    }

    public void MudarTemperatura()
    {
        Console.WriteLine("Mudando a temperatura do ar condicionado...");
    }
}