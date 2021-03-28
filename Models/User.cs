using System.ComponentModel.DataAnnotations;

namespace MvcApp.Models
{
  public class User
  {
    public int Id { get; set; }

    [Required]
    public string Username { get; set; }

    [DataType(DataType.Password)]
    [Required]
    public string Password { get; set; }
  }
}