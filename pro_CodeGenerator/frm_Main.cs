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
        
        #endregion
        public frm_Main()
        {
            InitializeComponent();
        }

        #region Pro
        void CreateFile(string path, string txt)
        {         
            if (!File.Exists(path))
            {
                //File.Create(path);
                //TextWriter tw = new StreamWriter(path);
                //tw.WriteLine(txt);
                //tw.Close();
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
        void TxtModelCheck()
        {
            if (string.IsNullOrEmpty(txt_ModelName.Text.Trim()))
            {
                MessageBox.Show("", "you have to spcify model name", MessageBoxButtons.OK);
                txt_ModelName.Focus();
                return;
            }
            txt_ModelName.Text = UpperFirstLetter(txt_ModelName.Text.Trim());
        }
        #endregion

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            TxtModelCheck();

            var dir = Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Repositories"));

            string fileName = "I" + txt_ModelName.Text.Trim() + "Repository";
            string fullFileName = Path.Combine(dir.FullName, fileName + ".cs");
            string txt = Properties.Resources.I_Model_Repository.ToString();
            txt = txt.Replace("-Model-", txt_ModelName.Text.Trim());
            txt = txt.Replace("-model-", txt_ModelName.Text.Trim().ToLower()); 
            CreateFile(fullFileName, txt);

            fileName = txt_ModelName.Text.Trim() + "Repository";
            fullFileName = Path.Combine(dir.FullName, fileName + ".cs");
            txt = Properties.Resources._Model_Repository.ToString();
            txt = txt.Replace("-Model-", txt_ModelName.Text.Trim());
            txt = txt.Replace("-model-", txt_ModelName.Text.Trim().ToLower());
            CreateFile(fullFileName, txt);

            dir = Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Controllers"));
            fileName = txt_ModelName.Text.Trim() + "Controller";
            fullFileName = Path.Combine(dir.FullName, fileName + ".cs");
            txt = Properties.Resources._Model_Controller.ToString();
            txt = txt.Replace("-Model-", txt_ModelName.Text.Trim());
            txt = txt.Replace("-model-", txt_ModelName.Text.Trim().ToLower());
            CreateFile(fullFileName, txt);

            string startupAPITex = "services.AddScoped<I-Model-Repository, -Model-Repository>();";
            startupAPITex = startupAPITex.Replace("-Model-", txt_ModelName.Text.Trim());
            txt_StartupAPI.AppendText(startupAPITex);
            txt_StartupAPI.AppendText(Environment.NewLine);
        }
        private void btn_CopyStartupAPI_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_StartupAPI.Text);
        }
        private void txt_ModelName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Generate_Click(null, null);
                txt_ModelName.SelectAll();
            }
        }

        private void btn_ClientGenerate_Click(object sender, EventArgs e)
        {
            TxtModelCheck();

            var dir = Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Services"));

            string fileName = "I" + txt_ModelName.Text.Trim() + "Service";
            string fullFileName = Path.Combine(dir.FullName, fileName + ".cs");
            string txt = Properties.Resources.I_Model_Service.ToString();
            txt = txt.Replace("-Model-", txt_ModelName.Text.Trim());
            txt = txt.Replace("-model-", txt_ModelName.Text.Trim().ToLower());
            CreateFile(fullFileName, txt);

            fileName = txt_ModelName.Text.Trim() + "Service";
            fullFileName = Path.Combine(dir.FullName, fileName + ".cs");
            txt = Properties.Resources._Model_Service.ToString();
            txt = txt.Replace("-Model-", txt_ModelName.Text.Trim());
            txt = txt.Replace("-model-", txt_ModelName.Text.Trim().ToLower());
            CreateFile(fullFileName, txt);

            string startupClientText = @"services.AddHttpClient<I-Model-Service, -Model-Service>(client =>
                                    {
                                        client.BaseAddress = new Uri(uri);
                                    }); ";
            startupClientText = startupClientText.Replace("-Model-", txt_ModelName.Text.Trim());
            txt_ClientStartup.AppendText(startupClientText);
            txt_ClientStartup.AppendText(Environment.NewLine);
        }

        private void btn_ClientGeneratePages_Click(object sender, EventArgs e)
        {
            TxtModelCheck();

            var dir = Directory.CreateDirectory(Path.Combine(Application.StartupPath, $@"Pages\{txt_ModelName.Text.Trim()}"));

            string fileName = txt_ModelName.Text.Trim();
            string fullFileName = Path.Combine(dir.FullName, fileName + ".razor");
            string txt = Properties.Resources._Model__razor.ToString();
            txt = txt.Replace("-Model-", txt_ModelName.Text.Trim());
            txt = txt.Replace("-model-", txt_ModelName.Text.Trim().ToLower());
            CreateFile(fullFileName, txt);

            fileName = txt_ModelName.Text.Trim() + "Form";
            fullFileName = Path.Combine(dir.FullName, fileName + ".razor");
            txt = Properties.Resources._Model_Form_razor.ToString();
            txt = txt.Replace("-Model-", txt_ModelName.Text.Trim());
            txt = txt.Replace("-model-", txt_ModelName.Text.Trim().ToLower());
            CreateFile(fullFileName, txt);

            fileName = txt_ModelName.Text.Trim() + "New";
            fullFileName = Path.Combine(dir.FullName, fileName + ".razor");
            txt = Properties.Resources._Model_New_razor.ToString();
            txt = txt.Replace("-Model-", txt_ModelName.Text.Trim());
            txt = txt.Replace("-model-", txt_ModelName.Text.Trim().ToLower());
            CreateFile(fullFileName, txt);

            fileName = txt_ModelName.Text.Trim() + "Details";
            fullFileName = Path.Combine(dir.FullName, fileName + ".razor");
            txt = Properties.Resources._Model_Details_razor.ToString();
            txt = txt.Replace("-Model-", txt_ModelName.Text.Trim());
            txt = txt.Replace("-model-", txt_ModelName.Text.Trim().ToLower());
            CreateFile(fullFileName, txt);

            fileName = txt_ModelName.Text.Trim() + "Edit";
            fullFileName = Path.Combine(dir.FullName, fileName + ".razor");
            txt = Properties.Resources._Model_Edit_razor.ToString();
            txt = txt.Replace("-Model-", txt_ModelName.Text.Trim());
            txt = txt.Replace("-model-", txt_ModelName.Text.Trim().ToLower());
            CreateFile(fullFileName, txt);
        }
    }
}
