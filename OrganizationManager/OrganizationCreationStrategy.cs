using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationManager
{
    public abstract class OrganizationCreationStrategy
    {
        public abstract OrganizationComponent Create(AbstractOrganizationBuilder abstractOrganizationBuilder, string name);
    }
    public class OrganizationCreation : OrganizationCreationStrategy
    {
        public override OrganizationComponent Create(AbstractOrganizationBuilder abstractOrganizationBuilder, string name)
        {
            abstractOrganizationBuilder = new OrganizationBuilder();
            OrganizationComposite organization = (OrganizationComposite)abstractOrganizationBuilder.BuildOrganizationComponent(name);
            return organization;
        }
    }
    public class EmployeeCreation : OrganizationCreationStrategy
    {
        public override OrganizationComponent Create(AbstractOrganizationBuilder abstractOrganizationBuilder, string name)
        {
            abstractOrganizationBuilder = new EmployeeBuilder();
            EmployeeLeaf employee = (EmployeeLeaf)abstractOrganizationBuilder.BuildOrganizationComponent(name);
            return employee;
        }
    }
}
