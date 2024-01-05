using OmikuCsharp.domain;

namespace OmikuCsharp
{
    partial class OmikuCsharp
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
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("游明朝", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(288, 106);
            label1.Name = "label1";
            label1.Size = new Size(207, 36);
            label1.TabIndex = 0;
            label1.Text = "今年の運勢は...";
            // 
            // button1
            // 
            button1.Font = new Font("游明朝", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button1.Location = new Point(316, 320);
            button1.Name = "button1";
            button1.Size = new Size(124, 37);
            button1.TabIndex = 1;
            button1.Text = "占う";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("游明朝", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(316, 183);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(0, 61);
            label2.TabIndex = 2;
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // OmikuCsharp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "OmikuCsharp";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = LotteryService.Lottery();
        }
    }
}
