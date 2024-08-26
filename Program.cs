using System;

namespace Rectangle
{
    public class Rectangle
    {
      
        private double length;

       
        public readonly double width;

       
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;  

       
        public double height = 5.0;



       
        private double area; 
        public double Area
        {
            get
            {
                return length * width; 
            }
        }

       
      
        
    class Program
    {
        static void Main(string[] args)
        {
           
            Rectangle rect = new Rectangle(10.0, 5.0);
            Console.WriteLine($"Width (readonly): {rect.width}");

          
            Console.WriteLine($"Initial Height (with default value): {rect.height}");
            rect.height = 7.0; // Wert ändern
            Console.WriteLine($"Changed Height: {rect.height}");

           
            Console.WriteLine($"Area (read-only): {rect.Area}");

          
           
     
        }
    }
}
