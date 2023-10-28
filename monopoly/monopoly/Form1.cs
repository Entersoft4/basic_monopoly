namespace monopoly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s1, s2;
        int toplam = 0;
        int sayac = 1;

        private void b1_Click(object sender, EventArgs e)
        {
            Random zar = new Random();
            s1 = zar.Next(1, 7);
            s2 = zar.Next(1, 7);
            l2.Text = "= " + s1;
            l3.Text = "= " + s2;
            toplam = s1 + s2;
            if ((sayac % 2) == 1)
            {

            }
            else
            {

            }
        }
    }
}