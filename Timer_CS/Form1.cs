using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ZYZTimer;

namespace Timer_CS
{
    /*
     * 这个计时器，在一开始显示窗口时，就已经会一直实时更新时间，这个由updateNowTime线程去做
     * 点击开始时，记录、显示开始的时间
     * 再次点击按钮时，记录、显示结束时间，并弹框显示计算出来的时长
     */
    public partial class WinTimer : Form, TimerDelegate
    {
        public WinTimer ()
        {
            InitializeComponent();
        }
        
        ZYZTimer.Timer timer = new ZYZTimer.Timer();  //计时器
        Thread updateNowTime;  //实时更新时间的线程

        private void Form1_Load (object sender, EventArgs e)
        {
            this.StartTimer();
            this.UpdateTextWithTime(this.startTimeLabel, DateTime.MinValue);
            this.UpdateTextWithTime(this.endTimeLabel, DateTime.MinValue);
            this.timer.timerDelegate = this;
        }
        
        private void TimerControl_Click (object sender, EventArgs e)
        {
            //翻转计时器状态
            this.timer.ReStatus();
        }

        /// <summary>
        /// 开始更新当前时间的线程
        /// </summary>
        void StartTimer ()
        {
            updateNowTime = new Thread(ShowNowTime);
            updateNowTime.IsBackground = true;
            updateNowTime.Start();
        }

        /// <summary>
        /// 实时更新“实时时间”
        /// </summary>
        /// <param name="status"></param>
        void ShowNowTime ()
        {
            //更新label的显示
            while ( updateNowTime.IsAlive )
            {
                this.UpdateTextWithTime(this.nowTimeLabel, DateTime.Now);
                //当前线程阻塞0.5秒，是为了不使UI一直刷新
                Thread.Sleep(500);
            }
        }

        /// <summary>
        /// 更新label显示的时间
        /// </summary>
        /// <param name="label"></param>
        /// <param name="time"></param>
        void UpdateTextWithTime (Label label, DateTime time)
        {
            label.Text = time.ToString("MM/dd HH:mm:ss");
        }

        private void Form1_FormClosed (object sender, FormClosedEventArgs e)
        {
            //使窗口进程完全销毁
            this.Dispose();
        }

        #region TimerDelegate 成员

        void TimerDelegate.TimerStart ()
        {
            //开始计时
            //重置状态
            this.timer.StartTimer();
            //显示开始时间
            this.UpdateTextWithTime(this.startTimeLabel, this.timer.StartTime);
            //重置结束时间的显示
            this.UpdateTextWithTime(this.endTimeLabel, this.timer.EndTime);
            //按钮文案修改
            this.TimerControl.Text = "停止";
        }

        void TimerDelegate.TimerEnd ()
        {
            //停止计时
            ZYZTimer.Timer tempStatus = this.timer;
            //status结束计时
            tempStatus.EndTimer();
            //显示结束时间
            this.UpdateTextWithTime(this.endTimeLabel, tempStatus.EndTime);
            //按钮文案修改
            this.TimerControl.Text = "开始";
            //计算时长
            string duration = tempStatus.Duration();
            //显示时长
            MessageBox.Show(string.Format("一共历时{0}", duration));
        }

        #endregion
    }
}
