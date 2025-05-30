using System;

namespace OperatorOverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object with sample data
            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Demonstrate polymorphism by creating an IQuittable reference
            // pointing to an Employee object. This shows that an Employee
            // can be treated as an IQuittable type
            IQuittable quittableEmployee = employee;

            // Call the Quit method through the interface reference
            // This demonstrates polymorphic behavior as the actual implementation
            // from the Employee class will be called
            quittableEmployee.Quit();

            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}