using System;

namespace NLayerProject
{
    public class Program
    {
        /// <summary>
        /// Main 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                var plugwine = new Plugwine();
                plugwine.Exec().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}

