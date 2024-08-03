using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;

namespace Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MovieType { get; set; }
        public string Duration { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        [NotMapped]
        public IFormFile? Images { get; set; }

        [JsonIgnore]
        public string? ImagePath { get; set; }
        public DateTime? CreatedDate { get; set; }

        public int? CreatedById { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public int? UpdatedById { get; set; }
    }
}
