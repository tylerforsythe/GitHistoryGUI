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
        }

        private void btnGo_Click(object sender, EventArgs e) {
            var commandString = GetCommandString();
            var args = GetArgumentsString();

            var process = new Process();
            process.StartInfo.WorkingDirectory = @"C:\home\projects\IMPrinting\src-lucy";
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
            return string.Format(" log --reverse --author=\"tylerforsythe\" --author=\"Tyler Forsythe\" --after=\"{0} 00:00:00\" --before=\"{0} 23:59:59\" --format=%B",
                FormatDateForGit(dtPicker.Value.Date));
        }

        private string FormatDateForGit(DateTime dt) {
            return string.Format("{0}-{1}-{2}", dt.Year, dt.Month.ToString("D2"), dt.Day.ToString("D2"));
        }

        private void txtUsersCsv_TextChanged(object sender, EventArgs e) {

        }
    }
}
