namespace BrassHandGenerator
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            BT_Generate = new Button();
            PB_BrassHandIcon = new PictureBox();
            LB_Title = new Label();
            LB_Credit = new Label();
            TB_Output = new TextBox();
            LB_Version = new Label();
            ((System.ComponentModel.ISupportInitialize)PB_BrassHandIcon).BeginInit();
            SuspendLayout();
            // 
            // BT_Generate
            // 
            BT_Generate.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BT_Generate.ForeColor = Color.DarkGreen;
            BT_Generate.Location = new Point(12, 208);
            BT_Generate.Name = "BT_Generate";
            BT_Generate.Size = new Size(776, 56);
            BT_Generate.TabIndex = 0;
            BT_Generate.Text = "Generate";
            BT_Generate.UseVisualStyleBackColor = true;
            BT_Generate.Click += BT_Generate_OnClick;
            // 
            // PB_BrassHandIcon
            // 
            PB_BrassHandIcon.Image = (Image)resources.GetObject("PB_BrassHandIcon.Image");
            PB_BrassHandIcon.Location = new Point(12, 12);
            PB_BrassHandIcon.Name = "PB_BrassHandIcon";
            PB_BrassHandIcon.Size = new Size(776, 252);
            PB_BrassHandIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            PB_BrassHandIcon.TabIndex = 1;
            PB_BrassHandIcon.TabStop = false;
            // 
            // LB_Title
            // 
            LB_Title.AutoSize = true;
            LB_Title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LB_Title.Location = new Point(298, 12);
            LB_Title.Name = "LB_Title";
            LB_Title.Size = new Size(208, 25);
            LB_Title.TabIndex = 2;
            LB_Title.Text = "Brass Hand Generator";
            LB_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LB_Credit
            // 
            LB_Credit.Anchor = AnchorStyles.None;
            LB_Credit.AutoSize = true;
            LB_Credit.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LB_Credit.Location = new Point(354, 37);
            LB_Credit.Name = "LB_Credit";
            LB_Credit.Size = new Size(78, 15);
            LB_Credit.TabIndex = 3;
            LB_Credit.Text = "By Josh Mate";
            LB_Credit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TB_Output
            // 
            TB_Output.Anchor = AnchorStyles.None;
            TB_Output.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Output.Location = new Point(12, 270);
            TB_Output.Multiline = true;
            TB_Output.Name = "TB_Output";
            TB_Output.Size = new Size(776, 88);
            TB_Output.TabIndex = 4;
            TB_Output.Text = " ";
            TB_Output.TextAlign = HorizontalAlignment.Center;
            // 
            // LB_Version
            // 
            LB_Version.Anchor = AnchorStyles.None;
            LB_Version.AutoSize = true;
            LB_Version.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LB_Version.Location = new Point(375, 52);
            LB_Version.Name = "LB_Version";
            LB_Version.Size = new Size(30, 15);
            LB_Version.TabIndex = 5;
            LB_Version.Text = "v1.0";
            LB_Version.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 370);
            Controls.Add(LB_Version);
            Controls.Add(TB_Output);
            Controls.Add(LB_Credit);
            Controls.Add(LB_Title);
            Controls.Add(BT_Generate);
            Controls.Add(PB_BrassHandIcon);
            Name = "Form_Main";
            Text = "Brass Hand Generator";
            Load += Form_Main_Load;
            ((System.ComponentModel.ISupportInitialize)PB_BrassHandIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT_Generate;
        private PictureBox PB_BrassHandIcon;
        private Label LB_Title;
        private Label LB_Credit;
        private TextBox TB_Output;
        private Label LB_Version;
    }
}