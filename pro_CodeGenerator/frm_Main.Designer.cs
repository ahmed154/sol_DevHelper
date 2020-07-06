namespace pro_CodeGenerator
{
    partial class frm_Main
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
            this.txt_ModelName = new System.Windows.Forms.TextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.txt_StartupAPI = new System.Windows.Forms.TextBox();
            this.btn_CopyStartupAPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ModelName
            // 
            this.txt_ModelName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ModelName.Location = new System.Drawing.Point(179, 12);
            this.txt_ModelName.Name = "txt_ModelName";
            this.txt_ModelName.Size = new System.Drawing.Size(100, 27);
            this.txt_ModelName.TabIndex = 0;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(285, 15);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(75, 23);
            this.btn_Generate.TabIndex = 1;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // txt_StartupAPI
            // 
            this.txt_StartupAPI.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StartupAPI.Location = new System.Drawing.Point(12, 99);
            this.txt_StartupAPI.Multiline = true;
            this.txt_StartupAPI.Name = "txt_StartupAPI";
            this.txt_StartupAPI.Size = new System.Drawing.Size(456, 120);
            this.txt_StartupAPI.TabIndex = 2;
            // 
            // btn_CopyStartupAPI
            // 
            this.btn_CopyStartupAPI.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_CopyStartupAPI.Location = new System.Drawing.Point(426, 66);
            this.btn_CopyStartupAPI.Name = "btn_CopyStartupAPI";
            this.btn_CopyStartupAPI.Size = new System.Drawing.Size(42, 27);
            this.btn_CopyStartupAPI.TabIndex = 3;
            this.btn_CopyStartupAPI.Text = "Copy";
            this.btn_CopyStartupAPI.UseVisualStyleBackColor = true;
            this.btn_CopyStartupAPI.Click += new System.EventHandler(this.btn_CopyStartupAPI_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 436);
            this.Controls.Add(this.btn_CopyStartupAPI);
            this.Controls.Add(this.txt_StartupAPI);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.txt_ModelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ModelName;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txt_StartupAPI;
        private System.Windows.Forms.Button btn_CopyStartupAPI;
    }
}

