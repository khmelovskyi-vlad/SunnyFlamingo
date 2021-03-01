using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OfficeOpenXml;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Extensions;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Creators
{
    public class ExcelGoodsMaster : IExcelGoodsMaster
    {
        private readonly ApplicationDbContext _context;
        private readonly NewGoodsExcelPathOption _newGoodsExcelPath;
        public ExcelGoodsMaster(ApplicationDbContext context, IOptions<NewGoodsExcelPathOption> newGoodsExcelPath)
        {
            _context = context;
            _newGoodsExcelPath = newGoodsExcelPath.Value;
        }
        public async Task<int> AddGoods()
        {
            try
            {
                var dtDestination = GetDataTable();
                var dtSource = _context.GetDataTable("[dbo].[Goods]");
                using (var bulkCopy = new SqlBulkCopy(_context.Database.GetDbConnection().ConnectionString))
                {
                    CreateColumnMappings(bulkCopy, dtDestination, dtSource);
                    bulkCopy.DestinationTableName = "Goods";
                    await bulkCopy.WriteToServerAsync(dtDestination);
                }
                return 1;
            }
            catch (Exception)
            {
                return 2;
            }
        }
        private void CreateColumnMappings(SqlBulkCopy bulkCopy, DataTable dtDestination, DataTable dtSource)
        {
            for (int i = 0; i < dtDestination.Columns.Count; i++)
            {
                string destinationColumnName = dtDestination.Columns[i].ToString();
                if (dtSource.Columns.Contains(destinationColumnName))
                {
                    int sourceColumnIndex = dtSource.Columns.IndexOf(destinationColumnName);
                    string sourceColumnName = dtSource.Columns[sourceColumnIndex].ToString();
                    bulkCopy.ColumnMappings.Add(sourceColumnName, destinationColumnName);
                }
            }
        }
        private DataTable GetDataTable()
        {
            using (var package = new ExcelPackage(new FileInfo(_newGoodsExcelPath.Path)))
            {
                return ExcelPackageToDataTable(package);
            }
        }
        public DataTable ExcelPackageToDataTable(ExcelPackage excelPackage)
        {
            var dt = new DataTable();
            var worksheet = excelPackage.Workbook.Worksheets[0];
            if (worksheet.Dimension == null)
            {
                return dt;
            }
            var columnNames = new List<string>();
            var currentColumn = 1;
            foreach (var cell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
            {
                string columnName = cell.Text.Trim();
                if (cell.Start.Column != currentColumn)
                {
                    columnNames.Add("Header_" + currentColumn);
                    dt.Columns.Add("Header_" + currentColumn);
                    currentColumn++;
                }
                columnNames.Add(columnName);
                int occurrences = columnNames.Count(x => x.Equals(columnName));
                if (occurrences > 1)
                {
                    columnName = columnName + "_" + occurrences;
                }
                if (columnName.Contains("Id"))
                {
                    dt.Columns.Add(new DataColumn(columnName, typeof(Guid)));
                }
                else
                {
                    dt.Columns.Add(columnName);
                }
                currentColumn++;
            }
            var idColumnName = "Id";
            var addTimeColumnName = "AddTime";
            dt.Columns.Add(new DataColumn(idColumnName, typeof(Guid)));
            dt.Columns.Add(addTimeColumnName);
            for (int i = 2; i <= worksheet.Dimension.End.Row; i++)
            {
                var row = worksheet.Cells[i, 1, i, worksheet.Dimension.End.Column];
                var newRow = dt.NewRow();
                foreach (var cell in row)
                {
                    newRow[cell.Start.Column - 1] = cell.Value;
                }
                if (!(newRow.ItemArray.Length == newRow.ItemArray.Where(item => item.ToString() == "").Count()))
                {
                    newRow[idColumnName] = Guid.NewGuid();
                    newRow[addTimeColumnName] = DateTime.Now;
                    dt.Rows.Add(newRow);
                }
            }

            return dt;
        }
    }
}
