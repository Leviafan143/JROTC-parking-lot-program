namespace jrotcProgram
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
            newDataInputBtn = new Button();
            inputExsitingData = new Button();
            viewData = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // newDataInputBtn
            // 
            newDataInputBtn.Location = new Point(88, 209);
            newDataInputBtn.Name = "newDataInputBtn";
            newDataInputBtn.Size = new Size(147, 53);
            newDataInputBtn.TabIndex = 0;
            newDataInputBtn.Text = "Input new data";
            newDataInputBtn.UseVisualStyleBackColor = true;
            newDataInputBtn.Click += button1_Click;
            // 
            // inputExsitingData
            // 
            inputExsitingData.Location = new Point(304, 209);
            inputExsitingData.Name = "inputExsitingData";
            inputExsitingData.Size = new Size(147, 53);
            inputExsitingData.TabIndex = 1;
            inputExsitingData.Text = "Input existing data";
            inputExsitingData.UseVisualStyleBackColor = true;
            inputExsitingData.Click += button2_Click;
            // 
            // viewData
            // 
            viewData.Location = new Point(515, 209);
            viewData.Name = "viewData";
            viewData.Size = new Size(147, 53);
            viewData.TabIndex = 2;
            viewData.Text = "View data";
            viewData.UseVisualStyleBackColor = true;
            viewData.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(304, 325);
            button1.Name = "button1";
            button1.Size = new Size(147, 53);
            button1.TabIndex = 3;
            button1.Text = "Report issue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(newDataInputBtn);
            Controls.Add(viewData);
            Controls.Add(inputExsitingData);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button newDataInputBtn;
        private Button inputExsitingData;
        private Button viewData;
        private Button button1;
    }
}
