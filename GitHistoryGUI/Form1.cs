using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHistoryGUI
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();

            txtUsersCsv.Text = ConfigurationManager.AppSettings["Users"];

            var directoryOptions = ConfigurationManager.AppSettings["DirectoryOptions"].Split(new string[] {";"}, StringSplitOptions.RemoveEmptyEntries);
            BindingSource bs = new BindingSource();
            bs.DataSource = directoryOptions.ToList();
            comboPaths.DataSource = bs;
            comboPaths.Text = directoryOptions[0];


            listPaths.DataSource = bs;
            listPaths.SelectedIndex = 0;
        }

        private void btnGo_Click(object sender, EventArgs e) {
            var commandString = GetCommandString();
            var args = GetArgumentsString();

            var process = new Process();
            //process.StartInfo.WorkingDirectory = comboPaths.Text;
            process.StartInfo.WorkingDirectory = (string)listPaths.SelectedItem;
            process.StartInfo.FileName = commandString;
            process.StartInfo.Arguments = args;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            output = output.Replace("\n", Environment.NewLine);
            output = output.Replace(Environment.NewLine + Environment.NewLine, Environment.NewLine);

            txtResult.Text = output;
        }

        private string GetCommandString() {
            return string.Format("git");
        }

        private string GetArgumentsString() {
            return string.Format(" log --reverse {1} --after=\"{0} 00:00:00\" --before=\"{0} 23:59:59\" --format=%B",
                FormatDateForGit(dtPicker.Value.Date), GetAuthorsString());
        }

        private string GetAuthorsString() {
            var authorsAll = txtUsersCsv.Text;
            var authorsList = authorsAll.Split(new []{","}, StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();
            foreach (var a in authorsList) {
                sb.AppendFormat(" --author=\"{0}\" ", a);
            }
            return sb.ToString();
        }

        private string FormatDateForGit(DateTime dt) {
            return string.Format("{0}-{1}-{2}", dt.Year, dt.Month.ToString("D2"), dt.Day.ToString("D2"));
        }

        private void txtUsersCsv_TextChanged(object sender, EventArgs e) {

        }

        private void btnToday_Click(object sender, EventArgs e) {
            dtPicker.Value = DateTime.Now.Date;
        }

        private void listPaths_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        private void btnYesterday_Click(object sender, EventArgs e) {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                dtPicker.Value = DateTime.Now.Date.AddDays(-3);
            else
                dtPicker.Value = DateTime.Now.Date.AddDays(-1);
        }
    }
}
