namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            weeksalad.Hide();
            weeksaladBox.Hide();
            howards.Hide();
            hourBox.Hide();
            waggs.Hide();
            wageBox.Hide();
            ewww.Hide();
            grosssaladBox.Hide();
            batman.Hide();
            gordonBox.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.BackColor = Color.LightGray;
            //radioButton2.Checked = false;
            radioButton2.BackColor = Color.Transparent;
            //radioButton3.Checked = false;
            radioButton3.BackColor = Color.Transparent;

            weeksalad.Show();
            weeksaladBox.Show();
            howards.Hide();
            hourBox.Hide();
            waggs.Hide();
            wageBox.Hide();
            ewww.Hide();
            grosssaladBox.Hide();
            batman.Hide();
            gordonBox.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.BackColor = Color.LightGray;
            //radioButton1.Checked = false;
            radioButton1.BackColor = Color.Transparent;
            //radioButton3.Checked = false;
            radioButton3.BackColor = Color.Transparent;

            weeksalad.Hide();
            weeksaladBox.Hide();
            howards.Show();
            hourBox.Show();
            waggs.Show();
            wageBox.Show();
            ewww.Hide();
            grosssaladBox.Hide();
            batman.Hide();
            gordonBox.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.BackColor = Color.LightGray;
            //radioButton1.Checked = false;
            radioButton1.BackColor = Color.Transparent;
            //radioButton2.Checked = false;
            radioButton2.BackColor = Color.Transparent;

            weeksalad.Hide();
            weeksaladBox.Hide();
            howards.Hide();
            hourBox.Hide();
            waggs.Hide();
            wageBox.Hide();
            ewww.Show();
            grosssaladBox.Show();
            batman.Show();
            gordonBox.Show();
        }

        private void submission_Click(object sender, EventArgs e)
        {
            if (fnameBox != null & lnameBox != null & ssnBox != null)
            {
                if (radioButton1.Checked)
                {
                    if (weeksaladBox != null)
                    {
                        SalaryEmployee worker1 = new SalaryEmployee(fnameBox.Text, lnameBox.Text, ssnBox.Text, Convert.ToDecimal(weeksaladBox.Text));
                        double weeklySalary = Convert.ToDouble(weeksaladBox.Text);
                        outputBox.Items.Add(worker1.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid weekly salary.");
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (hourBox != null & wageBox != null)
                    {
                        HourlyEmployee worker2 = new HourlyEmployee(fnameBox.Text, lnameBox.Text, ssnBox.Text, Convert.ToDecimal(wageBox.Text), Convert.ToInt32(hourBox.Text));
                        double hoursWorked = Convert.ToDouble(hourBox.Text);
                        double wage = Convert.ToDouble(wageBox.Text);
                        outputBox.Items.Add(worker2.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid hours worked and wage.");
                    }
                }
                else if (radioButton3.Checked)
                {
                    if (gordonBox != null & grosssaladBox != null)
                    {
                        CommissionEmployee worker3 = new CommissionEmployee(fnameBox.Text, lnameBox.Text, ssnBox.Text, Convert.ToDecimal(grosssaladBox.Text), Convert.ToDecimal(gordonBox.Text));
                        double grossSales = Convert.ToDouble(grosssaladBox.Text);
                        double commissionRate = Convert.ToDouble(gordonBox.Text);
                        outputBox.Items.Add(worker3.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid gross sales and commission rate.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the first and last name, the SSN, and select an employee type.");
                }
            }
        }
    }
}
