using System;

namespace BookLibraryApi.Models
{
    public class AuthorModel
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}