namespace foreach_döngüsü___Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] sayilar = { 13, 16, 24, 46, 40, 64, 81, 124, 62, 8 };

            foreach (int i in sayilar)
            {
                if (i % 4 == 0)
                {
                    listBox1.Items.Add(i);
                    toplam = toplam + i;
                    
                }

            }
            label2.Text = toplam.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label2.Text = string.Empty;
        }
    }
}