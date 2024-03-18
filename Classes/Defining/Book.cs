using System;

namespace Defining{

    //classes have unique name within the namwspace
    public class Book{
        // classes have member variables or feilds to hold data

        string _name;
        string _author;
        int _pageCount;

        // classes have one or more constructors

        public Book(string name, string author, int pages){
            _name = name;
            _author = author;
            _pageCount = pages;
        }

        // methods are used to operate on the class and data

        public string GetDescription(){
            return $"{_name} by {_author}";
        }
    }
    
}