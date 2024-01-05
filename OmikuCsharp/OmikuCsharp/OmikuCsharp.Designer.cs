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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label_money = new Label();
            label_working = new Label();
            label_study = new Label();
            label_love = new Label();
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
            button1.Location = new Point(316, 401);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("游明朝", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(149, 271);
            label3.Name = "label3";
            label3.Size = new Size(71, 36);
            label3.TabIndex = 3;
            label3.Text = "金運";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("游明朝", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(149, 321);
            label4.Name = "label4";
            label4.Size = new Size(71, 36);
            label4.TabIndex = 4;
            label4.Text = "仕事";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("游明朝", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(421, 271);
            label5.Name = "label5";
            label5.Size = new Size(71, 36);
            label5.TabIndex = 5;
            label5.Text = "学業";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("游明朝", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(421, 321);
            label6.Name = "label6";
            label6.Size = new Size(71, 36);
            label6.TabIndex = 6;
            label6.Text = "恋愛";
            // 
            // label_money
            // 
            label_money.AutoSize = true;
            label_money.Font = new Font("游明朝", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label_money.Location = new Point(316, 271);
            label_money.Name = "label_money";
            label_money.Size = new Size(0, 36);
            label_money.TabIndex = 7;
            // 
            // label_working
            // 
            label_working.AutoSize = true;
            label_working.Font = new Font("游明朝", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label_working.Location = new Point(316, 321);
            label_working.Name = "label_working";
            label_working.Size = new Size(0, 36);
            label_working.TabIndex = 8;
            // 
            // label_study
            // 
            label_study.AutoSize = true;
            label_study.Font = new Font("游明朝", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label_study.Location = new Point(590, 271);
            label_study.Name = "label_study";
            label_study.Size = new Size(0, 36);
            label_study.TabIndex = 9;
            // 
            // label_love
            // 
            label_love.AutoSize = true;
            label_love.Font = new Font("游明朝", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label_love.Location = new Point(590, 321);
            label_love.Name = "label_love";
            label_love.Size = new Size(0, 36);
            label_love.TabIndex = 10;
            // 
            // OmikuCsharp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(label_love);
            Controls.Add(label_study);
            Controls.Add(label_working);
            Controls.Add(label_money);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "OmikuCsharp";
            Text = "OmikuCsharp";
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
            label_working.Text = LotteryService.Lottery();
            label_love.Text = LotteryService.Lottery();
            label_study.Text = LotteryService.Lottery();
            label_money.Text = LotteryService.Lottery();
        }

        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label_money;
        private Label label_working;
        private Label label_study;
        private Label label_love;
    }
}
