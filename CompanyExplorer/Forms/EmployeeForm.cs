using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CompanyExplorer.Model;
using CompanyExplorer.Extensions;

namespace CompanyExplorer.Forms
{
    public partial class EmployeeForm : Form
    {
        public Empoyee Employee { get; private set; }
        private bool canSave => !firstNameTextBox.Text.IsEmpty() && 
            !surNameTextBox.Text.IsEmpty() && !positionTextBox.Text.IsEmpty();

        public EmployeeForm(List<Department> departments)
        {
            InitializeComponent();
            departmentComboBox.Items.AddRange(departments.ToArray());
            departmentComboBox.SelectedIndex = 0;
            Employee = new Empoyee();
        }

        public EmployeeForm(List<Department> departments, Empoyee employee) : this(departments)
        {
            Employee = employee;
            firstNameTextBox.Text = employee.FirstName;
            surNameTextBox.Text = employee.SurName;
            patronymicTextBox.Text = employee.Patronymic;
            departmentComboBox.SelectedIndex = departments.IndexOf(employee.Department);
            dateOfBirthDatePicker.Value = employee.DateOfBirth;
            docsSeriesTextBox.Text = employee.DocSeries;
            docNumberTextBox.Text = employee.DocNumber;
            positionTextBox.Text = employee.Position;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            saveEmployeeBtn.Enabled = canSave;
        }

        private void OnSaveEmployee(object sender, EventArgs e)
        {
            Employee.FirstName = firstNameTextBox.Text;
            Employee.SurName = surNameTextBox.Text;
            Employee.Patronymic = patronymicTextBox.Text;
            Employee.DepartmentID = (departmentComboBox.SelectedItem as Department).ID;
            Employee.DateOfBirth = dateOfBirthDatePicker.Value.Date;
            Employee.DocSeries = docsSeriesTextBox.Text;
            Employee.DocNumber = docNumberTextBox.Text;
            Employee.Position = positionTextBox.Text;
        }
    }
}
