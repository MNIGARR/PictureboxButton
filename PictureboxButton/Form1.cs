namespace PictureboxButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_london_Click(object sender, EventArgs e)
        {
            if(pictureofBaku.Visible == true)
            {
                pictureofLondon1.Visible = true;
                pictureofBaku.Visible = false;
            }
        }

        private void button_baku_Click(object sender, EventArgs e)
        {
            pictureofBaku.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var ukTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            DateTime ukTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, ukTimeZone);
            label1.Text = Convert.ToString(ukTime);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Baku_date_time_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            Baku_date_time.Text = Convert.ToString(date);
        }
    }
}