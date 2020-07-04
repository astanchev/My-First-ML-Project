namespace MyFirstMLProject.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using System;

    [Route("api/[controller]")]
    [ApiController]
    public class PrognosisController : ControllerBase
    {
        [HttpPost]
        public string Post(InputTaskModel taskForPrognosis)
        {

            return String.Empty;
        }
    }
}
