using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationManager
{
    public abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display();
    }
    public class OrganizationComposite : Component
    {
        private List<Component> components = new List<Component>();
        public OrganizationComposite(string name) : base(name)
        {

        }
        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Display()
        {
            Console.WriteLine("Organization Name: " + this.name);
            Console.WriteLine("Employees:");
            foreach (Component component in components)
            {
                component.Display();
            }
            Console.WriteLine("==================");
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }
    }
    public class EmployeeLeaf : Component
    {
        public EmployeeLeaf(string name) : base(name)
        {

        }
        public override void Add(Component component)
        {
            Console.WriteLine("Cannot make operations on a leaf node(Employee).");
        }

        public override void Display()
        {
            Console.WriteLine("Employee Name: " + this.name);
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Cannot make operations on a leaf node(Employee).");
        }
    }
}