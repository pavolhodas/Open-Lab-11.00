using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Book
    {
        public Book()
        {
            _category = "-1";
            _author = "-1";
            _releaseDate = -1;
            _title = "-1";
            _pages = -1;
        }
        public Book(string nameOfTitle, int NumOfPages)
        {
            _category = "-1";
            _author = "-1";
            _releaseDate = -1;
            _title = nameOfTitle;
            _pages = NumOfPages;
        }

        public Book(string category, string author, int releaseDate, string title, int pages)
        {
            _category = category;
            _author = author;
            _releaseDate = releaseDate;
            _title = title;
            _pages = pages;
        }
        public override string ToString()
        {
            return $"{this._category}, {this._author}, {this._releaseDate}, {this._title}, {this._pages}";
        }

        private string _category { get; set; }
        private string _author;
        private int _releaseDate;
        private string _title;
        private int _pages;


        public string Category
        {

            set { _category = value; }
        }


        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }


        public int ReleaseDate
        {
            get { return _releaseDate; }
            set
            {
                if (value >= 1450 && value <= 2021)
                {
                    _releaseDate = value;
                }
                else
                {
                    _releaseDate = -1;
                }
            }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }



        public int Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                if (value > 0)
                {
                    _pages = value;
                }
                else
                {
                    _pages = 1;
                }
            }

        }
        public static List<string> categoryList = new List<string> { "detské", "romantické", "néučné", "sci-fi", "dobrodružné" };
    }
}
