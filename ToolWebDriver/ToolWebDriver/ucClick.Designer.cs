namespace ToolWebDriver
{
    partial class ucClick
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDName = new System.Windows.Forms.TextBox();
            this.cboKieu = new System.Windows.Forms.ComboBox();
            this.btnAddAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiểu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Name";
            // 
            // txtIDName
            // 
            this.txtIDName.Location = new System.Drawing.Point(82, 103);
            this.txtIDName.Name = "txtIDName";
            this.txtIDName.Size = new System.Drawing.Size(152, 20);
            this.txtIDName.TabIndex = 1;
            // 
            // cboKieu
            // 
            this.cboKieu.FormattingEnabled = true;
            this.cboKieu.Items.AddRange(new object[] {
            "Xpath",
            "Thuong"});
            this.cboKieu.Location = new System.Drawing.Point(82, 62);
            this.cboKieu.Name = "cboKieu";
            this.cboKieu.Size = new System.Drawing.Size(152, 21);
            this.cboKieu.TabIndex = 2;
            // 
            // btnAddAction
            // 
            this.btnAddAction.Location = new System.Drawing.Point(93, 145);
            this.btnAddAction.Name = "btnAddAction";
            this.btnAddAction.Size = new System.Drawing.Size(54, 25);
            this.btnAddAction.TabIndex = 3;
            this.btnAddAction.Text = "Thêm";
            this.btnAddAction.UseVisualStyleBackColor = true;
            // 
            // ucClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddAction);
            this.Controls.Add(this.cboKieu);
            this.Controls.Add(this.txtIDName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucClick";
            this.Size = new System.Drawing.Size(237, 190);
            this.Load += new System.EventHandler(this.ucClick_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDName;
        private System.Windows.Forms.ComboBox cboKieu;
        private System.Windows.Forms.Button btnAddAction;
    }
}
