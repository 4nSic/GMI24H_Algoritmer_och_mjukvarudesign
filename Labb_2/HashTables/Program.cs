namespace HashTables
{
    internal class Program
    {
        static void Main()
        {
            Student truck = new Student("Daniel", "Dalberg", 198208317134, Student.Termin.Höst, new DateOnly(2021, 01, 01));
            Console.WriteLine(truck.UserId); 
        }
    }
}