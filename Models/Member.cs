using System;
using System.ComponentModel.DataAnnotations;

namespace MvcApp.Models
{
  public class Member
  {
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public string BirthPlace { get; set; }

    [Required]
    public bool IsGraduated { get; set; }

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }
  }
}
