using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass sampleObject = new SampleClass();
            sampleObject.Propertychanged += SampleObject_Propertychanged;

            Console.WriteLine("Изменение свойства SampleProperty...");
            sampleObject.SampleProperty = 10;
        }

        private static void SampleObject_Propertychanged(object sender, PropertyeventArgs e)
        {
            Console.WriteLine($"Свойство {e.PropertyName} было изменено.");
        }
    }
}
