public class Author{
    
    string name;

    string email;

    char gender;

    public string Name { get => name; set => name = value; }

    public Author(string name, string email, char gender)
    {
        this.name = name;
        this.email = email;
        this.gender = gender;
    }


}

