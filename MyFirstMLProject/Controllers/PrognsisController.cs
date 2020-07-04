namespace MyFirstMLProject.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using System;
    using System.Globalization;
    using Microsoft.Extensions.ML;

    [Route("api/[controller]")]
    [ApiController]
    public class PrognosisController : ControllerBase
    {
        private readonly PredictionEnginePool<InputModel, OutputModel> predictionEnginePool;

        public PrognosisController(PredictionEnginePool<InputModel, OutputModel> predictionEnginePool)
        {
            this.predictionEnginePool = predictionEnginePool;
        }

        [HttpPost]
        public ActionResult<ResponseModel> Post(InputTaskModel taskForPrognosis)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var days = float.Parse(taskForPrognosis.Days);
            var minutes = float.Parse(taskForPrognosis.Minutes);
            var numberTasks = float.Parse(taskForPrognosis.NumberTasks);
            
            var input = new InputModel
            {
                Date = taskForPrognosis.Date,
                Days = days,
                Task = taskForPrognosis.TaskName,
                Department = taskForPrognosis.Department,
                Section = taskForPrognosis.Section,
                Minutes = minutes,
                CountTasks = numberTasks
            };

            var output = this.predictionEnginePool.Predict(input).Score;

            return new ResponseModel
            {
                Response = output.ToString("f2")
            };
            ;
        }
    }
}
