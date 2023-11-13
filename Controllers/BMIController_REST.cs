using Microsoft.AspNetCore.Mvc;
using BMIService; 

[Route("[controller]")]
[ApiController]
public class BmiController : ControllerBase
{
    [HttpGet("GetBmiData")]
    public ActionResult<object> GetBmiData(double height, double weight)
    {
        if (height == 0 || weight == 0)
        {
            return BadRequest("Height and weight cannot be zero.");
        }

        BMI bmiData = new BMI { Height = height, Weight = weight };

        double bmi = bmiData.CalculateBMI();
        string status = bmiData.GetHealthStatus();

        // 构建返回的匿名对象，包含 BMI、健康状态和外部链接
        var result = new
        {
            BMI = bmi,
            HealthStatus = status,
            More = bmiData.More
        };

        return result;
    }
}