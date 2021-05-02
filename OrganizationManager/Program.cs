using System;

namespace OrganizationManager
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TO DO: probably should implement the state pattern as well, so as to change the employee creation or 
             organization creation state(when the user enters a company, we should switch to creating employees via the user 
            input), might want to put this also in a facade, just for the app to be more clear*/
            AbstractOrganizationBuilder abstractOrganizationBuilder = new OrganizationBuilder();
            CreationStrategy creationStrategy = new OrganizationCreationStrategy();
            Component company = creationStrategy.Create(abstractOrganizationBuilder, "Ico'S Company");
            Component secondCompany = creationStrategy.Create(abstractOrganizationBuilder, "Tosho'S Company");
            creationStrategy = new EmployeeCreationStrategy();
            abstractOrganizationBuilder = new EmployeeBuilder();
            Component firstEmployee = creationStrategy.Create(abstractOrganizationBuilder, "Pesho");
            company.Add(firstEmployee);

            company.Display();

            secondCompany.Add(firstEmployee);
            secondCompany.Display();
            Component secondEmployee = creationStrategy.Create(abstractOrganizationBuilder, "Gosho");
            company.Add(secondEmployee);
            company.Display();
            secondCompany.Add(secondEmployee);
            company.Remove(secondEmployee);
            company.Display();
            secondCompany.Display();
        }
    }
}
