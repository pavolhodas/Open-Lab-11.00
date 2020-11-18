using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Library : Book
    {
        private int numberOfBooks;
        private int numberOfStudents;
        public List<string> studentsList = new List<string>(){ "paul", "John"};
        public List<int> studentsBook = new List<int>() {2, 2 };


        public int NumberOfBooks
        {
            get { return numberOfBooks; }
            set { numberOfBooks = value; }
            
        }
        public int NumberOfStudents
        {
            get { return numberOfStudents; }
            set { numberOfStudents = value; }
        }
        
        public List<string> StudentsList
        {
            get { return studentsList; }
            set { studentsList = value;}
        }
        public List<int> StudentsBook
        {
            get { return studentsBook; }
            set { studentsBook = value; }
        }
        
        public void WriteAll()
        {

            Console.WriteLine("WriteAll books: " + numberOfBooks);
            Console.WriteLine("All students: " + numberOfStudents);
            Console.WriteLine("Name of first student: " + studentsList[0]);
            Console.WriteLine("Name of second student: " + studentsList[1]);
            Console.WriteLine("Number of book to first student: " + studentsBook[0]);
            Console.WriteLine("Number of book to second student: " + studentsBook[1]);
        }
        public Library() : base()
        {
            numberOfBooks = -1;
            numberOfStudents = -1;
        }


        
    }
}
