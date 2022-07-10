using System;

namespace BookLibraryApi.Models
{
    public  class BooksModel
    {
        public string? Title { get; set; }

        public AuthorModel Author { get; set; }

        public string? Publisher { get; set; }

        public DateTime? ReleaseDate { get; set; }

    }
}