namespace BMIService
{
    public class BMI
    {
        public double Height { get; set; } 
        public double Weight { get; set; } 
        public string[] More { get; set; } 


        public double CalculateBMI()
        {
            return (Weight / (Height/100 * Height/100)) ;
        }

        public string GetHealthStatus()
        {
            double bmi = CalculateBMI();

            More = new string[]
            {
                "https://www.cdc.gov/healthyweight/assessing/bmi/index.html",
                "https://www.nhlbi.nih.gov/health/educational/lose_wt/index.htm",
                "https://www.ucsfhealth.org/education/body_mass_index_tool/"
            };
            
            if (bmi < 18)
                return "Underweight >> Blue Color";
            else if (bmi >= 18 && bmi < 25)
                return "Normal >> Green Color";
            else if (bmi >= 25 && bmi < 30)
                return "pre-obese >> Purple Color";
            else
                return "Obese >> Red Color";

            
        }
    }
}