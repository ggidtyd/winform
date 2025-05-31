using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadEx01
{
    public partial class Form1 : Form
    {
        Thread _thread = null;
        bool IS_RUN = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if(_thread == null)
            {
                //thread_status_label.Text = "START";
                _thread = new Thread(new ThreadStart(thread_task));
                _thread.IsBackground = true;
                _thread.Start();
            }
        }

        public void change_status_safe()
        {
            try
            {
                if (thread_status_label.InvokeRequired)
                {
                    Action action = () => { change_status_safe(); };
                    if(thread_status_label != null)
                        thread_status_label.Invoke(action);
                    /*
                    Action action = delegate { change_status_safe(); };
                    if (thread_status_label != null)
                        thread_status_label.Invoke(action);
                    */
                }
                else
                {
                    thread_status_label.Text = "START";
                }
            }
            catch (Exception)
            {
            }
        }

        public void thread_task()
        {
            int new_val;
            Random rnd = new Random();
            IS_RUN = true;
            change_status_safe();
            while (true) 
            {
                if (IS_RUN == false)
                    break;
                new_val = rnd.Next(progressBar1.Minimum,progressBar1.Maximum);
                change_progress_safe(new_val);
                Thread.Sleep(100);
            }
        }

        public void change_progress_safe(int val)
        {
            try
            {
                if (progressBar1.InvokeRequired)
                {
                    /*
                    Action safe_write = delegate { change_progress_safe(val); };
                    if (progressBar1 != null)
                        progressBar1.Invoke(safe_write);
                    */
                    Action safe_write = () => { change_progress_safe(val); };
                    if (progressBar1 != null)
                        progressBar1.Invoke(safe_write);
                }
                else
                {
                    progressBar1.Value = val;
                }
            }
            catch (Exception)
            {
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            thread_status_label.Text = "STOP";
            if(_thread != null)
            {
                IS_RUN = false;
                try
                {
                    _thread.Abort();
                    _thread = null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
