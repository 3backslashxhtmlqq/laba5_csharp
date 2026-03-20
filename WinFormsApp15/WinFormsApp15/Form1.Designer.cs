namespace WinFormsApp15;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        listBox1 = new System.Windows.Forms.ListBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(20, 28);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(118, 27);
        label1.TabIndex = 0;
        label1.Text = "Имя студента:";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(20, 76);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(118, 27);
        label2.TabIndex = 1;
        label2.Text = "Возраст:";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(129, 25);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(251, 27);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(93, 73);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(251, 27);
        textBox2.TabIndex = 3;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(446, 28);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(523, 384);
        listBox1.TabIndex = 4;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(22, 150);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(176, 41);
        button1.TabIndex = 5;
        button1.Text = "Готово";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(22, 257);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(232, 41);
        button2.TabIndex = 6;
        button2.Text = "Конструктор без параметров";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(22, 314);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(230, 41);
        button3.TabIndex = 7;
        button3.Text = "Конструктор с 1 параметром";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(22, 373);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(230, 41);
        button4.TabIndex = 8;
        button4.Text = "Конструктор с 2 параметрами";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1008, 450);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(listBox1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    #endregion
}