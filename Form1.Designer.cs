namespace Moon_Base
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
            groupBox1 = new GroupBox();
            button_South = new Button();
            button_East = new Button();
            button_West = new Button();
            button_North = new Button();
            label_Navigation = new Label();
            textBox_Population = new TextBox();
            label_Population = new Label();
            textBox_Description = new TextBox();
            label_Location_Name = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_South);
            groupBox1.Controls.Add(button_East);
            groupBox1.Controls.Add(button_West);
            groupBox1.Controls.Add(button_North);
            groupBox1.Controls.Add(label_Navigation);
            groupBox1.Controls.Add(textBox_Population);
            groupBox1.Controls.Add(label_Population);
            groupBox1.Controls.Add(textBox_Description);
            groupBox1.Controls.Add(label_Location_Name);
            groupBox1.Location = new Point(685, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 250);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Location Information";
            // 
            // button_South
            // 
            button_South.Location = new Point(244, 205);
            button_South.Name = "button_South";
            button_South.Size = new Size(75, 23);
            button_South.TabIndex = 8;
            button_South.Text = "South";
            button_South.UseVisualStyleBackColor = true;
            button_South.Click += button_South_Click;
            // 
            // button_East
            // 
            button_East.Location = new Point(317, 176);
            button_East.Name = "button_East";
            button_East.Size = new Size(75, 23);
            button_East.TabIndex = 7;
            button_East.Text = "East";
            button_East.UseVisualStyleBackColor = true;
            button_East.Click += button_East_Click;
            // 
            // button_West
            // 
            button_West.Location = new Point(170, 176);
            button_West.Name = "button_West";
            button_West.Size = new Size(75, 23);
            button_West.TabIndex = 6;
            button_West.Text = "West";
            button_West.UseVisualStyleBackColor = true;
            button_West.Click += button_West_Click;
            // 
            // button_North
            // 
            button_North.Location = new Point(244, 147);
            button_North.Name = "button_North";
            button_North.Size = new Size(75, 23);
            button_North.TabIndex = 5;
            button_North.Text = "North";
            button_North.UseVisualStyleBackColor = true;
            button_North.Click += button_North_Click;
            // 
            // label_Navigation
            // 
            label_Navigation.AutoSize = true;
            label_Navigation.Location = new Point(244, 112);
            label_Navigation.Name = "label_Navigation";
            label_Navigation.Size = new Size(65, 15);
            label_Navigation.TabIndex = 4;
            label_Navigation.Text = "Navigation";
            // 
            // textBox_Population
            // 
            textBox_Population.Location = new Point(6, 148);
            textBox_Population.Name = "textBox_Population";
            textBox_Population.Size = new Size(100, 23);
            textBox_Population.TabIndex = 3;
            textBox_Population.Text = "3,023";
            // 
            // label_Population
            // 
            label_Population.AutoSize = true;
            label_Population.Location = new Point(6, 130);
            label_Population.Name = "label_Population";
            label_Population.Size = new Size(68, 15);
            label_Population.TabIndex = 2;
            label_Population.Text = "Population:";
            // 
            // textBox_Description
            // 
            textBox_Description.Location = new Point(6, 37);
            textBox_Description.Multiline = true;
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(446, 61);
            textBox_Description.TabIndex = 1;
            textBox_Description.Text = "In the year 9999, the human race established a Moonbase in the 19th district of the Cutashi Astroid belt.";
            // 
            // label_Location_Name
            // 
            label_Location_Name.AutoSize = true;
            label_Location_Name.Location = new Point(6, 19);
            label_Location_Name.Name = "label_Location_Name";
            label_Location_Name.Size = new Size(78, 15);
            label_Location_Name.TabIndex = 0;
            label_Location_Name.Text = "Headquarters";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HQBase;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1156, 630);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Moon_Base";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_Description;
        private Label label_Location_Name;
        private Label label_Population;
        private Button button_West;
        private Button button_North;
        private Label label_Navigation;
        private TextBox textBox_Population;
        private Button button_South;
        private Button button_East;
    }
}
