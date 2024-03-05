namespace _391project1Part2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            studentOrInstructorBox = new ComboBox();
            yearBox = new ComboBox();
            semesterBox = new ComboBox();
            majorBox = new ComboBox();
            genderBox = new ComboBox();
            facultyBox = new ComboBox();
            departmentBox = new ComboBox();
            universityBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(195, 200);
            listBox1.Margin = new Padding(2, 1, 2, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(738, 334);
            listBox1.TabIndex = 0;
            // 
            // studentOrInstructorBox
            // 
            studentOrInstructorBox.FormattingEnabled = true;
            studentOrInstructorBox.Location = new Point(222, 79);
            studentOrInstructorBox.Margin = new Padding(2, 1, 2, 1);
            studentOrInstructorBox.Name = "studentOrInstructorBox";
            studentOrInstructorBox.Size = new Size(132, 23);
            studentOrInstructorBox.TabIndex = 1;
            studentOrInstructorBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // yearBox
            // 
            yearBox.FormattingEnabled = true;
            yearBox.Location = new Point(406, 79);
            yearBox.Margin = new Padding(2, 1, 2, 1);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(132, 23);
            yearBox.TabIndex = 2;
            // 
            // semesterBox
            // 
            semesterBox.FormattingEnabled = true;
            semesterBox.Location = new Point(590, 79);
            semesterBox.Margin = new Padding(2, 1, 2, 1);
            semesterBox.Name = "semesterBox";
            semesterBox.Size = new Size(132, 23);
            semesterBox.TabIndex = 3;
            // 
            // majorBox
            // 
            majorBox.FormattingEnabled = true;
            majorBox.Location = new Point(774, 79);
            majorBox.Margin = new Padding(2, 1, 2, 1);
            majorBox.Name = "majorBox";
            majorBox.Size = new Size(132, 23);
            majorBox.TabIndex = 4;
            // 
            // genderBox
            // 
            genderBox.FormattingEnabled = true;
            genderBox.Location = new Point(774, 145);
            genderBox.Margin = new Padding(2, 1, 2, 1);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(132, 23);
            genderBox.TabIndex = 9;
            // 
            // facultyBox
            // 
            facultyBox.FormattingEnabled = true;
            facultyBox.Location = new Point(590, 145);
            facultyBox.Margin = new Padding(2, 1, 2, 1);
            facultyBox.Name = "facultyBox";
            facultyBox.Size = new Size(132, 23);
            facultyBox.TabIndex = 8;
            // 
            // departmentBox
            // 
            departmentBox.FormattingEnabled = true;
            departmentBox.Location = new Point(406, 145);
            departmentBox.Margin = new Padding(2, 1, 2, 1);
            departmentBox.Name = "departmentBox";
            departmentBox.Size = new Size(132, 23);
            departmentBox.TabIndex = 7;
            // 
            // universityBox
            // 
            universityBox.FormattingEnabled = true;
            universityBox.Location = new Point(222, 145);
            universityBox.Margin = new Padding(2, 1, 2, 1);
            universityBox.Name = "universityBox";
            universityBox.Size = new Size(132, 23);
            universityBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 63);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 10;
            label1.Text = "Student or Instructor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 63);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 11;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(590, 63);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 12;
            label3.Text = "Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(774, 63);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 13;
            label4.Text = "Major";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 129);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 14;
            label5.Text = "University";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(406, 129);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 15;
            label6.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(590, 129);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 16;
            label7.Text = "Faculty";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(774, 129);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 17;
            label8.Text = "Gender";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 544);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(genderBox);
            Controls.Add(facultyBox);
            Controls.Add(departmentBox);
            Controls.Add(universityBox);
            Controls.Add(majorBox);
            Controls.Add(semesterBox);
            Controls.Add(yearBox);
            Controls.Add(studentOrInstructorBox);
            Controls.Add(listBox1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ComboBox studentOrInstructorBox;
        private ComboBox yearBox;
        private ComboBox semesterBox;
        private ComboBox majorBox;
        private ComboBox genderBox;
        private ComboBox genderBox;
        private ComboBox facultyBox;
        private ComboBox departmentBox;
        private ComboBox universityBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
