namespace Neural_Network
{
    public class TimeConverter
    {
        public double ConvertToSeconds(double minute, double seconds, double milliseconds)
        {
            double minuteToSeconds = minute * 60;
            double millisecondsToSeconds = milliseconds / 1000;
            return minuteToSeconds + seconds + millisecondsToSeconds;
        }

        public double ConvertToSeconds(double seconds, double milliseconds)
        {
            double millisecondsToSeconds = milliseconds / 1000;
            return seconds + millisecondsToSeconds;
        }

        public double ConvertToSeconds(double milliseconds)
        {
            double millisecondsToSeconds = milliseconds / 1000;
            return millisecondsToSeconds;
        }
    }
}
