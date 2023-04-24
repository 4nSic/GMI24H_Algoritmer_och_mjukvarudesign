using MyLinkedList;

namespace HashTables
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, long pnr, Termin startTermin, DateOnly inskrivningsDatum) : base(firstName, lastName, pnr)
        {
            StartTermin = startTermin;
            StartÅr = inskrivningsDatum;
            UserId = GenerateID();
        }

        public Termin StartTermin { get; private set; }
        public DateOnly StartÅr { get; private set; }
        public string UserId { get; private set; }

        public enum Termin
        {
            Vår = 'v',
            Höst = 'h'
        }

        private string GenerateID()
        {
            string id = "";

            if (StartTermin == Termin.Vår)
            {
                id += (char)Termin.Vår;
            }
            else if (StartTermin == Termin.Höst)
            {
                id += (char)Termin.Höst;
            }

            id += StartÅr.Year.ToString().Substring(2);
            id += FirstName.Substring(0, 3).ToLower() + LastName.Substring(0,2).ToLower();
            return id;
        }
    }



}
