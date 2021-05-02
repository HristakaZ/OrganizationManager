using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationManager
{
    public abstract class AbstractOrganizationBuilder
    {
        protected OrganizationComponent organizationComponent;
        public abstract OrganizationComponent BuildOrganizationComponent(string name);
    }
    public class OrganizationBuilder : AbstractOrganizationBuilder
    {
        public override OrganizationComponent BuildOrganizationComponent(string name)
        {
            organizationComponent = new OrganizationComposite(name);
            return organizationComponent;
        }
    }
    public class EmployeeBuilder : AbstractOrganizationBuilder
    {
        public override OrganizationComponent BuildOrganizationComponent(string name)
        {
            organizationComponent = new EmployeeLeaf(name);
            return organizationComponent;
        }
    }
}
