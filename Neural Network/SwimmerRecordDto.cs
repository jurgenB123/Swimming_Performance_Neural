using System;

namespace Neural_Network
{
    public class SwimmerRecordDto
    {
        public string Gender { get; set; }
        public double FinaPoints { get; set; }
        public string StrokeType { get; set; }

        public SwimmerRecordDto(string gender, string strokeType, double finaPoints)
        {
            this.FinaPoints = finaPoints;
            this.StrokeType = strokeType;
            this.Gender = gender;
        }
        
    }
}

