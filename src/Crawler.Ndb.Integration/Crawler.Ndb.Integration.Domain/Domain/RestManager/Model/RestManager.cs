using System.ComponentModel.DataAnnotations;

namespace Crawler.Ndb.Integration.Web.Domain.RestManager.Model
{
    public class RestManager
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string[] Methods { get; set; } = Array.Empty<string>();
        public List<RestFieldModel> Fields { get; set; } = new();
    }

    public class RestFieldModel
    {
        [Key]
        public Guid Id { get; set; }
        public string FieldName { get; set; } = string.Empty;
        public string FieldType { get; set; } = "string"; // Ex: string, int, object, array, etc.
        public bool IsRequired { get; set; } = false;
        public List<RestFieldModel>? SubFields { get; set; } // Para objetos aninhados
    }
}
