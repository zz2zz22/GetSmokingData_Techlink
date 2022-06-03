﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSmokingData_Techlink
{
    public class SmokingReport
    {
        public string PathSmokingReport = Environment.CurrentDirectory + @"\Resources\SmokingReportForm.xlsx";
        public string PathKitchenReport = Environment.CurrentDirectory + @"\Resources\KitchenReportForm.xlsx";

        public void ExportExcelSmokingReport(string PathSave, List<EmployeeSmoking> employeeSmoking)
        {
            ToolSupport toolSupport = new ToolSupport();
            toolSupport.ExportSmoking(employeeSmoking, PathSave, PathSmokingReport);
        }
        public void ExportExcelKitchenReport(string PathSave, List<KitchenEmployee> kitchenEmployees)
        {
            ToolSupport toolSupport = new ToolSupport();
            toolSupport.ExportKitchen(kitchenEmployees, PathSave, PathKitchenReport);
        }
    }
}

