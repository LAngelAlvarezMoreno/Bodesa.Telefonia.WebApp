using Microsoft.JSInterop;
namespace Bodesa.Telefonia.WebApp.Extentions
{
    public static class JsRuntimeExtentions
    {
        public static ValueTask ToastrSuccess(this IJSRuntime jSRuntime, string message)
        {
            return jSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }

        public static ValueTask ToastrError(this IJSRuntime jSRuntime, string message)
        {
            return jSRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }

        public static ValueTask ToastrWarning(this IJSRuntime jSRuntime, string message)
        {
            return jSRuntime.InvokeVoidAsync("ShowToastr", "warning", message);
        }

        public static ValueTask ToastrInfo(this IJSRuntime jSRuntime, string message)
        {
            return jSRuntime.InvokeVoidAsync("ShowToastr", "info", message);
        }
    }
}
