namespace Neural_Network
{
    public class DataSets_FINA
    {
        //Data Sets URL: https://www.swimming.org.nz/results.html

        public const string FEMALE = "female";
        public const string STROKETYPE = "50m";

        //Swimmer: Daneka Sheppard Distance: 50m Gender: Female
        public SwimmerRecordDto danekSheppard_ds01 = new SwimmerRecordDto(FEMALE, STROKETYPE, 231);
        public SwimmerRecordDto danekSheppard_ds02 = new SwimmerRecordDto(FEMALE, STROKETYPE, 211);
        public SwimmerRecordDto danekSheppard_ds03 = new SwimmerRecordDto(FEMALE, STROKETYPE, 160);
        public SwimmerRecordDto danekSheppard_ds04 = new SwimmerRecordDto(FEMALE, STROKETYPE, 215);
        public SwimmerRecordDto danekSheppard_ds05 = new SwimmerRecordDto(FEMALE, STROKETYPE, 161);
        public SwimmerRecordDto danekSheppard_ds06 = new SwimmerRecordDto(FEMALE, STROKETYPE, 228);
        public SwimmerRecordDto danekSheppard_ds07 = new SwimmerRecordDto(FEMALE, STROKETYPE, 162);
        public SwimmerRecordDto danekSheppard_ds08 = new SwimmerRecordDto(FEMALE, STROKETYPE, 242);
        public SwimmerRecordDto danekSheppard_ds09 = new SwimmerRecordDto(FEMALE, STROKETYPE, 166);
        public SwimmerRecordDto danekSheppard_ds10 = new SwimmerRecordDto(FEMALE, STROKETYPE, 219);

        //Swimmer: Briana Gerring Distance: 50m Gender: Female
        public SwimmerRecordDto brianaGerrig_ds01 = new SwimmerRecordDto(FEMALE, STROKETYPE, 335);
        public SwimmerRecordDto brianaGerrig_ds02 = new SwimmerRecordDto(FEMALE, STROKETYPE, 346);
        public SwimmerRecordDto brianaGerrig_ds03 = new SwimmerRecordDto(FEMALE, STROKETYPE, 248);
        public SwimmerRecordDto brianaGerrig_ds04 = new SwimmerRecordDto(FEMALE, STROKETYPE, 246);
        public SwimmerRecordDto brianaGerrig_ds05 = new SwimmerRecordDto(FEMALE, STROKETYPE, 307);
        public SwimmerRecordDto brianaGerrig_ds06 = new SwimmerRecordDto(FEMALE, STROKETYPE, 312);
        public SwimmerRecordDto brianaGerrig_ds07 = new SwimmerRecordDto(FEMALE, STROKETYPE, 219);
        public SwimmerRecordDto brianaGerrig_ds08 = new SwimmerRecordDto(FEMALE, STROKETYPE, 214);
        public SwimmerRecordDto brianaGerrig_ds09 = new SwimmerRecordDto(FEMALE, STROKETYPE, 259);
        public SwimmerRecordDto brianaGerrig_ds10 = new SwimmerRecordDto(FEMALE, STROKETYPE, 250);

        //Swimmer: Adriana Albengrin Distance: 50m Gender: Female
        public SwimmerRecordDto adrianaAlbergrid_ds01 = new SwimmerRecordDto(FEMALE, STROKETYPE, 404);
        public SwimmerRecordDto adrianaAlbergrid_ds02 = new SwimmerRecordDto(FEMALE, STROKETYPE, 404);
        public SwimmerRecordDto adrianaAlbergrid_ds03 = new SwimmerRecordDto(FEMALE, STROKETYPE, 412);
        public SwimmerRecordDto adrianaAlbergrid_ds04 = new SwimmerRecordDto(FEMALE, STROKETYPE, 415);
        public SwimmerRecordDto adrianaAlbergrid_ds05 = new SwimmerRecordDto(FEMALE, STROKETYPE, 394);
        public SwimmerRecordDto adrianaAlbergrid_ds06 = new SwimmerRecordDto(FEMALE, STROKETYPE, 429);
        public SwimmerRecordDto adrianaAlbergrid_ds07 = new SwimmerRecordDto(FEMALE, STROKETYPE, 391);
        public SwimmerRecordDto adrianaAlbergrid_ds08 = new SwimmerRecordDto(FEMALE, STROKETYPE, 421);
        public SwimmerRecordDto adrianaAlbergrid_ds09 = new SwimmerRecordDto(FEMALE, STROKETYPE, 442);
        public SwimmerRecordDto adrianaAlbergrid_ds10 = new SwimmerRecordDto(FEMALE, STROKETYPE, 376);

        //Swimmer: Janelle Tinker Distance: 50m Gender: Female
        public SwimmerRecordDto janelleTinker_ds01 = new SwimmerRecordDto(FEMALE, STROKETYPE, 291);
        public SwimmerRecordDto janelleTinker_ds02 = new SwimmerRecordDto(FEMALE, STROKETYPE, 403);
        public SwimmerRecordDto janelleTinker_ds03 = new SwimmerRecordDto(FEMALE, STROKETYPE, 4);
        public SwimmerRecordDto janelleTinker_ds04 = new SwimmerRecordDto(FEMALE, STROKETYPE, 327);
        public SwimmerRecordDto janelleTinker_ds05 = new SwimmerRecordDto(FEMALE, STROKETYPE, 288);
        public SwimmerRecordDto janelleTinker_ds06 = new SwimmerRecordDto(FEMALE, STROKETYPE, 345);
        public SwimmerRecordDto janelleTinker_ds07 = new SwimmerRecordDto(FEMALE, STROKETYPE, 355);
        public SwimmerRecordDto janelleTinker_ds08 = new SwimmerRecordDto(FEMALE, STROKETYPE, 376);
        public SwimmerRecordDto janelleTinker_ds09 = new SwimmerRecordDto(FEMALE, STROKETYPE, 307);
        public SwimmerRecordDto janelleTinker_ds10 = new SwimmerRecordDto(FEMALE, STROKETYPE, 329);

        //Swimmer: Mary Fisher Distance: 50m Gender: Female
        public SwimmerRecordDto jenniZhang_ds01 = new SwimmerRecordDto(FEMALE, STROKETYPE, 433);
        public SwimmerRecordDto jenniZhang_ds02 = new SwimmerRecordDto(FEMALE, STROKETYPE, 415);
        public SwimmerRecordDto jenniZhang_ds03 = new SwimmerRecordDto(FEMALE, STROKETYPE, 353);
        public SwimmerRecordDto jenniZhang_ds04 = new SwimmerRecordDto(FEMALE, STROKETYPE, 374);
        public SwimmerRecordDto jenniZhang_ds05 = new SwimmerRecordDto(FEMALE, STROKETYPE, 396);
        public SwimmerRecordDto jenniZhang_ds06 = new SwimmerRecordDto(FEMALE, STROKETYPE, 385);
        public SwimmerRecordDto jenniZhang_ds07 = new SwimmerRecordDto(FEMALE, STROKETYPE, 408);
        public SwimmerRecordDto jenniZhang_ds08 = new SwimmerRecordDto(FEMALE, STROKETYPE, 400);
        public SwimmerRecordDto jenniZhang_ds09 = new SwimmerRecordDto(FEMALE, STROKETYPE, 414);
        public SwimmerRecordDto jenniZhang_ds10 = new SwimmerRecordDto(FEMALE, STROKETYPE, 396);


        public SwimmerRecordDto[] GetDataSets()
        {
            SwimmerRecordDto[] dataSet = {danekSheppard_ds01, danekSheppard_ds02, danekSheppard_ds03, danekSheppard_ds04, danekSheppard_ds05, danekSheppard_ds06, danekSheppard_ds07, danekSheppard_ds08, danekSheppard_ds09, danekSheppard_ds10,
            brianaGerrig_ds01, brianaGerrig_ds02, brianaGerrig_ds03, brianaGerrig_ds04, brianaGerrig_ds05, brianaGerrig_ds06, brianaGerrig_ds07, brianaGerrig_ds08, brianaGerrig_ds09, brianaGerrig_ds10,
            adrianaAlbergrid_ds01, adrianaAlbergrid_ds02, adrianaAlbergrid_ds03, adrianaAlbergrid_ds04, adrianaAlbergrid_ds05, adrianaAlbergrid_ds06, adrianaAlbergrid_ds07, adrianaAlbergrid_ds08, adrianaAlbergrid_ds09, adrianaAlbergrid_ds10,
            janelleTinker_ds01, janelleTinker_ds02, janelleTinker_ds03, janelleTinker_ds04,janelleTinker_ds05,janelleTinker_ds06,janelleTinker_ds07,janelleTinker_ds08,janelleTinker_ds09,janelleTinker_ds10,
            jenniZhang_ds01, jenniZhang_ds02,jenniZhang_ds03, jenniZhang_ds04,jenniZhang_ds05,jenniZhang_ds06,jenniZhang_ds07,jenniZhang_ds08,jenniZhang_ds09,jenniZhang_ds10};

            return dataSet;
        }
    }
}
