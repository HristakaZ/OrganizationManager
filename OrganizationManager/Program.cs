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
            OrganizationCreationStrategy organizationCreationStrategy = new OrganizationCreation();
            OrganizationComponent organizationComponent =
                organizationCreationStrategy.Create(abstractOrganizationBuilder, "Ico'S Company");
            organizationCreationStrategy = new EmployeeCreation();
            abstractOrganizationBuilder = new EmployeeBuilder();
            OrganizationComponent secondOrganizationComponent = organizationCreationStrategy.Create(abstractOrganizationBuilder,
                "Pesho");
            organizationComponent.Add(secondOrganizationComponent);
            organizationComponent.Display();
            OrganizationComponent thirdOrganizationComponent = organizationCreationStrategy.Create(abstractOrganizationBuilder,
                "Gosho");
            organizationComponent.Add(thirdOrganizationComponent);
            organizationComponent.Display();
            organizationComponent.Remove(thirdOrganizationComponent);
            organizationComponent.Display();
        }
    }
}
