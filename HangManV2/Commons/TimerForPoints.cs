using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.Commons
{
    /// <summary>
    /// This class handles the calculation of points based on time
    /// </summary>
    /// <param name="stopWatch">A stopWatch.</param>
    class TimerForPoints
    {
        Stopwatch stopWatch;
        public TimerForPoints()
        {
            this.stopWatch = new Stopwatch();
        }
        /// <summary>
        /// Calculates the amount of points based on the period of time between this and the last time this method was called
        /// </summary>
        /// <returns>
        ///  The amount of points
        /// </returns>
        /// <example>
        /// <code>
        /// points += timer.GetPoits();
        /// </code>
        /// </example>
        ///<param name="elapsedTime">An text value.</param>
        ///<param name="ts">Time interval</param>
        ///<param name="pointsSplit">An array of strings.</param>
        public int GetPoits()
        {
            string elapsedTime = "nothing";
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            //return elapsedTime;
            stopWatch.Restart();
            // stopWatch.Start();
            //  return elapsedTime;
            string[] pointsSplit = elapsedTime.Split(':');
            int timeInSec = int.Parse(pointsSplit[1]);
            if (elapsedTime != "nothing" && pointsSplit[0] == "00")
            {
                if (timeInSec < 2)
                {
                    return 4;
                }
                else
                {
                    if (timeInSec < 5)
                    {
                        return 3;
                    }
                    else
                    {
                        if (timeInSec < 10)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }

            }
            return 1;
        }
    }
}
