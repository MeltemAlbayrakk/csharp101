using System;



public class SignException : SystemException
{
    public SignException()
         : base()
    { }

    public SignException(String message)
        : base(message)

    { }

    public SignException(String message, Exception innerException)
        : base(message, innerException)
    { }

   
}
class Calculator
{
    internal int power(int n ,int p)
    {
        try
        {
            if (n<0||p<0)
            {
                throw new SignException("n and p should be non-negative");
            }
            else
            {
                int sonuc=Convert.ToInt32(Math.Pow(Convert.ToDouble(n),Convert.ToDouble(p)));
                return sonuc;
            }
            
        }
        catch (SignException signException)
        {

            Console.WriteLine(signException);
        }
           
    }
}
//Write your code here

class Solution
{
    static void Main(String[] args)
    {
        Calculator myCalculator = new Calculator();
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);
            try
            {
                int ans = myCalculator.power(n, p);
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

    }
}