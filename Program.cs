using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// namespace _02_Cars




namespace Helloworlds;

// In .NET our program is contained within its own class
class Program
{

    static void Main(string[] args){
        // User field: username, password, email, phone, dateOfBirth user_age, salary, isEmployed;
        User user1 = new( "Mwamuziscodev", "Password1", "mwamuziscodev@gmail.com", "254712345678", new DateTime(1990, 1, 1), 30, 100000,true);
        // print
        Console.WriteLine(user1.GetUserInformation());
        // Console.WriteLine(user1.GetUserAge());
        // Console.WriteLine(user1.GetUserSalary());

        // Products fields: name, description, price, quantity, category, manufacturer, color, size
        Products product1 = new("Macbook Pro", "Apple Macbook Pro 2020", 200000, 10, "Electronics", "Apple", "Silver", "13 inch", "Yes");
        // print
        Console.WriteLine(product1.GetProductInformation());
        // Console.WriteLine(product1.GetProductPrice());

        // Greeting user1
        Greeting(
            user1.GetUsername(),
            user1.GetIsEmployed()
        );

    }
    static void Greeting(string name, bool employed) {
        if (employed == true){
            Console.WriteLine($"Hello {name}, welcome to the C# class. We are glad you are here.");
        } else {
            Console.WriteLine($"Hello {name}, welcome to the C# class. We are glad you are here. We noticed you are not employed, we hope you get a job soon.");
        }
    }
}
