namespace P4_1_714220044
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
            label1 = new Label();
            vbButton = new Button();
            csButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 40);
            label1.Name = "label1";
            label1.Size = new Size(438, 25);
            label1.TabIndex = 0;
            label1.Text = " Which do you think is better, Visual Basic Or C# ";
            // 
            // vbButton
            // 
            vbButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            vbButton.ForeColor = Color.ForestGreen;
            vbButton.Location = new Point(98, 118);
            vbButton.Name = "vbButton";
            vbButton.Size = new Size(106, 32);
            vbButton.TabIndex = 1;
            vbButton.Text = "Visual basic";
            vbButton.UseVisualStyleBackColor = true;
            vbButton.MouseMove += vbButton_MouseMove;
            // 
            // csButton
            // 
            csButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            csButton.ForeColor = Color.Red;
            csButton.Location = new Point(292, 118);
            csButton.Name = "csButton";
            csButton.Size = new Size(113, 32);
            csButton.TabIndex = 2;
            csButton.Text = "C#";
            csButton.UseVisualStyleBackColor = true;
            csButton.Click += csButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(39, 305);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(88, 36);
            closeButton.TabIndex = 3;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(553, 367);
            Controls.Add(closeButton);
            Controls.Add(csButton);
            Controls.Add(vbButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button vbButton;
        private Button csButton;
        private Button closeButton;
    }
}