using Microsoft.AspNetCore.Mvc;
using Model;
using Database;

namespace backend.Controllers;

[ApiController]
public class BaseController: ControllerBase
{
    public BaseController()
    {

    }

    [HttpGet]
    [Route("login")]
    public ActionResult Get()
    {
        return Ok();
    }

    [HttpPost]
    [Route("registration")]
    public ActionResult Post([FromBody] AccountModel account)
    {
        // int result = new DatabaseContext().Registration(account);
        // if (result != 0)
        // {
        //     return Ok();
        // }
        return Ok();
    }
}