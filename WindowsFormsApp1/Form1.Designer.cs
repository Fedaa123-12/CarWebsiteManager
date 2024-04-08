namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.CREATE = new System.Windows.Forms.Button();
            this.READ = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.model});
            this.dataGridView1.Location = new System.Drawing.Point(1570, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(730, 353);
            this.dataGridView1.TabIndex = 2;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 9;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 175;
            // 
            // model
            // 
            this.model.HeaderText = "Model";
            this.model.MinimumWidth = 9;
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Width = 175;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2142, 857);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(340, 200);
            this.button3.TabIndex = 3;
            this.button3.Text = "testdelete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CREATE
            // 
            this.CREATE.Location = new System.Drawing.Point(12, 12);
            this.CREATE.Name = "CREATE";
            this.CREATE.Size = new System.Drawing.Size(666, 136);
            this.CREATE.TabIndex = 4;
            this.CREATE.Text = "CREATE";
            this.CREATE.UseVisualStyleBackColor = true;
            this.CREATE.Click += new System.EventHandler(this.CREATE_Click);
            // 
            // READ
            // 
            this.READ.Location = new System.Drawing.Point(12, 154);
            this.READ.Name = "READ";
            this.READ.Size = new System.Drawing.Size(666, 136);
            this.READ.TabIndex = 5;
            this.READ.Text = "READ";
            this.READ.UseVisualStyleBackColor = true;
            this.READ.Click += new System.EventHandler(this.READ_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(12, 296);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(666, 136);
            this.UPDATE.TabIndex = 6;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(12, 438);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(666, 136);
            this.DELETE.TabIndex = 7;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2513, 1159);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.READ);
            this.Controls.Add(this.CREATE);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.Button CREATE;
        private System.Windows.Forms.Button READ;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button DELETE;
    }
}

