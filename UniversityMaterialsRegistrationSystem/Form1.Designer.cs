namespace UniversityMaterialsRegistrationSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            txtMaterialId = new TextBox();
            txtMaterialName = new TextBox();
            dataGridViewMaterials = new DataGridView();
            btnRemoveMaterial = new Button();
            btnAddMaterial = new Button();
            btnLoadMaterials = new Button();
            tabPage2 = new TabPage();
            listBoxMyMaterials = new ListBox();
            label5 = new Label();
            btnClearList = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterials).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-4, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(809, 457);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Navy;
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(txtPass);
            tabPage1.Controls.Add(txtUser);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(801, 429);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Login page";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(637, 302);
            button3.Name = "button3";
            button3.Size = new Size(131, 66);
            button3.TabIndex = 8;
            button3.Text = "Go to Register";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(541, 259);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(147, 25);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(493, 302);
            button2.Name = "button2";
            button2.Size = new Size(131, 66);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(344, 302);
            button1.Name = "button1";
            button1.Size = new Size(131, 66);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(541, 198);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(171, 23);
            txtPass.TabIndex = 3;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(541, 93);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(171, 23);
            txtUser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(428, 198);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(428, 93);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Navy;
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(txtMaterialId);
            tabPage3.Controls.Add(txtMaterialName);
            tabPage3.Controls.Add(dataGridViewMaterials);
            tabPage3.Controls.Add(btnRemoveMaterial);
            tabPage3.Controls.Add(btnAddMaterial);
            tabPage3.Controls.Add(btnLoadMaterials);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(801, 429);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reg Materials";
            tabPage3.Click += tabPage3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(198, 312);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 19;
            label4.Text = "material ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(198, 270);
            label3.Name = "label3";
            label3.Size = new Size(128, 21);
            label3.TabIndex = 18;
            label3.Text = "Material Name:";
            // 
            // txtMaterialId
            // 
            txtMaterialId.Location = new Point(332, 310);
            txtMaterialId.Name = "txtMaterialId";
            txtMaterialId.Size = new Size(290, 23);
            txtMaterialId.TabIndex = 17;
            // 
            // txtMaterialName
            // 
            txtMaterialName.Location = new Point(332, 268);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.Size = new Size(290, 23);
            txtMaterialName.TabIndex = 16;
            // 
            // dataGridViewMaterials
            // 
            dataGridViewMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterials.Location = new Point(177, 25);
            dataGridViewMaterials.Name = "dataGridViewMaterials";
            dataGridViewMaterials.Size = new Size(463, 228);
            dataGridViewMaterials.TabIndex = 15;
            // 
            // btnRemoveMaterial
            // 
            btnRemoveMaterial.BackColor = Color.White;
            btnRemoveMaterial.FlatStyle = FlatStyle.Flat;
            btnRemoveMaterial.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRemoveMaterial.ForeColor = Color.Black;
            btnRemoveMaterial.Location = new Point(491, 349);
            btnRemoveMaterial.Name = "btnRemoveMaterial";
            btnRemoveMaterial.Size = new Size(131, 66);
            btnRemoveMaterial.TabIndex = 14;
            btnRemoveMaterial.Text = "Remove Material";
            btnRemoveMaterial.UseVisualStyleBackColor = false;
            btnRemoveMaterial.Click += btnRemoveMaterial_Click;
            // 
            // btnAddMaterial
            // 
            btnAddMaterial.BackColor = Color.White;
            btnAddMaterial.FlatStyle = FlatStyle.Flat;
            btnAddMaterial.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAddMaterial.ForeColor = Color.Black;
            btnAddMaterial.Location = new Point(347, 349);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Size = new Size(131, 66);
            btnAddMaterial.TabIndex = 13;
            btnAddMaterial.Text = "Add Material";
            btnAddMaterial.UseVisualStyleBackColor = false;
            btnAddMaterial.Click += btnAddMaterial_Click;
            // 
            // btnLoadMaterials
            // 
            btnLoadMaterials.BackColor = Color.White;
            btnLoadMaterials.FlatStyle = FlatStyle.Flat;
            btnLoadMaterials.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnLoadMaterials.ForeColor = Color.Black;
            btnLoadMaterials.Location = new Point(198, 349);
            btnLoadMaterials.Name = "btnLoadMaterials";
            btnLoadMaterials.Size = new Size(131, 66);
            btnLoadMaterials.TabIndex = 12;
            btnLoadMaterials.Text = "Load Materials";
            btnLoadMaterials.UseVisualStyleBackColor = false;
            btnLoadMaterials.Click += btnLoadMaterials_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Navy;
            tabPage2.Controls.Add(listBoxMyMaterials);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(btnClearList);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(801, 429);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Your Schedule";
            // 
            // listBoxMyMaterials
            // 
            listBoxMyMaterials.FormattingEnabled = true;
            listBoxMyMaterials.ItemHeight = 15;
            listBoxMyMaterials.Location = new Point(187, 72);
            listBoxMyMaterials.Name = "listBoxMyMaterials";
            listBoxMyMaterials.Size = new Size(451, 229);
            listBoxMyMaterials.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(321, 18);
            label5.Name = "label5";
            label5.Size = new Size(191, 30);
            label5.TabIndex = 19;
            label5.Text = "Selected Materials";
            // 
            // btnClearList
            // 
            btnClearList.BackColor = Color.White;
            btnClearList.FlatStyle = FlatStyle.Flat;
            btnClearList.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnClearList.ForeColor = Color.Black;
            btnClearList.Location = new Point(354, 325);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new Size(131, 66);
            btnClearList.TabIndex = 15;
            btnClearList.Text = "Clear List";
            btnClearList.UseVisualStyleBackColor = false;
            btnClearList.Click += btnClearList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "University Materials Registration System";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterials).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private CheckBox checkBox1;
        private Button button2;
        private Button button1;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button btnRemoveMaterial;
        private Button btnAddMaterial;
        private Button btnLoadMaterials;
        private Label label4;
        private Label label3;
        private TextBox txtMaterialId;
        private TextBox txtMaterialName;
        private DataGridView dataGridViewMaterials;
        private Button btnClearList;
        private Label label5;
        private ListBox listBoxMyMaterials;
    }
}
