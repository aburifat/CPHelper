using Microsoft.AspNetCore.Mvc;
using CPHelper.Managers;
using CPHelper.Requests;

namespace CPHelper.Controllers
{
    [Route("api/leetcode/[controller]/[action]")]
    [ApiController]
    public class OutputGenController : ControllerBase
    {
        public readonly IOutputGenManager _outputGenManager;

        public OutputGenController(IOutputGenManager outputGenManager)
        {
            _outputGenManager = outputGenManager;
        }

        [HttpPost]
        public async Task<IActionResult> TwoSum([FromBody] INTArrINTRequest request)
        {
            var result = await _outputGenManager.TwoSum(request);
            return Ok(result);
        }
    }
}
