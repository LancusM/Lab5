namespace Lab5
{
    public partial class Form1 : Form
    {
        StreamWriter fileWriter;
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

            //

            fnameBox.Enabled = false;
            lnameBox.Enabled = false;
            ssnBox.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            submission.Enabled = false;

            //


            savvy.Enabled = false;
            savvy.Hide();

            lode.Enabled = false;
            lode.Hide();
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
                string firstName = fnameBox.Text;
                string lastName = lnameBox.Text;
                string SSN = ssnBox.Text;
                string weekSalary = weeksaladBox.Text;
                string mage = wageBox.Text;
                string hour = hourBox.Text;
                string gross = grosssaladBox.Text;
                string commission = gordonBox.Text;

                if (radioButton1.Checked)
                {
                    if (weeksaladBox != null)
                    {
                        //ADD VALIDATION SO I WON'T CRASH WHEN NON-NUMBERS ARE INPUT
                        SalaryEmployee worker1 = new SalaryEmployee(fnameBox.Text, lnameBox.Text, ssnBox.Text, Convert.ToDecimal(weeksaladBox.Text));
                        double weeklySalary = Convert.ToDouble(weeksaladBox.Text);
                        outputBox.Items.Add(worker1.ToString());
                        fileWriter.WriteLine("Salary Employee/" + firstName + "/" + lastName + "/" + SSN + "/" + weekSalary);
                        fnameBox.Text = "";
                        lnameBox.Text = "";
                        ssnBox.Text = "";
                        weeksaladBox.Text = "";
                        fnameBox.Focus();
                        savvy.Enabled = true;
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
                        fileWriter.WriteLine("Hourly Employee/" + firstName + "/" + lastName + "/" + SSN + "/" + mage + "/" + hour);
                        fnameBox.Text = "";
                        lnameBox.Text = "";
                        ssnBox.Text = "";
                        wageBox.Text = "";
                        hourBox.Text = "";
                        fnameBox.Focus();
                        savvy.Enabled = true;
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
                        fileWriter.WriteLine("Commission Employee/" + firstName + "/" + lastName + "/" + SSN + "/" + gross + "/" + commission);
                        fnameBox.Text = "";
                        lnameBox.Text = "";
                        ssnBox.Text = "";
                        grosssaladBox.Text = "";
                        gordonBox.Text = "";
                        fnameBox.Focus();
                        savvy.Enabled = true;
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

        private void chooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string ileName;

            var ileChose = new SaveFileDialog();

            ileChose.CheckFileExists = false;
            result = ileChose.ShowDialog();
            ileName = ileChose.FileName;

            pathDis.Text = ileName;

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(ileName))
                {
                    MessageBox.Show("Invalid File Name or Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        FileStream stream = new FileStream(ileName, FileMode.Append, FileAccess.Write);
                        fileWriter = new StreamWriter(stream);


                        //savvy.Enabled = true;
                        savvy.Show();
                        lode.Enabled = true;
                        lode.Show();

                        chooseFile.Enabled = false;

                        radioButton1.Enabled = true;
                        radioButton2.Enabled = true;
                        radioButton3.Enabled = true;

                        fnameBox.Enabled = true;
                        lnameBox.Enabled = true;
                        ssnBox.Enabled = true;

                        submission.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening chosen file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fileWriter.Close();

                        savvy.Enabled = false;

                        chooseFile.Enabled = true;

                        radioButton1.Enabled = false;
                        radioButton2.Enabled = false;
                        radioButton3.Enabled = false;

                        fnameBox.Enabled = false;
                        lnameBox.Enabled = false;
                        ssnBox.Enabled = false;

                        submission.Enabled = false;
                    }
                }
            }
        }

        private void savvy_Click(object sender, EventArgs e)
        {
            try
            {
                fileWriter.Close();
                chooseFile.Enabled = true;
                savvy.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error saving file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lode_Click(object sender, EventArgs e)
        {
            string bilePath = pathDis.Text;
            outputBox.Items.Clear();
            fileWriter.Close();

            try
            {
                StreamReader reader = new StreamReader(bilePath);
                string currentLine;
                //MessageBox.Show("HA");
                while ((currentLine = reader.ReadLine()) != null)
                {
                    int indexOfSlash = currentLine.IndexOf('/');
                    string output = currentLine.Substring(0, indexOfSlash);
                    int lastSlash = indexOfSlash;
                    outputBox.Items.Add(currentLine);
                    fullOutBox.Items.Add(output);

                    currentLine = currentLine.Substring(indexOfSlash + 1);
                    //MessageBox.Show("IM ALIVE");
                    //print out to fullOutBox: employee name, type, and amount, per employee
                    //then total outgoing pay for all employees in outgoingBox
                    //string detailOutput = 

                    /*
                    while ((indexOfSlash = currentLine.Substring(lastSlash + 1).IndexOf("/")) != -1)
                    {
                        
                        output = currentLine.Substring(lastSlash + 1,indexOfSlash);
                        fullOutBox.Items.Add(output);
                        lastSlash = indexOfSlash;
                        MessageBox.Show("alive");
                        
                        
                        
                    }
                    */

                    while ((indexOfSlash = currentLine.IndexOf("/")) != -1)
                    {

                        output = currentLine.Substring(0, indexOfSlash);
                        fullOutBox.Items.Add(output);
                        MessageBox.Show("alive");
                        currentLine = currentLine.Substring(indexOfSlash + 1);
                    }

                    fullOutBox.Items.Add(currentLine);

                }
                reader.Close();

                submission.Enabled = false;
                chooseFile.Enabled = true;
                savvy.Enabled = false;
                lode.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Cannot read file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
