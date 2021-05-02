using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationManager
{
    public abstract class CreationStrategy
    {
        public abstract Component Create(AbstractOrganizationBuilder abstractOrganizationBuilder, string name);
    }
    public class OrganizationCreationStrategy : CreationStrategy
    {
        public override Component Create(AbstractOrganizationBuilder abstractOrganizationBuilder, string name)
        {
            Component organization = abstractOrganizationBuilder.BuildComponent(name);
            return organization;
        }
    }
    public class EmployeeCreationStrategy : CreationStrategy
    {
        public override Component Create(AbstractOrganizationBuilder abstractOrganizationBuilder, string name)
        {
            Component employee = abstractOrganizationBuilder.BuildComponent(name);
            return employee;
        }
    }
}
