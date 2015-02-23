using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            txtUsersCsv.Text = "tylerforsythe,Tyler Forsythe";
            txtWorkingDirectory.Text = @"C:\home\projects\IMPrinting\src-lucy";
        }

        private void btnGo_Click(object sender, EventArgs e) {
            var commandString = GetCommandString();
            var args = GetArgumentsString();

            var process = new Process();
            process.StartInfo.WorkingDirectory = txtWorkingDirectory.Text;
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
    }
}
