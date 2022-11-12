using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreEfCoreTemplate.Controllers;

public class ControllerBase : Controller
{
    protected DateTime now = DateTime.UtcNow;

    public void SetSuccessMessage(string message)
        => TempData.Add(Constants.MessageSuccess, message);

    public void SetErrorMessage(string message)
    => TempData.Add(Constants.MessageError, message);

    public void SetWarningMessage(string message)
=> TempData.Add(Constants.MessageWarning, message);
}
