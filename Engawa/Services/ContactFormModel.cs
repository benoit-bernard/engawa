using System.ComponentModel.DataAnnotations;

namespace Engawa.Services;

public sealed class ContactFormModel
{
    [Required(ErrorMessage = "Le nom est requis.")]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "L'adresse email est requise.")]
    [EmailAddress(ErrorMessage = "Adresse email invalide.")]
    [MaxLength(200)]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Le sujet est requis.")]
    [MaxLength(200)]
    public string Subject { get; set; } = string.Empty;

    [Required(ErrorMessage = "Le message est requis.")]
    [MinLength(10, ErrorMessage = "Le message doit contenir au moins 10 caractères.")]
    [MaxLength(2000)]
    public string Message { get; set; } = string.Empty;
}
