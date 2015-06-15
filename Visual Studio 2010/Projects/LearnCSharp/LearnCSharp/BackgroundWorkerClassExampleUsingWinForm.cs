using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LearnCSharp
{
    public partial class BackgroundWorkerClassExampleUsingWinForm : Form
    {
        
        //first sunsribe to event DoWork and add method to it.
        //this method will be run async whenever u call RunWorkerAsync method of bgworker class
        //so put your logic dowork which u want to run async or on thread.
        //also subscribe to RunWorkerCompleted which will run once async is completed.
        //As it runs in different thread so you can not access ui controls(objects) directly from DoWork method code.
        //background worker classes can be used to track progress. see below example

        //so basically using RunWorkerCompleted you update the ui on call back.
        // but there is one more to do this using dispatcher in wpf

        //The BackgroundWorker class helps with this kind of taks. It allows Reporting changes, 
        //like a percentage and dispatches this automatically from the Background thread into the ui thread. 
        //For the most thread <> update ui tasks the BackgroundWorker is a great tool.
        public BackgroundWorkerClassExampleUsingWinForm()
        {
            InitializeComponent();
            //
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.WorkerReportsProgress = true;
            
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            textBox1.Text = "completed using thread"+e.ProgressPercentage.ToString();
            Console.WriteLine("progress changed thread" + System.Threading.Thread.CurrentThread.ManagedThreadId);
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBox3.Text = "Completed";
            
        }
        delegate void Mydelegate();
        // code written under this method will be run on diff thread asyncroneoulsy
        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(250);
                backgroundWorker1.ReportProgress(i * 10);
                Console.WriteLine("backgroundWorker1_DoWork" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            }
            //textBox1.Text = "Running";
            //this is important. this begininvoke is different from delegate.begininvoke. because this is control.begininvoke
            //this.begininvoke runs on same UI thread but asynchroneoulsy
            this.BeginInvoke(new Mydelegate(method)); //running on same UI thread


            //very important. currently we are on new thread. but this will execute on same UI thread. and calls after this also runs on same UI thread.
            //but if we comment this code then call after this will not run on same UI thread but on new thread.
            this.Invoke(new Mydelegate(method1)); //running on same UI Thread
            //this.Invoke(new Mydelegate(() => textBox1.Text = "Running")); //same as above but anynemous method
            textBox1.Text = "Running";// see, we can't access UI controls from different thread
            Console.WriteLine("after backgroundWorker1_DoWork" + System.Threading.Thread.CurrentThread.ManagedThreadId);
           
        }

        void method()
        {
            Console.WriteLine("method calls on" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            textBox1.Text = "Running";
        }
        void method1()
        {
            Console.WriteLine("method1 calls on" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            textBox1.Text = "Running";
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HI");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                Console.WriteLine("main thread"+ System.Threading.Thread.CurrentThread.ManagedThreadId);
                backgroundWorker1.RunWorkerAsync();
            }
        }

        public static void CallMe()
        {
            BackgroundWorkerClassExampleUsingWinForm f = new BackgroundWorkerClassExampleUsingWinForm();
            f.ShowDialog();
        }

    }
}
