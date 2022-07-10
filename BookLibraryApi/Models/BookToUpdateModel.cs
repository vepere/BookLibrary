using System;

namespace BookLibraryApi.Models
{
    public class BookToUpdateModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public string? Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

    }
}