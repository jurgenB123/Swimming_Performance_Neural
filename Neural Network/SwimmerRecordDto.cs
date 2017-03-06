using System;

namespace Neural_Network
{
    class SwimmerRecordDto
    {
        public string Gender { get; set; }
        public double Time { get; set; }

        public SwimmerRecordDto(string gender, double time)
        {
            this.Gender = gender;
            this.Time = time;
        }
        
    }
}

