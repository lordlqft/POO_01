public class Livro
{
    private string _nome;
    private string _autor;
    private int _paginas;

    public Livro(string nome, string autor, int paginas)
    {
        _nome = nome;
        _autor = autor;
        _paginas = paginas;
    }

    public string getNome() { return _nome; }

    public void setNome(string nome) { this._nome = nome; }

    public string getAutor() { return _autor; }

    public void setAutor(string autor) { this._autor = autor; }

    public int getPaginas() { return _paginas; }

    public void setPaginas(int paginas) { this._paginas = paginas; }

    public void Ler()
    {
        Console.WriteLine("Lendo o livro...");
    }

    public void Escrever()
    {
        Console.WriteLine("Escrevendo no livro...");
    }
}