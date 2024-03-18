using System;

namespace Modifiers{
    // Access modifiers control how properities and methods are accessed
    class Book{
        // "public" members and methods can be accessed by any other
        // NOTE: this is  NOT the right way to expose internal data
        public string _name;

        // "protected" members can onlly be accessed by the class or a 
        // derived class from this on
        protected string _author;

        //"private" is the default and can only be accessed by code
        //within the class itself
        private int _pagesCount;

        public Book(string name,string author, int pages){
            _name = name;
            _author =  author;
            _pagesCount = pages;
        }

        public string GetDescription(){
            return $"{_name} by {_author}, {_pagesCount} pages.";
        }

        // Member variables can be accessed via methods

        public string GetName(){
            return _name;
        }

        public void SetName(string s){
            _name = s;
        }

        public void SetAuthor(string s){
            _author = s;
        }
         
        public void SetPageCount(int p){
            _pagesCount = p;
        }


    }
}