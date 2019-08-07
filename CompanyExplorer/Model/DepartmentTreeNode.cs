using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyExplorer.Model
{
    public class DepartmentTreeNode : TreeNode
    {
        public Department Department;

        public DepartmentTreeNode(Department department) : base(department.Name)
        {
            Department = department;
        }

        public override string ToString()
        {
            return Department.Name;
        }
    }
}
