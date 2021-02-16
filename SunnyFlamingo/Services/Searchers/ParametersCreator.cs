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
        public SqlParameter[] GetGoodsParameters(GoodsSelector goodsSelector)
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
            sqlParameters.Add(CreateFromParameter(goodsSelector.From));
            sqlParameters.Add(CreateToParameter(goodsSelector.To));
            sqlParameters.Add(CreateOrderTypeParameter(goodsSelector.OrderType));
            sqlParameters.Add(CreateSortDirParameter(goodsSelector.SortDir));
            sqlParameters.Add(CreateCountParameter());
            return sqlParameters.ToArray();
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
        private SqlParameter CreateFromParameter(int from)
        {
            return new SqlParameter("@from", from) { SqlDbType = SqlDbType.Int };
        }
        private SqlParameter CreateToParameter(int to)
        {
            return new SqlParameter("@to", to) { SqlDbType = SqlDbType.Int };
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
    }
}
