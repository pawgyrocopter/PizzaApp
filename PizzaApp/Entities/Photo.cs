using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaApp.Entities;

[Table("Photos")]
public class Photo
{
    public int Id { get; set; }

    public string Url { get; set; }

    public string PublicId { get; set; }

}