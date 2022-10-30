using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEAFLOWERFULLPROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double roseup = 50, tulipup = 65, orchidup = 75, starup = 50, lotusup = 55, w1up = 60, w2up=45, w3up = 45, w4up = 65, w5up = 70;
        double rosetp, tuliptp, orchidtp, startp, lotustp, w1tp, w2tp, w3tp, w4tp, w5tp;
        double subtotal, tax, grdtotal;
        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text+"Subtotal"+Subtotallbl.Text+"Tax:"+taxlbl.Text+"Grand Total"+totallbl.Text,new Font("Century Gothic",12,FontStyle.Regular),Brushes.Blue,new Point(130)); 
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            RoseCb.Checked=false;
            TulipCb.Checked=false;
            OrchidCb.Checked=false;
            StarCb.Checked=false;
            LotusCb.Checked=false;
            W1Cb.Checked=false;
            W2Cb.Checked=false;
            W3Cb.Checked=false;
            W4Cb.Checked=false;
            W5Cb.Checked=false;
          
        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            rosetp=roseup*Convert.ToDouble(RoseTb.Text);
            tuliptp=tulipup*Convert.ToDouble(TulipTb.Text);
            orchidtp=orchidup*Convert.ToDouble(OrchidTb.Text);
            startp=starup*Convert.ToDouble(StarTb.Text);
            lotustp=lotusup*Convert.ToDouble(LotusTb.Text);
            w1tp=w1up*Convert.ToDouble(W1Tb.Text);
            w2tp=w2up*Convert.ToDouble(W2Tb.Text);
            w3tp=w3up*Convert.ToDouble(W3Tb.Text);
            w4tp=w4up*Convert.ToDouble(W4Tb.Text);
            w5tp=w5up*Convert.ToDouble(W5Tb.Text);

            ReceiptTb.Clear();
            subtotal=0;
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\tSEAFLOWER\t\t\t"+DateLbl.Text+Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t************"+Environment.NewLine);



            if(RoseCb.Checked==true)
            {
                ReceiptTb.AppendText("\tRose:\t"+rosetp+"Rs"+Environment.NewLine);
                subtotal=subtotal+rosetp;
                Subtotallbl.Text=""+subtotal;
            }


            if (TulipCb.Checked==true)
            {
                ReceiptTb.AppendText("\tTulip:\t"+tuliptp+"Rs"+Environment.NewLine);
                subtotal=subtotal+tuliptp;
                Subtotallbl.Text=""+subtotal;
            }



            if (OrchidCb.Checked==true)
            {
                ReceiptTb.AppendText("\tOrchid:\t"+orchidtp+"Rs"+Environment.NewLine);
                subtotal=subtotal+orchidtp;
                Subtotallbl.Text=""+subtotal;
            }


            if (StarCb.Checked==true)
            {
                ReceiptTb.AppendText("\tStar:\t"+startp+"Rs"+Environment.NewLine);
                subtotal=subtotal+startp;
                Subtotallbl.Text=""+subtotal;
            }


            if (LotusCb.Checked==true)
            {
                ReceiptTb.AppendText("\tLotus:\t"+lotustp+"Rs"+Environment.NewLine);
                subtotal=subtotal+lotustp;
                Subtotallbl.Text=""+subtotal;
            }

            if (W1Cb.Checked==true)
            {
                ReceiptTb.AppendText("\tW1:\t"+w1tp+"Rs"+Environment.NewLine);
                subtotal=subtotal+w1tp;
                Subtotallbl.Text=""+subtotal;
            }


            if (W2Cb.Checked==true)
            {
                ReceiptTb.AppendText("\tW2:\t"+w2tp+"Rs"+Environment.NewLine);
                subtotal=subtotal+w2tp;
                Subtotallbl.Text=""+subtotal;
            }



            if (W3Cb.Checked==true)
            {
                ReceiptTb.AppendText("\tW3:\t"+w3tp+"Rs"+Environment.NewLine);
                subtotal=subtotal+w3tp;
                Subtotallbl.Text=""+subtotal;
            }

            if (W4Cb.Checked==true)
            {
                ReceiptTb.AppendText("\tW4:\t"+w4tp+"Rs"+Environment.NewLine);
                subtotal=subtotal+w4tp;
                Subtotallbl.Text=""+subtotal;
            }

            if (W5Cb.Checked==true)
            {
                ReceiptTb.AppendText("\tW5:\t"+w5tp+"Rs"+Environment.NewLine);
                subtotal=subtotal+w5tp;
                Subtotallbl.Text=""+subtotal;
            }

            tax=subtotal*0.16;
            grdtotal=subtotal+tax;
            taxlbl.Text=""+tax;
            totallbl.Text=""+grdtotal;


        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLbl.Text=DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateLbl.Text=DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RoseCb_CheckedChanged(object sender, EventArgs e)
        {
            if(RoseCb.Checked==true)
            {
                RoseTb.Enabled=true;
            }
            if(RoseCb.Checked==false)
            {
                RoseTb.Enabled=false;
                RoseTb.Text="0";
            }
        }

        private void TulipCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TulipCb.Checked==true)
            {
                TulipTb.Enabled=true;
            }
            if (TulipCb.Checked==false)
            {
                TulipTb.Enabled=false;
                TulipTb.Text="0";
            }
        }

        private void OrchidCb_CheckedChanged(object sender, EventArgs e)
        {
            if (OrchidCb.Checked==true)
            {
                OrchidTb.Enabled=true;
            }
            if (OrchidCb.Checked==false)
            {
                OrchidTb.Enabled=false;
                OrchidTb.Text="0";
            }
        }

        private void StarCb_CheckedChanged(object sender, EventArgs e)
        {
            if (StarCb.Checked==true)
            {
                StarTb.Enabled=true;
            }
            if (StarCb.Checked==false)
            {
                StarTb.Enabled=false;
                StarTb.Text="0";
            }
        }

        private void LotusCb_CheckedChanged(object sender, EventArgs e)
        {
            if (LotusCb.Checked==true)
            {
                LotusTb.Enabled=true;
            }
            if (LotusCb.Checked==false)
            {
                LotusTb.Enabled=false;
                LotusTb.Text="0";
            }
        }

        private void W1Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (W1Cb.Checked==true)
            {
                W1Tb.Enabled=true;
            }
            if (W1Cb.Checked==false)
            {
                W1Tb.Enabled=false;
                W1Tb.Text="0";
            }
        }

        private void W2Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (W2Cb.Checked==true)
            {
                W2Tb.Enabled=true;
            }
            if (W2Cb.Checked==false)
            {
                W2Tb.Enabled=false;
                W2Tb.Text="0";
            }
        }

        private void W3Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (W3Cb.Checked==true)
            {
                W3Tb.Enabled=true;
            }
            if (W3Cb.Checked==false)
            {
                W3Tb.Enabled=false;
                W3Tb.Text="0";
            }
        }

        private void W4Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (W4Cb.Checked==true)
            {
                W4Tb.Enabled=true;
            }
            if (W4Cb.Checked==false)
            {
                W4Tb.Enabled=false;
                W4Tb.Text="0";
            }
        }

        private void W5Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (W5Cb.Checked==true)
            {
                W5Tb.Enabled=true;
            }
            if (W5Cb.Checked==false)
            {
                W5Tb.Enabled=false;
                W5Tb.Text="0";
            }
        }
    }
}
