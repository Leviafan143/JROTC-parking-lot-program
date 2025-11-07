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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            inputNewData = new Button();
            inputExistingData = new Button();
            viewData = new Button();
            reportIssue = new Button();
            databaseTT = new ToolTip(components);
            inputExistingTT = new ToolTip(components);
            inputNewTT = new ToolTip(components);
            reportIssueTT = new ToolTip(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // inputNewData
            // 
            inputNewData.Location = new Point(378, 218);
            inputNewData.Margin = new Padding(4);
            inputNewData.Name = "inputNewData";
            inputNewData.Size = new Size(184, 66);
            inputNewData.TabIndex = 0;
            inputNewData.Text = "Input new data";
            inputNewTT.SetToolTip(inputNewData, "Click to input new data into the database. license plate and whatnot. STAFF AND ADMINISTRATOR USE ONLY (right? again this is a temporary tooltip make better later)");
            inputNewData.UseVisualStyleBackColor = true;
            inputNewData.Click += inputNewData_Click;
            // 
            // inputExistingData
            // 
            inputExistingData.Location = new Point(133, 218);
            inputExistingData.Margin = new Padding(4);
            inputExistingData.Name = "inputExistingData";
            inputExistingData.Size = new Size(184, 66);
            inputExistingData.TabIndex = 1;
            inputExistingData.Text = "Input existing data";
            inputExistingTT.SetToolTip(inputExistingData, resources.GetString("inputExistingData.ToolTip"));
            inputExistingData.UseVisualStyleBackColor = true;
            inputExistingData.Click += inputExistingData_Click;
            // 
            // viewData
            // 
            viewData.Location = new Point(378, 33);
            viewData.Margin = new Padding(4);
            viewData.Name = "viewData";
            viewData.Size = new Size(184, 66);
            viewData.TabIndex = 2;
            viewData.Text = "View data";
            databaseTT.SetToolTip(viewData, "Click to view all license plates and stuff temporary tooltip make this better later");
            viewData.UseVisualStyleBackColor = true;
            viewData.Click += viewData_Click;
            // 
            // reportIssue
            // 
            reportIssue.Location = new Point(133, 33);
            reportIssue.Margin = new Padding(4);
            reportIssue.Name = "reportIssue";
            reportIssue.Size = new Size(184, 66);
            reportIssue.TabIndex = 3;
            reportIssue.Text = "Report issue";
            reportIssueTT.SetToolTip(reportIssue, "Click to issue warning (issue warning citation. temporary tooltip make this better later)");
            reportIssue.UseVisualStyleBackColor = true;
            reportIssue.Click += reportIssue_Click;
            // 
            // databaseTT
            // 
            databaseTT.ToolTipIcon = ToolTipIcon.Info;
            // 
            // inputExistingTT
            // 
            inputExistingTT.ToolTipIcon = ToolTipIcon.Info;
            // 
            // inputNewTT
            // 
            inputNewTT.ToolTipIcon = ToolTipIcon.Info;
            // 
            // reportIssueTT
            // 
            reportIssueTT.ToolTipIcon = ToolTipIcon.Info;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 138);
            label1.Name = "label1";
            label1.Size = new Size(688, 45);
            label1.TabIndex = 4;
            label1.Text = "awesome criminal justice warning system thing";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 336);
            Controls.Add(label1);
            Controls.Add(reportIssue);
            Controls.Add(inputNewData);
            Controls.Add(viewData);
            Controls.Add(inputExistingData);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button inputNewData;
        private Button inputExistingData;
        private Button viewData;
        private Button reportIssue;
        private ToolTip databaseTT;
        private ToolTip inputExistingTT;
        private ToolTip inputNewTT;
        private ToolTip reportIssueTT;
        private Label label1;
    }
}
