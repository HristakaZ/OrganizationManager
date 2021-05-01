using System;

namespace OrganizationManager
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TO DO: make the console app more interactive, ask the user for the input and enter input while the user wants to - 
             probably with the state design pattern, if the user wants to write the organization's name, then the state is on,
            if he doesn't want to, then the state is off, and based on the state, we will just cancel a while/do while loop*/
            OrganizationComposite organization = new OrganizationComposite("Ico'S Company");
            EmployeeLeaf employee = new EmployeeLeaf("Ico");
            EmployeeLeaf secondEmployee = new EmployeeLeaf("Nqkuv Tam");
            organization.Add(employee);
            organization.Add(secondEmployee);
            organization.Display();
            Console.WriteLine();
            organization.Remove(secondEmployee);
            organization.Display();
            Console.WriteLine();
        }
    }
}
