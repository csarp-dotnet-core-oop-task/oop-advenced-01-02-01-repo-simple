using SchoolClassManagmentProject.Models.Entities;

namespace SchoolClassManagmentProject.Repos
{
    public class SchoolClassRepo
    {
        private List<SchoolClass> _schoolClasses;
        public SchoolClassRepo()
        {
            _schoolClasses = new List<SchoolClass>();
        }
        public int NumberOfSchoolClasses => _schoolClasses.Count;
        public int NumberOfGraduateClasses => _schoolClasses.Count(schoolClass => schoolClass.IsGraduate);

        public void Add(SchoolClass schoolClass)
        {
            _schoolClasses.Add(schoolClass);
        }

        public void Remove(int grade, char gradeLetter)
        {
            SchoolClass? schoolClassToRemove = _schoolClasses.Find(schoolClass => schoolClass.Grade == grade && schoolClass.GradeLetter == gradeLetter);
            if (schoolClassToRemove is not null)
            {
                _schoolClasses.Remove(schoolClassToRemove);
            }
        }
        public List<SchoolClass> GetGraduateClasses()
        {
            return _schoolClasses.Where(schoolClass => schoolClass.IsGraduate).ToList();
        }

        public int GetClassMoneyPerStudentInOneYear(int grade, char gradeLetter)
        {
            // 10 hónap alatt egy diák által befizetett osztálypénz
            return 10*_schoolClasses.Find(schoolClass => schoolClass.Grade == grade && schoolClass.GradeLetter == gradeLetter)?.ClassMoney ?? -1; // default(int);
        }

        public List<SchoolClass> GetSchoolClassesPerGrade(int grade)
        {
            // Adott évfolyam osztályi
            return _schoolClasses.Where(schoolClass => schoolClass.Grade == grade).ToList();
        }

        public int GetNumberOfSchoolClassesPerGrade(int grade)
        {
            // Adott évfolyam osztályinak száma
            return GetSchoolClassesPerGrade(grade).Count;
        }

        public List<byte> GetGrades()
        {
            // Beiskolázott évfolyamok
            return _schoolClasses.Select(schoolClass => schoolClass.Grade).Distinct().ToList();
        }
    }
}
