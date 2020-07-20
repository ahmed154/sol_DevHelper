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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ClientCopyStartup = new System.Windows.Forms.Button();
            this.txt_ClientStartup = new System.Windows.Forms.TextBox();
            this.btn_ClientGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ClientGeneratePages = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ModelName
            // 
            this.txt_ModelName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ModelName.Location = new System.Drawing.Point(262, 27);
            this.txt_ModelName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ModelName.Name = "txt_ModelName";
            this.txt_ModelName.Size = new System.Drawing.Size(148, 36);
            this.txt_ModelName.TabIndex = 0;
            this.txt_ModelName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ModelName_KeyDown);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(422, 31);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(112, 34);
            this.btn_Generate.TabIndex = 1;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // txt_StartupAPI
            // 
            this.txt_StartupAPI.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StartupAPI.Location = new System.Drawing.Point(22, 114);
            this.txt_StartupAPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_StartupAPI.Multiline = true;
            this.txt_StartupAPI.Name = "txt_StartupAPI";
            this.txt_StartupAPI.Size = new System.Drawing.Size(682, 90);
            this.txt_StartupAPI.TabIndex = 2;
            // 
            // btn_CopyStartupAPI
            // 
            this.btn_CopyStartupAPI.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_CopyStartupAPI.Location = new System.Drawing.Point(643, 65);
            this.btn_CopyStartupAPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CopyStartupAPI.Name = "btn_CopyStartupAPI";
            this.btn_CopyStartupAPI.Size = new System.Drawing.Size(63, 39);
            this.btn_CopyStartupAPI.TabIndex = 3;
            this.btn_CopyStartupAPI.Text = "Copy";
            this.btn_CopyStartupAPI.UseVisualStyleBackColor = true;
            this.btn_CopyStartupAPI.Click += new System.EventHandler(this.btn_CopyStartupAPI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ClientGeneratePages);
            this.groupBox1.Controls.Add(this.btn_ClientCopyStartup);
            this.groupBox1.Controls.Add(this.txt_ClientStartup);
            this.groupBox1.Controls.Add(this.btn_ClientGenerate);
            this.groupBox1.Location = new System.Drawing.Point(751, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 650);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // btn_ClientCopyStartup
            // 
            this.btn_ClientCopyStartup.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_ClientCopyStartup.Location = new System.Drawing.Point(628, 65);
            this.btn_ClientCopyStartup.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ClientCopyStartup.Name = "btn_ClientCopyStartup";
            this.btn_ClientCopyStartup.Size = new System.Drawing.Size(63, 39);
            this.btn_ClientCopyStartup.TabIndex = 7;
            this.btn_ClientCopyStartup.Text = "Copy";
            this.btn_ClientCopyStartup.UseVisualStyleBackColor = true;
            // 
            // txt_ClientStartup
            // 
            this.txt_ClientStartup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClientStartup.Location = new System.Drawing.Point(7, 114);
            this.txt_ClientStartup.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClientStartup.Multiline = true;
            this.txt_ClientStartup.Name = "txt_ClientStartup";
            this.txt_ClientStartup.Size = new System.Drawing.Size(682, 90);
            this.txt_ClientStartup.TabIndex = 6;
            // 
            // btn_ClientGenerate
            // 
            this.btn_ClientGenerate.Location = new System.Drawing.Point(29, 67);
            this.btn_ClientGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ClientGenerate.Name = "btn_ClientGenerate";
            this.btn_ClientGenerate.Size = new System.Drawing.Size(166, 34);
            this.btn_ClientGenerate.TabIndex = 5;
            this.btn_ClientGenerate.Text = "GenerateServices";
            this.btn_ClientGenerate.UseVisualStyleBackColor = true;
            this.btn_ClientGenerate.Click += new System.EventHandler(this.btn_ClientGenerate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_StartupAPI);
            this.groupBox2.Controls.Add(this.txt_ModelName);
            this.groupBox2.Controls.Add(this.btn_CopyStartupAPI);
            this.groupBox2.Controls.Add(this.btn_Generate);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 399);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "API";
            // 
            // btn_ClientGeneratePages
            // 
            this.btn_ClientGeneratePages.Location = new System.Drawing.Point(291, 65);
            this.btn_ClientGeneratePages.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ClientGeneratePages.Name = "btn_ClientGeneratePages";
            this.btn_ClientGeneratePages.Size = new System.Drawing.Size(185, 34);
            this.btn_ClientGeneratePages.TabIndex = 8;
            this.btn_ClientGeneratePages.Text = "GeneratePages";
            this.btn_ClientGeneratePages.UseVisualStyleBackColor = true;
            this.btn_ClientGeneratePages.Click += new System.EventHandler(this.btn_ClientGeneratePages_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ModelName;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txt_StartupAPI;
        private System.Windows.Forms.Button btn_CopyStartupAPI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ClientCopyStartup;
        private System.Windows.Forms.TextBox txt_ClientStartup;
        private System.Windows.Forms.Button btn_ClientGenerate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ClientGeneratePages;
    }
}

