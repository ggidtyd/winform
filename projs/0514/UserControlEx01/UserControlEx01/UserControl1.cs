using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlEx01
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler delete_button_event;
        public string GUID;
        public int rand_num;

        public UserControl1()
        {
            InitializeComponent();
            make_guid();
            make_random();
        }
        
        public void make_guid()
        {
            Guid guid = Guid.NewGuid();
            GUID = guid.ToString();
            guid_textbox.Text = guid.ToString();
        }

        public void make_random()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            rand_num = random.Next(100);
            random_textbox.Text = rand_num.ToString();
        }

        public void set_background()
        {
            if(rand_num >= 50)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            make_guid();
            make_random();
            set_background();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            // 이벤트 발생, mainform에서 이벤트 발생을 인지할수 있게됨
            delete_button_event(this, e);
        }
    }
}
