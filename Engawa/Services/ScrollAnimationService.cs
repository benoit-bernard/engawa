using Microsoft.JSInterop;

namespace Engawa.Services;

public sealed class ScrollAnimationService
{
    private readonly IJSRuntime _js;

    public ScrollAnimationService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task InitAsync()
        => await _js.InvokeVoidAsync("scrollAnimations.init");

    public async Task ReinitAsync()
        => await _js.InvokeVoidAsync("scrollAnimations.reinit");
}
