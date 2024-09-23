namespace GradeCalculating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HighSchool liseli = new HighSchool("Ali Veli", "İstanbul Lisesi", 8563, EducationLevels.HighSchool, 50, 55);           
            liseli.WriteStudents();
            liseli.CalcGrade();

            Bachelor bachelor = new Bachelor("Veli Ali", "İstanbul Üniversitesi", 16203332, EducationLevels.Bachelor, "Hukuk", 88, 68);
            bachelor.WriteStudents();
            bachelor.CalcGrade();
        }
    }
}
