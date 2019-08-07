using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CompanyExplorer.Model;

namespace CompanyExplorer.Forms
{
    public partial class MainForm : Form
    {
        public List<Department> Departments { get; private set; }
        public List<Empoyee> Employees { get; private set; }

        private List<Empoyee> bindEmployees = new List<Empoyee>();
        private Empoyee selectedEmployee => dataGridView.SelectedRows.Count > 0 ? dataGridView.SelectedRows[0].DataBoundItem as Empoyee : null;

        public MainForm()
        {
            using (CompanyContext db = new CompanyContext())
            {
                Departments = db.Departments.ToList();
                Employees = db.Empoyees.ToList();
            }

            InitializeComponent();
            // Инициализация дерева отделов
            UpdateDepartmentTree();
            treeView.ExpandAll();
            // Инициализация просмотра сотрудников
            dataGridView.DataSource = bindEmployees;
        }

        public void UpdateDepartmentTree(DepartmentTreeNode node = null)
        {
            Guid? parentId = (node == null ? (Guid?)null : node.Department.ID);
            var childs = Departments.Where(d => d.ParentDepartmentID == parentId);
            foreach (Department dept in childs)
            {
                var newNode = new DepartmentTreeNode(dept);
                if (node == null)
                {
                    treeView.Nodes.Add(newNode);
                }
                else
                {
                    node.Nodes.Add(newNode);
                }
                UpdateDepartmentTree(newNode);
            }
        }

        private void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnDepartmentSelected(object sender, TreeViewEventArgs e)
        {
            var selectedNode = (DepartmentTreeNode)treeView.SelectedNode;
            Guid departmentID = selectedNode.Department.ID;
            bindEmployees = Employees.Where(emp => emp.DepartmentID == departmentID).ToList();
            dataGridView.DataSource = bindEmployees;
        }

        private void OnCreateEmployee(object sender, EventArgs e)
        {
            using (var newEmployeeDialog = new EmployeeForm(Departments))
            {
                if (newEmployeeDialog.ShowDialog() == DialogResult.OK)
                {
                    var newEmployee = newEmployeeDialog.Employee;
                    using (CompanyContext db = new CompanyContext())
                    {
                        try
                        {
                            db.Empoyees.Add(newEmployee);
                            db.SaveChanges();
                            Employees.Add(newEmployee);
                        }
                        catch (Exception)
                        {
                            ShowErrorDialog("Ошибка сохранения пользователя в базе данных.");
                        }
                    }
                }
            }
        }

        private void OnDeleteEmployee(object sender, EventArgs e)
        {
            var deleteEmployee = selectedEmployee;
            if (MessageBox.Show("Вы уверены что хотите уволить сотрудника " + selectedEmployee.SurName + "?",
                "Увольнение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (CompanyContext db = new CompanyContext())
                {
                    bool success = false;
                    try
                    {
                        // Удаляем выбранного сотрудника из БД
                        db.Empoyees.Remove(db.Empoyees.Single(emp => emp.ID == selectedEmployee.ID));
                        db.SaveChanges();
                        success = true;
                    }
                    catch (Exception exeption)
                    {
                        ShowErrorDialog(string.Format("Ошибка удаления пользователя из базы данных. ({0})", exeption.ToString()));
                    }
                    if (success)
                    {
                        // Удаляем его из локальный переменных
                        Employees.Remove(deleteEmployee);
                        bindEmployees.Remove(deleteEmployee);
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = bindEmployees;
                    }
                }
            }
        }

        private void OnEditEmployee(object sender, EventArgs e)
        {
            using (var editEmployeeDialog = new EmployeeForm(Departments, selectedEmployee))
            {
                if (editEmployeeDialog.ShowDialog() == DialogResult.OK)
                {
                    var editedEmployee = editEmployeeDialog.Employee;
                    bool success = false;
                    using (CompanyContext db = new CompanyContext())
                    {
                        try
                        {
                            // Изменяем выбранного сотрудника
                            db.Entry(editedEmployee).State = EntityState.Modified;
                            db.SaveChanges();
                            success = true;
                        }
                        catch (Exception)
                        {
                            ShowErrorDialog("Ошибка сохранения пользователя в базе данных.");
                        }
                        if (success)
                        {
                            dataGridView.DataSource = null;
                            dataGridView.DataSource = bindEmployees;
                        }
                    }
                }
            }
        }
    }
}
