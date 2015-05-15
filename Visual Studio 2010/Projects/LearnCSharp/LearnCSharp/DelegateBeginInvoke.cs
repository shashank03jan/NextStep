using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace LearnCSharp
{
    public partial class DelegateBeginInvoke : Form
    {
        public DelegateBeginInvoke()
        {
            InitializeComponent();
        }
        delegate void d();
        private void button1_Click(object sender, EventArgs e)
        {
            d x = new d(() => { Thread.Sleep(5000); textBox1.Text = "i am shashank"; });
            // this will hang UI. and it runs on same thread which this control ('this') is running.
            this.BeginInvoke(x);
            textBox1.Text = "i am shekhar";
            MessageBox.Show("i am done");
            // this will not hang ui but will give error becasue it running on diff thread and accessing textbox from diff thread not allowed
            //x.BeginInvoke(new AsyncCallback(CallbackMethod), new object());
        }

        public static void CallMe()
        {
            DelegateBeginInvoke fo = new DelegateBeginInvoke();
            fo.ShowDialog();
        }
        static void CallbackMethod(IAsyncResult ar)
        {
            MessageBox.Show("i am done");
        }
    }
}
