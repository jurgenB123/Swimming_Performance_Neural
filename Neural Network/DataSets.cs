using System;
namespace Neural_Network
{
    class DataSets
    {
        public const string FEMALE = "Female";
        public const string MALE = "Male";
        public static TimeConverter converter = new TimeConverter();
        public SwimmerRecordDto amaSam_ds1 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(35, 86));
        public SwimmerRecordDto amaSam_ds2 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(54, 41));
        public SwimmerRecordDto amaSam_ds3 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(47, 99));
        public SwimmerRecordDto amaSam_ds4 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(2, 00, 24));
        public SwimmerRecordDto amaSam_ds5 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(1, 28, 15));

        public SwimmerRecordDto danekaShepard_ds1 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(39, 78));
        public SwimmerRecordDto danekaShepard_ds2 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(1, 33, 47));
        public SwimmerRecordDto danekaShepard_ds3 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(3, 37, 62));
        public SwimmerRecordDto danekaShepard_ds4 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(1, 35, 90));
        public SwimmerRecordDto danekaShepard_ds5 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(3, 25, 73));
        public SwimmerRecordDto danekaShepard_ds6 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(39, 80));
        public SwimmerRecordDto danekaShepard_ds7 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(54, 28));
        public SwimmerRecordDto danekaShepard_ds8 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(3, 37, 21));
        public SwimmerRecordDto danekaShepard_ds9 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(3, 37, 21));
        public SwimmerRecordDto danekaShepard_ds10 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(1, 36, 18));
        public SwimmerRecordDto danekaShepard_ds11 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(39, 60));
        public SwimmerRecordDto danekaShepard_ds12 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(44, 90));

        public SwimmerRecordDto geenaLaglois_ds1 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(30, 81));
        public SwimmerRecordDto geenaLaglois_ds2 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(32, 52));
        public SwimmerRecordDto geenaLaglois_ds3 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(2, 25, 02));
        public SwimmerRecordDto geenaLaglois_ds4 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(31, 40));
        public SwimmerRecordDto geenaLaglois_ds5 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(2, 47, 82));
        public SwimmerRecordDto geenaLaglois_ds6 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(1, 19, 42));
        public SwimmerRecordDto geenaLaglois_ds7 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(2, 38, 83));
        public SwimmerRecordDto geenaLaglois_ds8 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(44, 30));
        public SwimmerRecordDto geenaLaglois_ds9 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(1, 20, 79));
        public SwimmerRecordDto geenaLaglois_ds10 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(33, 62));
        public SwimmerRecordDto geenaLaglois_ds11 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(2, 34, 08));
        public SwimmerRecordDto geenaLaglois_ds12 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(33, 55));
        public SwimmerRecordDto geenaLaglois_ds13 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(1, 11, 81));
        public SwimmerRecordDto geenaLaglois_ds14 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(32, 52));
        public SwimmerRecordDto geenaLaglois_ds15 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(2, 59, 42));
        public SwimmerRecordDto geenaLaglois_ds16 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(1, 12, 71));
        public SwimmerRecordDto geenaLaglois_ds17 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(2, 59, 81));
        public SwimmerRecordDto geenaLaglois_ds18 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(1, 10, 98));
        public SwimmerRecordDto geenaLaglois_ds19 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(1, 17, 63));
        public SwimmerRecordDto geenaLaglois_ds20 = new SwimmerRecordDto(FEMALE, new TimeConverter().ConvertToSeconds(1, 16, 15));




    }
}
