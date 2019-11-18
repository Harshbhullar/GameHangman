using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;


namespace GameHangman
{
    [Activity(WindowSoftInputMode = SoftInput.StateHidden)]
    public class Game : Activity
    {
        private TextView Name;
        private TextView Answr;
        private TextView Hint;
        private TextView Ques;

        private Button btn;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnE;
        private Button btnF;
        private Button btnG;
        private Button btnH;
        private Button btnI;
        private Button btnJ;
        private Button btnK;
        private Button btnL;
        private Button btnM;
        private Button btnN;
        private Button btnO;
        private Button btnP;
        private Button btnQ;
        private Button btnR;
        private Button btnS;
        private Button btnT;
        private Button btnU;
        private Button btnV;
        private Button btnW;
        private Button btnX;
        private Button btnY;
        private Button btnZ;

        private ImageView img;


        List<String> quesLst;
        List<String> ans;
        Random rd = new Random();
        int no = 0, ln = 0, idx = 0, reply = 0;
        String quesAns = "", dulpAns = "";
        int clk = 0,countClk=0,wrongCount=0;
        char chr;


   
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.GameArea);

            img = FindViewById<ImageView>(Resource.Id.imageView1);

  /*          music-- - piano
Profession--actor
animal - lion
transport - plane
body-- - heart
flower--rose
Flower - Daisy
*/
            quesLst = new List<string>();
            quesLst.Add("Profession");
            quesLst.Add("Music");
            quesLst.Add("Animal");
            quesLst.Add("Body");
            quesLst.Add("Flower");
            quesLst.Add("Flower");
            quesLst.Add("Transport");

            
            ans = new List<string>();

            ans.Add("actor");
            ans.Add("piano");
            ans.Add("lion");
            ans.Add("heart");
            ans.Add("rose");
            ans.Add("daisy");
            ans.Add("plane");
            

            Name = FindViewById<TextView>(Resource.Id.txtName);
            
            
            Answr = FindViewById<TextView>(Resource.Id.txtAns);
            


            Hint = FindViewById<TextView>(Resource.Id.txtHint);

            Ques = FindViewById<TextView>(Resource.Id.txtQues);

            btn = FindViewById<Button>(Resource.Id.btnStore);

            btn.Click += (Object Sender, EventArgs ex) =>
            {
                if (Name.Text.ToString().Equals("")) {
                    Toast.MakeText(this, "Fill  the Name first ", ToastLength.Short).Show();
                }
                else {
                    clk++;    
                    no = rd.Next(1, 7);

                        Ques.Text = quesLst[no].ToString();

                    ln = ans[no].ToString().Length;
                    quesAns = ans[no].ToString();
                    Hint.Text = "Answer has " + ln + " Character";
                    Answr.Text = "";
                    for (int y=0;y<ln;y++) {
                        Answr.Text= Answr.Text.ToString()+"-";
                    }
                    btn.Enabled = false;

                   // Toast.MakeText(this, ""+Answr.Text.ToString()[0], ToastLength.Short).Show();
                }
                if (reply==1) {
                    StartActivity(typeof(Winner));
                    
                }
            };

           

            btnA = FindViewById<Button>(Resource.Id.btnA);
            btnA.Click += (Object Sender ,EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr ='a';
                    comp();
                    
                    btnA.Enabled = false;
                }
                else {
                   
                    Name.Text = Name.Text.ToString() + "a";
                }
            
               // 
            };
            btnB = FindViewById<Button>(Resource.Id.btnb);
            btnB.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'b';
                    comp();


                    

                    btnB.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "b";
                }

            };
            btnC = FindViewById<Button>(Resource.Id.btnc);
            btnC.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'c';
                    comp();


                    


                    btnC.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "c";
                }

            };

            btnD = FindViewById<Button>(Resource.Id.btnd);
            btnD.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'd';
                    comp();

                    
                    btnD.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "d";
                }

            };

            btnE = FindViewById<Button>(Resource.Id.btne);
            btnE.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'e';
                    comp();

                    
                    btnE.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "e";
                }

            };

            btnF = FindViewById<Button>(Resource.Id.btnf);
            btnF.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'f';
                    comp();

                    
                    btnF.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "f";
                }


            };
            btnG = FindViewById<Button>(Resource.Id.btng);
            btnG.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'g';
                    comp();


                    
                    btnG.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "g";
                }
            };

            btnH = FindViewById<Button>(Resource.Id.btnh);
            btnH.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;

                    chr = 'h';
                    comp();

                    
                    btnH.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "h";
                }
            };

            btnI = FindViewById<Button>(Resource.Id.btni);
            btnI.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'i';
                    comp();

                    
                    btnI.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "i";
                }
            };
            btnJ = FindViewById<Button>(Resource.Id.btnj);
            btnJ.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'j';
                    comp();

                    
                    btnJ.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "j";
                }
            };
            btnK = FindViewById<Button>(Resource.Id.btnk);
            btnK.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'k';
                    comp();

                    
                    btnK.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "k";
                }
            };
            btnL = FindViewById<Button>(Resource.Id.btnl);
            btnL.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'l';
                    comp();

                    
                    btnL.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "l";
                }
            };
            btnM = FindViewById<Button>(Resource.Id.btnm);
            btnM.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {

                    countClk++;
                    chr = 'm';
                    comp();

                    
                    btnM.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "m";
                }
            };
            btnN = FindViewById<Button>(Resource.Id.btnn);
            btnN.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'n';
                    comp();

                    
                    btnN.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "n";

                }
            };
            btnO = FindViewById<Button>(Resource.Id.btno);
            btnO.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'o';
                    comp();

                    
                    btnO.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "o";
                }
            };
            btnP = FindViewById<Button>(Resource.Id.btnp);
            btnP.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'p';
                    comp();

                    
                    btnP.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "p";
                }
            };
            btnQ = FindViewById<Button>(Resource.Id.btnq);
            btnQ.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'q';
                    comp();

                    
                    btnQ.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "q";
                }
            };
            btnR = FindViewById<Button>(Resource.Id.btnr);
            btnR.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'r';
                    comp();

                    
                    btnR.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "r";
                }
            };
            btnS = FindViewById<Button>(Resource.Id.btns);
            btnS.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 's';
                    comp();

                    
                    btnS.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "s";
                }
            };
            btnT = FindViewById<Button>(Resource.Id.btnt);
            btnT.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 't';
                    comp();

                    
                    btnT.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "t";
                }
            };
            btnU = FindViewById<Button>(Resource.Id.btnu);
            btnU.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    countClk++;
                    chr = 'u';

                    comp();

                    
                    btnU.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "u";
                }
            };
            btnV = FindViewById<Button>(Resource.Id.btnv);
            btnV.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {

                    chr = 'v';
                    countClk++;
                    comp();

                    
                    btnV.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "v";
                }
            };
            btnW = FindViewById<Button>(Resource.Id.btnw);
            btnW.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    chr = 'w';
                    


                    countClk++;
                    comp();
                    btnW.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "w";
                }
            };

            btnX = FindViewById<Button>(Resource.Id.btnx);
            btnX.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {

                    chr = 'x';
                    

                    countClk++;
                    comp();
                    btnX.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "x";
                }
            };
            btnY = FindViewById<Button>(Resource.Id.btny);
            btnY.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {

                    chr = 'y';
                    

                    countClk++;
                    comp();
                    btnY.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "y";
                }
            };
            btnZ = FindViewById<Button>(Resource.Id.btnz);
            btnZ.Click += (Object Sender, EventArgs ex) =>
            {
                if (clk > 0)
                {
                    chr = 'z';
                    

                    countClk++;
                    comp();
                    btnZ.Enabled = false;
                }
                else
                {
                    Name.Text = Name.Text.ToString() + "z";
                }
            };
        }

        public void comp()
        {
            // quesAns
            //Answr
            idx = -1;
            int x, y;
            dulpAns = "";
            //get the index of the answer with the alphabet i have pressed for the answer
            for (x = 0; x < quesAns.Length; x++)
            {
                if (chr.Equals(quesAns[x]))
                {
                    idx = x;
                    break;
                }
            }

            for (y = 0; y < Answr.Length(); y++)
            {
                if (idx == y)
                {
                    dulpAns = dulpAns + chr;
                }
                else
                {
                    dulpAns = dulpAns + Answr.Text.ToString()[y];
                }
            }

            if (idx == -1) {
                wrongCount++;
                result(wrongCount, quesAns.Length);   
            }

            
                Answr.Text = dulpAns;
            
            
            
            
                if (Answr.Text.ToString().Equals(quesAns) && countClk==quesAns.Length)
                {
                    btn.Text = "Won";
                    btn.Enabled = true;
                    reply = 1;
                    Toast.MakeText(this, "Congo you won the game ", ToastLength.Short).Show();
                
            }
                if (wrongCount==quesAns.Length) {
                    btn.Text = "loose";
                    btn.Enabled = true;
                    reply = 1;
                    Toast.MakeText(this, "Ooops you loose the game ", ToastLength.Short).Show();
                }
            

            

//result//
        }
        public void result(int y, int len)
        {
            if (len == 3)
            {
                if (y == 1)
                {
                 //   wrongCount++;
                    img.SetImageResource(Resource.Drawable.GuessFailed4);
                }
                else if (y == 2)
                {
                   // wrongCount++;
                    img.SetImageResource(Resource.Drawable.GuessFailed6);
                }
                else if (y == 3)
                {
                    //wrongCount++;
                    img.SetImageResource(Resource.Drawable.GuessFailed7);
                }


            }
            if (len == 4)
            {
                if (y == 1)
                {
                   // wrongCount++;
                    img.SetImageResource(Resource.Drawable.GuessFailed4);
                }
                else if (y == 2)
                {
                   // wrongCount++;
                    img.SetImageResource(Resource.Drawable.GuessFailed5);
                }
                else if (y == 3)
                {
                    //wrongCount++;
                    img.SetImageResource(Resource.Drawable.GuessFailed6);
                }
                else if (y == 4)
                {
                    //wrongCount++;
                    img.SetImageResource(Resource.Drawable.GuessFailed7);
                }


            }

            if (len == 5)
            {
                if (y == 1)
                {
                    //wrongCount++;
                    img.SetImageResource(Resource.Drawable.GuessFailed3);
                }
                else if (y == 2)
                {
                    //wrongCount++;
                    img.SetImageResource(Resource.Drawable.GuessFailed4);
                }
                else if (y == 3)
                {
                    //wrongCount++;
                    img.SetImageResource(Resource.Drawable.GuessFailed5);
                }
                else if (y == 4)
                {
                    //wrongCount++;
                    img.SetImageResource(Resource.Drawable.GuessFailed6);
                }
                else if (y == 5)
                {
                    //wrongCount++;
                    img.SetImageResource(Resource.Drawable.GuessFailed7);
                }

            }



        }



    }

}