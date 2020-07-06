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
        #endregion

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_ModelName.Text.Trim()))
            {
                MessageBox.Show("", "you have to spcify model name", MessageBoxButtons.OK);
                txt_ModelName.Focus();
                return;
            }

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
    }
}
