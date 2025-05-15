public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhập chiều cao: ");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập cân nặng: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        double bmi = weight / Math.Pow(height, 2); ;
        Console.WriteLine("BMI = " + bmi);
        if (bmi < 18.5)
            Console.WriteLine("Underweight");
        else if (bmi >= 18.5 && bmi < 25.0)
            Console.WriteLine("Normal");
        else if (bmi >= 25.00 && bmi < 30.0)
            Console.WriteLine("Overweight");
        else
            Console.WriteLine("Obese");    
    }   
}