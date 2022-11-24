using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigTablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        int bjkP = 0, bjkG = 0, bjkB = 0, bjkM = 0, bjkA = 0, bjkA2 = 0, bjkA3 = 0;
        int fbP = 0, fbG = 0, fbB = 0, fbM = 0, fbA = 0, fbA2 = 0, fbA3 = 0;
        int gsP = 0, gsG = 0, gsB = 0, gsM = 0, gsA = 0, gsA2 = 0, gsA3 = 0;
        int tsP = 0, tsG = 0, tsB = 0, tsM = 0, tsA = 0, tsA2 = 0, tsA3 = 0;
        int om = 0;
        int yedek = 0;
        string takım;


        private void button1_Click(object sender, EventArgs e)
        {
            om++;
            button1.Enabled = false;
            int a = rnd.Next(0, 5);
            int b = rnd.Next(0, 5);
            int c = rnd.Next(0, 5);
            int d = rnd.Next(0, 5);

            lblgsskor.Text = a.ToString();
            lblfbskor.Text = b.ToString();
            lblbjkskor.Text = c.ToString();
            lbltsskor.Text = d.ToString();

            if (Convert.ToInt32(lblgsskor.Text) > Convert.ToInt32(lblfbskor.Text))
            {
                gsP += 3;
                gsG += 1;
                fbM += 1;
                gsA = Convert.ToInt32(lblgsskor.Text) - Convert.ToInt32(lblfbskor.Text);
                fbA = Convert.ToInt32(lblfbskor.Text) - Convert.ToInt32(lblgsskor.Text);
            }
            if (Convert.ToInt32(lblgsskor.Text) == Convert.ToInt32(lblfbskor.Text))
            {
                gsP += 1;
                fbP += 1;
                gsB += 1;
                fbB += 1;
                gsA = Convert.ToInt32(lblgsskor.Text) - Convert.ToInt32(lblfbskor.Text);
                fbA = Convert.ToInt32(lblfbskor.Text) - Convert.ToInt32(lblgsskor.Text);
            }
            if (Convert.ToInt32(lblgsskor.Text) < Convert.ToInt32(lblfbskor.Text))
            {
                fbP += 3;
                fbG += 1;
                gsM += 1;
                gsA = Convert.ToInt32(lblgsskor.Text) - Convert.ToInt32(lblfbskor.Text);
                fbA = Convert.ToInt32(lblfbskor.Text) - Convert.ToInt32(lblgsskor.Text);
            }

            if (Convert.ToInt32(lblbjkskor.Text) > Convert.ToInt32(lbltsskor.Text))
            {
                bjkP += 3;
                bjkG += 1;
                tsM += 1;
                bjkA = Convert.ToInt32(lblbjkskor.Text) - Convert.ToInt32(lbltsskor.Text);
                tsA = Convert.ToInt32(lbltsskor.Text) - Convert.ToInt32(lblbjkskor.Text);
            }
            if (Convert.ToInt32(lblbjkskor.Text) == Convert.ToInt32(lbltsskor.Text))
            {
                bjkP += 1;
                tsP += 1;
                bjkB += 1;
                tsB += 1;
                bjkA = Convert.ToInt32(lblbjkskor.Text) - Convert.ToInt32(lbltsskor.Text);
                tsA = Convert.ToInt32(lbltsskor.Text) - Convert.ToInt32(lblbjkskor.Text);
            }
            if (Convert.ToInt32(lblbjkskor.Text) < Convert.ToInt32(lbltsskor.Text))
            {
                tsP += 3;
                tsG += 1;
                bjkM += 1;
                bjkA = Convert.ToInt32(lblbjkskor.Text) - Convert.ToInt32(lbltsskor.Text);
                tsA = Convert.ToInt32(lbltsskor.Text) - Convert.ToInt32(lblbjkskor.Text);
            }



            lblbjkom.Text = om.ToString();
            lblfbom.Text = om.ToString();
            lblgsom.Text = om.ToString();
            lbltsom.Text = om.ToString();
            lblbjkG.Text = bjkG.ToString();
            lblfbG.Text = fbG.ToString();
            lblgsG.Text = gsG.ToString();
            lbltsG.Text = tsG.ToString();
            lblbjkB.Text = bjkB.ToString();
            lblfbB.Text = fbB.ToString();
            lblgsB.Text = gsB.ToString();
            lbltsB.Text = tsB.ToString();
            lblbjkM.Text = bjkM.ToString();
            lblfbM.Text = fbM.ToString();
            lblgsM.Text = gsM.ToString();
            lbltsM.Text = tsM.ToString();
            lblbjkA.Text = bjkA.ToString();
            lblfbA.Text = fbA.ToString();
            lblgsA.Text = gsA.ToString();
            lbltsA.Text = tsA.ToString();
            lblbjkP.Text = bjkP.ToString();
            lblfbP.Text = fbP.ToString();
            lblgsP.Text = gsP.ToString();
            lbltsP.Text = tsP.ToString();

            if (bjkP>fbP && bjkP>gsP && bjkP>tsP)
            {
                label32.Text = lblbjkP.Text;
                label56.Text= "Beşiktaş";
               
            }
            if (fbP > bjkP && fbP > gsP && fbP > tsP)
            {
                label32.Text = fbP.ToString();
                label56.Text = "Fenerbahçe";

            }
            if (gsP > bjkP && gsP > fbP && gsP > tsP)
            {
                label32.Text = gsP.ToString();
                label56.Text = "Galatasaray";

            }
            if (tsP > bjkP && tsP > fbP && tsP > gsP)
            {
                label32.Text = tsP.ToString();
                label56.Text = "Trabzonspor";

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            om++;
            button2.Enabled = false;
            int a = rnd.Next(0, 5);
            int b = rnd.Next(0, 5);
            int c = rnd.Next(0, 5);
            int d = rnd.Next(0, 5);

            lbltsskor2.Text = a.ToString();
            lblgsskor2.Text = b.ToString();
            lblfbskor2.Text = c.ToString();
            lblbjkskor2.Text = d.ToString();

            if (Convert.ToInt32(lbltsskor2.Text) > Convert.ToInt32(lblgsskor2.Text))
            {
                tsP += 3;
                tsG += 1;
                gsM += 1;
            }

                if (Convert.ToInt32(lbltsskor2.Text) == Convert.ToInt32(lblgsskor2.Text))
                {
                    tsP += 1;
                    gsP += 1;
                    tsB += 1;
                    gsB += 1;

                }
                if (Convert.ToInt32(lbltsskor2.Text) < Convert.ToInt32(lblgsskor2.Text))
                {
                    gsP += 3;
                    gsG += 1;
                    tsM += 1;
                }

                if (Convert.ToInt32(lblfbskor2.Text) > Convert.ToInt32(lblbjkskor2.Text))
                {
                    fbP += 3;
                    fbG += 1;
                    bjkM += 1;

                }
                if (Convert.ToInt32(lblfbskor2.Text) == Convert.ToInt32(lblbjkskor2.Text))
                {
                    fbP += 1;
                    bjkP += 1;
                    bjkB += 1;
                    fbB += 1;

                }
                if (Convert.ToInt32(lblfbskor2.Text) < Convert.ToInt32(lblbjkskor2.Text))
                {
                    bjkP += 3;
                    bjkG += 1;
                    fbM += 1;

                }

                tsA2 = Convert.ToInt32(lbltsskor2.Text) - Convert.ToInt32(lblgsskor2.Text) + tsA;
                gsA2 = Convert.ToInt32(lblgsskor2.Text) - Convert.ToInt32(lbltsskor2.Text) + gsA;
                fbA2 = Convert.ToInt32(lblfbskor2.Text) - Convert.ToInt32(lblbjkskor2.Text) + fbA;
                bjkA2 = Convert.ToInt32(lblbjkskor2.Text) - Convert.ToInt32(lblfbskor2.Text) + bjkA;


                lblbjkom.Text = om.ToString();
                lblfbom.Text = om.ToString();
                lblgsom.Text = om.ToString();
                lbltsom.Text = om.ToString();
                lblbjkG.Text = bjkG.ToString();
                lblfbG.Text = fbG.ToString();
                lblgsG.Text = gsG.ToString();
                lbltsG.Text = tsG.ToString();
                lblbjkB.Text = bjkB.ToString();
                lblfbB.Text = fbB.ToString();
                lblgsB.Text = gsB.ToString();
                lbltsB.Text = tsB.ToString();
                lblbjkM.Text = bjkM.ToString();
                lblfbM.Text = fbM.ToString();
                lblgsM.Text = gsM.ToString();
                lbltsM.Text = tsM.ToString();
                lblbjkA.Text = bjkA2.ToString();
                lblfbA.Text = fbA2.ToString();
                lblgsA.Text = gsA2.ToString();
                lbltsA.Text = tsA2.ToString();
                lblbjkP.Text = bjkP.ToString();
                lblfbP.Text = fbP.ToString();
                lblgsP.Text = gsP.ToString();
                lbltsP.Text = tsP.ToString();
            

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            om++;
            button3.Enabled = false;
            int a = rnd.Next(0, 5);
            int b = rnd.Next(0, 5);
            int c = rnd.Next(0, 5);
            int d = rnd.Next(0, 5);

            lblfbskor3.Text = a.ToString();
            lbltsskor3.Text = b.ToString();
            lblbjkskor3.Text = c.ToString();
            lblgsskor3.Text = d.ToString();

            if (Convert.ToInt32(lblfbskor3.Text) > Convert.ToInt32(lbltsskor3.Text))
            {
                fbP += 3;
                fbG += 1;
                tsM += 1;
                
            }
            if (Convert.ToInt32(lblfbskor3.Text) == Convert.ToInt32(lbltsskor3.Text))
            {
                fbP += 1;
                tsP += 1;
                fbB += 1;
                gsB += 1;
                
            }
            if (Convert.ToInt32(lblfbskor3.Text) < Convert.ToInt32(lbltsskor3.Text))
            {
                tsP += 3;
                tsG += 1;
                fbM += 1;
                
            }

            if (Convert.ToInt32(lblbjkskor3.Text) > Convert.ToInt32(lblgsskor3.Text))
            {
                bjkP += 3;
                bjkG += 1;
                gsM += 1;
               
            }
            if (Convert.ToInt32(lblbjkskor3.Text) == Convert.ToInt32(lblgsskor3.Text))
            {
                bjkP += 1;
                gsP += 1;
                bjkB += 1;
                gsB += 1;
               
            }
            if (Convert.ToInt32(lblbjkskor3.Text) < Convert.ToInt32(lblgsskor3.Text))
            {
                gsP += 3;
                gsG += 1;
                bjkM += 1;
              
            }

            fbA3 = Convert.ToInt32(lblfbskor3.Text) - Convert.ToInt32(lbltsskor3.Text) + fbA2;
            tsA3 = Convert.ToInt32(lbltsskor3.Text) - Convert.ToInt32(lblfbskor3.Text) + tsA2;
            bjkA3 = Convert.ToInt32(lblbjkskor3.Text) - Convert.ToInt32(lblgsskor3.Text) + bjkA2;
            gsA3 = Convert.ToInt32(lblgsskor3.Text) - Convert.ToInt32(lblbjkskor3.Text) + gsA2;

            lblbjkom.Text = om.ToString();
            lblfbom.Text = om.ToString();
            lblgsom.Text = om.ToString();
            lbltsom.Text = om.ToString();
            lblbjkG.Text = bjkG.ToString();
            lblfbG.Text = fbG.ToString();
            lblgsG.Text = gsG.ToString();
            lbltsG.Text = tsG.ToString();
            lblbjkB.Text = bjkB.ToString();
            lblfbB.Text = fbB.ToString();
            lblgsB.Text = gsB.ToString();
            lbltsB.Text = tsB.ToString();
            lblbjkM.Text = bjkM.ToString();
            lblfbM.Text = fbM.ToString();
            lblgsM.Text = gsM.ToString();
            lbltsM.Text = tsM.ToString();
            lblbjkA.Text = bjkA3.ToString();
            lblfbA.Text = fbA3.ToString();
            lblgsA.Text = gsA3.ToString();
            lbltsA.Text = tsA3.ToString();
            lblbjkP.Text = bjkP.ToString();
            lblfbP.Text = fbP.ToString();
            lblgsP.Text = gsP.ToString();
            lbltsP.Text = tsP.ToString();

        }

        


    }
}
