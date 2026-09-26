namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)

        {
            try
            {
                int num1 = int.Parse(txtnumber1.Text);
                int num2 = int.Parse(txtnumber2.Text);
                int result = num1 + num2;
                lblResult.Text = " Резултат: " + result.ToString();
            }
            catch (FormatException)
            {
                // Грешка при преобразуване на текст към число
                MessageBox.Show("Моля, въведете валидни цели числа! Грешка " + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Обща грешка
                MessageBox.Show("Възникна неочаквана грешка:\n" + ex.Message + "Грешка" + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtnumber1.Text);
                int num2 = int.Parse(txtnumber2.Text);
                int result = num1 - num2;
                lblResult.Text = " Резултат: " + result.ToString();
            }
            catch (FormatException)
            {
                // Грешка при преобразуване на текст към число
                MessageBox.Show("Моля, въведете валидни цели числа! Грешка " + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Обща грешка
                MessageBox.Show("Възникна неочаквана грешка:\n" + ex.Message + "Грешка" + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtnumber1.Text);
                int num2 = int.Parse(txtnumber2.Text);
                int result = num1 / num2;
                lblResult.Text = " Резултат: " + result.ToString();
            }
            catch (FormatException)
            {
                // Грешка при преобразуване на текст към число
                MessageBox.Show("Моля, въведете валидни цели числа! Грешка " + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Обща грешка
                MessageBox.Show("Възникна неочаквана грешка:\n" + ex.Message + "Грешка" + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void btnpo_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtnumber1.Text);
                int num2 = int.Parse(txtnumber2.Text);
                int result = num1 * num2;
                lblResult.Text = " Резултат: " + result.ToString();
            }
            catch (FormatException)
            {
                // Грешка при преобразуване на текст към число
                MessageBox.Show("Моля, въведете валидни цели числа! Грешка " + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Обща грешка
                MessageBox.Show("Възникна неочаквана грешка:\n" + ex.Message + "Грешка" + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngreating_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            lblgreatings.Text = "Greatings " + name + '!';
            if(name ==string.Empty)
            {
                MessageBox.Show("Възникна грешка:\n Vuvedete ime" + MessageBoxButtons.OKCancel);
            }
           
        }
    }
}
