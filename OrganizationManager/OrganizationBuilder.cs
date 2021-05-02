using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationManager
{
    public abstract class AbstractOrganizationBuilder
    {
        protected Component component;
        public abstract Component BuildComponent(string name);
    }
    public class OrganizationBuilder : AbstractOrganizationBuilder
    {
        public override Component BuildComponent(string name)
        {
            component = new OrganizationComposite(name);
            return component;
        }
    }
    public class EmployeeBuilder : AbstractOrganizationBuilder
    {
        public override Component BuildComponent(string name)
        {
            component = new EmployeeLeaf(name);
            return component;
        }
    }
}
