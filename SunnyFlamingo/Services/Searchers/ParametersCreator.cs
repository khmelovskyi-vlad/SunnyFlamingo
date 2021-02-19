using Microsoft.Data.SqlClient;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class ParametersCreator : IParametersCreator
    {
        public SqlParameter CreateDiscriminatorParameter<T>()
        {
            var discriminators = AppDomain.CurrentDomain.GetAssemblies()
                       .SelectMany(assembly => assembly.GetTypes())
                       .Where(type => type.IsSubclassOf(typeof(T)) || type.IsEquivalentTo(typeof(T)))
                       .Select(type => type.Name)
                       .ToArray();
            return CreateStringListParameter("@discriminators", CreateStringListTable(discriminators));
        }
        public List<SqlParameter> GetGoodsParameters(GoodsSelector goodsSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (goodsSelector.Producers != null)
            {
                sqlParameters.Add(CreateProducerParameter(goodsSelector.Producers));
            }
            if (goodsSelector.Countries != null)
            {
                sqlParameters.Add(CreateCountryParameter(goodsSelector.Countries));
            }
            if (goodsSelector.Materials != null)
            {
                sqlParameters.Add(CreateMaterialParameter(goodsSelector.Materials));
            }
            if (goodsSelector.Colors != null)
            {
                sqlParameters.Add(CreateColorParameter(goodsSelector.Colors));
            }
            if (goodsSelector.PriceFrom != null)
            {
                sqlParameters.Add(CreatePriceFromParameter(goodsSelector.PriceFrom));
            }
            if (goodsSelector.PriceTo != null)
            {
                sqlParameters.Add(CreatePriceToParameter(goodsSelector.PriceTo));
            }
            sqlParameters.AddRange(CreateFromToParameters(goodsSelector.Page, goodsSelector.ShowGoods));
            sqlParameters.Add(CreateOrderTypeParameter(goodsSelector.OrderType));
            sqlParameters.Add(CreateSortDirParameter(goodsSelector.SortDir));
            sqlParameters.Add(CreateCountParameter());
            return sqlParameters;
        }
        public List<SqlParameter> GetComputerTechnologiesParameters(ComputerTechnologiesSelector computerTechnologiesSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.AddRange(GetGoodsParameters(computerTechnologiesSelector));
            return sqlParameters;
        }
        public List<SqlParameter> GetLaptopsParameters(LaptopsSelector laptopsSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.AddRange(GetComputerTechnologiesParameters(laptopsSelector));
            if (laptopsSelector.AmountOfRAMs != null)
            {
                sqlParameters.Add(CreateAmountOfRAMParameter(laptopsSelector.AmountOfRAMs));
            }
            if (laptopsSelector.CPUFrequencies != null)
            {
                sqlParameters.Add(CreateCpuFrequenciesParameter(laptopsSelector.CPUFrequencies));
            }
            if (laptopsSelector.Length != null)
            {
                sqlParameters.Add(CreateLengthParameter(laptopsSelector.Length));
            }
            if (laptopsSelector.Height != null)
            {
                sqlParameters.Add(CreateHeightParameter(laptopsSelector.Height));
            }
            if (laptopsSelector.Width != null)
            {
                sqlParameters.Add(CreateWidthParameter(laptopsSelector.Width));
            }
            if (laptopsSelector.HaveFloppyDrives != null)
            {
                sqlParameters.Add(CreateHaveFloppyDrivesParameter(laptopsSelector.HaveFloppyDrives));
            }
            if (laptopsSelector.SSDMemory != null)
            {
                sqlParameters.Add(CreateSSDMemoryParameter(laptopsSelector.SSDMemory));
            }
            if (laptopsSelector.HardDiskMemory != null)
            {
                sqlParameters.Add(CreateHardDiskMemoryParameter(laptopsSelector.HardDiskMemory));
            }
            if (laptopsSelector.CPUSocketTypes != null)
            {
                sqlParameters.Add(CreateCPUSocketTypesParameter(laptopsSelector.CPUSocketTypes));
            }
            if (laptopsSelector.ComputerDriveTypes != null)
            {
                sqlParameters.Add(CreateComputerDriveTypesParameter(laptopsSelector.ComputerDriveTypes));
            }
            if (laptopsSelector.NumberOfCores != null)
            {
                sqlParameters.Add(CreateNumberOfCoresParameter(laptopsSelector.NumberOfCores));
            }
            if (laptopsSelector.FloppyDrivesCount != null && (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(true)))
            {
                sqlParameters.Add(CreateFloppyDrivesCountParameter(laptopsSelector.FloppyDrivesCount));
            }
            if (laptopsSelector.Displays != null)
            {
                sqlParameters.Add(CreateDisplaysParameter(laptopsSelector.Displays));
            }
            return sqlParameters;
        }
        public List<SqlParameter> GetComputersParameters(ComputersSelector computersSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.AddRange(GetComputerTechnologiesParameters(computersSelector));
            if (computersSelector.AmountOfRAMs != null)
            {
                sqlParameters.Add(CreateAmountOfRAMParameter(computersSelector.AmountOfRAMs));
            }
            if (computersSelector.CPUFrequencies != null)
            {
                sqlParameters.Add(CreateCpuFrequenciesParameter(computersSelector.CPUFrequencies));
            }
            if (computersSelector.Length != null)
            {
                sqlParameters.Add(CreateLengthParameter(computersSelector.Length));
            }
            if (computersSelector.Height != null)
            {
                sqlParameters.Add(CreateHeightParameter(computersSelector.Height));
            }
            if (computersSelector.Width != null)
            {
                sqlParameters.Add(CreateWidthParameter(computersSelector.Width));
            }
            if (computersSelector.HaveFloppyDrives != null)
            {
                sqlParameters.Add(CreateHaveFloppyDrivesParameter(computersSelector.HaveFloppyDrives));
            }
            if (computersSelector.SSDMemory != null)
            {
                sqlParameters.Add(CreateSSDMemoryParameter(computersSelector.SSDMemory));
            }
            if (computersSelector.HardDiskMemory != null)
            {
                sqlParameters.Add(CreateHardDiskMemoryParameter(computersSelector.HardDiskMemory));
            }
            if (computersSelector.CPUSocketTypes != null)
            {
                sqlParameters.Add(CreateCPUSocketTypesParameter(computersSelector.CPUSocketTypes));
            }
            if (computersSelector.ComputerDriveTypes != null)
            {
                sqlParameters.Add(CreateComputerDriveTypesParameter(computersSelector.ComputerDriveTypes));
            }
            if (computersSelector.NumberOfCores != null)
            {
                sqlParameters.Add(CreateNumberOfCoresParameter(computersSelector.NumberOfCores));
            }
            if (computersSelector.FloppyDrivesCount != null && (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(true)))
            {
                sqlParameters.Add(CreateFloppyDrivesCountParameter(computersSelector.FloppyDrivesCount));
            }
            return sqlParameters;
        }
        public List<SqlParameter> GetComputerAccessoriesParameters(ComputerAccessoriesSelector computerAccessoriesSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.AddRange(GetComputerTechnologiesParameters(computerAccessoriesSelector));
            return sqlParameters;
        }
        public List<SqlParameter> GetComputerPartsParameters(ComputerPartsSelector computerPartsSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.AddRange(GetComputerTechnologiesParameters(computerPartsSelector));
            return sqlParameters;
        }
        public List<SqlParameter> GetFlashDrivesParameters(FlashDrivesSelector flashDrivesSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.AddRange(GetComputerTechnologiesParameters(flashDrivesSelector));
            if (flashDrivesSelector.Capacities != null)
            {
                sqlParameters.Add(CreateCapacitiesParameter(flashDrivesSelector.Capacities));
            }
            if (flashDrivesSelector.USBSpecificationTypes != null)
            {
                sqlParameters.Add(CreateUSBSpecificationTypesParameter(flashDrivesSelector.USBSpecificationTypes));
            }
            return sqlParameters;
        }
        public List<SqlParameter> GetVideoCardsParameters(VideoCardsSelector videoCardsSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.AddRange(GetComputerPartsParameters(videoCardsSelector));
            if (videoCardsSelector.DriveInterfaces != null)
            {
                sqlParameters.Add(CreateDriveInterfacesParameter(videoCardsSelector.DriveInterfaces));
            }
            if (videoCardsSelector.VideoSizes != null)
            {
                sqlParameters.Add(CreateVideoSizesParameter(videoCardsSelector.VideoSizes));
            }
            if (videoCardsSelector.VideoMemoryCapacities != null)
            {
                sqlParameters.Add(CreateVideoMemoryCapacitiesParameter(videoCardsSelector.VideoMemoryCapacities));
            }
            return sqlParameters;
        }
        public List<SqlParameter> GetCPUsParameters(CPUsSelector cpusSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.AddRange(GetComputerPartsParameters(cpusSelector));
            if (cpusSelector.CPUSocketTypes != null)
            {
                sqlParameters.Add(CreateCPUSocketTypesParameter(cpusSelector.CPUSocketTypes));
            }
            if (cpusSelector.ThermalDesignPowers != null)
            {
                sqlParameters.Add(CreateThermalDesignPowersParameter(cpusSelector.ThermalDesignPowers));
            }
            if (cpusSelector.NumberOfCores != null)
            {
                sqlParameters.Add(CreateNumberOfCoresParameter(cpusSelector.NumberOfCores));
            }
            if (cpusSelector.NumberOfThreads != null)
            {
                sqlParameters.Add(CreateNumberOfThreadsParameter(cpusSelector.NumberOfThreads));
            }
            return sqlParameters;
        }
        public List<SqlParameter> GetCoolersParameters(CoolersSelector coolersSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.AddRange(GetComputerPartsParameters(coolersSelector));
            if (coolersSelector.Types != null)
            {
                sqlParameters.Add(CreateCoolerTypesParameter(coolersSelector.Types));
            }
            if (coolersSelector.FanSizes != null)
            {
                sqlParameters.Add(CreateFanSizesParameter(coolersSelector.FanSizes));
            }
            return sqlParameters;
        }
        public List<SqlParameter> GetComputerDrivesParameters(ComputerDrivesSelector computerDrivesSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.AddRange(GetComputerPartsParameters(computerDrivesSelector));
            if (computerDrivesSelector.Capacities != null)
            {
                sqlParameters.Add(CreateCapacitiesParameter(computerDrivesSelector.Capacities));
            }
            if (computerDrivesSelector.Types != null)
            {
                sqlParameters.Add(CreateComputerDriveTypesParameter(computerDrivesSelector.Types));
            }
            if (computerDrivesSelector.FormFactorTypes != null)
            {
                sqlParameters.Add(CreateFormFactorTypesParameter(computerDrivesSelector.FormFactorTypes));
            }
            return sqlParameters;
        }
        public List<SqlParameter> GetMiceParameters(MiceSelector miceSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.AddRange(GetComputerAccessoriesParameters(miceSelector));
            if (miceSelector.Types != null)
            {
                sqlParameters.Add(CreateMauseTypesParameter(miceSelector.Types));
            }
            if (miceSelector.ButtonsCount != null)
            {
                sqlParameters.Add(CreateButtonsCountParameter(miceSelector.ButtonsCount));
            }
            return sqlParameters;
        }
        public List<SqlParameter> GetKeyboardsParameters(KeyboardsSelector keyboardsSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.AddRange(GetComputerAccessoriesParameters(keyboardsSelector));
            if (keyboardsSelector.Types != null)
            {
                sqlParameters.Add(CreateKeyboardTypesParameter(keyboardsSelector.Types));
            }
            return sqlParameters;
        }
        public List<SqlParameter> GetHeadphonesParameters(HeadphonesSelector HeadphonesSelector)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.AddRange(GetComputerAccessoriesParameters(HeadphonesSelector));
            if (HeadphonesSelector.Types != null)
            {
                sqlParameters.Add(CreateHeadphonesTypesParameter(HeadphonesSelector.Types));
            }
            if (HeadphonesSelector.WirelessTypes != null)
            {
                sqlParameters.Add(CreateWirelessTypesParameter(HeadphonesSelector.WirelessTypes));
            }
            if (HeadphonesSelector.ConnectorTypes != null)
            {
                sqlParameters.Add(CreateConnectorTypesParameter(HeadphonesSelector.ConnectorTypes));
            }
            return sqlParameters;
        }



        private SqlParameter CreateConnectorTypesParameter(string[] connectorTypes)
        {
            return CreateStringListParameter("@connectorType", CreateStringListTable(connectorTypes));
        }
        private SqlParameter CreateWirelessTypesParameter(string[] wirelessTypes)
        {
            return CreateStringListParameter("@wirelessType", CreateStringListTable(wirelessTypes));
        }
        private SqlParameter CreateHeadphonesTypesParameter(string[] headphonesTypes)
        {
            return CreateStringListParameter("@headphonesType", CreateStringListTable(headphonesTypes));
        }
        private SqlParameter CreateKeyboardTypesParameter(string[] keyboardTypes)
        {
            return CreateStringListParameter("@keyboardType", CreateStringListTable(keyboardTypes));
        }
        private SqlParameter CreateButtonsCountParameter(int[] buttonsCount)
        {
            return CreateIntListParameter("@buttonsCount", CreateIntListTable(buttonsCount));
        }
        private SqlParameter CreateMauseTypesParameter(string[] mauseTypes)
        {
            return CreateStringListParameter("@mauseType", CreateStringListTable(mauseTypes));
        }
        private SqlParameter CreateFormFactorTypesParameter(string[] formFactorTypes)
        {
            return CreateStringListParameter("@formFactorType", CreateStringListTable(formFactorTypes));
        }
        private SqlParameter CreateFanSizesParameter(int[] fanSizes)
        {
            return CreateIntListParameter("@fanSize", CreateIntListTable(fanSizes));
        }
        private SqlParameter CreateCoolerTypesParameter(string[] coolerTypes)
        {
            return CreateStringListParameter("@coolerType", CreateStringListTable(coolerTypes));
        }
        private SqlParameter CreateNumberOfThreadsParameter(int[] numberOfThreads)
        {
            return CreateIntListParameter("@numberOfThreads", CreateIntListTable(numberOfThreads));
        }
        private SqlParameter CreateThermalDesignPowersParameter(int[] thermalDesignPowers)
        {
            return CreateIntListParameter("@thermalDesignPower", CreateIntListTable(thermalDesignPowers));
        }
        private SqlParameter CreateVideoMemoryCapacitiesParameter(int[] videoMemoryCapacities)
        {
            return CreateIntListParameter("@videoMemoryCapacity", CreateIntListTable(videoMemoryCapacities));
        }
        private SqlParameter CreateVideoSizesParameter(int[] videoSizes)
        {
            return CreateIntListParameter("@videoSize", CreateIntListTable(videoSizes));
        }
        private SqlParameter CreateDriveInterfacesParameter(string[] driveInterfaces)
        {
            return CreateStringListParameter("@driveInterface", CreateStringListTable(driveInterfaces));
        }
        private SqlParameter CreateCapacitiesParameter(int[] capacities)
        {
            return CreateIntListParameter("@capacity", CreateIntListTable(capacities));
        }
        private SqlParameter CreateUSBSpecificationTypesParameter(string[] usbSpecificationTypes)
        {
            return CreateStringListParameter("@usbSpecificationType", CreateStringListTable(usbSpecificationTypes));
        }
        private SqlParameter CreateAmountOfRAMParameter(int[] amountOfRAM)
        {
            return CreateIntListParameter("@amountOfRAM", CreateIntListTable(amountOfRAM));
        }

        private SqlParameter CreateCpuFrequenciesParameter(int[] cpuFrequencies)
        {
            return CreateIntListParameter("@cpuFrequency", CreateIntListTable(cpuFrequencies));
        }
        private SqlParameter CreateLengthParameter(float[] length)
        {
            return CreateRealListParameter("@length", CreateRealListTable(length));
        }
        private SqlParameter CreateHeightParameter(float[] height)
        {
            return CreateRealListParameter("@height", CreateRealListTable(height));
        }
        private SqlParameter CreateWidthParameter(float[] width)
        {
            return CreateRealListParameter("@width", CreateRealListTable(width));
        }
        private SqlParameter CreateHaveFloppyDrivesParameter(bool[] haveFloppyDrives)
        {
            return CreateBoolListParameter("@haveFloppyDrives", CreateBoolListTable(haveFloppyDrives));
        }
        private SqlParameter CreateSSDMemoryParameter(int?[] ssdMemory)
        {
            return CreateIntListParameter("@ssdMemory", CreateIntListTable(ssdMemory));
        }
        private SqlParameter CreateHardDiskMemoryParameter(int?[] hardDiskMemory)
        {
            return CreateIntListParameter("@hardDiskMemory", CreateIntListTable(hardDiskMemory));
        }
        private SqlParameter CreateCPUSocketTypesParameter(string[] cpuSocketTypes)
        {
            return CreateStringListParameter("@cpuSocketType", CreateStringListTable(cpuSocketTypes));
        }
        private SqlParameter CreateComputerDriveTypesParameter(string[] computerDriveTypes)
        {
            return CreateStringListParameter("@computerDriveType", CreateStringListTable(computerDriveTypes));
        }
        private SqlParameter CreateNumberOfCoresParameter(int[] numberOfCores)
        {
            return CreateIntListParameter("@numberOfCores", CreateIntListTable(numberOfCores));
        }
        private SqlParameter CreateFloppyDrivesCountParameter(int?[] floppyDrivesCount)
        {
            return CreateIntListParameter("@floppyDrivesCount", CreateIntListTable(floppyDrivesCount));
        }
        private SqlParameter CreateDisplaysParameter(int[] displays)
        {
            return CreateIntListParameter("@displays", CreateIntListTable(displays));
        }




        private SqlParameter CreateCountParameter()
        {
            return new SqlParameter() { ParameterName = "@count", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
        }
        private SqlParameter CreateProducerParameter(string[] producers)
        {
            return CreateStringListParameter("@producers", CreateStringListTable(producers));
        }
        private SqlParameter CreateCountryParameter(string[] countries)
        {
            return CreateStringListParameter("@countries", CreateStringListTable(countries));
        }
        private SqlParameter CreateMaterialParameter(string[] material)
        {
            return CreateStringListParameter("@materials", CreateStringListTable(material));
        }
        private SqlParameter CreateColorParameter(string[] colors)
        {
            return CreateStringListParameter("@colors", CreateStringListTable(colors));
        }
        private SqlParameter[] CreateFromToParameters(int page, int showGoods)
        {
            if (page < 1)
            {
                page = 1;
            }
            if (showGoods < 36)
            {
                showGoods = 36;
            }
            if (showGoods > 36 * 3)
            {
                showGoods = 36 * 3;
            }
            var asd = new SqlParameter[] {
                new SqlParameter("@from", (page - 1) * showGoods) { SqlDbType = SqlDbType.Int },
                new SqlParameter("@to", page * showGoods) { SqlDbType = SqlDbType.Int },
            };
            return new SqlParameter[] {
                new SqlParameter("@from", (page - 1) * showGoods) { SqlDbType = SqlDbType.Int },
                new SqlParameter("@to", showGoods) { SqlDbType = SqlDbType.Int },
            };
        }
        private SqlParameter CreateOrderTypeParameter(OrderType orderType)
        {
            return new SqlParameter("@orderType", orderType.ToString()) { SqlDbType = SqlDbType.NVarChar };
        }
        private SqlParameter CreateSortDirParameter(SortDir sortDir)
        {
            return new SqlParameter("@sortDir", sortDir.ToString()) { SqlDbType = SqlDbType.NVarChar };
        }
        private SqlParameter CreatePriceFromParameter(decimal? priceFrom)
        {
            return new SqlParameter("@priceFrom", priceFrom) { SqlDbType = SqlDbType.Decimal, Precision = 18, Scale = 6 };
        }
        private SqlParameter CreatePriceToParameter(decimal? priceTo)
        {
            return new SqlParameter("@priceTo", priceTo) { SqlDbType = SqlDbType.Decimal, Precision = 18, Scale = 6 };
        }









        private SqlParameter CreateStringListParameter(string parameterName, DataTable table)
        {
            return new SqlParameter(parameterName, table) { SqlDbType = SqlDbType.Structured, TypeName = "[dbo].StringList" };
        }
        private SqlParameter CreateIntListParameter(string parameterName, DataTable table)
        {
            return new SqlParameter(parameterName, table) { SqlDbType = SqlDbType.Structured, TypeName = "[dbo].IntList" };
        }
        private SqlParameter CreateBoolListParameter(string parameterName, DataTable table)
        {
            return new SqlParameter(parameterName, table) { SqlDbType = SqlDbType.Structured, TypeName = "[dbo].BoolList" };
        }
        private SqlParameter CreateRealListParameter(string parameterName, DataTable table)
        {
            return new SqlParameter(parameterName, table) { SqlDbType = SqlDbType.Structured, TypeName = "[dbo].RealList" };
        }
        private DataTable CreateStringListTable(string[] data)
        {
            var table = new DataTable();
            var column = new DataColumn("Value", typeof(string));
            table.Columns.Add(column);
            foreach (var item in data)
            {
                var row = table.NewRow();
                row["Value"] = item;
                table.Rows.Add(row);
            }
            return table;
        }
        private DataTable CreateIntListTable(int?[] data)
        {
            var table = new DataTable();
            var column = new DataColumn("Value", typeof(int));
            table.Columns.Add(column);
            foreach (var item in data)
            {
                var row = table.NewRow();
                row["Value"] = item;
                table.Rows.Add(row);
            }
            return table;
        }
        private DataTable CreateIntListTable(int[] data)
        {
            var table = new DataTable();
            var column = new DataColumn("Value", typeof(int));
            table.Columns.Add(column);
            foreach (var item in data)
            {
                var row = table.NewRow();
                row["Value"] = item;
                table.Rows.Add(row);
            }
            return table;
        }
        private DataTable CreateBoolListTable(bool?[] data)
        {
            var table = new DataTable();
            var column = new DataColumn("Value", typeof(bool));
            table.Columns.Add(column);
            foreach (var item in data)
            {
                var row = table.NewRow();
                row["Value"] = item;
                table.Rows.Add(row);
            }
            return table;
        }
        private DataTable CreateBoolListTable(bool[] data)
        {
            var table = new DataTable();
            var column = new DataColumn("Value", typeof(bool));
            table.Columns.Add(column);
            foreach (var item in data)
            {
                var row = table.NewRow();
                row["Value"] = item;
                table.Rows.Add(row);
            }
            return table;
        }
        private DataTable CreateRealListTable(float?[] data)
        {
            var table = new DataTable();
            var column = new DataColumn("Value", typeof(float));
            table.Columns.Add(column);
            foreach (var item in data)
            {
                var row = table.NewRow();
                row["Value"] = item;
                table.Rows.Add(row);
            }
            return table;
        }
        private DataTable CreateRealListTable(float[] data)
        {
            var table = new DataTable();
            var column = new DataColumn("Value", typeof(float));
            table.Columns.Add(column);
            foreach (var item in data)
            {
                var row = table.NewRow();
                row["Value"] = item;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
