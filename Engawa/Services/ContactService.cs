using Microsoft.JSInterop;

namespace Engawa.Services;

public sealed class ContactService
{
    private const string ContactEmail = "contact@engawa.fr";

    private readonly IJSRuntime _js;

    public ContactService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task SendAsync(ContactFormModel model)
    {
        var body = $"Nom : {model.Name}\nEmail : {model.Email}\n\nMessage :\n{model.Message}";
        await _js.InvokeVoidAsync("contactService.sendMail", ContactEmail, model.Subject, body);
    }
}
