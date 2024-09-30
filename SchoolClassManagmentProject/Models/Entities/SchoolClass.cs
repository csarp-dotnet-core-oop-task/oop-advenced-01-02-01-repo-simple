using SchoolClassManagmentProject.Models.AppExceptions;

namespace SchoolClassManagmentProject.Models.Entities
{
    public class SchoolClass
    {
        private byte _grade;
        private char _gradeLetter;
        private byte _lastGrade;
        private int _classMoney;
        public SchoolClass()
        {
            _grade = byte.MinValue;
            _gradeLetter = char.MinValue;
            _classMoney = int.MinValue;
        }

        public SchoolClass(byte grade, char gradeLetter, byte lastGrade)
        {
            _grade = grade;
            _gradeLetter = gradeLetter;
            _lastGrade = lastGrade;
            _classMoney = int.MinValue;
        }

        public byte Grade { get => _grade; set => _grade = value; }
        public char GradeLetter { get => _gradeLetter; set => _gradeLetter = value; }
        public byte LastGrade { get => _lastGrade; private set => _lastGrade = value; }
        public int ClassMoney { get => _classMoney; private set => _classMoney = value; }
        public string Name => $"{_grade}. {_gradeLetter}";
        public bool HasGraduated => _grade > _lastGrade;
        public bool IsGraduate => _grade == _lastGrade;
        public bool IsActive => !HasGraduated;

        public void SetClassMoney(int classMoney)
        {
            _classMoney = classMoney; 
        }
        public void SetLastGrade(byte newGrade)
        {
            if (newGrade > _grade)
                LastGrade = newGrade;
            else
                throw new LastGradeModificationErrorException($"{nameof(SchoolClass)} osztályba, {nameof(SetLastGrade)} metódusban paraméter hiba történt.", nameof(newGrade),null);
        }

        public void AdvanceGrade()
        {
            if (IsActive)
                Grade = (byte) (Grade + 1);
        }

        ~SchoolClass()
        {
            Console.WriteLine($"{_grade}. {_gradeLetter} osztály megszünt.");
        }

        public override string ToString()
        {
            return $"{Grade}.{GradeLetter}";
        }
    }
}
