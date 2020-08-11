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
            this.btn_ApiGenerateRepos = new System.Windows.Forms.Button();
            this.txt_ApiStartup = new System.Windows.Forms.TextBox();
            this.btn_ApoStartupCopy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.com_Client = new System.Windows.Forms.ComboBox();
            this.btn_ClientGeneratePages = new System.Windows.Forms.Button();
            this.btn_ClientCopyStartup = new System.Windows.Forms.Button();
            this.txt_ClientStartup = new System.Windows.Forms.TextBox();
            this.btn_ClientGenerateSevices = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.com_Api = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.com_Models = new System.Windows.Forms.ComboBox();
            this.btn_ModelsGenerateVM = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_OldModel = new System.Windows.Forms.TextBox();
            this.txt_NewModel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ApiGenerateRepos
            // 
            this.btn_ApiGenerateRepos.Location = new System.Drawing.Point(221, 17);
            this.btn_ApiGenerateRepos.Name = "btn_ApiGenerateRepos";
            this.btn_ApiGenerateRepos.Size = new System.Drawing.Size(122, 23);
            this.btn_ApiGenerateRepos.TabIndex = 1;
            this.btn_ApiGenerateRepos.Text = "Generate Repositories";
            this.btn_ApiGenerateRepos.UseVisualStyleBackColor = true;
            this.btn_ApiGenerateRepos.Click += new System.EventHandler(this.btn_ApiGenerateRepos_Click);
            // 
            // txt_ApiStartup
            // 
            this.txt_ApiStartup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ApiStartup.Location = new System.Drawing.Point(14, 48);
            this.txt_ApiStartup.Multiline = true;
            this.txt_ApiStartup.Name = "txt_ApiStartup";
            this.txt_ApiStartup.Size = new System.Drawing.Size(417, 63);
            this.txt_ApiStartup.TabIndex = 2;
            // 
            // btn_ApoStartupCopy
            // 
            this.btn_ApoStartupCopy.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_ApoStartupCopy.Location = new System.Drawing.Point(389, 15);
            this.btn_ApoStartupCopy.Name = "btn_ApoStartupCopy";
            this.btn_ApoStartupCopy.Size = new System.Drawing.Size(42, 27);
            this.btn_ApoStartupCopy.TabIndex = 3;
            this.btn_ApoStartupCopy.Text = "Copy";
            this.btn_ApoStartupCopy.UseVisualStyleBackColor = true;
            this.btn_ApoStartupCopy.Click += new System.EventHandler(this.btn_CopyStartupAPI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.com_Client);
            this.groupBox1.Controls.Add(this.btn_ClientGeneratePages);
            this.groupBox1.Controls.Add(this.btn_ClientCopyStartup);
            this.groupBox1.Controls.Add(this.txt_ClientStartup);
            this.groupBox1.Controls.Add(this.btn_ClientGenerateSevices);
            this.groupBox1.Location = new System.Drawing.Point(11, 226);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(473, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // com_Client
            // 
            this.com_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Client.FormattingEnabled = true;
            this.com_Client.Location = new System.Drawing.Point(19, 51);
            this.com_Client.Name = "com_Client";
            this.com_Client.Size = new System.Drawing.Size(121, 21);
            this.com_Client.TabIndex = 5;
            // 
            // btn_ClientGeneratePages
            // 
            this.btn_ClientGeneratePages.Location = new System.Drawing.Point(261, 47);
            this.btn_ClientGeneratePages.Name = "btn_ClientGeneratePages";
            this.btn_ClientGeneratePages.Size = new System.Drawing.Size(123, 23);
            this.btn_ClientGeneratePages.TabIndex = 8;
            this.btn_ClientGeneratePages.Text = "GeneratePages";
            this.btn_ClientGeneratePages.UseVisualStyleBackColor = true;
            this.btn_ClientGeneratePages.Click += new System.EventHandler(this.btn_ClientGeneratePages_Click);
            // 
            // btn_ClientCopyStartup
            // 
            this.btn_ClientCopyStartup.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_ClientCopyStartup.Location = new System.Drawing.Point(390, 45);
            this.btn_ClientCopyStartup.Name = "btn_ClientCopyStartup";
            this.btn_ClientCopyStartup.Size = new System.Drawing.Size(42, 27);
            this.btn_ClientCopyStartup.TabIndex = 7;
            this.btn_ClientCopyStartup.Text = "Copy";
            this.btn_ClientCopyStartup.UseVisualStyleBackColor = true;
            this.btn_ClientCopyStartup.Click += new System.EventHandler(this.btn_ClientCopyStartup_Click);
            // 
            // txt_ClientStartup
            // 
            this.txt_ClientStartup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClientStartup.Location = new System.Drawing.Point(19, 78);
            this.txt_ClientStartup.Multiline = true;
            this.txt_ClientStartup.Name = "txt_ClientStartup";
            this.txt_ClientStartup.Size = new System.Drawing.Size(413, 63);
            this.txt_ClientStartup.TabIndex = 6;
            // 
            // btn_ClientGenerateSevices
            // 
            this.btn_ClientGenerateSevices.Location = new System.Drawing.Point(146, 47);
            this.btn_ClientGenerateSevices.Name = "btn_ClientGenerateSevices";
            this.btn_ClientGenerateSevices.Size = new System.Drawing.Size(111, 23);
            this.btn_ClientGenerateSevices.TabIndex = 5;
            this.btn_ClientGenerateSevices.Text = "GenerateServices";
            this.btn_ClientGenerateSevices.UseVisualStyleBackColor = true;
            this.btn_ClientGenerateSevices.Click += new System.EventHandler(this.btn_ClientGenerateSevices_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.com_Api);
            this.groupBox2.Controls.Add(this.txt_ApiStartup);
            this.groupBox2.Controls.Add(this.btn_ApoStartupCopy);
            this.groupBox2.Controls.Add(this.btn_ApiGenerateRepos);
            this.groupBox2.Location = new System.Drawing.Point(11, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(473, 127);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "API";
            // 
            // com_Api
            // 
            this.com_Api.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Api.FormattingEnabled = true;
            this.com_Api.Location = new System.Drawing.Point(19, 21);
            this.com_Api.Name = "com_Api";
            this.com_Api.Size = new System.Drawing.Size(121, 21);
            this.com_Api.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.com_Models);
            this.groupBox3.Controls.Add(this.btn_ModelsGenerateVM);
            this.groupBox3.Location = new System.Drawing.Point(11, 448);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(473, 85);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Models";
            // 
            // com_Models
            // 
            this.com_Models.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Models.FormattingEnabled = true;
            this.com_Models.Location = new System.Drawing.Point(19, 35);
            this.com_Models.Name = "com_Models";
            this.com_Models.Size = new System.Drawing.Size(121, 21);
            this.com_Models.TabIndex = 9;
            // 
            // btn_ModelsGenerateVM
            // 
            this.btn_ModelsGenerateVM.Location = new System.Drawing.Point(240, 35);
            this.btn_ModelsGenerateVM.Name = "btn_ModelsGenerateVM";
            this.btn_ModelsGenerateVM.Size = new System.Drawing.Size(111, 23);
            this.btn_ModelsGenerateVM.TabIndex = 5;
            this.btn_ModelsGenerateVM.Text = "Generate VM";
            this.btn_ModelsGenerateVM.UseVisualStyleBackColor = true;
            this.btn_ModelsGenerateVM.Click += new System.EventHandler(this.btn_ModelsGenerateVM_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_OldModel);
            this.groupBox4.Controls.Add(this.txt_NewModel);
            this.groupBox4.Location = new System.Drawing.Point(11, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(473, 66);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // txt_OldModel
            // 
            this.txt_OldModel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OldModel.Location = new System.Drawing.Point(99, 18);
            this.txt_OldModel.Name = "txt_OldModel";
            this.txt_OldModel.Size = new System.Drawing.Size(100, 27);
            this.txt_OldModel.TabIndex = 4;
            // 
            // txt_NewModel
            // 
            this.txt_NewModel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewModel.Location = new System.Drawing.Point(243, 18);
            this.txt_NewModel.Name = "txt_NewModel";
            this.txt_NewModel.Size = new System.Drawing.Size(100, 27);
            this.txt_NewModel.TabIndex = 0;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 542);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ApiGenerateRepos;
        private System.Windows.Forms.TextBox txt_ApiStartup;
        private System.Windows.Forms.Button btn_ApoStartupCopy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ClientCopyStartup;
        private System.Windows.Forms.TextBox txt_ClientStartup;
        private System.Windows.Forms.Button btn_ClientGenerateSevices;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ClientGeneratePages;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ModelsGenerateVM;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_OldModel;
        private System.Windows.Forms.TextBox txt_NewModel;
        private System.Windows.Forms.ComboBox com_Client;
        private System.Windows.Forms.ComboBox com_Api;
        private System.Windows.Forms.ComboBox com_Models;
    }
}

