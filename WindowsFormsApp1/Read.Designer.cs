namespace WindowsFormsApp1
{
    partial class Read
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatSat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.model,
            this.Mileage,
            this.MotExp,
            this.Reg,
            this.KeyNo,
            this.CatSat,
            this.Colour,
            this.Value,
            this.FuelType,
            this.ExtraFeatures,
            this.Image});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(3615, 743);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 9;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 269;
            // 
            // model
            // 
            this.model.HeaderText = "Model";
            this.model.MinimumWidth = 9;
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Width = 268;
            // 
            // Mileage
            // 
            this.Mileage.HeaderText = "Mileage";
            this.Mileage.MinimumWidth = 9;
            this.Mileage.Name = "Mileage";
            this.Mileage.ReadOnly = true;
            this.Mileage.Width = 269;
            // 
            // MotExp
            // 
            this.MotExp.HeaderText = "MotExp";
            this.MotExp.MinimumWidth = 9;
            this.MotExp.Name = "MotExp";
            this.MotExp.ReadOnly = true;
            this.MotExp.Width = 268;
            // 
            // Reg
            // 
            this.Reg.HeaderText = "Reg";
            this.Reg.MinimumWidth = 9;
            this.Reg.Name = "Reg";
            this.Reg.ReadOnly = true;
            this.Reg.Width = 269;
            // 
            // KeyNo
            // 
            this.KeyNo.HeaderText = "KeyNo";
            this.KeyNo.MinimumWidth = 9;
            this.KeyNo.Name = "KeyNo";
            this.KeyNo.ReadOnly = true;
            this.KeyNo.Width = 268;
            // 
            // CatSat
            // 
            this.CatSat.HeaderText = "CatSat";
            this.CatSat.MinimumWidth = 9;
            this.CatSat.Name = "CatSat";
            this.CatSat.ReadOnly = true;
            this.CatSat.Width = 269;
            // 
            // Colour
            // 
            this.Colour.HeaderText = "Colour";
            this.Colour.MinimumWidth = 9;
            this.Colour.Name = "Colour";
            this.Colour.ReadOnly = true;
            this.Colour.Width = 268;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 9;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 269;
            // 
            // FuelType
            // 
            this.FuelType.HeaderText = "FuelType";
            this.FuelType.MinimumWidth = 9;
            this.FuelType.Name = "FuelType";
            this.FuelType.ReadOnly = true;
            this.FuelType.Width = 268;
            // 
            // ExtraFeatures
            // 
            this.ExtraFeatures.HeaderText = "ExtraFeatures";
            this.ExtraFeatures.MinimumWidth = 9;
            this.ExtraFeatures.Name = "ExtraFeatures";
            this.ExtraFeatures.ReadOnly = true;
            this.ExtraFeatures.Width = 269;
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 9;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 268;
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3627, 1200);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Read";
            this.Text = "Read";
            this.Load += new System.EventHandler(this.Read_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatSat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraFeatures;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
    }
}