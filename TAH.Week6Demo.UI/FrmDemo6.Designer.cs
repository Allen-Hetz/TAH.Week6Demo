namespace TAH.Week6Demo.UI
{
    partial class FrmDemo6
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
            btnExit = new Button();
            btnEnter = new Button();
            lblResult = new Label();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(260, 222);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(388, 222);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.White;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.FlatStyle = FlatStyle.Popup;
            lblResult.Location = new Point(172, 174);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(383, 23);
            lblResult.TabIndex = 3;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(310, 100);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 4;
            // 
            // FrmDemo6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Controls.Add(btnEnter);
            Controls.Add(btnExit);
            Name = "FrmDemo6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Week 6 Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExit;
        private Button btnEnter;
        private Label lblResult;
        private TextBox txtInput;
    }
}
