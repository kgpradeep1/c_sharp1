using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// STEP 1-Create a user-defined exception that inherits the base class EXCEPTION
    /// </summary>
    public class TrackerException : Exception
    {
        public TrackerException(string? message) : base(message)
        {

        }
    }
    internal class ExceptionsCustom
    {
        public static void Main()
        {
            int age_count;
            try
            {
                
                Console.WriteLine("Enter the age");//14
                age_count = Convert.ToInt32(Console.ReadLine());
                if (age_count < 18 && age_count > 18)
                {
                    throw (new TrackerException("not eligible"));
                }
                else
                {
                    Console.WriteLine("eligible");
                }

            }
            catch (TrackerException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}