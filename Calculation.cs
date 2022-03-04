using System;

namespace ConvertTime
{
    class Calculation
    {
        //Declaring some variables before they are called/used
        private string advancedCalcString;
        private TimeSpan timeSpanInterval;
        private double convertedTimeSpan;

        public string CalculateAdvanced(TimeSpan tAdvanced, string destinationFormat)
        {
            //Calculates answer in the form YYy WWw DDd HH:MM:SS.ss
            switch (destinationFormat)
            {
                case "minutes":
                    advancedCalcString = String.Format("{0}:{1:00}.{2:00}", Math.Floor(tAdvanced.TotalMinutes), tAdvanced.Seconds, tAdvanced.Milliseconds);
                    break;
                case "hours":
                    advancedCalcString = String.Format("{0}:{1:00}:{2:00}.{3:00}", Math.Floor(tAdvanced.TotalHours), tAdvanced.Minutes, tAdvanced.Seconds, tAdvanced.Milliseconds);
                    break;
                case "days":
                    advancedCalcString = String.Format("{0}d {1:00}:{2:00}:{3:00}.{4:00}", Math.Floor(tAdvanced.TotalDays), tAdvanced.Hours, tAdvanced.Minutes, tAdvanced.Seconds, tAdvanced.Milliseconds);
                    break;
                case "weeks":
                    advancedCalcString = String.Format("{0}w {1:00}d {2:00}:{3:00}:{4:00}.{5:00}", Math.Floor(tAdvanced.TotalDays / 7), tAdvanced.TotalDays % 7, tAdvanced.Hours, tAdvanced.Minutes, tAdvanced.Seconds, tAdvanced.Milliseconds);
                    break;
                case "years":
                    double yearsCalc = Math.Floor(tAdvanced.TotalDays / 365);
                    double weeksCalc = Math.Floor((tAdvanced.TotalDays - (365 * yearsCalc)) / 7);
                    double daysCalc = (tAdvanced.TotalDays - (365 * yearsCalc)) % 7;
                    advancedCalcString = String.Format("{0}y {1:00}w {2:00}d {3:00}:{4:00}:{5:00}.{6:00}", yearsCalc, weeksCalc, daysCalc, tAdvanced.Hours, tAdvanced.Minutes, tAdvanced.Seconds, tAdvanced.Milliseconds);
                    break;
                default:
                    advancedCalcString = String.Format("{0:00.00}", tAdvanced.TotalSeconds);
                    break;
            }

            return advancedCalcString;
        }


        public TimeSpan ConvertInputToTimeSpan(double aUserNumber, string aUserUnitSelection)
        {
            //Converts user input into a TimeSpan object. Used in conversion later

            switch (aUserUnitSelection)
            {
                case "minutes":
                    timeSpanInterval = TimeSpan.FromMinutes(aUserNumber);
                    break;
                case "hours":
                    timeSpanInterval = TimeSpan.FromHours(aUserNumber);
                    break;
                case "days":
                    timeSpanInterval = TimeSpan.FromDays(aUserNumber);
                    break;
                case "weeks":
                    timeSpanInterval = TimeSpan.FromDays(aUserNumber * 7);
                    break;
                case "years":
                    timeSpanInterval = TimeSpan.FromDays(aUserNumber * 365);
                    break;
                default:
                    timeSpanInterval = TimeSpan.FromSeconds(aUserNumber);
                    break;
            }

            return timeSpanInterval;
        }

        public double ConversionOfUnits(TimeSpan aToConvert, string aDestinationUnit)
        {
            //Finds total destination units and retruns the result. From TimeSpan to double

            switch (aDestinationUnit)
            {
                case "minutes":
                    convertedTimeSpan = aToConvert.TotalMinutes;
                    break;
                case "hours":
                    convertedTimeSpan = aToConvert.TotalHours;
                    break;
                case "days":
                    convertedTimeSpan = aToConvert.TotalDays;
                    break;
                case "weeks":
                    convertedTimeSpan = (aToConvert.TotalDays) / 7;
                    break;
                case "years":
                    convertedTimeSpan = (aToConvert.TotalDays) / 365;
                    break;
                default:
                    convertedTimeSpan = aToConvert.TotalSeconds;
                    break;
            }

            return convertedTimeSpan;
        }
    }
}
