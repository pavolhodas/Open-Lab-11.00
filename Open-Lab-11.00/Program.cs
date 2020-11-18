using System;

namespace Open_Lab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Library schoolLibrary = new Library();
            schoolLibrary.NumberOfBooks = 4;
            schoolLibrary.NumberOfStudents = 2;

            schoolLibrary.StudentsBook[0] = 2;
            schoolLibrary.StudentsBook[1] = 2;
            schoolLibrary.StudentsList[0] = "Paul";
            schoolLibrary.StudentsList[1] = "John";

            schoolLibrary.WriteAll();
        }
    }
}
