using HandsOnExceptions.Models.Students;

try
{
    var student = new Student("John", 20);
}
catch (Exception ex) 
{
    Console.WriteLine("catch block is working");
    Console.WriteLine(ex.Message);
}