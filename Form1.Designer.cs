namespace WeddingBook
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
            policy = new CheckBox();
            privacy = new LinkLabel();
            label1 = new Label();
            termsandcondition = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            start = new CustomButton();
            SuspendLayout();
            // 
            // policy
            // 
            policy.AutoSize = true;
            policy.BackColor = Color.Transparent;
            policy.Location = new Point(125, 290);
            policy.Name = "policy";
            policy.Size = new Size(277, 24);
            policy.TabIndex = 0;
            policy.Text = "I have read and agree and accept the";
            policy.UseVisualStyleBackColor = false;
            policy.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // privacy
            // 
            privacy.AutoSize = true;
            privacy.BackColor = Color.Transparent;
            privacy.LinkBehavior = LinkBehavior.HoverUnderline;
            privacy.Location = new Point(393, 291);
            privacy.Name = "privacy";
            privacy.Size = new Size(97, 20);
            privacy.TabIndex = 0;
            privacy.TabStop = true;
            privacy.Text = "Privacy Policy";
            privacy.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(485, 291);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 4;
            label1.Text = "and";
            // 
            // termsandcondition
            // 
            termsandcondition.AutoSize = true;
            termsandcondition.BackColor = Color.Transparent;
            termsandcondition.LinkBehavior = LinkBehavior.HoverUnderline;
            termsandcondition.Location = new Point(513, 291);
            termsandcondition.Name = "termsandcondition";
            termsandcondition.Size = new Size(146, 20);
            termsandcondition.TabIndex = 5;
            termsandcondition.TabStop = true;
            termsandcondition.Text = "Terms and Condition";
            termsandcondition.LinkClicked += termsandcondition_LinkClicked;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Open Sans Condensed Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(106, 48);
            label2.Name = "label2";
            label2.Size = new Size(576, 239);
            label2.TabIndex = 6;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(653, 291);
            label3.Name = "label3";
            label3.Size = new Size(10, 21);
            label3.TabIndex = 4;
            label3.Text = ".";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            start.BackColor = Color.Firebrick;
            start.BackgroundColor = Color.Firebrick;
            start.BorderColor = Color.PaleVioletRed;
            start.BorderRadius = 20;
            start.BorderSize = 0;
            start.FlatAppearance.BorderSize = 0;
            start.FlatStyle = FlatStyle.Flat;
            start.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.ForeColor = Color.White;
            start.Location = new Point(300, 324);
            start.Name = "start";
            start.Size = new Size(188, 50);
            start.TabIndex = 7;
            start.Text = "Start Planning";
            start.TextColor = Color.White;
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(789, 401);
            Controls.Add(label3);
            Controls.Add(start);
            Controls.Add(termsandcondition);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(privacy);
            Controls.Add(policy);
            MaximumSize = new Size(807, 448);
            MinimumSize = new Size(807, 448);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wedding Book";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox policy;
        private LinkLabel privacy;
        private Label label1;
        private LinkLabel termsandcondition;
        private Label label2;
        private Label label3;
        private CustomButton start;
    }
}
