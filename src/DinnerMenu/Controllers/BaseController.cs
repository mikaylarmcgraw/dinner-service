namespace DinnerMenu
{

    using DinnerMenu.Core;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    public class BaseController<T> : ControllerBase where T : ModelBase, new()
    {

    }
}
