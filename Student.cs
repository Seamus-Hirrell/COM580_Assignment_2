using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace assignment_2;

public partial class Student
{
  public int Id { get; set; }

  [DataType(DataType.Text)]
  [Required(ErrorMessage = "Please enter a first name")]
  public string FirstName { get; set; } = null!;

  [DataType(DataType.Text)]
  [Required(ErrorMessage = "Please enter a last name")]
  public string LastName { get; set; } = null!;

  [DataType(DataType.EmailAddress)]
  [Required(ErrorMessage = "Please enter an email address")]
  public string EmailAddress { get; set; } = null!;

  [DataType(DataType.PhoneNumber)]
  [Required(ErrorMessage = "Please enter a phone number")]
  [RegularExpression(@"^(\d{3}-\d{3}-\d{4})$", ErrorMessage = "Please enter a valid phone number (xxx-xxx-xxxx)")]
  public string PhoneNumber { get; set; } = null!;

  [DataType(DataType.Text)]
  [Required(ErrorMessage = "Please enter a country")]
  public string Country { get; set; } = null!;
}
