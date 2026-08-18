public class Notebook
{
    private double _preço;
    private string _modelo;
    private string _sistemaOperacional;

    public Notebook(double preço, string modelo, string sistemaOperacional)
    {
        _preço = preço;
        _modelo = modelo;
        _sistemaOperacional = sistemaOperacional;
    }
    public string getModelo() { return _modelo; }

    public void setModelo(string modelo) { this._modelo = modelo; }

    public string getSistemaOperacional() { return _sistemaOperacional; }

    public void setSistemaOperacional(string sistemaOperacional) { this._sistemaOperacional = sistemaOperacional; }

    public double getPreço() { return _preço; }

    public void setPreço(double preço) { this._preço = preço; }

    public void Ligar()
    {
        Console.WriteLine("Ligando o Notebook...");
    }

    public void Digitar()
    {
        Console.WriteLine("Digitando no Notebook");
    }
}