using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.DataViz.WinForms;
namespace Nomre_Re
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //*********int
            int math_value = 0, arabic_value = 0;
            int avrage_math = 0, avrage_arabic = 0;
            //********nomarat
            int[] math_list = { 19, 20, 19, 20, 19 };
            List<int> arabic_list = new List<int>();
            arabic_list.Add(15);
            arabic_list.Add(19);
            arabic_list.Add(18);
            arabic_list.Add(20);
            arabic_list.Add(20);
            //************foreach
            foreach (var math_fe in math_list)
            {
                math_value = math_value + math_fe;
            }
            foreach (var arabic_fe in arabic_list)
            {
                arabic_value = arabic_value + arabic_fe;
            }
            avrage_math = math_value / math_list.Count();
            avrage_arabic = arabic_value / arabic_list.Count;
            //****************data point
            DataPoint p1 = new DataPoint(BunifuDataViz._type.Bunifu_column);
            p1.addLabely($"Math{avrage_math}", avrage_math);
            p1.addLabely($"Arabic{avrage_arabic}", avrage_arabic);
            //************canvas
            Canvas canvas1 = new Canvas();
            canvas1.addData(p1);
            //dataviz
            bunifuDataViz1.Render(canvas1);

        }


    }
}
