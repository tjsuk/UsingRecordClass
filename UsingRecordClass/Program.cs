// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record

using UsingRecordClass;

class Program
{
    public static void Main()
    {
        var student1 = new Student("John", "Doe", 25, "", "johndoe@student.com");
        var student2 = new Student("Teresa", "Green", 27, "", "teresagreen@student.com");
    }
}