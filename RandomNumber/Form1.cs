namespace RandomNumber
{
	public partial class Form1 : Form
	{
		int num;
		int cehdSayi = 0;
		public Form1()
		{
			InitializeComponent();
			button1.Enabled = false;
			textBox1.Enabled = false;
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				errorProvider1.SetError(textBox1, "Xana boş qala bilməz!");
				return;
			}

			int texmin = int.Parse(textBox1.Text);

			if (texmin > 100)
			{
				errorProvider1.SetError(textBox1, "100-dən böyük ədəd yazmaq olmaz!");
				return;
			}

			errorProvider1.Clear();
			listBox1.Items.Clear();
			cehdSayi++;

			if (texmin == num)
			{
				listBox1.Items.Add("Oyunu qazandınız");
				listBox1.Items.Add("Cəhd sayı: " + cehdSayi);
				button1.Enabled = false;
				textBox1.Enabled = false;
			}
			else
			{
				listBox1.Items.Add("Daxil edilən ədəd yanlışdır");

				if (texmin < num)
				{
					listBox1.Items.Add("Təsadüfi ədəddən kiçikdir");
				}
				else
				{
					listBox1.Items.Add("Təsadüfi ədəddən böyükdür");
				}

				listBox1.Items.Add("Cəhd sayı: " + cehdSayi);

				textBox1.Clear();
				textBox1.Focus();
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			num = r.Next(0, 101);
			cehdSayi = 0;

			button1.Enabled = true;
			textBox1.Enabled = true;

			listBox1.Items.Clear();
			textBox1.Clear();
			errorProvider1.Clear();

			textBox1.Focus();

		}
	}
}
