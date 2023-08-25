namespace WFACRUD
{
    partial class WAFPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WAFPage));
            this.dataView = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.GPA = new System.Windows.Forms.TextBox();
            this.lblGPA = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataView.Location = new System.Drawing.Point(27, 61);
            this.dataView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(495, 337);
            this.dataView.TabIndex = 0;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblId
            // 
            this.lblId.AccessibleName = "lblId";
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(575, 66);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 19);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // Id
            // 
            this.Id.AccessibleName = "txtId";
            this.Id.Location = new System.Drawing.Point(660, 61);
            this.Id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(158, 27);
            this.Id.TabIndex = 2;
            this.Id.TextChanged += new System.EventHandler(this.txtId);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "txtName";
            this.txtName.Location = new System.Drawing.Point(660, 107);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 27);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AccessibleName = "lblName";
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(575, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label2_Click);
            // 
            // GPA
            // 
            this.GPA.AccessibleName = "txtGPA";
            this.GPA.Location = new System.Drawing.Point(660, 153);
            this.GPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GPA.Name = "GPA";
            this.GPA.Size = new System.Drawing.Size(158, 27);
            this.GPA.TabIndex = 7;
            this.GPA.TextChanged += new System.EventHandler(this.GPA_TextChanged);
            // 
            // lblGPA
            // 
            this.lblGPA.AccessibleName = "lblGPA";
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(575, 158);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(40, 19);
            this.lblGPA.TabIndex = 6;
            this.lblGPA.Text = "GPA";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(660, 209);
            this.insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(159, 42);
            this.insert.TabIndex = 8;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(660, 258);
            this.update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(159, 42);
            this.update.TabIndex = 8;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(660, 306);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(159, 42);
            this.delete.TabIndex = 8;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // WAFPage
            // 
            this.AccessibleName = "waf";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.GPA);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dataView);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WAFPage";
            this.Text = "WAFCRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox GPA;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
    }
}

