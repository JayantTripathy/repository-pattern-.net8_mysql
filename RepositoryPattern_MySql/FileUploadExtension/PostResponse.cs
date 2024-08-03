using Domain.Entities;

namespace RepositoryPattern_MySql.FileUploadExtension
{
    public class PostResponse : BaseResponse
    {
        public Movie Post { get; set; }
    }
}
