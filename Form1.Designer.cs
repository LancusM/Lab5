namespace Lab5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            fnameBox = new TextBox();
            shadow = new Label();
            hedgehog = new Label();
            lnameBox = new TextBox();
            bbc = new Label();
            ssnBox = new TextBox();
            radioButton1 = new RadioButton();
            label4 = new Label();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            weeksalad = new Label();
            weeksaladBox = new TextBox();
            howards = new Label();
            hourBox = new TextBox();
            batman = new Label();
            gordonBox = new TextBox();
            waggs = new Label();
            wageBox = new TextBox();
            ewww = new Label();
            grosssaladBox = new TextBox();
            submission = new Button();
            outputBox = new ListBox();
            chooseFile = new Button();
            pathDis = new Label();
            savvy = new Button();
            lode = new Button();
            X = new Button();
            fullOutBox = new ListBox();
            outgoingBox = new ListBox();
            SuspendLayout();
            // 
            // fnameBox
            // 
            fnameBox.Location = new Point(85, 100);
            fnameBox.Name = "fnameBox";
            fnameBox.Size = new Size(100, 23);
            fnameBox.TabIndex = 0;
            // 
            // shadow
            // 
            shadow.AutoSize = true;
            shadow.Location = new Point(85, 80);
            shadow.Name = "shadow";
            shadow.Size = new Size(122, 15);
            shadow.TabIndex = 1;
            shadow.Text = "Employee First Name:";
            // 
            // hedgehog
            // 
            hedgehog.AutoSize = true;
            hedgehog.Location = new Point(85, 130);
            hedgehog.Name = "hedgehog";
            hedgehog.Size = new Size(121, 15);
            hedgehog.TabIndex = 3;
            hedgehog.Text = "Employee Last Name:";
            // 
            // lnameBox
            // 
            lnameBox.Location = new Point(85, 150);
            lnameBox.Name = "lnameBox";
            lnameBox.Size = new Size(100, 23);
            lnameBox.TabIndex = 2;
            // 
            // bbc
            // 
            bbc.AutoSize = true;
            bbc.Location = new Point(85, 180);
            bbc.Name = "bbc";
            bbc.Size = new Size(86, 15);
            bbc.TabIndex = 5;
            bbc.Text = "Employee SSN:";
            // 
            // ssnBox
            // 
            ssnBox.Location = new Point(85, 200);
            ssnBox.Name = "ssnBox";
            ssnBox.Size = new Size(100, 23);
            ssnBox.TabIndex = 4;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(335, 80);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(121, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Salaried Employee";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 60);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 7;
            label4.Text = "Type of Employee:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(335, 100);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(116, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hourly Employee";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(335, 120);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(147, 19);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Commission Employee";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // weeksalad
            // 
            weeksalad.AutoSize = true;
            weeksalad.Location = new Point(85, 230);
            weeksalad.Name = "weeksalad";
            weeksalad.Size = new Size(137, 15);
            weeksalad.TabIndex = 11;
            weeksalad.Text = "Employee Weekly Salary:";
            // 
            // weeksaladBox
            // 
            weeksaladBox.Location = new Point(85, 250);
            weeksaladBox.Name = "weeksaladBox";
            weeksaladBox.Size = new Size(100, 23);
            weeksaladBox.TabIndex = 10;
            // 
            // howards
            // 
            howards.AutoSize = true;
            howards.Location = new Point(85, 280);
            howards.Name = "howards";
            howards.Size = new Size(97, 15);
            howards.TabIndex = 13;
            howards.Text = "Employee Hours:";
            // 
            // hourBox
            // 
            hourBox.Location = new Point(85, 300);
            hourBox.Name = "hourBox";
            hourBox.Size = new Size(100, 23);
            hourBox.TabIndex = 12;
            // 
            // batman
            // 
            batman.AutoSize = true;
            batman.Location = new Point(85, 280);
            batman.Name = "batman";
            batman.Size = new Size(158, 15);
            batman.TabIndex = 17;
            batman.Text = "Employee Commission Rate:";
            // 
            // gordonBox
            // 
            gordonBox.Location = new Point(85, 300);
            gordonBox.Name = "gordonBox";
            gordonBox.Size = new Size(100, 23);
            gordonBox.TabIndex = 16;
            // 
            // waggs
            // 
            waggs.AutoSize = true;
            waggs.Location = new Point(85, 230);
            waggs.Name = "waggs";
            waggs.Size = new Size(100, 15);
            waggs.TabIndex = 15;
            waggs.Text = "Employee Wages:";
            // 
            // wageBox
            // 
            wageBox.Location = new Point(85, 250);
            wageBox.Name = "wageBox";
            wageBox.Size = new Size(100, 23);
            wageBox.TabIndex = 14;
            // 
            // ewww
            // 
            ewww.AutoSize = true;
            ewww.Location = new Point(85, 230);
            ewww.Name = "ewww";
            ewww.Size = new Size(123, 15);
            ewww.TabIndex = 19;
            ewww.Text = "Employee Gross Sales:";
            // 
            // grosssaladBox
            // 
            grosssaladBox.Location = new Point(85, 250);
            grosssaladBox.Name = "grosssaladBox";
            grosssaladBox.Size = new Size(100, 23);
            grosssaladBox.TabIndex = 18;
            // 
            // submission
            // 
            submission.Location = new Point(85, 350);
            submission.Name = "submission";
            submission.Size = new Size(75, 23);
            submission.TabIndex = 20;
            submission.Text = "Submit";
            submission.UseVisualStyleBackColor = true;
            submission.Click += submission_Click;
            // 
            // outputBox
            // 
            outputBox.FormattingEnabled = true;
            outputBox.HorizontalScrollbar = true;
            outputBox.ItemHeight = 15;
            outputBox.Location = new Point(330, 180);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(260, 214);
            outputBox.TabIndex = 21;
            // 
            // chooseFile
            // 
            chooseFile.Location = new Point(550, 50);
            chooseFile.Name = "chooseFile";
            chooseFile.Size = new Size(90, 25);
            chooseFile.TabIndex = 22;
            chooseFile.Text = "Choose File...";
            chooseFile.UseVisualStyleBackColor = true;
            chooseFile.Click += chooseFile_Click;
            // 
            // pathDis
            // 
            pathDis.AutoSize = true;
            pathDis.Location = new Point(550, 80);
            pathDis.Name = "pathDis";
            pathDis.Size = new Size(0, 15);
            pathDis.TabIndex = 23;
            // 
            // savvy
            // 
            savvy.Location = new Point(605, 120);
            savvy.Name = "savvy";
            savvy.Size = new Size(40, 25);
            savvy.TabIndex = 25;
            savvy.Text = "Save";
            savvy.UseVisualStyleBackColor = true;
            savvy.Click += savvy_Click;
            // 
            // lode
            // 
            lode.Location = new Point(550, 120);
            lode.Name = "lode";
            lode.Size = new Size(45, 25);
            lode.TabIndex = 27;
            lode.Text = "Load";
            lode.UseVisualStyleBackColor = true;
            lode.Click += lode_Click;
            // 
            // X
            // 
            X.Image = (Image)resources.GetObject("X.Image");
            X.Location = new Point(738, 12);
            X.Name = "X";
            X.Size = new Size(50, 50);
            X.TabIndex = 28;
            X.UseVisualStyleBackColor = true;
            X.Click += X_Click;
            // 
            // fullOutBox
            // 
            fullOutBox.FormattingEnabled = true;
            fullOutBox.HorizontalScrollbar = true;
            fullOutBox.ItemHeight = 15;
            fullOutBox.Location = new Point(605, 180);
            fullOutBox.Name = "fullOutBox";
            fullOutBox.Size = new Size(180, 184);
            fullOutBox.TabIndex = 29;
            // 
            // outgoingBox
            // 
            outgoingBox.FormattingEnabled = true;
            outgoingBox.HorizontalScrollbar = true;
            outgoingBox.ItemHeight = 15;
            outgoingBox.Location = new Point(605, 360);
            outgoingBox.Name = "outgoingBox";
            outgoingBox.Size = new Size(180, 34);
            outgoingBox.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outgoingBox);
            Controls.Add(fullOutBox);
            Controls.Add(X);
            Controls.Add(lode);
            Controls.Add(savvy);
            Controls.Add(pathDis);
            Controls.Add(chooseFile);
            Controls.Add(outputBox);
            Controls.Add(submission);
            Controls.Add(ewww);
            Controls.Add(grosssaladBox);
            Controls.Add(batman);
            Controls.Add(gordonBox);
            Controls.Add(waggs);
            Controls.Add(wageBox);
            Controls.Add(howards);
            Controls.Add(hourBox);
            Controls.Add(weeksalad);
            Controls.Add(weeksaladBox);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(label4);
            Controls.Add(radioButton1);
            Controls.Add(bbc);
            Controls.Add(ssnBox);
            Controls.Add(hedgehog);
            Controls.Add(lnameBox);
            Controls.Add(shadow);
            Controls.Add(fnameBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fnameBox;
        private Label shadow;
        private Label hedgehog;
        private TextBox lnameBox;
        private Label bbc;
        private TextBox ssnBox;
        private RadioButton radioButton1;
        private Label label4;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label weeksalad;
        private TextBox weeksaladBox;
        private Label howards;
        private TextBox hourBox;
        private Label batman;
        private TextBox gordonBox;
        private Label waggs;
        private TextBox wageBox;
        private Label ewww;
        private TextBox grosssaladBox;
        private Button submission;
        private ListBox outputBox;
        private Button chooseFile;
        private Label pathDis;
        private Button savvy;
        private Button deli;
        private Button lode;
        private Button X;
        private ListBox fullOutBox;
        private ListBox outgoingBox;
    }
}
