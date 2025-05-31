using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler delete_event;
        public string guid;
        public int rand_num;

        public Thread thread;
        public bool IS_STOP = true;
        
        public UserControl1()
        {
            InitializeComponent();
            make_guid();
            make_random();
            set_background();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            update();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            delete_event(this, e);
        }

        #region update
        public void update()
        {
            make_guid();
            make_random();
            set_background();
        }

        public void make_guid()
        {
            guid = Guid.NewGuid().ToString();
            //guid_label.Text = guid;
            write_guid_safe(guid);
        }

        public void make_random()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            rand_num = random.Next(100);
            //random_label.Text = rand_num.ToString();
            write_rand_num_safe(rand_num.ToString());
        }

        public void set_background()
        {
            if (rand_num > 50)
            {
                //this.BackColor = Color.Red;
                set_back_color_safe(Color.Red);
            }
            else
            {
                //this.BackColor = SystemColors.Control;
                set_back_color_safe(SystemColors.Control);
            }
        }
        #endregion

        #region run
        private void run_button_Click(object sender, EventArgs e)
        {
            if (IS_STOP)
                run();
        }

        public void run()
        {
            IS_STOP = false;
            if (thread == null)
            {
                thread = new Thread(new ThreadStart(run_thread));
                if (thread.IsAlive == false)
                {
                    thread.Start();
                }
            }
        }

        public void run_thread()
        {
            while (true)
            {
                if (IS_STOP)
                {
                    stop_thread();
                    break;
                }

                make_guid();
                make_random();
                set_background();
                Thread.Sleep(100);
            }
        }
        #endregion

        #region stop
        private void stop_button_Click(object sender, EventArgs e)
        {
            if (IS_STOP == false)
                stop_thread();
        }

        public void stop_thread()
        {
            IS_STOP = true;

            try
            {
                if (thread != null)
                    thread.Abort();
            }
            catch (Exception)
            {
            }

            thread = null;
        }
        #endregion

        #region safe
        public void write_guid_safe(string text)
        {
            try
            {
                if (guid_label.InvokeRequired)
                {
                    Action safe_write = () => { write_guid_safe(text); };
                    if (guid_label != null)
                    {
                        guid_label.Invoke(safe_write);
                    }
                }
                else
                {
                    guid_label.Text = text;
                }
                
            }
            catch (Exception)
            {

            }
        }

        public void write_rand_num_safe(string text)
        {
            try
            {
                if (random_label.InvokeRequired)
                {
                    Action safe_write = () => { write_rand_num_safe(text); };
                    if (random_label != null)
                    {
                        random_label.Invoke(safe_write);
                    }
                }
                else
                {
                    random_label.Text = text;
                }
            }
            catch (Exception)
            { 

            }
        }

        public void set_back_color_safe(Color color)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    Action safe_set_back_color = () => { set_back_color_safe(color); };
                    if (this != null)
                        this.Invoke(safe_set_back_color);
                }
                else
                    this.BackColor = color;
                
            }
            catch (Exception)
            {

            }
        }
        #endregion
    }
}
