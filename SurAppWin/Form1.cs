using ZXYWll0338;

namespace SurAppWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBoxBna.Text = 1.ToString();
            textBoxBX.Text = 1.ToString();
            textBoxBY.Text = 1.ToString();
            textBoxEn.Text = 2.ToString();
            textBoxEX.Text = 2.ToString();
            textBoxEY.Text = 2.ToString();
        }
        /// <summary>
        ///计算按钮的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cal_Click(object sender, EventArgs e)
        {
            double bX = double.Parse(textBoxBX.Text);
            //double bX = Convert.ToDouble(textBoxBX.Text);
            double bY = double.Parse(textBoxBY.Text);
            double eX = double.Parse(textBoxEX.Text);
            double eY = double.Parse(textBoxEY.Text);

            var ad = SurMath.Azimuth(bX, eX, bY, eY);

            textBox_A.Text = SurMath.RadianToString(ad.a);
            textBox_Dist.Text = ad.d.ToString();
            label_AZ.Text = $"{textBoxBna.Text}-->{textBoxEn.Text}的坐标方位角为：";

        }

        /// <summary>
        /// 实现起点和终点的交换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_change_Click(object sender, EventArgs e)
        {
            string tn=textBoxBna.Text;
            textBoxBna.Text=textBoxEn.Text;
            textBoxEn.Text=tn;

            tn=textBoxBX.Text;
            textBoxBX.Text=textBoxEX.Text;
            textBoxEX.Text=tn;

            tn=textBoxBY.Text;
            textBoxBY.Text=textBoxEY.Text;
            textBoxEY.Text=tn;
        }
    }
}
