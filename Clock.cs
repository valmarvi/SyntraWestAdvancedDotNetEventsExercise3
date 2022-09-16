using System;
using System.Threading;

namespace AdvancedDotNetEventsExercise3
{
    public class Clock
    {
        private DateTime _alarmTime;
        private Timer _timer;
        public event EventHandler Alarm;

        public Clock(DateTime alarmTime)
        {
            _alarmTime = alarmTime;
            _timer = new Timer(TimerTriggered, null, 0, 1000);
        }

        public void TimerTriggered(object? s)
        {
            if (_alarmTime.ToString() == DateTime.Now.ToString())
            {
                Alarm?.Invoke(this, new EventArgs());
            }
        }
    }
}
