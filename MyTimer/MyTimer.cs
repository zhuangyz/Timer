using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZYZTimer
{
    /*
     * 标记计时器状态
     */
    public enum TimerStatus
    {
        TimerRunning,
        TimerEnding,
        TimerStatusNone = TimerEnding
    }

    /*
     * 计时器代理
     */
    public interface TimerDelegate
    {
        void TimerStart ();
        void TimerEnd ();
    }

    /*
     * 这个虽然叫做计时器，但其实它只是记录计时的开始、结束时间，以及计算出时长，我也不太确定这样算不算计时器
     */
    public class Timer
    {
        #region 属性
        //计时器的状态
        private TimerStatus status;
        public TimerStatus Status
        {
            get
            {
                return this.status;
            }
        }
        //代理
        public TimerDelegate timerDelegate;
        //开始时间
        private DateTime startTime;
        public DateTime StartTime
        {
            get
            {
                return this.startTime;
            }
        }
        //结束时间
        private DateTime endTime;
        public DateTime EndTime
        {
            get
            {
                return this.endTime;
            }
        }
        //时长
        private TimeSpan duration;
        #endregion

        public Timer ()
        {
            this.InitTimer();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void InitTimer ()
        {
            this.startTime = DateTime.MinValue;
            this.endTime = DateTime.MinValue;
            this.duration = TimeSpan.Zero;
            this.status = TimerStatus.TimerStatusNone;
        }

        /// <summary>
        /// 调用这个方法可以让计时器翻转状态
        /// </summary>
        public void ReStatus ()
        {
            if(this.timerDelegate == null)
                return;
            if ( this.status == TimerStatus.TimerRunning )
            {
                this.EndTimer();
                this.timerDelegate.TimerEnd();

            } else if ( this.status == TimerStatus.TimerEnding )
            {
                this.StartTimer();
                this.timerDelegate.TimerStart();
            }
        }

        /// <summary>
        /// 开始计时
        /// </summary>
        public void StartTimer ()
        {
            this.startTime = DateTime.Now;
            this.endTime = DateTime.MinValue;
            this.duration = TimeSpan.Zero;
            this.status = TimerStatus.TimerRunning;
        }

        /// <summary>
        /// 结束计时
        /// </summary>
        public void EndTimer ()
        {
            this.endTime = DateTime.Now;
            this.duration = this.startTime.Subtract(this.endTime).Duration();
            this.status = TimerStatus.TimerEnding;
        }

        /// <summary>
        /// 计算时长
        /// </summary>
        /// <returns>返回经历的时分秒</returns>
        public string Duration ()
        {
            //根据时长生成一个时间
            DateTime durationFormat = new DateTime(this.duration.Ticks);
            return durationFormat.ToString("HH小时mm分ss秒");
        }
    }
}
