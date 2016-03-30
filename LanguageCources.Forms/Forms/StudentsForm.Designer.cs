using System.Windows.Forms;

namespace LanguageCourses.Forms.Forms
{
    partial class StudentsForm : Form
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
            this.components = new System.ComponentModel.Container();
            this._bindingStudents = new System.Windows.Forms.BindingSource(this.components);
            this._btNext = new System.Windows.Forms.Button();
            this._btPrevious = new System.Windows.Forms.Button();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._dgvStudents = new System.Windows.Forms.DataGridView();
            this._btCreate = new System.Windows.Forms.Button();
            this._btDelete = new System.Windows.Forms.Button();
            this._btEdit = new System.Windows.Forms.Button();
            this._btUndo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._tbFirstNameFilter = new System.Windows.Forms.TextBox();
            this._tbLastNameFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._lbLastAction = new System.Windows.Forms.Label();
            this._nudOffset = new System.Windows.Forms.NumericUpDown();
            this._nudCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._bindingStudents)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // _btNext
            // 
            this._btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btNext.Location = new System.Drawing.Point(930, 677);
            this._btNext.Name = "_btNext";
            this._btNext.Size = new System.Drawing.Size(130, 50);
            this._btNext.TabIndex = 11;
            this._btNext.Text = "Next Page";
            this._btNext.UseVisualStyleBackColor = true;
            // 
            // _btPrevious
            // 
            this._btPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btPrevious.Location = new System.Drawing.Point(754, 677);
            this._btPrevious.Name = "_btPrevious";
            this._btPrevious.Size = new System.Drawing.Size(159, 50);
            this._btPrevious.TabIndex = 12;
            this._btPrevious.Text = "Previous Page";
            this._btPrevious.UseVisualStyleBackColor = true;
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(121, 36);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.groupsToolStripMenuItem.Text = "Groups";
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(121, 36);
            this.teachersToolStripMenuItem.Text = "Teachers";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.teachersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 40);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _dgvStudents
            // 
            this._dgvStudents.AllowUserToAddRows = false;
            this._dgvStudents.AutoGenerateColumns = false;
            this._dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvStudents.DataSource = this._bindingStudents;
            this._dgvStudents.Location = new System.Drawing.Point(12, 170);
            this._dgvStudents.Name = "_dgvStudents";
            this._dgvStudents.RowTemplate.Height = 33;
            this._dgvStudents.Size = new System.Drawing.Size(1057, 491);
            this._dgvStudents.TabIndex = 10;
            // 
            // _btCreate
            // 
            this._btCreate.Location = new System.Drawing.Point(12, 63);
            this._btCreate.Name = "_btCreate";
            this._btCreate.Size = new System.Drawing.Size(200, 50);
            this._btCreate.TabIndex = 16;
            this._btCreate.Text = "Create Student";
            this._btCreate.UseVisualStyleBackColor = true;
            // 
            // _btDelete
            // 
            this._btDelete.Location = new System.Drawing.Point(490, 63);
            this._btDelete.Name = "_btDelete";
            this._btDelete.Size = new System.Drawing.Size(200, 50);
            this._btDelete.TabIndex = 17;
            this._btDelete.Text = "Delete Student";
            this._btDelete.UseVisualStyleBackColor = true;
            // 
            // _btEdit
            // 
            this._btEdit.Location = new System.Drawing.Point(255, 63);
            this._btEdit.Name = "_btEdit";
            this._btEdit.Size = new System.Drawing.Size(200, 50);
            this._btEdit.TabIndex = 18;
            this._btEdit.Text = "Edit Student";
            this._btEdit.UseVisualStyleBackColor = true;
            // 
            // _btUndo
            // 
            this._btUndo.Location = new System.Drawing.Point(860, 63);
            this._btUndo.Name = "_btUndo";
            this._btUndo.Size = new System.Drawing.Size(200, 50);
            this._btUndo.TabIndex = 19;
            this._btUndo.Text = "Undo";
            this._btUndo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 690);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filter";
            // 
            // _tbFirstNameFilter
            // 
            this._tbFirstNameFilter.Location = new System.Drawing.Point(219, 669);
            this._tbFirstNameFilter.Name = "_tbFirstNameFilter";
            this._tbFirstNameFilter.Size = new System.Drawing.Size(200, 31);
            this._tbFirstNameFilter.TabIndex = 21;
            this._tbFirstNameFilter.TextChanged += new System.EventHandler(this._tbFirstNameFilter_TextChanged);
            // 
            // _tbLastNameFilter
            // 
            this._tbLastNameFilter.Location = new System.Drawing.Point(219, 712);
            this._tbLastNameFilter.Name = "_tbLastNameFilter";
            this._tbLastNameFilter.Size = new System.Drawing.Size(200, 31);
            this._tbLastNameFilter.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 672);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 702);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Last Action:";
            // 
            // _lbLastAction
            // 
            this._lbLastAction.AutoSize = true;
            this._lbLastAction.Location = new System.Drawing.Point(155, 126);
            this._lbLastAction.Name = "_lbLastAction";
            this._lbLastAction.Size = new System.Drawing.Size(103, 25);
            this._lbLastAction.TabIndex = 26;
            this._lbLastAction.Text = "No action";
            // 
            // _nudOffset
            // 
            this._nudOffset.Location = new System.Drawing.Point(628, 670);
            this._nudOffset.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this._nudOffset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudOffset.Name = "_nudOffset";
            this._nudOffset.Size = new System.Drawing.Size(120, 31);
            this._nudOffset.TabIndex = 27;
            this._nudOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _nudCount
            // 
            this._nudCount.Location = new System.Drawing.Point(628, 712);
            this._nudCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudCount.Name = "_nudCount";
            this._nudCount.Size = new System.Drawing.Size(120, 31);
            this._nudCount.TabIndex = 28;
            this._nudCount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 672);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Start index";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 712);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Take first";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 755);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._nudCount);
            this.Controls.Add(this._nudOffset);
            this.Controls.Add(this._lbLastAction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._tbLastNameFilter);
            this.Controls.Add(this._tbFirstNameFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btUndo);
            this.Controls.Add(this._btEdit);
            this.Controls.Add(this._btDelete);
            this.Controls.Add(this._btCreate);
            this.Controls.Add(this._dgvStudents);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this._btPrevious);
            this.Controls.Add(this._btNext);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentsForm";
            this.Text = "Language Courses - Students";
            ((System.ComponentModel.ISupportInitialize)(this._bindingStudents)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button _btNext;
        private Button _btPrevious;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem groupsToolStripMenuItem;
        private ToolStripMenuItem teachersToolStripMenuItem;
        private MenuStrip menuStrip1;
        private BindingSource _bindingStudents;
        private DataGridView _dgvStudents;
        private Button _btCreate;
        private Button _btDelete;
        private Button _btEdit;
        private Button _btUndo;
        private Label label1;
        private TextBox _tbFirstNameFilter;
        private TextBox _tbLastNameFilter;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label _lbLastAction;
        private NumericUpDown _nudOffset;
        private NumericUpDown _nudCount;
        private Label label5;
        private Label label6;

        public BindingSource Students
        {
            get { return _bindingStudents; }
            set { _bindingStudents = value; }
        }

        public DataGridView DgvStudents
        {
            get { return _dgvStudents; }
        }

        public Button BtCreate
        {
            get { return _btCreate; }
        }

        public Button BtDelete
        {
            get { return _btDelete; }
        }

        public Button BtEdit
        {
            get { return _btEdit; }
        }

        public Button BtUndo
        {
            get { return _btUndo; }
        }

        public TextBox TbFirstNameFilter
        {
            get { return _tbFirstNameFilter; }
        }

        public TextBox TbLastNameFilter
        {
            get { return _tbLastNameFilter; }
        }

        public NumericUpDown NudOffset
        {
            get { return _nudOffset; }
        }

        public NumericUpDown NudCount
        {
            get { return _nudCount; }
        }

        public Button BtNext
        {
            get { return _btNext; }
        }

        public Button BtPrevious
        {
            get { return _btPrevious; }
        }


    }
}

