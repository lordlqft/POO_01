public class Bebedouro
{
    private string _material;
    private double _temperatura;
    private double _volume;

    public Bebedouro(string material, double temperatura, double volume)
    {
        _material = material;
        _temperatura = temperatura;
        _volume = volume;
    }

    public string getMaterial() { return _material; }

    public void setMaterial(string material) { this._material = material; }

    public double getTemperatura() { return _temperatura; }

    public void setTemperatura(double temperatura) { this._temperatura = temperatura; }

    public double getVolume() { return _volume; }

    public void setVolume(double volume) { this._volume = volume; }

    public void Beber()
    {
        Console.WriteLine("Bebendo da fonte...");
    }

    public void Abrir()
    {
        Console.WriteLine("Abrindo a torneira do bebedouro...");
    }
}