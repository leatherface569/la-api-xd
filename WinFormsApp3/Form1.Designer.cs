namespace WinFormsApp3
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
            btnTodos = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(31, 56);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(164, 29);
            btnTodos.TabIndex = 0;
            btnTodos.Text = "ObtenProductos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // button1
            // 
            button1.Location = new Point(218, 56);
            button1.Name = "button1";
            button1.Size = new Size(266, 29);
            button1.TabIndex = 1;
            button1.Text = "Obten Producto por Id";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(552, 54);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Envia Post";
            button2.UseVisualStyleBackColor = true;
       
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnTodos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTodos;
        private Button button1;
        private Button button2;
    }
}
