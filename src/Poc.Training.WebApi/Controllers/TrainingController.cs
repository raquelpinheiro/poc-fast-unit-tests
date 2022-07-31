using Microsoft.AspNetCore.Mvc;

namespace Poc.Training.Api
{
    [Route("trainning")]
    [ApiController]
    public class TrainingController : ControllerBase
    {

        /// <summary>
        /// Add a trainning to collection
        /// </summary>
        /// <returns></returns>
        [Route("add")]
        [HttpPost]
        public IActionResult Add()
        {
            return Ok();
        }
    }
}
