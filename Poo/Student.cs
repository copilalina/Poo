public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int RegistrationNumber { get; set; }
    public int AnStudiu {  get; set; }
    List<Disciplina>Materii=new List<Disciplina>();

    public Student(string firstName, string lastName,int registrationNumber,int anstudiu)
    {
        FirstName = firstName;
        LastName = lastName;
        RegistrationNumber = registrationNumber;
        AnStudiu = anstudiu;
    }
    public void AddMaterii(Disciplina materii)
    {
        Materii.Add(materii);
    }
    public void PrintMaterii() { 
    foreach(var materii in Materii)
        {
            Console.WriteLine(materii.Name);
        }
    }
}
