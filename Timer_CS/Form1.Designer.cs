namespace Timer_CS
{
    partial class WinTimer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose (bool disposing)
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent ()
        {
            this.TimerControl = new System.Windows.Forms.Button();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.nowTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimerControl
            // 
            this.TimerControl.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimerControl.Location = new System.Drawing.Point(63, 167);
            this.TimerControl.Name = "TimerControl";
            this.TimerControl.Size = new System.Drawing.Size(165, 39);
            this.TimerControl.TabIndex = 0;
            this.TimerControl.Text = "开始";
            this.TimerControl.UseVisualStyleBackColor = true;
            this.TimerControl.Click += new System.EventHandler(this.TimerControl_Click);
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.BackColor = System.Drawing.Color.Red;
            this.startTimeLabel.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startTimeLabel.Location = new System.Drawing.Point(111, 13);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(162, 44);
            this.startTimeLabel.TabIndex = 1;
            this.startTimeLabel.Text = "开始时间";
            this.startTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nowTimeLabel
            // 
            this.nowTimeLabel.BackColor = System.Drawing.Color.Yellow;
            this.nowTimeLabel.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nowTimeLabel.Location = new System.Drawing.Point(111, 61);
            this.nowTimeLabel.Name = "nowTimeLabel";
            this.nowTimeLabel.Size = new System.Drawing.Size(162, 44);
            this.nowTimeLabel.TabIndex = 2;
            this.nowTimeLabel.Text = "实时时间";
            this.nowTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.BackColor = System.Drawing.Color.Blue;
            this.endTimeLabel.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endTimeLabel.Location = new System.Drawing.Point(111, 109);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(162, 44);
            this.endTimeLabel.TabIndex = 3;
            this.endTimeLabel.Text = "结束时间";
            this.endTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "结束时间";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "实时时间";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "开始时间";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 217);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.nowTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.TimerControl);
            this.Name = "WinTimer";
            this.Text = "计时器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TimerControl;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label nowTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

