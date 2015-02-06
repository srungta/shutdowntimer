using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDownTimer
{
    public partial class ShutDownTimer : Form
    {
        public ShutDownTimer()
        {
            InitializeComponent();
        }

        private void ShutDownTimer_Load(object sender, EventArgs e)
        {
            DisplayText.Text = "Seems like you want to shutdown your system. Good Call Mate!";
            TimeValueLabel.Text = TimeBar.Value.ToString();
        }

        private void TimeBar_ValueChanged(object sender, EventArgs e)
        {
            TimeValueLabel.Text = TimeBar.Value.ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(ShutDownRadioButton.Checked == true)
            {
                int minute = TimeBar.Value;
                string minute_s= (TimeBar.Value > 1) ? minute.ToString()+" minutes" : minute.ToString()+" minute";
                string textToBeDisplayed = "Your system will shutdown in " + minute_s;
                DialogResult dialogResult = MessageBox.Show(textToBeDisplayed, "You sure you want to do this now?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    //code for shutdown
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/c shutdown -s -t " + (minute * 60).ToString();
                   // startInfo.Arguments = "/c dir";
                    process.StartInfo = startInfo;
                    try
                    {
                        
                        process.Start();
                    }
                    catch (Exception)
                    {
                        Console.Write("An error occured");
                        Console.Read();
                        throw;
                    }
                    
                    //Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else if(RestartRadioButton.Checked == true)
            {
                int minute = TimeBar.Value;
                string minute_s = (TimeBar.Value > 1) ? minute.ToString() + " minutes" : minute.ToString() + " minute";
                string textToBeDisplayed = "Your system will restart in " + minute_s;
                DialogResult dialogResult = MessageBox.Show(textToBeDisplayed, "You sure you want to do this now?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    //code for shutdown
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/c shutdown -r -t "+(minute*60).ToString();
                    process.StartInfo = startInfo;
                    process.Start();
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void StopShutdown_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c shutdown -a";
            process.StartInfo = startInfo;
            process.Start();
            Application.Exit();
        }
    }
}
