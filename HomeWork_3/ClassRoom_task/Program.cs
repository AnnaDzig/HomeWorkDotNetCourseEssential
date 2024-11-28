// See https://aka.ms/new-console-template for more information
using HomeWork_3;

//# Завдання 2 
class Program
{
    static void Main(string[] args)
    {
        Pupil excelentPupil = new ExcelentPupil();
        Pupil goodPupil = new GoodPupil();
        Pupil badPupil = new BadPupil();

        ClassRoom classRoom = new ClassRoom(excelentPupil, goodPupil, badPupil);


        classRoom.ShowPupils();


        Console.ReadLine();

    }
}

