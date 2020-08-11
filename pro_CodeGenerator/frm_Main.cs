using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro_CodeGenerator
{
    public partial class frm_Main : Form
    {
        #region Declaration
        string  I, Type, Extention;
        #endregion
        public frm_Main()
        {
            InitializeComponent();

            GetProjectsDirectories();
            txt_OldModel.Text = oldModelName();

        }

        #region Pro
        void CreateFile(string path)
        {
            string oldFileName = I + txt_OldModel.Text + Type + Extention;
            string oldFilePath = Path.Combine(Application.StartupPath, "src", oldFileName);
            string txt = File.ReadAllText(oldFilePath);
            txt = txt.Replace(txt_OldModel.Text, txt_NewModel.Text);
            txt = txt.Replace(txt_OldModel.Text.ToLower(), txt_NewModel.Text.ToLower());
            Directory.CreateDirectory(path);
            path = Path.Combine(path, oldFileName.Replace(txt_OldModel.Text, txt_NewModel.Text));

            if (!File.Exists(path))
            {
                using (var fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                {
                    TextWriter tw = new StreamWriter(fs);
                    tw.Write(txt);
                    tw.Flush();
                }
            }
        }
        string UpperFirstLetter(string txt)
        {
            string f = txt.Substring(0, 1).ToUpper();
            return f + txt.Substring(1);
        }
        void TxtModelCheck(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text.Trim()))
            {
                MessageBox.Show("", "you have to spcify model name", MessageBoxButtons.OK);
                txt.Focus();
                return;
            }
            txt.Text = UpperFirstLetter(txt.Text.Trim());
        }
        void GetProjectsDirectories()
        {
            string exePath = Application.StartupPath;

            List<string> subdirectoryEntries = Directory.GetDirectories(exePath).ToList();

            foreach (string subdirectory in subdirectoryEntries)
            {
                if (Path.GetFileName(subdirectory).Length < 4 ||  Path.GetFileName(subdirectory).Substring(0, 4) != "pro_") continue;

                com_Api.Items.Add(Path.GetFileName(subdirectory));
                com_Client.Items.Add(Path.GetFileName(subdirectory));
                com_Models.Items.Add(Path.GetFileName(subdirectory));
            }
            foreach (var item in com_Api.Items)
            {
                if(item.ToString().ToLower() == "pro_api")
                {
                    com_Api.SelectedItem = item;
                }
            }
            foreach (var item in com_Client.Items)
            {
                if (item.ToString().ToLower() == "pro_server" || item.ToString().ToLower() == "pro_client")
                {
                    com_Client.SelectedItem = item;
                }
            }
            foreach (var item in com_Models.Items)
            {
                if (item.ToString().ToLower() == "pro_models")
                {
                    com_Models.SelectedItem = item;
                }
            }
        }
        string oldModelName()
        {
            string modelName = "";
            string filepath = Path.GetFileName(Path.Combine(Application.StartupPath, "src"));
            DirectoryInfo d = new DirectoryInfo(filepath);

            foreach (var file in d.GetFiles("*.cs"))
            {
                if (file.Name.Substring(0, 1) != "I" && file.Name.Contains("Repository"))
                {
                    modelName = file.Name.Replace("Repository.cs", "");
                    return modelName;
                }
            }

            return modelName;
        }
        #endregion

        private void btn_ApiGenerateRepos_Click(object sender, EventArgs e)
        {
            TxtModelCheck(txt_OldModel);
            TxtModelCheck(txt_NewModel);

            var newFilePath = Directory.CreateDirectory(Path.Combine(Application.StartupPath, com_Api.Text, "Controllers"));
            I = ""; Type = "Controller"; Extention = ".cs";
            CreateFile(newFilePath.FullName);

            newFilePath = Directory.CreateDirectory(Path.Combine(Application.StartupPath, com_Api.Text, "Repositories"));
            I = "I"; Type = "Repository"; Extention = ".cs";
            CreateFile(newFilePath.FullName);

            I = "";
            CreateFile(newFilePath.FullName);

            string startupAPITex = $"services.AddScoped<I{txt_NewModel.Text + Type}, {txt_NewModel.Text + Type}>();";
            txt_ApiStartup.AppendText(startupAPITex);
            txt_ApiStartup.AppendText(Environment.NewLine);
        }
        private void btn_ClientGenerateSevices_Click(object sender, EventArgs e)
        {
            TxtModelCheck(txt_OldModel);
            TxtModelCheck(txt_NewModel);

            var newFilePath = Directory.CreateDirectory(Path.Combine(Application.StartupPath, com_Client.Text, "Services"));
            I = "I"; Type = "Service"; Extention = ".cs";
            CreateFile(newFilePath.FullName);

            I = "";
            CreateFile(newFilePath.FullName);

            string startupAPITex = $"services.AddScoped<I{txt_NewModel.Text+Type}, {txt_NewModel.Text+Type}>();";
            txt_ClientStartup.AppendText(startupAPITex);
            txt_ClientStartup.AppendText(Environment.NewLine);
        }
        private void btn_ModelsGenerateVM_Click(object sender, EventArgs e)
        {
            TxtModelCheck(txt_OldModel);
            TxtModelCheck(txt_NewModel);

            var newFilePath = Directory.CreateDirectory(Path.Combine(Application.StartupPath, com_Models.Text, "ViewModels"));
            I = ""; Type = "VM"; Extention = ".cs";
            CreateFile(newFilePath.FullName);
        }

        private void btn_ClientGeneratePages_Click(object sender, EventArgs e)
        {
            TxtModelCheck(txt_OldModel);
            TxtModelCheck(txt_NewModel);

            var newFilePath = Directory.CreateDirectory(Path.Combine(Application.StartupPath, com_Client.Text, "Pages", txt_NewModel.Text));

            I = ""; Type = "Index"; Extention = ".razor";
            CreateFile(newFilePath.FullName);

            Type = "Form";
            CreateFile(newFilePath.FullName);

            Type = "New";
            CreateFile(newFilePath.FullName);

            Type = "Details";
            CreateFile(newFilePath.FullName);

            Type = "Edit";
            CreateFile(newFilePath.FullName);
        }
        private void btn_CopyStartupAPI_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_ApiStartup.Text);
        }
        private void btn_ClientCopyStartup_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_ClientStartup.Text);
        }
    }
}
