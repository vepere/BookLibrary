namespace BookLibraryApi.Models
{
    internal class UpdateBookModel : BookToUpdateModel
    {
        public BookToUpdateModel BookToUpdate { get; set; }
    }
}