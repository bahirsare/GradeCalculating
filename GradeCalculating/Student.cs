namespace GradeCalculating
{
    enum EducationLevels
    {
        PrimarySchool, SecondarySchool, HighSchool, Bachelor
    };
    class Student
    {
        internal static List<Student> Students = new List<Student>();
        protected string FullName;
        protected string SchoolName;//(Alt sınıflarda tanımlanırsa değişecek)
        protected int SchoolNumber;
        protected EducationLevels EducationLevel;


        //* Yapıcı metot ile nesne tanımlandığında notlar otomatik olarak ArrayListe eklenecek.(constructer 4     parametre ile çağırılacak.)
        //    * NotHesapla() : Ekrana "Not Bilgisi Eksik !" yazdıracak.(Alt sınıflarda tanımlanırsa değişecek)

        public Student(string fullName, int schoolNumber, EducationLevels educationLevel, string schoolName = "Açıktan Eğitim")
        {

            FullName = fullName;
            SchoolName = schoolName;
            SchoolNumber = schoolNumber;
            EducationLevel = educationLevel;
            Students.Add(this);
        }
        internal void WriteStudents()
        {
            Console.Write($"\nÖğrencinin;\nAdı:{FullName} Okul Adı:{SchoolName} Okul Numarası:{SchoolNumber} Okul düzeyi:{EducationLevel} ");
        }
        internal void CalcGrade()
        {
            Console.WriteLine("Not Bilgisi Eksik!!");
        }
    }
    class HighSchool : Student
    {
        internal static List<HighSchool> HighSchoolers = new List<HighSchool>();
        int Grade1;
        int Grade2;
        public HighSchool(string fullName, string schoolName, int schoolNumber, EducationLevels educationLevel, int grade1, int grade2) : base(fullName, schoolNumber, educationLevel, schoolName)
        {
            Grade1 = grade1;
            Grade2 = grade2;
            HighSchoolers.Add(this);
        }
        internal new void WriteStudents()
        {
            base.WriteStudents();
            Console.WriteLine($"1.Not: {Grade1} 2.Not: {Grade2}");
        }
        internal new void CalcGrade()
        {

            //5	85.00-100	Pekiyi
            //4	70.00-84.99	İyi
            //3	60.00-69.99	Orta
            //2	50.00-59.99	Geçer	
            //1	0 - 49.99	Tekrar
            string status = "";
            double Average =( Grade1 + Grade2)/2;
            if (Average > 0 && Average < 50)
            {
                status = "Tekrar";
            }
            
            else if (Average > 50 && Average < 60)
            {
                status = "Geçer";
            }
            else if (Average > 60 && Average < 70)
            {
                status = "Orta";
            }
            else if (Average > 70 && Average < 85)
            {
                status = "İyi";
            }
            else if (Average > 85 && Average < 100)
            {
                status = "Pekiyi";
            }
            Console.WriteLine($"Öğrencinin dönem sonu ders notu: {status}");
        }
    }
    class Bachelor : Student
    {
        static List<Bachelor> Bachelors = new List<Bachelor>();
        string Faculty;
        int MidtermGrade;
        int FinalGrade;

        public Bachelor(string fullName, string schoolName, int schoolNumber, EducationLevels educationLevel, string faculty, int midtermGrade, int finalGrade) : base(fullName, schoolNumber, educationLevel, schoolName)
        {
            Faculty = faculty;
            MidtermGrade = midtermGrade;
            FinalGrade = finalGrade;
            Bachelors.Add(this);
        }

        internal new void CalcGrade()
        {
            string status = "";
            double weightedAverage = MidtermGrade * 0.4 + FinalGrade * 0.6;
            if (weightedAverage > 0 && weightedAverage < 45)
            {
                status = "F";
            }
            else if (weightedAverage > 45 && weightedAverage < 50)
            {
                status = "E";
            }
            else if (weightedAverage > 50 && weightedAverage < 60)
            {
                status = "D";
            }
            else if (weightedAverage > 60 && weightedAverage < 70)
            {
                status = "C";
            }
            else if (weightedAverage > 70 && weightedAverage < 85)
            {
                status = "B";
            }
            else if (weightedAverage > 85 && weightedAverage < 100)
            {
                status = "A";
            }
            Console.WriteLine($"Öğrencinin dönem sonu ders notu: {status}");
        }
        internal new void WriteStudents()
        {

            base.WriteStudents();
            Console.WriteLine($"Fakülte: {Faculty} Vize Notu: {MidtermGrade} Final Notu: {FinalGrade}");
        }
    }
}
