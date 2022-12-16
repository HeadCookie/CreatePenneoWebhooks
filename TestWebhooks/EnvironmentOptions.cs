using System.ComponentModel.DataAnnotations;
using Sharprompt;

public class EnvironmentOptions
{
    [Display(Name = "Enter your API key")]
    [DataType(DataType.Password)]
    [Required]
    public string Key { get; set; }
    
    [Display(Name = "Enter your API secret")]
    [DataType(DataType.Password)]
    [Required]
    public string Secret { get; set; }

    [Display(Name = "Select your environment")]
    [Required]
    [InlineItems("app", "sandbox", "staging")]
    public string Environment { get; set; }
    
    [Display(Name = "Enter your webhook endpoint")]
    [Required]
    public string WebhookEndpoint { get; set; }
    
    [Display(Name = "Select your subscription topic")]
    [Required]
    [InlineItems("casefile", "signer")]
    public string Topic { get; set; }
}