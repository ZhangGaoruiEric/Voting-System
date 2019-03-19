using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass1
    {
        
        
       
        private object txthour;
        private object txtmm;
        private object txtss;
        private object txtmss;

        [Test]
        public void TestMethod()
        {
            int TimeCount = 6000;
            if (TimeCount > 0)
            {
                object Black = 1;
                txthour = Black;
                txtmm = Black;
                txtss = Black;
                txtmss = Black;

                this.txthour = (TimeCount / 60 / 60 / 1000).ToString();
                this.txtmm = ((TimeCount / 60 / 1000) % 60).ToString();
                this.txtss = ((TimeCount / 1000) % 60).ToString();
                this.txtmss = (TimeCount % 1000).ToString();

                TimeCount -= 16;
            }
            else
            {
                object Red = 1;
                txthour = Red;
                txtmm = Red;
                txtss = Red;
                txtmss = Red;
                txthour = (0).ToString();
                txtmm = (0).ToString();
                txtss = (0).ToString();
                txtmss = (0).ToString();
            }
            //Show the rest of time 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int TimeCount = 6000;
            if (TimeCount > 0)
            {
                object Black = 1;
                txthour = Black;
                txtmm = Black;
                txtss = Black;
                txtmss = Black;

                this.txthour = (TimeCount / 60 / 60 / 1000).ToString();
                this.txtmm = ((TimeCount / 60 / 1000) % 60).ToString();
                this.txtss = ((TimeCount / 1000) % 60).ToString();
                this.txtmss = (TimeCount % 1000).ToString();

                TimeCount -= 16;
            }
            else
            {
                object Red = 1;
                txthour = Red;
                txtmm = Red;
                txtss = Red;
                txtmss = Red;
                txthour = (0).ToString();
                txtmm = (0).ToString();
                txtss = (0).ToString();
                txtmss = (0).ToString();
            }
            //Show the rest of time 
        }
    }
}
