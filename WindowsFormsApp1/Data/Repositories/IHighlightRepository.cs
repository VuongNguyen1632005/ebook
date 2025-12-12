using System.Collections.Generic;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Data.Repositories
{
    /// <summary>
    /// Interface cho Highlight/Note Repository
    /// </summary>
    public interface IHighlightRepository
    {
        void AddHighlight(Highlight highlight);
        void DeleteHighlight(int highlightId);
        
        List<Highlight> GetOnlyHighlights(int userId);
        List<Highlight> GetOnlyNotes(int userId);
        List<Highlight> GetHighlightsForBook(int bookId);
        
        List<Book> GetBooksWithHighlights();
        List<Book> GetBooksWithNotes();
        
        int DeleteAllNotes(int userId);
        int DeleteAllHighlights(int userId);
    }
}
