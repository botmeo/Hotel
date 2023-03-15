using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class ToBook_BUS
    {
        private readonly ToBook_DAL dalToBook = new ToBook_DAL();

        public DataTable GetDataBook()
        {
            return dalToBook.GetDataBook();
        }

        public List<BookRoom_DTO> LoadBookList()
        {
            return dalToBook.LoadBookList();
        }

        public List<BookRoom_DTO> GetBookList(string idBook)
        {
            return dalToBook.GetBookList(idBook);
        }

        public bool CheckIdBook(string id)
        {
            return dalToBook.CheckIdBook(id);
        }

        public bool CheckChangeRoom(string id)
        {
            return dalToBook.CheckChangeRoom(id);
        }

        public void AddBookRoom(BookRoom_DTO book)
        {
            dalToBook.AddBookRoom(book);
        }

        public void EditBookRoom(BookRoom_DTO book)
        {
            dalToBook.EditBookRoom(book);
        }

        public void DeleteBookRoom(string id)
        {
            dalToBook.DeleteBookRoom(id);
        }

        public DataTable SearchBook(string searchText)
        {
            return dalToBook.SearchBook(searchText);
        }
    }
}
