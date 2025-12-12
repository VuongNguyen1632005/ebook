using System.Collections.Generic;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Data.Repositories
{
    /// <summary>
    /// Interface cho Book Repository - Pattern Repository
    /// </summary>
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        List<Book> GetDeletedBooks();
        List<Book> GetFavoriteBooks();
        List<Book> GetBooksByShelf(int shelfId);
        Book GetBookById(int bookId);
        
        void AddBook(Book book);
        void UpdateBookInfo(int bookId, string newTitle, string newAuthor, string newDescription);
        void DeleteBook(int bookId);
        void RestoreBook(int bookId);
        void PermanentlyDeleteBook(int bookId);
        void ToggleFavorite(int bookId);
        
        bool IsBookExists(string filePath);
    }
}
