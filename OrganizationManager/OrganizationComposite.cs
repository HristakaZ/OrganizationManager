using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationManager
{
    public abstract class OrganizationComponent
    {
        protected string name;
        public OrganizationComponent(string name)
        {
            this.name = name;
        }
        public abstract void Add(OrganizationComponent organizationComponent);
        public abstract void Remove(OrganizationComponent organizationComponent);
        public abstract void Display();
    }
    public class OrganizationComposite : OrganizationComponent
    {
        private List<OrganizationComponent> organizations = new List<OrganizationComponent>();
        public OrganizationComposite(string name) : base(name)
        {

        }
        public override void Add(OrganizationComponent teamComponent)
        {
            organizations.Add(teamComponent);
        }

        public override void Display()
        {
            Console.WriteLine("Organization Name: " + this.name);
            foreach (OrganizationComponent organization in organizations)
            {
                organization.Display();
            }
        }

        public override void Remove(OrganizationComponent organizationComponent)
        {
            organizations.Remove(organizationComponent);
        }
    }
    public class EmployeeLeaf : OrganizationComponent
    {
        public EmployeeLeaf(string name) : base(name)
        {

        }
        public override void Add(OrganizationComponent teamComponent)
        {
            Console.WriteLine("Cannot make operations on a leaf node(Employee).");
        }

        public override void Display()
        {
            Console.WriteLine("Employee Name: " + this.name);
        }

        public override void Remove(OrganizationComponent teamComponent)
        {
            Console.WriteLine("Cannot make operations on a leaf node(Employee).");
        }
    }
}