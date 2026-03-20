namespace WinFormsApp18;

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
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(24, 23);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(83, 26);
        label1.TabIndex = 0;
        label1.Text = "X:";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(24, 64);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(83, 26);
        label2.TabIndex = 1;
        label2.Text = "Y:";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(51, 20);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(229, 27);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(51, 61);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(229, 27);
        textBox2.TabIndex = 3;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(418, 20);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(336, 284);
        listBox1.TabIndex = 4;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(24, 130);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(126, 41);
        button1.TabIndex = 5;
        button1.Text = "Вывод";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(24, 247);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(272, 41);
        button2.TabIndex = 6;
        button2.Text = "Вывод точки с двумя переменными";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(24, 315);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(272, 41);
        button3.TabIndex = 7;
        button3.Text = "Вывод точки с одной переменной";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
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

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;

    #endregion
}