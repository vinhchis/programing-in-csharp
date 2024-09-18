namespace session04_Properties;

public class Ex01_Field_Properties
{
    private string java;
    private string csharp;

    public string GetJava()
    {
        return java;
    }

    public void SetJava(string java)
    {
        this.java = java;
    }

    // Using Properties - Block declaration
    public string? CSharp {
        get {
            return csharp;
        }

        set {
            // "value" keyword 
            csharp = value;
        }
    }

    // static void Main(string[] args)
    // {
    //     Ex01_Field_Properties java, cSharp;

    //     java = new Ex01_Field_Properties();
    //     java.SetJava("Hello Java");
    //     System.Console.WriteLine(java.GetJava());

    //     cSharp = new Ex01_Field_Properties();
    //     cSharp.CSharp = "Hello C#";
    //     System.Console.WriteLine(cSharp.CSharp);
    // }
}







