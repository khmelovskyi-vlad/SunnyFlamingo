using Microsoft.Data.SqlClient;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IParametersCreator
    {
        SqlParameter CreateDiscriminatorParameter<T>();
        List<SqlParameter> GetGoodsParameters(GoodsSelector goodsSelector);
        List<SqlParameter> GetComputerTechnologiesParameters(ComputerTechnologiesSelector computerTechnologiesSelector);
        List<SqlParameter> GetLaptopsParameters(LaptopsSelector laptopsSelector);
        List<SqlParameter> GetComputersParameters(ComputersSelector computersSelector);
        List<SqlParameter> GetComputerAccessoriesParameters(ComputerAccessoriesSelector computerAccessoriesSelector);
        List<SqlParameter> GetComputerPartsParameters(ComputerPartsSelector computerPartsSelector);
        List<SqlParameter> GetFlashDrivesParameters(FlashDrivesSelector flashDrivesSelector);
        List<SqlParameter> GetVideoCardsParameters(VideoCardsSelector videoCardsSelector);
        List<SqlParameter> GetCPUsParameters(CPUsSelector cpusSelector);
        List<SqlParameter> GetCoolersParameters(CoolersSelector coolersSelector);
        List<SqlParameter> GetComputerDrivesParameters(ComputerDrivesSelector computerDrivesSelector);
        List<SqlParameter> GetMiceParameters(MiceSelector miceSelector);
        List<SqlParameter> GetKeyboardsParameters(KeyboardsSelector keyboardsSelector);
        List<SqlParameter> GetHeadphonesParameters(HeadphonesSelector HeadphonesSelector);
    }
}
