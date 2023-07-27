namespace SistemaMinimarket
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label8 = new Label();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(765, 223);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(292, 40);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(292, 99);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(187, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(34, 159);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(187, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(292, 159);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(187, 23);
            textBox6.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(34, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(705, 209);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(292, 141);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 9;
            label7.Text = "FECHA-NACIMIENTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 141);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 11;
            label6.Text = "TELEFONO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 81);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 10;
            label5.Text = "E-MAIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 19);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 9;
            label3.Text = "DIRECCION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 81);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 8;
            label2.Text = "APELLIDOS";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 19);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 7;
            label1.Text = "NOMBRES";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 9);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 8;
            label4.Text = "REGISTRO CLIENTES";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 501);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 9;
            button1.Text = "NUEVO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(173, 501);
            button2.Name = "button2";
            button2.Size = new Size(98, 38);
            button2.TabIndex = 10;
            button2.Text = "ELIMINAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(340, 501);
            button3.Name = "button3";
            button3.Size = new Size(98, 38);
            button3.TabIndex = 11;
            button3.Text = "MODIFICAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(523, 501);
            button4.Name = "button4";
            button4.Size = new Size(98, 38);
            button4.TabIndex = 12;
            button4.Text = "LIMPIAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(601, 128);
            button5.Name = "button5";
            button5.Size = new Size(98, 38);
            button5.TabIndex = 13;
            button5.Text = "BUSCAR";
            button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(512, 81);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 14;
            label8.Text = "APELLIDOS";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(512, 99);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(187, 23);
            textBox7.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 551);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox7;
        private Button button5;
        private Label label8;
    }
}