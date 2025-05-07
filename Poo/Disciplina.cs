using System.Xml.Schema;

public class Disciplina
{
    public string Name { get; set; }
    public int Cod {  get; set; }
    public Disciplina(string name,int cod)
    {
        Name = name;
        Cod = cod;
    }
}