using System.ComponentModel.DataAnnotations;

public class Confirmation
{
    [Display(Name = "Enter your confirmation token")]
    [Required]
    public string Token { get; set; }
}