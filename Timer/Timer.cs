using System;
using System.Threading;

namespace Timer
{
    public sealed class Timer
    {
        #region Private fields

        private int _time;

        #endregion

        #region Properties

        public int Time
        {
            get
            {
                return _time;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Time must be more than zero.");
                }

                _time = value;
            }
        }

        #endregion

        #region Event: Time is over

        /// <summary>
        /// Event: Time is over.
        /// </summary>
        public event EventHandler<TimeIsOverEventArgs> TimeIsOver = delegate { };

        /// <summary>
        /// Method that starts the time.
        /// </summary>
        /// <param name="msg"> The message for customers. </param>
        public void Start(string msg)
        {
            Thread.Sleep(1000 * Time);
            OnTimeIsOver(new TimeIsOverEventArgs() { Msg = msg });
        }

        /// <summary>
        /// Method that invoke event.
        /// </summary>
        /// <param name="eventArgs"></param>
        private void OnTimeIsOver(TimeIsOverEventArgs eventArgs)
        {
            EventHandler<TimeIsOverEventArgs> temp = TimeIsOver;
            temp?.Invoke(this, eventArgs);
        }

        #endregion
    }
}
