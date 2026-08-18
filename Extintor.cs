public class Extintor
{
    private string _tamanho;
    private string _tipoCarga;
    private int _peso;

    public Extintor(string tamanho, string tipoCarga, int peso)
    {
        _tamanho = tamanho;
        _tipoCarga = tipoCarga;
        _peso = peso;
    }
    public string getTamanho() { return _tamanho; }

    public void setTamanho(string tamanho) { this._tamanho = tamanho; }

    public string getTipoCarga() { return _tipoCarga; }

    public void setTipoCarga(string tipoCarga) { this._tipoCarga = tipoCarga; }

    public int getPeso() { return _peso; }

    public void setPeso(int peso) { this._peso = peso; }

    public void Apertar()
    {
        Console.WriteLine("Apertando o extintor...");
    }

    public void Soltar()
    {
        Console.WriteLine("Soltando o extintor...");
    }
}