namespace CompanyExplorer.Forms
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label titleTextBox;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Button cancelBtn;
            this.surNameTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.docNumberTextBox = new System.Windows.Forms.TextBox();
            this.docsSeriesTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.saveEmployeeBtn = new System.Windows.Forms.Button();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            label7 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            titleTextBox = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cancelBtn = new System.Windows.Forms.Button();
            tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel.Controls.Add(label7, 0, 7);
            tableLayoutPanel.Controls.Add(this.surNameTextBox, 1, 1);
            tableLayoutPanel.Controls.Add(this.positionTextBox, 1, 6);
            tableLayoutPanel.Controls.Add(this.docNumberTextBox, 1, 5);
            tableLayoutPanel.Controls.Add(this.docsSeriesTextBox, 1, 4);
            tableLayoutPanel.Controls.Add(label3, 0, 0);
            tableLayoutPanel.Controls.Add(titleTextBox, 0, 1);
            tableLayoutPanel.Controls.Add(this.firstNameTextBox, 1, 0);
            tableLayoutPanel.Controls.Add(label6, 0, 3);
            tableLayoutPanel.Controls.Add(label5, 0, 2);
            tableLayoutPanel.Controls.Add(this.patronymicTextBox, 1, 2);
            tableLayoutPanel.Controls.Add(this.dateOfBirthDatePicker, 1, 3);
            tableLayoutPanel.Controls.Add(label2, 0, 5);
            tableLayoutPanel.Controls.Add(label4, 0, 6);
            tableLayoutPanel.Controls.Add(label1, 0, 4);
            tableLayoutPanel.Controls.Add(cancelBtn, 2, 8);
            tableLayoutPanel.Controls.Add(this.saveEmployeeBtn, 3, 8);
            tableLayoutPanel.Controls.Add(this.departmentComboBox, 1, 7);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            tableLayoutPanel.RowCount = 9;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new System.Drawing.Size(889, 326);
            tableLayoutPanel.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label7.Location = new System.Drawing.Point(11, 244);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(152, 34);
            label7.TabIndex = 11;
            label7.Text = "Отдел:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surNameTextBox
            // 
            tableLayoutPanel.SetColumnSpan(this.surNameTextBox, 3);
            this.surNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.surNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.surNameTextBox.Location = new System.Drawing.Point(170, 47);
            this.surNameTextBox.MaxLength = 50;
            this.surNameTextBox.Name = "surNameTextBox";
            this.surNameTextBox.Size = new System.Drawing.Size(712, 24);
            this.surNameTextBox.TabIndex = 1;
            this.surNameTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // positionTextBox
            // 
            tableLayoutPanel.SetColumnSpan(this.positionTextBox, 3);
            this.positionTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.positionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.positionTextBox.Location = new System.Drawing.Point(170, 217);
            this.positionTextBox.MaxLength = 50;
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(712, 24);
            this.positionTextBox.TabIndex = 6;
            this.positionTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // docNumberTextBox
            // 
            tableLayoutPanel.SetColumnSpan(this.docNumberTextBox, 3);
            this.docNumberTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.docNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.docNumberTextBox.Location = new System.Drawing.Point(170, 183);
            this.docNumberTextBox.MaxLength = 6;
            this.docNumberTextBox.Name = "docNumberTextBox";
            this.docNumberTextBox.Size = new System.Drawing.Size(712, 24);
            this.docNumberTextBox.TabIndex = 5;
            // 
            // docsSeriesTextBox
            // 
            tableLayoutPanel.SetColumnSpan(this.docsSeriesTextBox, 3);
            this.docsSeriesTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.docsSeriesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.docsSeriesTextBox.Location = new System.Drawing.Point(170, 149);
            this.docsSeriesTextBox.MaxLength = 4;
            this.docsSeriesTextBox.Name = "docsSeriesTextBox";
            this.docsSeriesTextBox.Size = new System.Drawing.Size(712, 24);
            this.docsSeriesTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label3.Location = new System.Drawing.Point(11, 6);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 34);
            label3.TabIndex = 0;
            label3.Text = "Имя:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleTextBox
            // 
            titleTextBox.AutoSize = true;
            titleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            titleTextBox.Location = new System.Drawing.Point(11, 40);
            titleTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new System.Drawing.Size(152, 34);
            titleTextBox.TabIndex = 1;
            titleTextBox.Text = "Фамилия:";
            titleTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameTextBox
            // 
            tableLayoutPanel.SetColumnSpan(this.firstNameTextBox, 3);
            this.firstNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.firstNameTextBox.Location = new System.Drawing.Point(171, 12);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.MaxLength = 50;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(710, 24);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label6.Location = new System.Drawing.Point(11, 108);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(152, 34);
            label6.TabIndex = 7;
            label6.Text = "Дата рождения:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label5.Location = new System.Drawing.Point(11, 74);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(152, 34);
            label5.TabIndex = 6;
            label5.Text = "Отчество:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // patronymicTextBox
            // 
            tableLayoutPanel.SetColumnSpan(this.patronymicTextBox, 3);
            this.patronymicTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.patronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.patronymicTextBox.Location = new System.Drawing.Point(170, 81);
            this.patronymicTextBox.MaxLength = 50;
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(712, 24);
            this.patronymicTextBox.TabIndex = 2;
            // 
            // dateOfBirthDatePicker
            // 
            tableLayoutPanel.SetColumnSpan(this.dateOfBirthDatePicker, 3);
            this.dateOfBirthDatePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateOfBirthDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateOfBirthDatePicker.Location = new System.Drawing.Point(170, 115);
            this.dateOfBirthDatePicker.Name = "dateOfBirthDatePicker";
            this.dateOfBirthDatePicker.Size = new System.Drawing.Size(712, 24);
            this.dateOfBirthDatePicker.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label2.Location = new System.Drawing.Point(11, 176);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(152, 34);
            label2.TabIndex = 9;
            label2.Text = "Номер документа:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label4.Location = new System.Drawing.Point(11, 210);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(152, 34);
            label4.TabIndex = 10;
            label4.Text = "Должность:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label1.Location = new System.Drawing.Point(11, 142);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(152, 34);
            label1.TabIndex = 8;
            label1.Text = "Серия документа:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelBtn.Location = new System.Drawing.Point(693, 289);
            cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new System.Drawing.Size(90, 27);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveEmployeeBtn
            // 
            this.saveEmployeeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveEmployeeBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveEmployeeBtn.Enabled = false;
            this.saveEmployeeBtn.Location = new System.Drawing.Point(791, 289);
            this.saveEmployeeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveEmployeeBtn.Name = "saveEmployeeBtn";
            this.saveEmployeeBtn.Size = new System.Drawing.Size(90, 27);
            this.saveEmployeeBtn.TabIndex = 8;
            this.saveEmployeeBtn.Text = "Сохранить";
            this.saveEmployeeBtn.UseVisualStyleBackColor = true;
            this.saveEmployeeBtn.Click += new System.EventHandler(this.OnSaveEmployee);
            // 
            // departmentComboBox
            // 
            tableLayoutPanel.SetColumnSpan(this.departmentComboBox, 3);
            this.departmentComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.departmentComboBox.Location = new System.Drawing.Point(170, 249);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(712, 26);
            this.departmentComboBox.TabIndex = 7;
            // 
            // CreateEmployeeForm
            // 
            this.AcceptButton = this.saveEmployeeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = cancelBtn;
            this.ClientSize = new System.Drawing.Size(889, 326);
            this.Controls.Add(tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateEmployeeForm";
            this.ShowIcon = false;
            this.Text = "Новый сотрудник";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDatePicker;
        private System.Windows.Forms.Button saveEmployeeBtn;
        private System.Windows.Forms.TextBox surNameTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox docNumberTextBox;
        private System.Windows.Forms.TextBox docsSeriesTextBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
    }
}