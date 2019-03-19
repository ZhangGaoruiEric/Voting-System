using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass2
    {
        public object txthour { get; private set; }
        public object txtmm { get; private set; }
        public object txtss { get; private set; }
        public object txtmss { get; private set; }
        public object Dealine_txt { get; private set; }
        public object button1 { get; private set; }
        public int isstop { get; private set; }

        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }
        public void Counter()
        {   //counting down the rest of time
            try
            {
                int Timecount = 6000;
                while (Timecount >= 0)
                {
                    this.txthour = (Timecount / 3600000).ToString();
                    this.txtmm = ((Timecount / 60000) % 60).ToString();
                    this.txtss = ((Timecount / 1000) % 60).ToString();
                    this.txtmss = (Timecount % 1000).ToString();

                    if (Timecount == 0)
                    {
                        object Red = 2;
                        txthour = Red;
                        txtmm = Red;
                        txtss = Red;
                        txtmss = Red;
                        this.Dealine_txt = false;

                        this.button1 = "Start";
                        isstop = 0;
                        try
                        {
                            Thread currthread = Thread.CurrentThread;
                            currthread.Abort();// Terminating the current process will trigger a ThreadAbortException and terminate the process, so the following need to catch the exception to terminate the process.
                        }
                        catch (ThreadAbortException) { }
                    }
                    if (isstop != 2)
                        Timecount -= 1;
                    Thread.Sleep(1);
                }
            }
            catch
            {
                MessageBox.Show("error!!?");
            }//Handling exceptions in case of abnormal shutdown
        }

        //int timeData = 0;
        //bool btFlag = true;


        private void timer1_Tick(object sender, EventArgs e)
        {
            int Timecount = 6000;
            if (Timecount >= 0)
            {
                this.txthour = (Timecount / 3600000).ToString(); // hour
                this.txtmm = ((Timecount / 60000) % 60).ToString();// minute
                this.txtss = ((Timecount / 1000) % 60).ToString();// second
                this.txtmss = (Timecount % 1000).ToString();// millisecond

                if (Timecount == 0)
                {
                    object Red = 2;
                    txthour = Red;
                    txtmm = Red;
                    txtss = Red;
                    txtmss = Red;
                    // when time is 0, the font will change red
                }
                Timecount -= 10;
            }
        }
    }
}
