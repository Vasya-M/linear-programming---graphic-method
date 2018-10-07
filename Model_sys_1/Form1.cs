using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_sys_1
{
    
    public partial class Form1 : Form
    {
        int N=1,prevN=1;
        obm[] line1 = new obm[15];
        Equation[] lines = new Equation[15];
        List<point1> points = new List<point1>();
        double XX1, XX2;
        point1 minp = new point1(0,0,true), maxp = new point1(0, 0, true);

        public Form1()
        {
            InitializeComponent();
            setlines();
            drawp.Visible = false;
            vScrollBar1.Visible = false;
            hScrollBar1.Visible = false;
            trackBar1.Visible = false;
            this.Height = 454; 

        }
        private void setlines()
        {
            for(int i=0;i<15;i++)
            {
                line1[i] = new obm(i);
                lines[i] = new Equation();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void n_TextChanged(object sender, EventArgs e)
        {
            if (n.Text != "")
            {
                N = Convert.ToInt32(n.Text);
                if (N >= 0 && N<=15)
                {
                    int y = 0;
                    for (int i = 0; i < prevN; i++)
                    {
                        panel1.Controls.Remove (line1[i].x1);
                        panel1.Controls.Remove(line1[i].x2);
                        panel1.Controls.Remove(line1[i].zn);
                        panel1.Controls.Remove(line1[i].xb);
                    }
                    for (int i=0;i<N;i++,y++)
                    {
                        panel1.Controls.Add(line1[i].x1);
                        panel1.Controls.Add(line1[i].x2);
                        panel1.Controls.Add(line1[i].zn);
                        panel1.Controls.Add(line1[i].xb);
                    }
                    prevN = N;
                }
            }
         }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Dock the PictureBox to the form and set its background to white.
            // Connect the Paint event of the PictureBox to the event handler method. 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            point1 buf=new point1();
            double max = 0, min = 0;
            read_equation();
            XX1 = Convert.ToDouble(X1.Text);
            XX2 = Convert.ToDouble(X2.Text);
            result_text.Visible = true;
            result_text.Text = "";
            points.Clear();
            result_text.Text += "Tочки які не входять в ОДЗ:\n";
            for (int i = 0; i < N; i++)
            { 
                for (int q = i+1; q < N; q++)
                {
                    if (is_empty(lines[i]) || is_empty(lines[q])) // empty
                        continue;
                    if (lines[i].x1 * lines[q].x2 - lines[q].x1 * lines[i].x2 == 0)//   parallel ?
                        continue;
                    buf = Intersection(lines[i], lines[q]);

                    for (int w = 0; w < N; w++) //  inside ?
                    {
                        if (check_inside(buf, lines[w]))
                            buf.inside = true;
                        else
                        {
                            buf.inside = false;
                            result_text.Text += "(" + Math.Round(buf.x1,3) + "; " + Math.Round(buf.x2,3) + ") - перетин " + (i+1) + " і " + (q+1) + " обемеження\n";
                            break;
                        }
                    }
                    if (buf.inside)
                    {
                        buf.i = i;
                        buf.q = q;
                        points.Add(new point1(buf.x1,buf.x2,true));
                        if (Func(buf) > max)
                        {
                            max = Func(buf);
                            maxp.x1 = buf.x1;
                            maxp.x2 = buf.x2;
                            if (min == 0)
                                min = max;
                        }       
                            if (Func(buf) < min)
                            {
                                min = Func(buf);
                            minp.x1 = buf.x1;
                            minp.x2 = buf.x2;
                        }
                       
                     }     
                }
            }
            int ki = 0;
            result_text.Text += "\nTочки які  входять в ОДЗ:\n";
            for (int a = 0; a < 2; a++)
                for (int r=0;r<N;r++)
            { 
                    if(a==0)
                    {
                        buf.x1 = 0;
                        buf.x2 = lines[r].xb / lines[r].x2;
                    }
                    else
                    {
                        buf.x2 = 0;
                        buf.x1 = lines[r].xb / lines[r].x1;
                    }

                for (int w = 0; w < N; w++) //  inside ?
                {
                    if (check_inside(buf, lines[w]))
                        buf.inside = true;
                    else
                    {
                            buf.inside = false;
                            break;
                    }
                }
                if(buf.inside)
                    {
                        ki++;
                        points.Add(buf);
                        buf.inside = false; char aa; if (a == 0) aa = 'y'; else aa = 'x';

                        if (Func(buf) >= max)
                        {
                            max = Func(buf);
                            maxp.x1 = buf.x1;
                            maxp.x2 = buf.x2;
                            if (min == 0)
                                min = max;
                        }
                        if (Func(buf) <= min)
                        {
                            min = Func(buf);
                            minp.x1 = buf.x1;
                            minp.x2 = buf.x2;
                        }
                        result_text.Text += "(" + Math.Round(buf.x1,3) + "; " + Math.Round(buf.x2,3) + ") - перетин " + (r + 1) + " і " + aa + " обемеження, F";//+ ";  \n";
                        result_text.Text += "(" + Math.Round(buf.x1,3) + "; " + Math.Round(buf.x2,3) + ") = " + Math.Round(Func(buf), 3) + ";\n";
                    }

            }

            for(int t=0;t< points.Count-ki;t++)
            {
                result_text.Text += "(" + Math.Round(points[t].x1, 3) + "; " + Math.Round(points[t].x2, 3) + ") - перетин " + (points[t].i+1) + " і " + (points[t].q+1) + " обемеження, F";
                result_text.Text += "(" + Math.Round( points[t].x1,3) + "; " + Math.Round(points[t].x2,3) + ") = " + Math.Round(Func(points[t]), 3)+";\n";
            }
            result_text.Text += "\nТочки екстремуму функції:";
          result_text.Text += "\nMax (" + Math.Round(maxp.x1,3).ToString() + ";" + Math.Round(maxp.x2,3).ToString() + ") = " + Math.Round(max,3).ToString() +
                    ";\nMin (" + Math.Round(minp.x1,3).ToString() + "; " + Math.Round(minp.x2,3).ToString() + ") =" + Math.Round(min,3).ToString() + ";\n";
            if (min == Double.MaxValue && max == Double.MinValue)
                        MessageBox.Show("No solution. All posible points are ouside definition area!");
            else
                MessageBox.Show("max (" + maxp.x1.ToString() + ";" + maxp.x2.ToString() + ") = " + max.ToString() +
                    ";\nmin (" + minp.x1.ToString() + "; " + minp.x2.ToString() + ") =" + min.ToString() + ";\n");    
            drawpic.Invalidate();
            if (i++ == 0)
                drawpic.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
    

        }
        int i = 0; //  flag for redrawing
        private Font fnt = new Font("Arial", 10);
        int k = 5;// for zooming
        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(200, 0, 0, 0));
            Brush aBrush = (Brush)Brushes.LightGray;
            Graphics g = e.Graphics;
            int x0 = drawpic.Right    / 2, y0 = drawpic.Bottom   / 2;
            int xmax= drawpic.Right   , ymax = drawpic.Bottom   ;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // e.Graphics.ScaleTransform(1+(zoom)/15, 1+(zoom)/15);  // (1+(zoom)/15) // old zooming by scaling
            e.Graphics.TranslateTransform((hScrollBar1.Maximum/2-dx),(vScrollBar1.Maximum/2 - dy)/2); // new zooming by changing width of 1 
            e.Graphics.TranslateTransform(1 + (zoom)/10, 1 + (zoom)/10 );
            g.DrawLine(System.Drawing.Pens.Red, drawpic.Right   / 2, -500  , // draw y
              drawpic.Right   / 2,900  );
            g.DrawLine(System.Drawing.Pens.Red, -900 , drawpic.Bottom   / 2, // daw x
                1800 , drawpic.Bottom   / 2);  
            for (int i = 1; i < ymax; i++)
            {
                point1 buf=new point1();
                for (int x = 0; x <= xmax;x++)
                {                   
                    for (int w = 0; w < N; w++) //  inside ?
                    {
                        buf.x1 = x;
                        buf.x2 = i;
                        if (check_inside(buf, lines[w],1))
                            buf.inside = true;
                        else
                        {
                            buf.inside = false;
                            break;
                        }
                    }
                    if(buf.inside)
                     g.FillRectangle(aBrush, (float)buf.x1   + x0, (-(float)buf.x2)  + y0, 1, 1);
                }
            }
            for (int i = 0; i < N; i++)
            {
                int x = -x0, y = getposy(x, lines[i]);
                int xe = xmax, ye = getposy(xe, lines[i]);
                g.DrawLine(pen, x0 + x * (1 + (zoom) / k), y0 + y * (1 + (zoom) / k), x0 + xe * (1 + (zoom) / k), y0 + ye * (1 + (zoom) / k));
            }
            Font drawFont = new Font("Arial", 5);
            aBrush = (Brush)Brushes.Green;
            pen.Color = Color.Green;
            pen.Width = 1;
             g.DrawLine(pen, x0  , y0  , x0 + (float)XX1 * (1 + (zoom) / k), y0 -(float)XX2 * (1 + (zoom) / k));
        }
        float zoom = 1;
        int getposy(int x, Equation line)
        { 
            double res2;
            if (line.x1 == 0)
                return -(int)line.xb;
            if (line.x2 != 0)
                res2 = line.xb / -line.x2 + ((-line.x1) * x) / -line.x2;
            else return 0;
            return (int)res2;
        }
        private double Func(point1 buf)
        {
            return buf.x1 * XX1 + buf.x2 * XX2;
        }
        private bool check_inside(point1 buf, Equation eq, int b=0)
        {
            float kkk = kk;
            if (b == 0)
                kkk = 1;
            double res = buf.x1 * eq.x1 + buf.x2 * eq.x2 ;
            if (buf.x1 < 0 || buf.x2 < 0)
                return false;
            if (Sign.less == eq.zn)
                if (res <= eq.xb*kkk )
                    return true;
            if (Sign.more == eq.zn )
                if (res >= eq.xb*kkk )
                    return true;
            return false;
        }
        private point1 Intersection(Equation obj1, Equation obj2)
        {
            point1 ret= new point1();
            double A1, A2, B1, B2, C1, C2;
            A1 = obj1.x1; B1 = obj1.x2; C1 = -obj1.xb;
            A2 = obj2.x1; B2 = obj2.x2; C2 = -obj2.xb;
            ret.x1=(-((C1 * B2 - C2 * B1) / (A1 * B2 - A2 * B1)));
            ret.x2=(-((A1 * C2 - A2 * C1) / (A1 * B2 - A2 * B1)));
            return ret;

        }
        private bool is_empty(Equation a)
        {
            if (a.x1 == 0 && a.x2 == 0)
                return true;
            else
            return false;
        }
        private void read_equation()
        {
            if (n.Text != "")
            {
                if (N >= 0 && N <= 15)
                {
               
                    for (int i = 0; i < N; i++ )
                    {
                        int myInt;
                        bool isNumerical;
                        if (isNumerical = int.TryParse(line1[i].x1.Text, out myInt)) //
                            lines[i].x1 = Convert.ToDouble(line1[i].x1.Text);
                        else
                            lines[i].x1 = 1;

                        if (isNumerical = int.TryParse(line1[i].x1.Text, out myInt)) //
                            lines[i].x2 = Convert.ToDouble(line1[i].x2.Text);
                        else
                            lines[i].x2 = 1;
                        if (isNumerical = int.TryParse(line1[i].x1.Text, out myInt)) //
                            lines[i].xb = Convert.ToDouble(line1[i].xb.Text);
                        else
                               lines[i].xb = 1;
                        if (line1[i].zn.Text[0] == '>')
                            lines[i].zn = Sign.more;
                        else
                        {
                            if (line1[i].zn.Text[0] == '<')
                                lines[i].zn = Sign.less;
                        }
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {   
        }

        private void result_text_Click(object sender, EventArgs e)
        {
        }

        private void picture_Click(object sender, EventArgs e)
        {  
        }

        private void drawpic_Click(object sender, EventArgs e)
        {
        }

        private void drawp_Paint(object sender, PaintEventArgs e)
        {
        }

        float kk = 1;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            zoom = trackBar1.Value;
            kk=(1 + (zoom) / k);
            drawpic.Invalidate();
        }
        float dy = 600, dx=600; // for scroling plot

        void reset()
        {
            hScrollBar1.Value = 600;
            vScrollBar1.Value = 600;
            trackBar1.Value = 0;

        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            dx = hScrollBar1.Value;
            drawpic.Invalidate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                this.Height = 775;
                drawp.Visible = true;
                vScrollBar1.Visible = true;
                hScrollBar1.Visible= true;
                trackBar1.Visible = true;
            }else
            {
                this.Height = 454;
                drawp.Visible = false;
                vScrollBar1.Visible = false;
                hScrollBar1.Visible = false;
                trackBar1.Visible = false;
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            dy = vScrollBar1.Value;// (1+zoom);
            drawpic.Invalidate();
        }



        public enum Sign  { less, more };
        public class Equation
        {
            public Sign  zn;
            public double x1, x2, xb;
            public Equation()
            { }
            public Equation(Sign  sign, double x1, double x2, double res)
            {
                this.zn = sign;
                this.x1 = x1;
                this.x2 = x2;
                this.xb = res;
            }
        }
        public class point1
        {
            public  double x1, x2;
            public int i, q;
            public bool inside;
            public point1()
            {
                i = q = 0;
                x1 = x2 = 0;
                inside = false;
            }
            public point1(double xx1,double xx2, bool ins)
            {
                i = q = 0;
                x1 = xx1;
                x2 = xx2;
                inside = ins;
            }
        }
    }

    class obm    
    {
        public TextBox x1 = new TextBox();
        public TextBox x2 = new TextBox();
        public TextBox xb = new TextBox();
        public ComboBox zn = new ComboBox();
        public obm(int y)
        {
            this.Set(y);
        }
        public void Set(int y )
        {

            zn.Items.AddRange(new object[] {
            ">=",
            "<="});
            zn.Size = new System.Drawing.Size(40, 21);
            x1.Width = 40;
            x2.Width = 40;
            xb.Width = 40;
        
            x1.Location = new Point(1 * 40, y * 20);
            x2.Location = new Point(2 * 40, y * 20);
            zn.Location = new Point(3 * 40, y * 20);
            xb.Location = new Point(4 * 40 , y * 20);
            x1.Text = "0";
            x2.Text = "0";
            xb.Text = "0";
            zn.Text = ">=";
        }
 
    }
}
