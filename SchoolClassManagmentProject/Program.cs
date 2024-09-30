using SchoolClassManagmentProject.Models.AppExceptions;
using SchoolClassManagmentProject.Models.Entities;
using SchoolClassManagmentProject.Repos;

SchoolClass schoolClass9a = new SchoolClass(9, 'a',12);
SchoolClass schoolClass9b = new SchoolClass(9, 'b',13);
SchoolClass schoolClass10a = new SchoolClass(10, 'a', 12);
SchoolClass schoolClass10b = new SchoolClass(10, 'b', 12);

SchoolClass schoolClass12a = new SchoolClass(12, 'a', 12);
SchoolClass schoolClass12b = new SchoolClass(12, 'b', 12);

SchoolClass schoolClass13a = new SchoolClass(13, 'a',13);
SchoolClass schoolClass13b = new SchoolClass(13, 'b',13);

try
{
    schoolClass9a.SetLastGrade(1);
}
catch (LastGradeModificationErrorException lastGradeModificationError)
{
    Console.WriteLine(lastGradeModificationError.ParamName);
    Console.WriteLine(lastGradeModificationError.Message);
}

schoolClass9a.AdvanceGrade();
Console.WriteLine(schoolClass9a.Name);

SchoolClassRepo schoolClassRepo = new SchoolClassRepo();
schoolClass10b.SetClassMoney(1500);
schoolClassRepo.Add(schoolClass9a);
schoolClassRepo.Add(schoolClass9b);
schoolClassRepo.Add(schoolClass10a);
schoolClassRepo.Add(schoolClass10b);
schoolClassRepo.Add(schoolClass12a);
schoolClassRepo.Add(schoolClass12b);
schoolClassRepo.Add(schoolClass13a);
schoolClassRepo.Add(schoolClass13b);

Console.WriteLine($"Iskolában az osztályok száma: {schoolClassRepo.NumberOfSchoolClasses}");
Console.WriteLine($"Iskolában a végzős osztályok száma: {schoolClassRepo.NumberOfGraduateClasses}");

Console.WriteLine("Végzős osztályok:");
List<SchoolClass> gradeteClasses=schoolClassRepo.GetGraduateClasses();
foreach(SchoolClass graduateClass in gradeteClasses)
    Console.WriteLine(graduateClass);



int exsistingClassClassMoneyPerStudentInOneYear = schoolClassRepo.GetClassMoneyPerStudentInOneYear(10, 'b');
Console.WriteLine($"10.a osztáybevétele egy évben egy diák által:{exsistingClassClassMoneyPerStudentInOneYear}");

int nonExsistingClassClassMoneyPerStudentInOneYear = schoolClassRepo.GetClassMoneyPerStudentInOneYear(-1, 'z');
Console.WriteLine($"10.a osztáybevétele egy évben egy diák által:{nonExsistingClassClassMoneyPerStudentInOneYear}");

