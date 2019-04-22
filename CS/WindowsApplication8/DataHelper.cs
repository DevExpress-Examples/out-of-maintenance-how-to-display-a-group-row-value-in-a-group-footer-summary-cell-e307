using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApplication8
{
    class DataHelper
    {
        public static DataTable CreateTable()
        {
            DataTable table = new DataTable();
            DataRow dataRow;
            table.Columns.Add("OrderID", typeof(System.Int32));
            table.Columns.Add("CustomerID", typeof(System.String));
            table.Columns.Add("EmployeeID", typeof(System.Int32));
            table.Columns.Add("OrderDate", typeof(System.DateTime));
            table.Columns.Add("RequiredDate", typeof(System.DateTime));
            table.Columns.Add("Freight", typeof(System.Decimal));
            dataRow = table.NewRow();
            dataRow["OrderID"] = 10643;
            dataRow["CustomerID"] = "ALFKI";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("9/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/23/1995 12:00:00 AM");
            dataRow["Freight"] = 29.46;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10692;
            dataRow["CustomerID"] = "ALFKI";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("11/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/1/1995 12:00:00 AM");
            dataRow["Freight"] = 61.02;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10702;
            dataRow["CustomerID"] = "ALFKI";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("11/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/25/1995 12:00:00 AM");
            dataRow["Freight"] = 23.94;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10835;
            dataRow["CustomerID"] = "ALFKI";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("2/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/14/1996 12:00:00 AM");
            dataRow["Freight"] = 69.53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10952;
            dataRow["CustomerID"] = "ALFKI";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["Freight"] = 40.42;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11011;
            dataRow["CustomerID"] = "ALFKI";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/6/1996 12:00:00 AM");
            dataRow["Freight"] = 1.21;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10308;
            dataRow["CustomerID"] = "ANATR";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("10/19/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/16/1994 12:00:00 AM");
            dataRow["Freight"] = 1.61;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10625;
            dataRow["CustomerID"] = "ANATR";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("9/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/6/1995 12:00:00 AM");
            dataRow["Freight"] = 43.9;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10759;
            dataRow["CustomerID"] = "ANATR";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("12/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/26/1996 12:00:00 AM");
            dataRow["Freight"] = 11.99;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10926;
            dataRow["CustomerID"] = "ANATR";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["Freight"] = 39.92;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10365;
            dataRow["CustomerID"] = "ANTON";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("12/28/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/25/1995 12:00:00 AM");
            dataRow["Freight"] = 22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10507;
            dataRow["CustomerID"] = "ANTON";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/13/1995 12:00:00 AM");
            dataRow["Freight"] = 47.45;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10535;
            dataRow["CustomerID"] = "ANTON";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("6/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/11/1995 12:00:00 AM");
            dataRow["Freight"] = 15.64;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10573;
            dataRow["CustomerID"] = "ANTON";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("7/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/17/1995 12:00:00 AM");
            dataRow["Freight"] = 84.84;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10677;
            dataRow["CustomerID"] = "ANTON";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("10/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/20/1995 12:00:00 AM");
            dataRow["Freight"] = 4.03;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10682;
            dataRow["CustomerID"] = "ANTON";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("10/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/23/1995 12:00:00 AM");
            dataRow["Freight"] = 36.13;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10856;
            dataRow["CustomerID"] = "ANTON";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/27/1996 12:00:00 AM");
            dataRow["Freight"] = 58.43;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10355;
            dataRow["CustomerID"] = "AROUT";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("12/16/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/13/1995 12:00:00 AM");
            dataRow["Freight"] = 41.95;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10383;
            dataRow["CustomerID"] = "AROUT";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("1/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/13/1995 12:00:00 AM");
            dataRow["Freight"] = 34.24;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10453;
            dataRow["CustomerID"] = "AROUT";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("3/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/21/1995 12:00:00 AM");
            dataRow["Freight"] = 25.36;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10558;
            dataRow["CustomerID"] = "AROUT";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("7/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/2/1995 12:00:00 AM");
            dataRow["Freight"] = 72.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10707;
            dataRow["CustomerID"] = "AROUT";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("11/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/30/1995 12:00:00 AM");
            dataRow["Freight"] = 21.74;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10741;
            dataRow["CustomerID"] = "AROUT";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("12/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/29/1995 12:00:00 AM");
            dataRow["Freight"] = 10.96;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10743;
            dataRow["CustomerID"] = "AROUT";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("12/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/15/1996 12:00:00 AM");
            dataRow["Freight"] = 23.72;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10768;
            dataRow["CustomerID"] = "AROUT";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/5/1996 12:00:00 AM");
            dataRow["Freight"] = 146.32;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10793;
            dataRow["CustomerID"] = "AROUT";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/21/1996 12:00:00 AM");
            dataRow["Freight"] = 4.52;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10864;
            dataRow["CustomerID"] = "AROUT";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/1/1996 12:00:00 AM");
            dataRow["Freight"] = 3.04;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10920;
            dataRow["CustomerID"] = "AROUT";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/30/1996 12:00:00 AM");
            dataRow["Freight"] = 29.61;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10953;
            dataRow["CustomerID"] = "AROUT";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["Freight"] = 23.72;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11016;
            dataRow["CustomerID"] = "AROUT";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("5/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/7/1996 12:00:00 AM");
            dataRow["Freight"] = 33.8;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10278;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("9/12/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/10/1994 12:00:00 AM");
            dataRow["Freight"] = 92.69;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10280;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("9/14/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/12/1994 12:00:00 AM");
            dataRow["Freight"] = 8.98;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10384;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/13/1995 12:00:00 AM");
            dataRow["Freight"] = 168.64;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10444;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/12/1995 12:00:00 AM");
            dataRow["Freight"] = 3.5;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10445;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/13/1995 12:00:00 AM");
            dataRow["Freight"] = 9.3;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10524;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("6/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/29/1995 12:00:00 AM");
            dataRow["Freight"] = 244.79;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10572;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("7/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/16/1995 12:00:00 AM");
            dataRow["Freight"] = 116.43;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10626;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("9/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/9/1995 12:00:00 AM");
            dataRow["Freight"] = 138.69;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10654;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("10/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/31/1995 12:00:00 AM");
            dataRow["Freight"] = 55.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10672;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("10/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/1/1995 12:00:00 AM");
            dataRow["Freight"] = 95.75;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10689;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("11/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/29/1995 12:00:00 AM");
            dataRow["Freight"] = 13.42;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10733;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("12/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/5/1996 12:00:00 AM");
            dataRow["Freight"] = 110.11;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10778;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/13/1996 12:00:00 AM");
            dataRow["Freight"] = 6.79;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10837;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("2/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/15/1996 12:00:00 AM");
            dataRow["Freight"] = 13.32;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10857;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("2/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/27/1996 12:00:00 AM");
            dataRow["Freight"] = 188.85;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10866;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("3/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/2/1996 12:00:00 AM");
            dataRow["Freight"] = 109.11;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10875;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["Freight"] = 32.37;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10924;
            dataRow["CustomerID"] = "BERGS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["Freight"] = 151.52;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10501;
            dataRow["CustomerID"] = "BLAUS";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("5/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/7/1995 12:00:00 AM");
            dataRow["Freight"] = 8.85;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10509;
            dataRow["CustomerID"] = "BLAUS";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/15/1995 12:00:00 AM");
            dataRow["Freight"] = 0.15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10582;
            dataRow["CustomerID"] = "BLAUS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("7/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/25/1995 12:00:00 AM");
            dataRow["Freight"] = 27.71;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10614;
            dataRow["CustomerID"] = "BLAUS";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("8/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/26/1995 12:00:00 AM");
            dataRow["Freight"] = 1.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10853;
            dataRow["CustomerID"] = "BLAUS";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["Freight"] = 53.83;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10956;
            dataRow["CustomerID"] = "BLAUS";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("4/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["Freight"] = 44.65;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11058;
            dataRow["CustomerID"] = "BLAUS";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/26/1996 12:00:00 AM");
            dataRow["Freight"] = 31.14;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10265;
            dataRow["CustomerID"] = "BLONP";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("8/25/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/22/1994 12:00:00 AM");
            dataRow["Freight"] = 55.28;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10297;
            dataRow["CustomerID"] = "BLONP";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("10/5/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/16/1994 12:00:00 AM");
            dataRow["Freight"] = 5.74;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10360;
            dataRow["CustomerID"] = "BLONP";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("12/23/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/20/1995 12:00:00 AM");
            dataRow["Freight"] = 131.7;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10436;
            dataRow["CustomerID"] = "BLONP";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1995 12:00:00 AM");
            dataRow["Freight"] = 156.66;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10449;
            dataRow["CustomerID"] = "BLONP";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/18/1995 12:00:00 AM");
            dataRow["Freight"] = 53.3;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10559;
            dataRow["CustomerID"] = "BLONP";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("7/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/3/1995 12:00:00 AM");
            dataRow["Freight"] = 8.05;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10566;
            dataRow["CustomerID"] = "BLONP";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("7/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/10/1995 12:00:00 AM");
            dataRow["Freight"] = 88.4;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10584;
            dataRow["CustomerID"] = "BLONP";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("7/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/28/1995 12:00:00 AM");
            dataRow["Freight"] = 59.14;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10628;
            dataRow["CustomerID"] = "BLONP";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/10/1995 12:00:00 AM");
            dataRow["Freight"] = 30.36;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10679;
            dataRow["CustomerID"] = "BLONP";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("10/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/21/1995 12:00:00 AM");
            dataRow["Freight"] = 27.94;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10826;
            dataRow["CustomerID"] = "BLONP";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("2/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/11/1996 12:00:00 AM");
            dataRow["Freight"] = 7.09;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10326;
            dataRow["CustomerID"] = "BOLID";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("11/10/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/8/1994 12:00:00 AM");
            dataRow["Freight"] = 77.92;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10801;
            dataRow["CustomerID"] = "BOLID";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("1/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/26/1996 12:00:00 AM");
            dataRow["Freight"] = 97.09;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10970;
            dataRow["CustomerID"] = "BOLID";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/7/1996 12:00:00 AM");
            dataRow["Freight"] = 16.16;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10331;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("11/16/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/28/1994 12:00:00 AM");
            dataRow["Freight"] = 10.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10340;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("11/29/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/27/1994 12:00:00 AM");
            dataRow["Freight"] = 166.31;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10362;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("12/26/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/23/1995 12:00:00 AM");
            dataRow["Freight"] = 96.04;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10470;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/9/1995 12:00:00 AM");
            dataRow["Freight"] = 64.56;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10511;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/16/1995 12:00:00 AM");
            dataRow["Freight"] = 350.64;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10525;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("6/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/30/1995 12:00:00 AM");
            dataRow["Freight"] = 11.06;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10663;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("10/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/25/1995 12:00:00 AM");
            dataRow["Freight"] = 113.15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10715;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("11/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/7/1995 12:00:00 AM");
            dataRow["Freight"] = 63.2;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10730;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("12/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/3/1996 12:00:00 AM");
            dataRow["Freight"] = 20.12;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10732;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("12/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/4/1996 12:00:00 AM");
            dataRow["Freight"] = 16.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10755;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("12/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/24/1996 12:00:00 AM");
            dataRow["Freight"] = 16.71;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10827;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("2/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/26/1996 12:00:00 AM");
            dataRow["Freight"] = 63.54;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10871;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("3/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/4/1996 12:00:00 AM");
            dataRow["Freight"] = 112.27;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10876;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("3/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/8/1996 12:00:00 AM");
            dataRow["Freight"] = 60.42;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10932;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/3/1996 12:00:00 AM");
            dataRow["Freight"] = 134.64;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10940;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["Freight"] = 19.77;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11076;
            dataRow["CustomerID"] = "BONAP";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/3/1996 12:00:00 AM");
            dataRow["Freight"] = 38.28;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10389;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("1/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/17/1995 12:00:00 AM");
            dataRow["Freight"] = 47.42;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10410;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/10/1995 12:00:00 AM");
            dataRow["Freight"] = 2.4;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10411;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("2/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/10/1995 12:00:00 AM");
            dataRow["Freight"] = 23.65;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10431;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/16/1995 12:00:00 AM");
            dataRow["Freight"] = 44.17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10492;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/30/1995 12:00:00 AM");
            dataRow["Freight"] = 62.89;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10742;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("12/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/12/1996 12:00:00 AM");
            dataRow["Freight"] = 243.73;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10918;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["Freight"] = 48.83;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10944;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("4/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["Freight"] = 52.92;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10949;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("4/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/10/1996 12:00:00 AM");
            dataRow["Freight"] = 74.44;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10975;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/22/1996 12:00:00 AM");
            dataRow["Freight"] = 32.27;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10982;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["Freight"] = 14.01;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11027;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/13/1996 12:00:00 AM");
            dataRow["Freight"] = 52.52;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11045;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/20/1996 12:00:00 AM");
            dataRow["Freight"] = 70.58;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11048;
            dataRow["CustomerID"] = "BOTTM";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/21/1996 12:00:00 AM");
            dataRow["Freight"] = 24.12;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10289;
            dataRow["CustomerID"] = "BSBEV";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("9/26/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/24/1994 12:00:00 AM");
            dataRow["Freight"] = 22.77;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10471;
            dataRow["CustomerID"] = "BSBEV";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("4/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/9/1995 12:00:00 AM");
            dataRow["Freight"] = 45.59;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10484;
            dataRow["CustomerID"] = "BSBEV";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/22/1995 12:00:00 AM");
            dataRow["Freight"] = 6.88;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10538;
            dataRow["CustomerID"] = "BSBEV";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("6/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/13/1995 12:00:00 AM");
            dataRow["Freight"] = 4.87;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10539;
            dataRow["CustomerID"] = "BSBEV";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("6/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/14/1995 12:00:00 AM");
            dataRow["Freight"] = 12.36;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10578;
            dataRow["CustomerID"] = "BSBEV";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("7/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/22/1995 12:00:00 AM");
            dataRow["Freight"] = 29.6;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10599;
            dataRow["CustomerID"] = "BSBEV";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("8/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/26/1995 12:00:00 AM");
            dataRow["Freight"] = 29.98;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10943;
            dataRow["CustomerID"] = "BSBEV";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["Freight"] = 2.17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10947;
            dataRow["CustomerID"] = "BSBEV";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/10/1996 12:00:00 AM");
            dataRow["Freight"] = 3.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11023;
            dataRow["CustomerID"] = "BSBEV";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["Freight"] = 123.83;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10521;
            dataRow["CustomerID"] = "CACTU";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("5/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/27/1995 12:00:00 AM");
            dataRow["Freight"] = 17.22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10782;
            dataRow["CustomerID"] = "CACTU";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("1/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/14/1996 12:00:00 AM");
            dataRow["Freight"] = 1.1;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10819;
            dataRow["CustomerID"] = "CACTU";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("2/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["Freight"] = 19.76;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10881;
            dataRow["CustomerID"] = "CACTU";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["Freight"] = 2.84;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10937;
            dataRow["CustomerID"] = "CACTU";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("4/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["Freight"] = 31.51;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11054;
            dataRow["CustomerID"] = "CACTU";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/25/1996 12:00:00 AM");
            dataRow["Freight"] = 0.33;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10259;
            dataRow["CustomerID"] = "CENTC";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("8/18/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/15/1994 12:00:00 AM");
            dataRow["Freight"] = 3.25;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10254;
            dataRow["CustomerID"] = "CHOPS";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("8/11/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/8/1994 12:00:00 AM");
            dataRow["Freight"] = 22.98;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10370;
            dataRow["CustomerID"] = "CHOPS";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("1/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/31/1995 12:00:00 AM");
            dataRow["Freight"] = 1.17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10519;
            dataRow["CustomerID"] = "CHOPS";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("5/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/26/1995 12:00:00 AM");
            dataRow["Freight"] = 91.76;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10731;
            dataRow["CustomerID"] = "CHOPS";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("12/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/4/1996 12:00:00 AM");
            dataRow["Freight"] = 96.65;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10746;
            dataRow["CustomerID"] = "CHOPS";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("12/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/17/1996 12:00:00 AM");
            dataRow["Freight"] = 31.43;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10966;
            dataRow["CustomerID"] = "CHOPS";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["Freight"] = 27.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11029;
            dataRow["CustomerID"] = "CHOPS";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/13/1996 12:00:00 AM");
            dataRow["Freight"] = 47.84;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11041;
            dataRow["CustomerID"] = "CHOPS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/19/1996 12:00:00 AM");
            dataRow["Freight"] = 48.22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10290;
            dataRow["CustomerID"] = "COMMI";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("9/27/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/25/1994 12:00:00 AM");
            dataRow["Freight"] = 79.7;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10466;
            dataRow["CustomerID"] = "COMMI";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/4/1995 12:00:00 AM");
            dataRow["Freight"] = 11.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10494;
            dataRow["CustomerID"] = "COMMI";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/31/1995 12:00:00 AM");
            dataRow["Freight"] = 65.99;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10969;
            dataRow["CustomerID"] = "COMMI";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/20/1996 12:00:00 AM");
            dataRow["Freight"] = 0.21;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11042;
            dataRow["CustomerID"] = "COMMI";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["Freight"] = 29.99;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10435;
            dataRow["CustomerID"] = "CONSH";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("3/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/18/1995 12:00:00 AM");
            dataRow["Freight"] = 9.21;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10462;
            dataRow["CustomerID"] = "CONSH";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("4/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/1/1995 12:00:00 AM");
            dataRow["Freight"] = 6.17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10848;
            dataRow["CustomerID"] = "CONSH";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("2/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/22/1996 12:00:00 AM");
            dataRow["Freight"] = 38.24;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10363;
            dataRow["CustomerID"] = "DRACD";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("12/27/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/24/1995 12:00:00 AM");
            dataRow["Freight"] = 30.54;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10391;
            dataRow["CustomerID"] = "DRACD";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/20/1995 12:00:00 AM");
            dataRow["Freight"] = 5.45;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10797;
            dataRow["CustomerID"] = "DRACD";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("1/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/22/1996 12:00:00 AM");
            dataRow["Freight"] = 33.35;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10825;
            dataRow["CustomerID"] = "DRACD";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("2/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["Freight"] = 79.25;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11036;
            dataRow["CustomerID"] = "DRACD";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("5/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/17/1996 12:00:00 AM");
            dataRow["Freight"] = 149.47;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11067;
            dataRow["CustomerID"] = "DRACD";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/17/1996 12:00:00 AM");
            dataRow["Freight"] = 7.98;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10311;
            dataRow["CustomerID"] = "DUMON";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("10/21/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/4/1994 12:00:00 AM");
            dataRow["Freight"] = 24.69;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10609;
            dataRow["CustomerID"] = "DUMON";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("8/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/21/1995 12:00:00 AM");
            dataRow["Freight"] = 1.85;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10683;
            dataRow["CustomerID"] = "DUMON";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("10/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/24/1995 12:00:00 AM");
            dataRow["Freight"] = 4.4;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10890;
            dataRow["CustomerID"] = "DUMON";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("3/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["Freight"] = 32.76;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10364;
            dataRow["CustomerID"] = "EASTC";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("12/27/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/7/1995 12:00:00 AM");
            dataRow["Freight"] = 71.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10400;
            dataRow["CustomerID"] = "EASTC";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("2/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/1/1995 12:00:00 AM");
            dataRow["Freight"] = 83.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10532;
            dataRow["CustomerID"] = "EASTC";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("6/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/7/1995 12:00:00 AM");
            dataRow["Freight"] = 74.46;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10726;
            dataRow["CustomerID"] = "EASTC";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("12/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/18/1995 12:00:00 AM");
            dataRow["Freight"] = 16.56;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10987;
            dataRow["CustomerID"] = "EASTC";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["Freight"] = 185.48;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11024;
            dataRow["CustomerID"] = "EASTC";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/12/1996 12:00:00 AM");
            dataRow["Freight"] = 74.36;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11047;
            dataRow["CustomerID"] = "EASTC";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/21/1996 12:00:00 AM");
            dataRow["Freight"] = 46.62;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11056;
            dataRow["CustomerID"] = "EASTC";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/11/1996 12:00:00 AM");
            dataRow["Freight"] = 278.96;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10258;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("8/17/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/14/1994 12:00:00 AM");
            dataRow["Freight"] = 140.51;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10263;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("8/23/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/20/1994 12:00:00 AM");
            dataRow["Freight"] = 146.06;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10351;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("12/12/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/9/1995 12:00:00 AM");
            dataRow["Freight"] = 162.33;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10368;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("12/30/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/27/1995 12:00:00 AM");
            dataRow["Freight"] = 101.95;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10382;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("1/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/10/1995 12:00:00 AM");
            dataRow["Freight"] = 94.77;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10390;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("1/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/20/1995 12:00:00 AM");
            dataRow["Freight"] = 126.38;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10402;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("2/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/16/1995 12:00:00 AM");
            dataRow["Freight"] = 67.88;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10403;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("2/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/3/1995 12:00:00 AM");
            dataRow["Freight"] = 73.79;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10430;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/16/1995 12:00:00 AM");
            dataRow["Freight"] = 458.78;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10442;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/11/1995 12:00:00 AM");
            dataRow["Freight"] = 47.94;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10514;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/20/1995 12:00:00 AM");
            dataRow["Freight"] = 789.95;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10571;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("7/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/29/1995 12:00:00 AM");
            dataRow["Freight"] = 26.06;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10595;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("8/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/7/1995 12:00:00 AM");
            dataRow["Freight"] = 96.78;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10633;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("9/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/13/1995 12:00:00 AM");
            dataRow["Freight"] = 477.9;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10667;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("10/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/10/1995 12:00:00 AM");
            dataRow["Freight"] = 78.09;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10698;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("11/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/7/1995 12:00:00 AM");
            dataRow["Freight"] = 272.47;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10764;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("1/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/31/1996 12:00:00 AM");
            dataRow["Freight"] = 145.45;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10771;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("1/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/7/1996 12:00:00 AM");
            dataRow["Freight"] = 11.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10773;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/8/1996 12:00:00 AM");
            dataRow["Freight"] = 96.43;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10776;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/12/1996 12:00:00 AM");
            dataRow["Freight"] = 351.53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10795;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("1/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/21/1996 12:00:00 AM");
            dataRow["Freight"] = 126.66;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10836;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("2/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/15/1996 12:00:00 AM");
            dataRow["Freight"] = 411.88;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10854;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["Freight"] = 100.22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10895;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/17/1996 12:00:00 AM");
            dataRow["Freight"] = 162.75;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10968;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/20/1996 12:00:00 AM");
            dataRow["Freight"] = 74.6;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10979;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["Freight"] = 353.07;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10990;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/12/1996 12:00:00 AM");
            dataRow["Freight"] = 117.61;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11008;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["Freight"] = 79.46;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11017;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("5/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/10/1996 12:00:00 AM");
            dataRow["Freight"] = 754.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11072;
            dataRow["CustomerID"] = "ERNSH";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/2/1996 12:00:00 AM");
            dataRow["Freight"] = 258.64;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10347;
            dataRow["CustomerID"] = "FAMIA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("12/7/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/4/1995 12:00:00 AM");
            dataRow["Freight"] = 3.1;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10386;
            dataRow["CustomerID"] = "FAMIA";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("1/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/1/1995 12:00:00 AM");
            dataRow["Freight"] = 13.99;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10414;
            dataRow["CustomerID"] = "FAMIA";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("2/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/14/1995 12:00:00 AM");
            dataRow["Freight"] = 21.48;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10512;
            dataRow["CustomerID"] = "FAMIA";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/19/1995 12:00:00 AM");
            dataRow["Freight"] = 3.53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10581;
            dataRow["CustomerID"] = "FAMIA";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("7/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/24/1995 12:00:00 AM");
            dataRow["Freight"] = 3.01;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10650;
            dataRow["CustomerID"] = "FAMIA";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("9/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/27/1995 12:00:00 AM");
            dataRow["Freight"] = 176.81;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10725;
            dataRow["CustomerID"] = "FAMIA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("12/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/29/1995 12:00:00 AM");
            dataRow["Freight"] = 10.83;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10408;
            dataRow["CustomerID"] = "FOLIG";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("2/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/8/1995 12:00:00 AM");
            dataRow["Freight"] = 11.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10480;
            dataRow["CustomerID"] = "FOLIG";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("4/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/18/1995 12:00:00 AM");
            dataRow["Freight"] = 1.35;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10634;
            dataRow["CustomerID"] = "FOLIG";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/13/1995 12:00:00 AM");
            dataRow["Freight"] = 487.38;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10763;
            dataRow["CustomerID"] = "FOLIG";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/31/1996 12:00:00 AM");
            dataRow["Freight"] = 37.35;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10789;
            dataRow["CustomerID"] = "FOLIG";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/19/1996 12:00:00 AM");
            dataRow["Freight"] = 100.6;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10264;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("8/24/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/21/1994 12:00:00 AM");
            dataRow["Freight"] = 3.67;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10327;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("11/11/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/9/1994 12:00:00 AM");
            dataRow["Freight"] = 63.36;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10378;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("1/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/7/1995 12:00:00 AM");
            dataRow["Freight"] = 5.44;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10434;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/3/1995 12:00:00 AM");
            dataRow["Freight"] = 17.92;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10460;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("3/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/28/1995 12:00:00 AM");
            dataRow["Freight"] = 16.27;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10533;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("6/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/10/1995 12:00:00 AM");
            dataRow["Freight"] = 188.04;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10561;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("7/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/4/1995 12:00:00 AM");
            dataRow["Freight"] = 242.21;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10703;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("11/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/12/1995 12:00:00 AM");
            dataRow["Freight"] = 152.3;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10762;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/30/1996 12:00:00 AM");
            dataRow["Freight"] = 328.74;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10774;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("1/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/25/1996 12:00:00 AM");
            dataRow["Freight"] = 48.2;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10824;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("2/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["Freight"] = 1.23;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10880;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("3/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["Freight"] = 88.01;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10902;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("3/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/22/1996 12:00:00 AM");
            dataRow["Freight"] = 44.15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10955;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["Freight"] = 3.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10977;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["Freight"] = 208.5;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10980;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/7/1996 12:00:00 AM");
            dataRow["Freight"] = 1.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10993;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["Freight"] = 8.81;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11001;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["Freight"] = 197.3;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11050;
            dataRow["CustomerID"] = "FOLKO";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/24/1996 12:00:00 AM");
            dataRow["Freight"] = 59.41;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10267;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("8/29/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/26/1994 12:00:00 AM");
            dataRow["Freight"] = 208.58;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10337;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("11/24/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/22/1994 12:00:00 AM");
            dataRow["Freight"] = 108.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10342;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("11/30/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/14/1994 12:00:00 AM");
            dataRow["Freight"] = 54.83;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10396;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/10/1995 12:00:00 AM");
            dataRow["Freight"] = 135.35;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10488;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/25/1995 12:00:00 AM");
            dataRow["Freight"] = 4.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10560;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("7/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/4/1995 12:00:00 AM");
            dataRow["Freight"] = 36.65;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10623;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("9/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/5/1995 12:00:00 AM");
            dataRow["Freight"] = 97.18;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10653;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("10/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/31/1995 12:00:00 AM");
            dataRow["Freight"] = 93.25;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10670;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("10/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/14/1995 12:00:00 AM");
            dataRow["Freight"] = 203.48;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10675;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("10/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/17/1995 12:00:00 AM");
            dataRow["Freight"] = 31.85;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10717;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("11/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/22/1995 12:00:00 AM");
            dataRow["Freight"] = 59.25;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10791;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("1/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/20/1996 12:00:00 AM");
            dataRow["Freight"] = 16.85;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10859;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("2/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["Freight"] = 76.1;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10929;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("4/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["Freight"] = 33.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11012;
            dataRow["CustomerID"] = "FRANK";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("5/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["Freight"] = 242.95;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10671;
            dataRow["CustomerID"] = "FRANR";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("10/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/15/1995 12:00:00 AM");
            dataRow["Freight"] = 30.34;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10860;
            dataRow["CustomerID"] = "FRANR";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["Freight"] = 19.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10971;
            dataRow["CustomerID"] = "FRANR";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/21/1996 12:00:00 AM");
            dataRow["Freight"] = 121.82;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10422;
            dataRow["CustomerID"] = "FRANS";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("2/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/22/1995 12:00:00 AM");
            dataRow["Freight"] = 3.02;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10710;
            dataRow["CustomerID"] = "FRANS";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("11/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/18/1995 12:00:00 AM");
            dataRow["Freight"] = 4.98;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10753;
            dataRow["CustomerID"] = "FRANS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("12/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/23/1996 12:00:00 AM");
            dataRow["Freight"] = 7.7;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10807;
            dataRow["CustomerID"] = "FRANS";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("1/31/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/28/1996 12:00:00 AM");
            dataRow["Freight"] = 1.36;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11026;
            dataRow["CustomerID"] = "FRANS";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/12/1996 12:00:00 AM");
            dataRow["Freight"] = 47.09;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11060;
            dataRow["CustomerID"] = "FRANS";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/27/1996 12:00:00 AM");
            dataRow["Freight"] = 10.98;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10328;
            dataRow["CustomerID"] = "FURIB";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("11/14/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/12/1994 12:00:00 AM");
            dataRow["Freight"] = 87.03;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10352;
            dataRow["CustomerID"] = "FURIB";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("12/13/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/27/1994 12:00:00 AM");
            dataRow["Freight"] = 1.3;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10464;
            dataRow["CustomerID"] = "FURIB";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1995 12:00:00 AM");
            dataRow["Freight"] = 89;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10491;
            dataRow["CustomerID"] = "FURIB";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("5/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/29/1995 12:00:00 AM");
            dataRow["Freight"] = 16.96;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10551;
            dataRow["CustomerID"] = "FURIB";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("6/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/9/1995 12:00:00 AM");
            dataRow["Freight"] = 72.95;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10604;
            dataRow["CustomerID"] = "FURIB";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("8/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/15/1995 12:00:00 AM");
            dataRow["Freight"] = 7.46;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10664;
            dataRow["CustomerID"] = "FURIB";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("10/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/8/1995 12:00:00 AM");
            dataRow["Freight"] = 1.27;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10963;
            dataRow["CustomerID"] = "FURIB";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("4/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["Freight"] = 2.7;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10366;
            dataRow["CustomerID"] = "GALED";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("12/29/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/9/1995 12:00:00 AM");
            dataRow["Freight"] = 10.14;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10426;
            dataRow["CustomerID"] = "GALED";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("2/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/27/1995 12:00:00 AM");
            dataRow["Freight"] = 18.69;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10568;
            dataRow["CustomerID"] = "GALED";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("7/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/11/1995 12:00:00 AM");
            dataRow["Freight"] = 6.54;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10887;
            dataRow["CustomerID"] = "GALED";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("3/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/12/1996 12:00:00 AM");
            dataRow["Freight"] = 1.25;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10928;
            dataRow["CustomerID"] = "GALED";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["Freight"] = 1.36;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10303;
            dataRow["CustomerID"] = "GODOS";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("10/12/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/9/1994 12:00:00 AM");
            dataRow["Freight"] = 107.83;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10550;
            dataRow["CustomerID"] = "GODOS";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("6/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/26/1995 12:00:00 AM");
            dataRow["Freight"] = 4.32;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10629;
            dataRow["CustomerID"] = "GODOS";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/10/1995 12:00:00 AM");
            dataRow["Freight"] = 85.46;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10872;
            dataRow["CustomerID"] = "GODOS";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("3/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/4/1996 12:00:00 AM");
            dataRow["Freight"] = 175.32;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10874;
            dataRow["CustomerID"] = "GODOS";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["Freight"] = 19.58;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10888;
            dataRow["CustomerID"] = "GODOS";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("3/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["Freight"] = 51.87;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10911;
            dataRow["CustomerID"] = "GODOS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["Freight"] = 38.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10948;
            dataRow["CustomerID"] = "GODOS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/10/1996 12:00:00 AM");
            dataRow["Freight"] = 23.39;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11009;
            dataRow["CustomerID"] = "GODOS";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["Freight"] = 59.11;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11037;
            dataRow["CustomerID"] = "GODOS";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/18/1996 12:00:00 AM");
            dataRow["Freight"] = 3.2;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10423;
            dataRow["CustomerID"] = "GOURL";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("2/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/9/1995 12:00:00 AM");
            dataRow["Freight"] = 24.5;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10652;
            dataRow["CustomerID"] = "GOURL";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("10/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/30/1995 12:00:00 AM");
            dataRow["Freight"] = 7.14;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10685;
            dataRow["CustomerID"] = "GOURL";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("10/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/13/1995 12:00:00 AM");
            dataRow["Freight"] = 33.75;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10709;
            dataRow["CustomerID"] = "GOURL";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("11/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/15/1995 12:00:00 AM");
            dataRow["Freight"] = 210.8;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10734;
            dataRow["CustomerID"] = "GOURL";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("12/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/5/1996 12:00:00 AM");
            dataRow["Freight"] = 1.63;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10777;
            dataRow["CustomerID"] = "GOURL";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("1/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/29/1996 12:00:00 AM");
            dataRow["Freight"] = 3.01;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10790;
            dataRow["CustomerID"] = "GOURL";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("1/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/19/1996 12:00:00 AM");
            dataRow["Freight"] = 28.23;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10959;
            dataRow["CustomerID"] = "GOURL";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("4/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["Freight"] = 4.98;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11049;
            dataRow["CustomerID"] = "GOURL";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/21/1996 12:00:00 AM");
            dataRow["Freight"] = 8.34;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10528;
            dataRow["CustomerID"] = "GREAL";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("6/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/20/1995 12:00:00 AM");
            dataRow["Freight"] = 3.35;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10589;
            dataRow["CustomerID"] = "GREAL";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("8/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/1/1995 12:00:00 AM");
            dataRow["Freight"] = 4.42;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10616;
            dataRow["CustomerID"] = "GREAL";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("8/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/28/1995 12:00:00 AM");
            dataRow["Freight"] = 116.53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10617;
            dataRow["CustomerID"] = "GREAL";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("8/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/28/1995 12:00:00 AM");
            dataRow["Freight"] = 18.53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10656;
            dataRow["CustomerID"] = "GREAL";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("10/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/2/1995 12:00:00 AM");
            dataRow["Freight"] = 57.15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10681;
            dataRow["CustomerID"] = "GREAL";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("10/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/23/1995 12:00:00 AM");
            dataRow["Freight"] = 76.13;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10816;
            dataRow["CustomerID"] = "GREAL";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("2/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/5/1996 12:00:00 AM");
            dataRow["Freight"] = 719.78;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10936;
            dataRow["CustomerID"] = "GREAL";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["Freight"] = 33.68;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11006;
            dataRow["CustomerID"] = "GREAL";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["Freight"] = 25.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11040;
            dataRow["CustomerID"] = "GREAL";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/19/1996 12:00:00 AM");
            dataRow["Freight"] = 18.84;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11061;
            dataRow["CustomerID"] = "GREAL";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/11/1996 12:00:00 AM");
            dataRow["Freight"] = 14.01;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10268;
            dataRow["CustomerID"] = "GROSR";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("8/30/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/27/1994 12:00:00 AM");
            dataRow["Freight"] = 66.29;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10785;
            dataRow["CustomerID"] = "GROSR";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/15/1996 12:00:00 AM");
            dataRow["Freight"] = 1.51;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10250;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("8/8/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/5/1994 12:00:00 AM");
            dataRow["Freight"] = 65.83;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10253;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("8/10/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/24/1994 12:00:00 AM");
            dataRow["Freight"] = 58.17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10541;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("6/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/17/1995 12:00:00 AM");
            dataRow["Freight"] = 68.65;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10645;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/24/1995 12:00:00 AM");
            dataRow["Freight"] = 12.41;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10690;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("11/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/30/1995 12:00:00 AM");
            dataRow["Freight"] = 15.8;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10770;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("1/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/6/1996 12:00:00 AM");
            dataRow["Freight"] = 5.32;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10783;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("1/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/15/1996 12:00:00 AM");
            dataRow["Freight"] = 124.98;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10886;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("3/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/12/1996 12:00:00 AM");
            dataRow["Freight"] = 4.99;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10903;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["Freight"] = 36.71;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10922;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("4/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/30/1996 12:00:00 AM");
            dataRow["Freight"] = 62.74;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10925;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["Freight"] = 2.27;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10981;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["Freight"] = 193.37;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11022;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/11/1996 12:00:00 AM");
            dataRow["Freight"] = 6.27;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11052;
            dataRow["CustomerID"] = "HANAR";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/24/1996 12:00:00 AM");
            dataRow["Freight"] = 67.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10257;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("8/16/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/13/1994 12:00:00 AM");
            dataRow["Freight"] = 81.91;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10395;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("1/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/23/1995 12:00:00 AM");
            dataRow["Freight"] = 184.41;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10476;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/15/1995 12:00:00 AM");
            dataRow["Freight"] = 4.41;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10486;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/24/1995 12:00:00 AM");
            dataRow["Freight"] = 30.53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10490;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/29/1995 12:00:00 AM");
            dataRow["Freight"] = 210.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10498;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("5/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/5/1995 12:00:00 AM");
            dataRow["Freight"] = 29.75;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10552;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("6/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/27/1995 12:00:00 AM");
            dataRow["Freight"] = 83.22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10601;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("8/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/27/1995 12:00:00 AM");
            dataRow["Freight"] = 58.3;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10613;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("8/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/26/1995 12:00:00 AM");
            dataRow["Freight"] = 8.11;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10641;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/20/1995 12:00:00 AM");
            dataRow["Freight"] = 179.61;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10705;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("11/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/13/1995 12:00:00 AM");
            dataRow["Freight"] = 3.52;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10796;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/22/1996 12:00:00 AM");
            dataRow["Freight"] = 26.52;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10863;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/1/1996 12:00:00 AM");
            dataRow["Freight"] = 30.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10901;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/22/1996 12:00:00 AM");
            dataRow["Freight"] = 62.09;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10957;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/15/1996 12:00:00 AM");
            dataRow["Freight"] = 105.36;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10960;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["Freight"] = 2.08;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10976;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["Freight"] = 37.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11055;
            dataRow["CustomerID"] = "HILAA";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/25/1996 12:00:00 AM");
            dataRow["Freight"] = 120.92;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10375;
            dataRow["CustomerID"] = "HUNGC";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/3/1995 12:00:00 AM");
            dataRow["Freight"] = 20.12;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10394;
            dataRow["CustomerID"] = "HUNGC";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/22/1995 12:00:00 AM");
            dataRow["Freight"] = 30.34;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10415;
            dataRow["CustomerID"] = "HUNGC";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/15/1995 12:00:00 AM");
            dataRow["Freight"] = 0.2;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10600;
            dataRow["CustomerID"] = "HUNGC";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("8/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/13/1995 12:00:00 AM");
            dataRow["Freight"] = 45.13;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10660;
            dataRow["CustomerID"] = "HUNGC";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("10/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/6/1995 12:00:00 AM");
            dataRow["Freight"] = 111.29;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10298;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("10/6/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/3/1994 12:00:00 AM");
            dataRow["Freight"] = 168.22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10309;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("10/20/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/17/1994 12:00:00 AM");
            dataRow["Freight"] = 47.3;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10335;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("11/22/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/20/1994 12:00:00 AM");
            dataRow["Freight"] = 42.11;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10373;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("1/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/2/1995 12:00:00 AM");
            dataRow["Freight"] = 124.12;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10380;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("1/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/9/1995 12:00:00 AM");
            dataRow["Freight"] = 35.03;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10429;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/12/1995 12:00:00 AM");
            dataRow["Freight"] = 56.63;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10503;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("5/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/9/1995 12:00:00 AM");
            dataRow["Freight"] = 16.74;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10516;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/22/1995 12:00:00 AM");
            dataRow["Freight"] = 62.78;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10567;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("7/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/10/1995 12:00:00 AM");
            dataRow["Freight"] = 33.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10646;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("9/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/8/1995 12:00:00 AM");
            dataRow["Freight"] = 142.33;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10661;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("10/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/7/1995 12:00:00 AM");
            dataRow["Freight"] = 17.55;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10687;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("10/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/28/1995 12:00:00 AM");
            dataRow["Freight"] = 296.43;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10701;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("11/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/27/1995 12:00:00 AM");
            dataRow["Freight"] = 220.31;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10712;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("11/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/19/1995 12:00:00 AM");
            dataRow["Freight"] = 89.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10736;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("12/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/9/1996 12:00:00 AM");
            dataRow["Freight"] = 44.1;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10897;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/18/1996 12:00:00 AM");
            dataRow["Freight"] = 603.54;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10912;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["Freight"] = 580.91;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10985;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["Freight"] = 91.51;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11063;
            dataRow["CustomerID"] = "HUNGO";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/27/1996 12:00:00 AM");
            dataRow["Freight"] = 81.73;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10315;
            dataRow["CustomerID"] = "ISLAT";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("10/27/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/24/1994 12:00:00 AM");
            dataRow["Freight"] = 41.76;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10318;
            dataRow["CustomerID"] = "ISLAT";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("11/1/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/29/1994 12:00:00 AM");
            dataRow["Freight"] = 4.73;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10321;
            dataRow["CustomerID"] = "ISLAT";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("11/3/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/1/1994 12:00:00 AM");
            dataRow["Freight"] = 3.43;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10473;
            dataRow["CustomerID"] = "ISLAT";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/27/1995 12:00:00 AM");
            dataRow["Freight"] = 16.37;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10621;
            dataRow["CustomerID"] = "ISLAT";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/3/1995 12:00:00 AM");
            dataRow["Freight"] = 23.73;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10674;
            dataRow["CustomerID"] = "ISLAT";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("10/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/16/1995 12:00:00 AM");
            dataRow["Freight"] = 0.9;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10749;
            dataRow["CustomerID"] = "ISLAT";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("12/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/18/1996 12:00:00 AM");
            dataRow["Freight"] = 61.53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10798;
            dataRow["CustomerID"] = "ISLAT";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("1/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/23/1996 12:00:00 AM");
            dataRow["Freight"] = 2.33;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10829;
            dataRow["CustomerID"] = "ISLAT";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("2/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/12/1996 12:00:00 AM");
            dataRow["Freight"] = 154.72;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10933;
            dataRow["CustomerID"] = "ISLAT";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/3/1996 12:00:00 AM");
            dataRow["Freight"] = 54.15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10323;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("11/7/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/5/1994 12:00:00 AM");
            dataRow["Freight"] = 4.88;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10325;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("11/9/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/23/1994 12:00:00 AM");
            dataRow["Freight"] = 64.86;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10456;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/9/1995 12:00:00 AM");
            dataRow["Freight"] = 8.12;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10457;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1995 12:00:00 AM");
            dataRow["Freight"] = 11.57;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10468;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/5/1995 12:00:00 AM");
            dataRow["Freight"] = 44.12;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10506;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("5/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/13/1995 12:00:00 AM");
            dataRow["Freight"] = 21.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10542;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("6/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/18/1995 12:00:00 AM");
            dataRow["Freight"] = 10.95;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10630;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("9/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/11/1995 12:00:00 AM");
            dataRow["Freight"] = 32.35;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10718;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("11/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/25/1995 12:00:00 AM");
            dataRow["Freight"] = 170.88;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10799;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("1/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["Freight"] = 30.76;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10817;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/20/1996 12:00:00 AM");
            dataRow["Freight"] = 306.07;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10849;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("2/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/22/1996 12:00:00 AM");
            dataRow["Freight"] = 0.56;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10893;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("3/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/17/1996 12:00:00 AM");
            dataRow["Freight"] = 77.78;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11028;
            dataRow["CustomerID"] = "KOENE";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/13/1996 12:00:00 AM");
            dataRow["Freight"] = 29.59;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10858;
            dataRow["CustomerID"] = "LACOR";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("2/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["Freight"] = 52.51;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10927;
            dataRow["CustomerID"] = "LACOR";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["Freight"] = 19.79;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10972;
            dataRow["CustomerID"] = "LACOR";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/21/1996 12:00:00 AM");
            dataRow["Freight"] = 0.02;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10973;
            dataRow["CustomerID"] = "LACOR";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/21/1996 12:00:00 AM");
            dataRow["Freight"] = 15.17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10350;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("12/12/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/9/1995 12:00:00 AM");
            dataRow["Freight"] = 64.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10358;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("12/21/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/18/1995 12:00:00 AM");
            dataRow["Freight"] = 19.64;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10371;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/31/1995 12:00:00 AM");
            dataRow["Freight"] = 0.45;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10413;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/14/1995 12:00:00 AM");
            dataRow["Freight"] = 95.66;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10425;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("2/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/24/1995 12:00:00 AM");
            dataRow["Freight"] = 7.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10454;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/21/1995 12:00:00 AM");
            dataRow["Freight"] = 2.74;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10493;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/31/1995 12:00:00 AM");
            dataRow["Freight"] = 10.64;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10500;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("5/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/7/1995 12:00:00 AM");
            dataRow["Freight"] = 42.68;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10610;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("8/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/22/1995 12:00:00 AM");
            dataRow["Freight"] = 26.78;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10631;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("9/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/12/1995 12:00:00 AM");
            dataRow["Freight"] = 0.87;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10787;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("1/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/2/1996 12:00:00 AM");
            dataRow["Freight"] = 249.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10832;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("2/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/13/1996 12:00:00 AM");
            dataRow["Freight"] = 43.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10923;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("4/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["Freight"] = 68.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11051;
            dataRow["CustomerID"] = "LAMAI";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/24/1996 12:00:00 AM");
            dataRow["Freight"] = 2.79;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10495;
            dataRow["CustomerID"] = "LAUGB";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/1/1995 12:00:00 AM");
            dataRow["Freight"] = 4.65;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10620;
            dataRow["CustomerID"] = "LAUGB";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("9/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/3/1995 12:00:00 AM");
            dataRow["Freight"] = 0.94;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10810;
            dataRow["CustomerID"] = "LAUGB";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("2/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/29/1996 12:00:00 AM");
            dataRow["Freight"] = 4.33;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10482;
            dataRow["CustomerID"] = "LAZYK";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/19/1995 12:00:00 AM");
            dataRow["Freight"] = 7.48;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10545;
            dataRow["CustomerID"] = "LAZYK";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("6/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/20/1995 12:00:00 AM");
            dataRow["Freight"] = 11.92;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10279;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("9/13/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/11/1994 12:00:00 AM");
            dataRow["Freight"] = 25.83;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10284;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/19/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/17/1994 12:00:00 AM");
            dataRow["Freight"] = 76.56;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10343;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("12/1/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/29/1994 12:00:00 AM");
            dataRow["Freight"] = 110.37;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10497;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/2/1995 12:00:00 AM");
            dataRow["Freight"] = 36.21;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10522;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/28/1995 12:00:00 AM");
            dataRow["Freight"] = 45.33;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10534;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("6/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/10/1995 12:00:00 AM");
            dataRow["Freight"] = 27.94;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10536;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("6/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/12/1995 12:00:00 AM");
            dataRow["Freight"] = 58.88;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10557;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("7/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/18/1995 12:00:00 AM");
            dataRow["Freight"] = 96.72;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10592;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("8/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/5/1995 12:00:00 AM");
            dataRow["Freight"] = 32.1;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10593;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("8/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/6/1995 12:00:00 AM");
            dataRow["Freight"] = 174.2;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10772;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/7/1996 12:00:00 AM");
            dataRow["Freight"] = 91.28;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10862;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("3/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/12/1996 12:00:00 AM");
            dataRow["Freight"] = 53.23;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10891;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("3/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/16/1996 12:00:00 AM");
            dataRow["Freight"] = 20.37;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10934;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["Freight"] = 32.01;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11070;
            dataRow["CustomerID"] = "LEHMS";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/2/1996 12:00:00 AM");
            dataRow["Freight"] = 136;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10579;
            dataRow["CustomerID"] = "LETSS";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("7/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/23/1995 12:00:00 AM");
            dataRow["Freight"] = 13.73;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10719;
            dataRow["CustomerID"] = "LETSS";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("11/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/25/1995 12:00:00 AM");
            dataRow["Freight"] = 51.44;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10735;
            dataRow["CustomerID"] = "LETSS";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("12/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/8/1996 12:00:00 AM");
            dataRow["Freight"] = 45.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10884;
            dataRow["CustomerID"] = "LETSS";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/11/1996 12:00:00 AM");
            dataRow["Freight"] = 90.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10283;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("9/16/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/14/1994 12:00:00 AM");
            dataRow["Freight"] = 84.81;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10296;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("10/4/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/1/1994 12:00:00 AM");
            dataRow["Freight"] = 0.12;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10330;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("11/16/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/14/1994 12:00:00 AM");
            dataRow["Freight"] = 12.75;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10357;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("12/20/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/17/1995 12:00:00 AM");
            dataRow["Freight"] = 34.88;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10381;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/9/1995 12:00:00 AM");
            dataRow["Freight"] = 7.99;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10461;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("3/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/28/1995 12:00:00 AM");
            dataRow["Freight"] = 148.61;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10499;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/6/1995 12:00:00 AM");
            dataRow["Freight"] = 102.02;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10543;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("6/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/19/1995 12:00:00 AM");
            dataRow["Freight"] = 48.17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10780;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("1/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/30/1996 12:00:00 AM");
            dataRow["Freight"] = 42.13;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10823;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("2/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["Freight"] = 163.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10899;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("3/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["Freight"] = 1.21;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10997;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("5/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/14/1996 12:00:00 AM");
            dataRow["Freight"] = 73.91;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11065;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("5/31/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/28/1996 12:00:00 AM");
            dataRow["Freight"] = 12.91;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11071;
            dataRow["CustomerID"] = "LILAS";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/2/1996 12:00:00 AM");
            dataRow["Freight"] = 0.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10405;
            dataRow["CustomerID"] = "LINOD";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("2/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/6/1995 12:00:00 AM");
            dataRow["Freight"] = 34.82;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10485;
            dataRow["CustomerID"] = "LINOD";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/9/1995 12:00:00 AM");
            dataRow["Freight"] = 64.45;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10638;
            dataRow["CustomerID"] = "LINOD";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("9/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/18/1995 12:00:00 AM");
            dataRow["Freight"] = 158.44;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10697;
            dataRow["CustomerID"] = "LINOD";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("11/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/6/1995 12:00:00 AM");
            dataRow["Freight"] = 45.52;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10729;
            dataRow["CustomerID"] = "LINOD";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("12/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/16/1996 12:00:00 AM");
            dataRow["Freight"] = 141.06;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10811;
            dataRow["CustomerID"] = "LINOD";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("2/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/1/1996 12:00:00 AM");
            dataRow["Freight"] = 31.22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10838;
            dataRow["CustomerID"] = "LINOD";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/18/1996 12:00:00 AM");
            dataRow["Freight"] = 59.28;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10840;
            dataRow["CustomerID"] = "LINOD";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("2/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/1/1996 12:00:00 AM");
            dataRow["Freight"] = 2.71;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10919;
            dataRow["CustomerID"] = "LINOD";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("4/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["Freight"] = 19.8;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10954;
            dataRow["CustomerID"] = "LINOD";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("4/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["Freight"] = 27.91;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11014;
            dataRow["CustomerID"] = "LINOD";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/7/1996 12:00:00 AM");
            dataRow["Freight"] = 23.6;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11039;
            dataRow["CustomerID"] = "LINOD";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("5/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/18/1996 12:00:00 AM");
            dataRow["Freight"] = 65;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10307;
            dataRow["CustomerID"] = "LONEP";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("10/18/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/15/1994 12:00:00 AM");
            dataRow["Freight"] = 0.56;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10317;
            dataRow["CustomerID"] = "LONEP";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("10/31/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/28/1994 12:00:00 AM");
            dataRow["Freight"] = 12.69;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10544;
            dataRow["CustomerID"] = "LONEP";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("6/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/19/1995 12:00:00 AM");
            dataRow["Freight"] = 24.91;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10662;
            dataRow["CustomerID"] = "LONEP";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("10/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/7/1995 12:00:00 AM");
            dataRow["Freight"] = 1.28;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10665;
            dataRow["CustomerID"] = "LONEP";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("10/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/9/1995 12:00:00 AM");
            dataRow["Freight"] = 26.31;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10867;
            dataRow["CustomerID"] = "LONEP";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("3/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/16/1996 12:00:00 AM");
            dataRow["Freight"] = 1.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10883;
            dataRow["CustomerID"] = "LONEP";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("3/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/11/1996 12:00:00 AM");
            dataRow["Freight"] = 0.53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11018;
            dataRow["CustomerID"] = "LONEP";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/10/1996 12:00:00 AM");
            dataRow["Freight"] = 11.65;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10275;
            dataRow["CustomerID"] = "MAGAA";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("9/7/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/5/1994 12:00:00 AM");
            dataRow["Freight"] = 26.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10300;
            dataRow["CustomerID"] = "MAGAA";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("10/10/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/7/1994 12:00:00 AM");
            dataRow["Freight"] = 17.68;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10404;
            dataRow["CustomerID"] = "MAGAA";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("2/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/3/1995 12:00:00 AM");
            dataRow["Freight"] = 155.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10467;
            dataRow["CustomerID"] = "MAGAA";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/4/1995 12:00:00 AM");
            dataRow["Freight"] = 4.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10635;
            dataRow["CustomerID"] = "MAGAA";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("9/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/16/1995 12:00:00 AM");
            dataRow["Freight"] = 47.46;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10754;
            dataRow["CustomerID"] = "MAGAA";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("12/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/23/1996 12:00:00 AM");
            dataRow["Freight"] = 2.38;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10784;
            dataRow["CustomerID"] = "MAGAA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("1/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/15/1996 12:00:00 AM");
            dataRow["Freight"] = 70.09;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10818;
            dataRow["CustomerID"] = "MAGAA";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("2/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["Freight"] = 65.48;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10939;
            dataRow["CustomerID"] = "MAGAA";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("4/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/7/1996 12:00:00 AM");
            dataRow["Freight"] = 76.33;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10950;
            dataRow["CustomerID"] = "MAGAA";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/13/1996 12:00:00 AM");
            dataRow["Freight"] = 2.5;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10529;
            dataRow["CustomerID"] = "MAISD";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("6/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/5/1995 12:00:00 AM");
            dataRow["Freight"] = 66.69;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10649;
            dataRow["CustomerID"] = "MAISD";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("9/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/26/1995 12:00:00 AM");
            dataRow["Freight"] = 6.2;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10760;
            dataRow["CustomerID"] = "MAISD";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("1/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/29/1996 12:00:00 AM");
            dataRow["Freight"] = 155.64;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10892;
            dataRow["CustomerID"] = "MAISD";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/16/1996 12:00:00 AM");
            dataRow["Freight"] = 120.27;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10896;
            dataRow["CustomerID"] = "MAISD";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("3/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/18/1996 12:00:00 AM");
            dataRow["Freight"] = 32.45;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10978;
            dataRow["CustomerID"] = "MAISD";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["Freight"] = 32.82;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11004;
            dataRow["CustomerID"] = "MAISD";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["Freight"] = 44.84;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10332;
            dataRow["CustomerID"] = "MEREP";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("11/17/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/29/1994 12:00:00 AM");
            dataRow["Freight"] = 52.84;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10339;
            dataRow["CustomerID"] = "MEREP";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("11/28/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/26/1994 12:00:00 AM");
            dataRow["Freight"] = 15.66;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10376;
            dataRow["CustomerID"] = "MEREP";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/6/1995 12:00:00 AM");
            dataRow["Freight"] = 20.39;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10424;
            dataRow["CustomerID"] = "MEREP";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("2/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/23/1995 12:00:00 AM");
            dataRow["Freight"] = 370.61;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10439;
            dataRow["CustomerID"] = "MEREP";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("3/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/7/1995 12:00:00 AM");
            dataRow["Freight"] = 4.07;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10505;
            dataRow["CustomerID"] = "MEREP";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/12/1995 12:00:00 AM");
            dataRow["Freight"] = 7.13;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10565;
            dataRow["CustomerID"] = "MEREP";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("7/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/9/1995 12:00:00 AM");
            dataRow["Freight"] = 7.15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10570;
            dataRow["CustomerID"] = "MEREP";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("7/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/15/1995 12:00:00 AM");
            dataRow["Freight"] = 188.99;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10590;
            dataRow["CustomerID"] = "MEREP";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("8/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/4/1995 12:00:00 AM");
            dataRow["Freight"] = 44.77;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10605;
            dataRow["CustomerID"] = "MEREP";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("8/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/18/1995 12:00:00 AM");
            dataRow["Freight"] = 379.13;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10618;
            dataRow["CustomerID"] = "MEREP";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("9/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/13/1995 12:00:00 AM");
            dataRow["Freight"] = 154.68;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10619;
            dataRow["CustomerID"] = "MEREP";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("9/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/2/1995 12:00:00 AM");
            dataRow["Freight"] = 91.05;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10724;
            dataRow["CustomerID"] = "MEREP";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("11/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/11/1996 12:00:00 AM");
            dataRow["Freight"] = 57.75;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10277;
            dataRow["CustomerID"] = "MORGK";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("9/9/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/7/1994 12:00:00 AM");
            dataRow["Freight"] = 125.77;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10575;
            dataRow["CustomerID"] = "MORGK";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("7/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/4/1995 12:00:00 AM");
            dataRow["Freight"] = 127.34;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10699;
            dataRow["CustomerID"] = "MORGK";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("11/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/7/1995 12:00:00 AM");
            dataRow["Freight"] = 0.58;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10779;
            dataRow["CustomerID"] = "MORGK";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/16/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/13/1996 12:00:00 AM");
            dataRow["Freight"] = 58.13;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10945;
            dataRow["CustomerID"] = "MORGK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/9/1996 12:00:00 AM");
            dataRow["Freight"] = 10.22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10517;
            dataRow["CustomerID"] = "NORTS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/22/1995 12:00:00 AM");
            dataRow["Freight"] = 32.07;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10752;
            dataRow["CustomerID"] = "NORTS";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("12/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/22/1996 12:00:00 AM");
            dataRow["Freight"] = 1.39;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11057;
            dataRow["CustomerID"] = "NORTS";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/26/1996 12:00:00 AM");
            dataRow["Freight"] = 4.13;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10409;
            dataRow["CustomerID"] = "OCEAN";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/9/1995 12:00:00 AM");
            dataRow["Freight"] = 29.83;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10531;
            dataRow["CustomerID"] = "OCEAN";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("6/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/6/1995 12:00:00 AM");
            dataRow["Freight"] = 8.12;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10898;
            dataRow["CustomerID"] = "OCEAN";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["Freight"] = 1.27;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10958;
            dataRow["CustomerID"] = "OCEAN";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("4/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/15/1996 12:00:00 AM");
            dataRow["Freight"] = 49.56;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10986;
            dataRow["CustomerID"] = "OCEAN";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["Freight"] = 217.86;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10305;
            dataRow["CustomerID"] = "OLDWO";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("10/14/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/11/1994 12:00:00 AM");
            dataRow["Freight"] = 257.62;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10338;
            dataRow["CustomerID"] = "OLDWO";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("11/25/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/23/1994 12:00:00 AM");
            dataRow["Freight"] = 84.21;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10441;
            dataRow["CustomerID"] = "OLDWO";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/24/1995 12:00:00 AM");
            dataRow["Freight"] = 73.02;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10594;
            dataRow["CustomerID"] = "OLDWO";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("8/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/6/1995 12:00:00 AM");
            dataRow["Freight"] = 5.24;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10680;
            dataRow["CustomerID"] = "OLDWO";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("10/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/22/1995 12:00:00 AM");
            dataRow["Freight"] = 26.61;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10706;
            dataRow["CustomerID"] = "OLDWO";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("11/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/14/1995 12:00:00 AM");
            dataRow["Freight"] = 135.63;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10808;
            dataRow["CustomerID"] = "OLDWO";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("2/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/29/1996 12:00:00 AM");
            dataRow["Freight"] = 45.53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10855;
            dataRow["CustomerID"] = "OLDWO";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["Freight"] = 170.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10965;
            dataRow["CustomerID"] = "OLDWO";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["Freight"] = 144.38;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11034;
            dataRow["CustomerID"] = "OLDWO";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("5/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/1/1996 12:00:00 AM");
            dataRow["Freight"] = 40.32;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10260;
            dataRow["CustomerID"] = "OTTIK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("8/19/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/16/1994 12:00:00 AM");
            dataRow["Freight"] = 55.09;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10407;
            dataRow["CustomerID"] = "OTTIK";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("2/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/7/1995 12:00:00 AM");
            dataRow["Freight"] = 91.48;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10508;
            dataRow["CustomerID"] = "OTTIK";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("5/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/14/1995 12:00:00 AM");
            dataRow["Freight"] = 4.99;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10554;
            dataRow["CustomerID"] = "OTTIK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("6/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/28/1995 12:00:00 AM");
            dataRow["Freight"] = 120.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10580;
            dataRow["CustomerID"] = "OTTIK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("7/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/24/1995 12:00:00 AM");
            dataRow["Freight"] = 75.89;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10684;
            dataRow["CustomerID"] = "OTTIK";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("10/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/24/1995 12:00:00 AM");
            dataRow["Freight"] = 145.63;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10766;
            dataRow["CustomerID"] = "OTTIK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("1/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/2/1996 12:00:00 AM");
            dataRow["Freight"] = 157.55;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10833;
            dataRow["CustomerID"] = "OTTIK";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("2/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/14/1996 12:00:00 AM");
            dataRow["Freight"] = 71.49;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10999;
            dataRow["CustomerID"] = "OTTIK";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("5/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/31/1996 12:00:00 AM");
            dataRow["Freight"] = 96.35;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11020;
            dataRow["CustomerID"] = "OTTIK";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/11/1996 12:00:00 AM");
            dataRow["Freight"] = 43.3;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10322;
            dataRow["CustomerID"] = "PERIC";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("11/4/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/2/1994 12:00:00 AM");
            dataRow["Freight"] = 0.4;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10354;
            dataRow["CustomerID"] = "PERIC";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("12/15/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/12/1995 12:00:00 AM");
            dataRow["Freight"] = 53.8;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10474;
            dataRow["CustomerID"] = "PERIC";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("4/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/11/1995 12:00:00 AM");
            dataRow["Freight"] = 83.49;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10502;
            dataRow["CustomerID"] = "PERIC";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/8/1995 12:00:00 AM");
            dataRow["Freight"] = 69.32;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10995;
            dataRow["CustomerID"] = "PERIC";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/30/1996 12:00:00 AM");
            dataRow["Freight"] = 46;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11073;
            dataRow["CustomerID"] = "PERIC";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/2/1996 12:00:00 AM");
            dataRow["Freight"] = 24.95;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10353;
            dataRow["CustomerID"] = "PICCO";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("12/14/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/11/1995 12:00:00 AM");
            dataRow["Freight"] = 360.63;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10392;
            dataRow["CustomerID"] = "PICCO";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("1/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/21/1995 12:00:00 AM");
            dataRow["Freight"] = 122.46;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10427;
            dataRow["CustomerID"] = "PICCO";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("2/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/27/1995 12:00:00 AM");
            dataRow["Freight"] = 31.29;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10489;
            dataRow["CustomerID"] = "PICCO";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("4/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/26/1995 12:00:00 AM");
            dataRow["Freight"] = 5.29;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10530;
            dataRow["CustomerID"] = "PICCO";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("6/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/6/1995 12:00:00 AM");
            dataRow["Freight"] = 339.22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10597;
            dataRow["CustomerID"] = "PICCO";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("8/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/8/1995 12:00:00 AM");
            dataRow["Freight"] = 35.12;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10686;
            dataRow["CustomerID"] = "PICCO";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("10/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/28/1995 12:00:00 AM");
            dataRow["Freight"] = 96.5;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10747;
            dataRow["CustomerID"] = "PICCO";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("12/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/17/1996 12:00:00 AM");
            dataRow["Freight"] = 117.33;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10844;
            dataRow["CustomerID"] = "PICCO";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("2/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/20/1996 12:00:00 AM");
            dataRow["Freight"] = 25.22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11053;
            dataRow["CustomerID"] = "PICCO";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/24/1996 12:00:00 AM");
            dataRow["Freight"] = 53.05;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10336;
            dataRow["CustomerID"] = "PRINI";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("11/23/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/21/1994 12:00:00 AM");
            dataRow["Freight"] = 15.51;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10397;
            dataRow["CustomerID"] = "PRINI";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("1/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/24/1995 12:00:00 AM");
            dataRow["Freight"] = 60.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10433;
            dataRow["CustomerID"] = "PRINI";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/3/1995 12:00:00 AM");
            dataRow["Freight"] = 73.83;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10477;
            dataRow["CustomerID"] = "PRINI";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("4/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/15/1995 12:00:00 AM");
            dataRow["Freight"] = 13.02;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11007;
            dataRow["CustomerID"] = "PRINI";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["Freight"] = 202.24;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10261;
            dataRow["CustomerID"] = "QUEDE";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("8/19/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/16/1994 12:00:00 AM");
            dataRow["Freight"] = 3.05;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10291;
            dataRow["CustomerID"] = "QUEDE";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("9/27/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/25/1994 12:00:00 AM");
            dataRow["Freight"] = 6.4;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10379;
            dataRow["CustomerID"] = "QUEDE";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("1/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/8/1995 12:00:00 AM");
            dataRow["Freight"] = 45.03;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10421;
            dataRow["CustomerID"] = "QUEDE";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("2/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/4/1995 12:00:00 AM");
            dataRow["Freight"] = 99.23;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10587;
            dataRow["CustomerID"] = "QUEDE";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("8/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/30/1995 12:00:00 AM");
            dataRow["Freight"] = 62.52;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10647;
            dataRow["CustomerID"] = "QUEDE";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/11/1995 12:00:00 AM");
            dataRow["Freight"] = 45.54;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10720;
            dataRow["CustomerID"] = "QUEDE";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("11/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/12/1995 12:00:00 AM");
            dataRow["Freight"] = 9.53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10794;
            dataRow["CustomerID"] = "QUEDE";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("1/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/21/1996 12:00:00 AM");
            dataRow["Freight"] = 21.49;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10989;
            dataRow["CustomerID"] = "QUEDE";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("4/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["Freight"] = 34.76;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10372;
            dataRow["CustomerID"] = "QUEEN";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("1/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/1/1995 12:00:00 AM");
            dataRow["Freight"] = 890.78;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10406;
            dataRow["CustomerID"] = "QUEEN";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("2/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/21/1995 12:00:00 AM");
            dataRow["Freight"] = 108.04;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10487;
            dataRow["CustomerID"] = "QUEEN";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("4/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/24/1995 12:00:00 AM");
            dataRow["Freight"] = 71.07;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10637;
            dataRow["CustomerID"] = "QUEEN";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("9/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/17/1995 12:00:00 AM");
            dataRow["Freight"] = 201.29;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10659;
            dataRow["CustomerID"] = "QUEEN";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("10/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/3/1995 12:00:00 AM");
            dataRow["Freight"] = 105.81;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10704;
            dataRow["CustomerID"] = "QUEEN";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("11/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/12/1995 12:00:00 AM");
            dataRow["Freight"] = 4.78;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10728;
            dataRow["CustomerID"] = "QUEEN";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("12/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/2/1996 12:00:00 AM");
            dataRow["Freight"] = 58.33;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10786;
            dataRow["CustomerID"] = "QUEEN";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("1/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/16/1996 12:00:00 AM");
            dataRow["Freight"] = 110.87;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10868;
            dataRow["CustomerID"] = "QUEEN";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/3/1996 12:00:00 AM");
            dataRow["Freight"] = 191.27;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10913;
            dataRow["CustomerID"] = "QUEEN";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["Freight"] = 33.05;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10914;
            dataRow["CustomerID"] = "QUEEN";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("3/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["Freight"] = 21.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10961;
            dataRow["CustomerID"] = "QUEEN";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["Freight"] = 104.47;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11068;
            dataRow["CustomerID"] = "QUEEN";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/1/1996 12:00:00 AM");
            dataRow["Freight"] = 81.75;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10273;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("9/5/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/3/1994 12:00:00 AM");
            dataRow["Freight"] = 76.07;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10285;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("9/20/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/18/1994 12:00:00 AM");
            dataRow["Freight"] = 76.83;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10286;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("9/21/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/19/1994 12:00:00 AM");
            dataRow["Freight"] = 229.24;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10313;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("10/25/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/22/1994 12:00:00 AM");
            dataRow["Freight"] = 1.96;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10345;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("12/5/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/2/1995 12:00:00 AM");
            dataRow["Freight"] = 249.06;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10361;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("12/23/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/20/1995 12:00:00 AM");
            dataRow["Freight"] = 183.17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10418;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("2/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/17/1995 12:00:00 AM");
            dataRow["Freight"] = 17.55;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10451;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1995 12:00:00 AM");
            dataRow["Freight"] = 189.09;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10515;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/7/1995 12:00:00 AM");
            dataRow["Freight"] = 204.47;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10527;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("6/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/3/1995 12:00:00 AM");
            dataRow["Freight"] = 41.9;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10540;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("6/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/17/1995 12:00:00 AM");
            dataRow["Freight"] = 1007.64;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10549;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("6/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/11/1995 12:00:00 AM");
            dataRow["Freight"] = 171.24;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10588;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("8/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/31/1995 12:00:00 AM");
            dataRow["Freight"] = 194.67;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10658;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("10/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/3/1995 12:00:00 AM");
            dataRow["Freight"] = 364.15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10691;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("11/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/15/1995 12:00:00 AM");
            dataRow["Freight"] = 810.05;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10694;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("11/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/4/1995 12:00:00 AM");
            dataRow["Freight"] = 398.36;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10721;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("11/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/27/1995 12:00:00 AM");
            dataRow["Freight"] = 48.92;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10745;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("12/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/16/1996 12:00:00 AM");
            dataRow["Freight"] = 3.52;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10765;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/1/1996 12:00:00 AM");
            dataRow["Freight"] = 42.74;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10788;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/19/1996 12:00:00 AM");
            dataRow["Freight"] = 42.7;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10845;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("2/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["Freight"] = 212.98;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10865;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("3/4/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/18/1996 12:00:00 AM");
            dataRow["Freight"] = 348.14;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10878;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/9/1996 12:00:00 AM");
            dataRow["Freight"] = 46.69;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10938;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/7/1996 12:00:00 AM");
            dataRow["Freight"] = 31.89;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10962;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["Freight"] = 275.79;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10991;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["Freight"] = 38.51;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10996;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/30/1996 12:00:00 AM");
            dataRow["Freight"] = 1.12;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11021;
            dataRow["CustomerID"] = "QUICK";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/11/1996 12:00:00 AM");
            dataRow["Freight"] = 297.18;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10448;
            dataRow["CustomerID"] = "RANCH";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/17/1995 12:00:00 AM");
            dataRow["Freight"] = 38.82;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10716;
            dataRow["CustomerID"] = "RANCH";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("11/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/22/1995 12:00:00 AM");
            dataRow["Freight"] = 22.57;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10828;
            dataRow["CustomerID"] = "RANCH";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("2/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["Freight"] = 90.85;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10916;
            dataRow["CustomerID"] = "RANCH";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("3/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["Freight"] = 63.77;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11019;
            dataRow["CustomerID"] = "RANCH";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("5/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/10/1996 12:00:00 AM");
            dataRow["Freight"] = 3.17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10262;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("8/22/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/19/1994 12:00:00 AM");
            dataRow["Freight"] = 48.29;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10272;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("9/2/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/30/1994 12:00:00 AM");
            dataRow["Freight"] = 98.03;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10294;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/30/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/28/1994 12:00:00 AM");
            dataRow["Freight"] = 147.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10314;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("10/26/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/23/1994 12:00:00 AM");
            dataRow["Freight"] = 74.16;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10316;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("10/28/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/25/1994 12:00:00 AM");
            dataRow["Freight"] = 150.15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10346;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("12/6/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/17/1995 12:00:00 AM");
            dataRow["Freight"] = 142.08;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10401;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("2/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/1/1995 12:00:00 AM");
            dataRow["Freight"] = 12.51;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10479;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/17/1995 12:00:00 AM");
            dataRow["Freight"] = 708.95;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10564;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("7/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/8/1995 12:00:00 AM");
            dataRow["Freight"] = 13.75;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10569;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("7/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/14/1995 12:00:00 AM");
            dataRow["Freight"] = 58.98;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10598;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("8/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/11/1995 12:00:00 AM");
            dataRow["Freight"] = 44.42;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10761;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("1/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/30/1996 12:00:00 AM");
            dataRow["Freight"] = 18.66;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10820;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["Freight"] = 37.52;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10852;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("2/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/11/1996 12:00:00 AM");
            dataRow["Freight"] = 174.05;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10889;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("3/18/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["Freight"] = 280.61;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10988;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/28/1996 12:00:00 AM");
            dataRow["Freight"] = 61.14;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11000;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["Freight"] = 55.12;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11077;
            dataRow["CustomerID"] = "RATTC";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/3/1996 12:00:00 AM");
            dataRow["Freight"] = 8.53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10288;
            dataRow["CustomerID"] = "REGGC";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/23/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/21/1994 12:00:00 AM");
            dataRow["Freight"] = 7.45;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10428;
            dataRow["CustomerID"] = "REGGC";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("2/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/28/1995 12:00:00 AM");
            dataRow["Freight"] = 11.09;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10443;
            dataRow["CustomerID"] = "REGGC";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("3/15/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/12/1995 12:00:00 AM");
            dataRow["Freight"] = 13.95;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10562;
            dataRow["CustomerID"] = "REGGC";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("7/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/7/1995 12:00:00 AM");
            dataRow["Freight"] = 22.95;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10586;
            dataRow["CustomerID"] = "REGGC";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("8/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/30/1995 12:00:00 AM");
            dataRow["Freight"] = 0.48;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10655;
            dataRow["CustomerID"] = "REGGC";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("10/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/1/1995 12:00:00 AM");
            dataRow["Freight"] = 4.41;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10727;
            dataRow["CustomerID"] = "REGGC";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("12/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/1/1996 12:00:00 AM");
            dataRow["Freight"] = 89.9;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10812;
            dataRow["CustomerID"] = "REGGC";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("2/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/1/1996 12:00:00 AM");
            dataRow["Freight"] = 59.78;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10908;
            dataRow["CustomerID"] = "REGGC";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["Freight"] = 32.96;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10942;
            dataRow["CustomerID"] = "REGGC";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["Freight"] = 17.95;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11010;
            dataRow["CustomerID"] = "REGGC";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/6/1996 12:00:00 AM");
            dataRow["Freight"] = 28.71;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11062;
            dataRow["CustomerID"] = "REGGC";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/27/1996 12:00:00 AM");
            dataRow["Freight"] = 29.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10287;
            dataRow["CustomerID"] = "RICAR";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("9/22/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/20/1994 12:00:00 AM");
            dataRow["Freight"] = 12.76;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10299;
            dataRow["CustomerID"] = "RICAR";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("10/7/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/4/1994 12:00:00 AM");
            dataRow["Freight"] = 29.76;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10447;
            dataRow["CustomerID"] = "RICAR";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/14/1995 12:00:00 AM");
            dataRow["Freight"] = 68.66;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10481;
            dataRow["CustomerID"] = "RICAR";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/18/1995 12:00:00 AM");
            dataRow["Freight"] = 64.33;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10563;
            dataRow["CustomerID"] = "RICAR";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("7/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/22/1995 12:00:00 AM");
            dataRow["Freight"] = 60.43;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10622;
            dataRow["CustomerID"] = "RICAR";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/4/1995 12:00:00 AM");
            dataRow["Freight"] = 50.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10648;
            dataRow["CustomerID"] = "RICAR";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("9/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/9/1995 12:00:00 AM");
            dataRow["Freight"] = 14.25;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10813;
            dataRow["CustomerID"] = "RICAR";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("2/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/4/1996 12:00:00 AM");
            dataRow["Freight"] = 47.38;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10851;
            dataRow["CustomerID"] = "RICAR";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("2/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/25/1996 12:00:00 AM");
            dataRow["Freight"] = 160.55;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10877;
            dataRow["CustomerID"] = "RICAR";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("3/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/8/1996 12:00:00 AM");
            dataRow["Freight"] = 38.06;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11059;
            dataRow["CustomerID"] = "RICAR";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/10/1996 12:00:00 AM");
            dataRow["Freight"] = 85.8;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10255;
            dataRow["CustomerID"] = "RICSU";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("8/12/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/9/1994 12:00:00 AM");
            dataRow["Freight"] = 148.33;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10419;
            dataRow["CustomerID"] = "RICSU";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("2/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/20/1995 12:00:00 AM");
            dataRow["Freight"] = 137.35;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10537;
            dataRow["CustomerID"] = "RICSU";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("6/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/28/1995 12:00:00 AM");
            dataRow["Freight"] = 78.85;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10666;
            dataRow["CustomerID"] = "RICSU";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("10/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/10/1995 12:00:00 AM");
            dataRow["Freight"] = 232.42;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10751;
            dataRow["CustomerID"] = "RICSU";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("12/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/22/1996 12:00:00 AM");
            dataRow["Freight"] = 130.79;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10758;
            dataRow["CustomerID"] = "RICSU";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("12/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/26/1996 12:00:00 AM");
            dataRow["Freight"] = 138.17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10931;
            dataRow["CustomerID"] = "RICSU";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["Freight"] = 13.6;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10951;
            dataRow["CustomerID"] = "RICSU";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("4/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["Freight"] = 30.85;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11033;
            dataRow["CustomerID"] = "RICSU";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/14/1996 12:00:00 AM");
            dataRow["Freight"] = 84.74;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11075;
            dataRow["CustomerID"] = "RICSU";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/3/1996 12:00:00 AM");
            dataRow["Freight"] = 6.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10281;
            dataRow["CustomerID"] = "ROMEY";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/14/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/28/1994 12:00:00 AM");
            dataRow["Freight"] = 2.94;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10282;
            dataRow["CustomerID"] = "ROMEY";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/15/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/13/1994 12:00:00 AM");
            dataRow["Freight"] = 12.69;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10306;
            dataRow["CustomerID"] = "ROMEY";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("10/17/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/14/1994 12:00:00 AM");
            dataRow["Freight"] = 7.56;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10917;
            dataRow["CustomerID"] = "ROMEY";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["Freight"] = 8.29;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11013;
            dataRow["CustomerID"] = "ROMEY";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/9/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/6/1996 12:00:00 AM");
            dataRow["Freight"] = 32.99;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10387;
            dataRow["CustomerID"] = "SANTG";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/15/1995 12:00:00 AM");
            dataRow["Freight"] = 93.63;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10520;
            dataRow["CustomerID"] = "SANTG";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/27/1995 12:00:00 AM");
            dataRow["Freight"] = 13.37;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10639;
            dataRow["CustomerID"] = "SANTG";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("9/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/18/1995 12:00:00 AM");
            dataRow["Freight"] = 38.64;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10831;
            dataRow["CustomerID"] = "SANTG";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/13/1996 12:00:00 AM");
            dataRow["Freight"] = 72.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10909;
            dataRow["CustomerID"] = "SANTG";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["Freight"] = 53.05;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11015;
            dataRow["CustomerID"] = "SANTG";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["Freight"] = 4.62;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10324;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("11/8/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/6/1994 12:00:00 AM");
            dataRow["Freight"] = 214.27;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10393;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/22/1995 12:00:00 AM");
            dataRow["Freight"] = 126.56;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10398;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("1/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/27/1995 12:00:00 AM");
            dataRow["Freight"] = 89.16;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10440;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/10/1995 12:00:00 AM");
            dataRow["Freight"] = 86.53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10452;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("3/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/20/1995 12:00:00 AM");
            dataRow["Freight"] = 140.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10510;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("5/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/16/1995 12:00:00 AM");
            dataRow["Freight"] = 367.63;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10555;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("7/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/31/1995 12:00:00 AM");
            dataRow["Freight"] = 252.49;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10603;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("8/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/15/1995 12:00:00 AM");
            dataRow["Freight"] = 48.77;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10607;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("8/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/19/1995 12:00:00 AM");
            dataRow["Freight"] = 200.24;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10612;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("8/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/25/1995 12:00:00 AM");
            dataRow["Freight"] = 544.08;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10627;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("9/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/23/1995 12:00:00 AM");
            dataRow["Freight"] = 107.46;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10657;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("10/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/2/1995 12:00:00 AM");
            dataRow["Freight"] = 352.69;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10678;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("10/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/21/1995 12:00:00 AM");
            dataRow["Freight"] = 388.98;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10700;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("11/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/8/1995 12:00:00 AM");
            dataRow["Freight"] = 65.1;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10711;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("11/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/2/1996 12:00:00 AM");
            dataRow["Freight"] = 52.41;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10713;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("11/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/20/1995 12:00:00 AM");
            dataRow["Freight"] = 167.05;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10714;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("11/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/20/1995 12:00:00 AM");
            dataRow["Freight"] = 24.49;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10722;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("11/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/10/1996 12:00:00 AM");
            dataRow["Freight"] = 74.58;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10748;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("12/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/18/1996 12:00:00 AM");
            dataRow["Freight"] = 232.55;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10757;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("12/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/25/1996 12:00:00 AM");
            dataRow["Freight"] = 8.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10815;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("2/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/4/1996 12:00:00 AM");
            dataRow["Freight"] = 14.62;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10847;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("2/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/7/1996 12:00:00 AM");
            dataRow["Freight"] = 487.57;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10882;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["Freight"] = 23.1;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10894;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("3/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/17/1996 12:00:00 AM");
            dataRow["Freight"] = 116.13;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10941;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["Freight"] = 400.81;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10983;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/24/1996 12:00:00 AM");
            dataRow["Freight"] = 657.54;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10984;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/27/1996 12:00:00 AM");
            dataRow["Freight"] = 211.22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11002;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["Freight"] = 141.16;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11030;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/14/1996 12:00:00 AM");
            dataRow["Freight"] = 830.75;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11031;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/14/1996 12:00:00 AM");
            dataRow["Freight"] = 227.22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11064;
            dataRow["CustomerID"] = "SAVEA";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("5/31/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/28/1996 12:00:00 AM");
            dataRow["Freight"] = 30.09;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10359;
            dataRow["CustomerID"] = "SEVES";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("12/22/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/19/1995 12:00:00 AM");
            dataRow["Freight"] = 288.43;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10377;
            dataRow["CustomerID"] = "SEVES";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/6/1995 12:00:00 AM");
            dataRow["Freight"] = 22.21;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10388;
            dataRow["CustomerID"] = "SEVES";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("1/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/16/1995 12:00:00 AM");
            dataRow["Freight"] = 34.86;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10472;
            dataRow["CustomerID"] = "SEVES";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("4/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/10/1995 12:00:00 AM");
            dataRow["Freight"] = 4.2;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10523;
            dataRow["CustomerID"] = "SEVES";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("6/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/29/1995 12:00:00 AM");
            dataRow["Freight"] = 77.63;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10547;
            dataRow["CustomerID"] = "SEVES";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("6/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/21/1995 12:00:00 AM");
            dataRow["Freight"] = 178.43;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10800;
            dataRow["CustomerID"] = "SEVES";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/23/1996 12:00:00 AM");
            dataRow["Freight"] = 137.44;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10804;
            dataRow["CustomerID"] = "SEVES";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("1/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["Freight"] = 27.33;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10869;
            dataRow["CustomerID"] = "SEVES";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/3/1996 12:00:00 AM");
            dataRow["Freight"] = 143.28;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10341;
            dataRow["CustomerID"] = "SIMOB";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("11/29/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/27/1994 12:00:00 AM");
            dataRow["Freight"] = 26.78;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10417;
            dataRow["CustomerID"] = "SIMOB";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("2/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/16/1995 12:00:00 AM");
            dataRow["Freight"] = 70.29;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10556;
            dataRow["CustomerID"] = "SIMOB";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("7/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/15/1995 12:00:00 AM");
            dataRow["Freight"] = 9.8;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10642;
            dataRow["CustomerID"] = "SIMOB";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("9/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/20/1995 12:00:00 AM");
            dataRow["Freight"] = 41.89;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10669;
            dataRow["CustomerID"] = "SIMOB";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("10/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/13/1995 12:00:00 AM");
            dataRow["Freight"] = 24.39;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10802;
            dataRow["CustomerID"] = "SIMOB";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("1/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/26/1996 12:00:00 AM");
            dataRow["Freight"] = 257.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11074;
            dataRow["CustomerID"] = "SIMOB";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("6/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/3/1996 12:00:00 AM");
            dataRow["Freight"] = 18.44;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10738;
            dataRow["CustomerID"] = "SPECD";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("12/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/10/1996 12:00:00 AM");
            dataRow["Freight"] = 2.91;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10907;
            dataRow["CustomerID"] = "SPECD";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("3/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/24/1996 12:00:00 AM");
            dataRow["Freight"] = 9.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10964;
            dataRow["CustomerID"] = "SPECD";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["Freight"] = 87.38;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11043;
            dataRow["CustomerID"] = "SPECD";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("5/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/19/1996 12:00:00 AM");
            dataRow["Freight"] = 8.8;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10271;
            dataRow["CustomerID"] = "SPLIR";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("9/1/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/29/1994 12:00:00 AM");
            dataRow["Freight"] = 4.54;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10329;
            dataRow["CustomerID"] = "SPLIR";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("11/15/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/27/1994 12:00:00 AM");
            dataRow["Freight"] = 191.67;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10349;
            dataRow["CustomerID"] = "SPLIR";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("12/9/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/6/1995 12:00:00 AM");
            dataRow["Freight"] = 8.63;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10369;
            dataRow["CustomerID"] = "SPLIR";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("1/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/30/1995 12:00:00 AM");
            dataRow["Freight"] = 195.68;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10385;
            dataRow["CustomerID"] = "SPLIR";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/14/1995 12:00:00 AM");
            dataRow["Freight"] = 30.96;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10432;
            dataRow["CustomerID"] = "SPLIR";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/3/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/17/1995 12:00:00 AM");
            dataRow["Freight"] = 4.34;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10756;
            dataRow["CustomerID"] = "SPLIR";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("12/28/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/25/1996 12:00:00 AM");
            dataRow["Freight"] = 73.21;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10821;
            dataRow["CustomerID"] = "SPLIR";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("2/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/7/1996 12:00:00 AM");
            dataRow["Freight"] = 36.68;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10974;
            dataRow["CustomerID"] = "SPLIR";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("4/24/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1996 12:00:00 AM");
            dataRow["Freight"] = 12.96;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10252;
            dataRow["CustomerID"] = "SUPRD";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("8/9/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/6/1994 12:00:00 AM");
            dataRow["Freight"] = 51.3;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10302;
            dataRow["CustomerID"] = "SUPRD";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("10/11/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/8/1994 12:00:00 AM");
            dataRow["Freight"] = 6.27;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10458;
            dataRow["CustomerID"] = "SUPRD";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("3/29/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/26/1995 12:00:00 AM");
            dataRow["Freight"] = 147.06;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10463;
            dataRow["CustomerID"] = "SUPRD";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("4/4/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1995 12:00:00 AM");
            dataRow["Freight"] = 14.78;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10475;
            dataRow["CustomerID"] = "SUPRD";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("4/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/12/1995 12:00:00 AM");
            dataRow["Freight"] = 68.52;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10767;
            dataRow["CustomerID"] = "SUPRD";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("1/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/2/1996 12:00:00 AM");
            dataRow["Freight"] = 1.59;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10841;
            dataRow["CustomerID"] = "SUPRD";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("2/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/19/1996 12:00:00 AM");
            dataRow["Freight"] = 424.3;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10846;
            dataRow["CustomerID"] = "SUPRD";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("2/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/4/1996 12:00:00 AM");
            dataRow["Freight"] = 56.46;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10885;
            dataRow["CustomerID"] = "SUPRD";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("3/14/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/11/1996 12:00:00 AM");
            dataRow["Freight"] = 5.64;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10930;
            dataRow["CustomerID"] = "SUPRD";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["Freight"] = 15.55;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11035;
            dataRow["CustomerID"] = "SUPRD";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/17/1996 12:00:00 AM");
            dataRow["Freight"] = 0.17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11038;
            dataRow["CustomerID"] = "SUPRD";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("5/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/18/1996 12:00:00 AM");
            dataRow["Freight"] = 29.59;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10310;
            dataRow["CustomerID"] = "THEBI";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("10/21/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/18/1994 12:00:00 AM");
            dataRow["Freight"] = 17.52;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10708;
            dataRow["CustomerID"] = "THEBI";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("11/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/29/1995 12:00:00 AM");
            dataRow["Freight"] = 2.96;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10805;
            dataRow["CustomerID"] = "THEBI";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("1/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["Freight"] = 237.34;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10992;
            dataRow["CustomerID"] = "THEBI";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("5/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/29/1996 12:00:00 AM");
            dataRow["Freight"] = 4.27;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10624;
            dataRow["CustomerID"] = "THECR";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/5/1995 12:00:00 AM");
            dataRow["Freight"] = 94.8;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10775;
            dataRow["CustomerID"] = "THECR";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("1/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/9/1996 12:00:00 AM");
            dataRow["Freight"] = 20.25;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11003;
            dataRow["CustomerID"] = "THECR";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["Freight"] = 14.91;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10249;
            dataRow["CustomerID"] = "TOMSP";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("8/5/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/16/1994 12:00:00 AM");
            dataRow["Freight"] = 11.61;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10438;
            dataRow["CustomerID"] = "TOMSP";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/9/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/6/1995 12:00:00 AM");
            dataRow["Freight"] = 8.24;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10446;
            dataRow["CustomerID"] = "TOMSP";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("3/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/14/1995 12:00:00 AM");
            dataRow["Freight"] = 14.68;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10548;
            dataRow["CustomerID"] = "TOMSP";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("6/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/24/1995 12:00:00 AM");
            dataRow["Freight"] = 1.43;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10608;
            dataRow["CustomerID"] = "TOMSP";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("8/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/20/1995 12:00:00 AM");
            dataRow["Freight"] = 27.79;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10967;
            dataRow["CustomerID"] = "TOMSP";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("4/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/20/1996 12:00:00 AM");
            dataRow["Freight"] = 62.22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10276;
            dataRow["CustomerID"] = "TORTU";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("9/8/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/22/1994 12:00:00 AM");
            dataRow["Freight"] = 13.84;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10293;
            dataRow["CustomerID"] = "TORTU";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("9/29/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/27/1994 12:00:00 AM");
            dataRow["Freight"] = 21.18;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10304;
            dataRow["CustomerID"] = "TORTU";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("10/13/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/10/1994 12:00:00 AM");
            dataRow["Freight"] = 63.79;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10319;
            dataRow["CustomerID"] = "TORTU";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("11/2/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/30/1994 12:00:00 AM");
            dataRow["Freight"] = 64.5;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10518;
            dataRow["CustomerID"] = "TORTU";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/26/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/9/1995 12:00:00 AM");
            dataRow["Freight"] = 218.15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10576;
            dataRow["CustomerID"] = "TORTU";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("7/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/7/1995 12:00:00 AM");
            dataRow["Freight"] = 18.56;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10676;
            dataRow["CustomerID"] = "TORTU";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("10/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/20/1995 12:00:00 AM");
            dataRow["Freight"] = 2.01;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10842;
            dataRow["CustomerID"] = "TORTU";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("2/20/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/19/1996 12:00:00 AM");
            dataRow["Freight"] = 54.42;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10915;
            dataRow["CustomerID"] = "TORTU";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("3/29/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/26/1996 12:00:00 AM");
            dataRow["Freight"] = 3.51;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11069;
            dataRow["CustomerID"] = "TORTU";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("6/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/1/1996 12:00:00 AM");
            dataRow["Freight"] = 15.67;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10292;
            dataRow["CustomerID"] = "TRADH";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("9/28/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/26/1994 12:00:00 AM");
            dataRow["Freight"] = 1.35;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10496;
            dataRow["CustomerID"] = "TRADH";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/2/1995 12:00:00 AM");
            dataRow["Freight"] = 46.77;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10606;
            dataRow["CustomerID"] = "TRADH";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("8/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/19/1995 12:00:00 AM");
            dataRow["Freight"] = 79.4;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10830;
            dataRow["CustomerID"] = "TRADH";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("2/13/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["Freight"] = 81.83;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10834;
            dataRow["CustomerID"] = "TRADH";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("2/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/14/1996 12:00:00 AM");
            dataRow["Freight"] = 29.78;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10839;
            dataRow["CustomerID"] = "TRADH";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/19/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/18/1996 12:00:00 AM");
            dataRow["Freight"] = 35.43;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10574;
            dataRow["CustomerID"] = "TRAIH";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("7/20/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/17/1995 12:00:00 AM");
            dataRow["Freight"] = 37.6;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10577;
            dataRow["CustomerID"] = "TRAIH";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("7/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/4/1995 12:00:00 AM");
            dataRow["Freight"] = 25.41;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10822;
            dataRow["CustomerID"] = "TRAIH";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("2/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/7/1996 12:00:00 AM");
            dataRow["Freight"] = 7;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10367;
            dataRow["CustomerID"] = "VAFFE";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("12/29/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/26/1995 12:00:00 AM");
            dataRow["Freight"] = 13.55;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10399;
            dataRow["CustomerID"] = "VAFFE";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("1/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/14/1995 12:00:00 AM");
            dataRow["Freight"] = 27.36;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10465;
            dataRow["CustomerID"] = "VAFFE";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/3/1995 12:00:00 AM");
            dataRow["Freight"] = 145.04;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10591;
            dataRow["CustomerID"] = "VAFFE";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("8/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/21/1995 12:00:00 AM");
            dataRow["Freight"] = 55.92;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10602;
            dataRow["CustomerID"] = "VAFFE";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("8/17/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/14/1995 12:00:00 AM");
            dataRow["Freight"] = 2.92;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10688;
            dataRow["CustomerID"] = "VAFFE";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("11/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/15/1995 12:00:00 AM");
            dataRow["Freight"] = 299.09;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10744;
            dataRow["CustomerID"] = "VAFFE";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("12/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/15/1996 12:00:00 AM");
            dataRow["Freight"] = 69.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10769;
            dataRow["CustomerID"] = "VAFFE";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/5/1996 12:00:00 AM");
            dataRow["Freight"] = 65.06;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10921;
            dataRow["CustomerID"] = "VAFFE";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/14/1996 12:00:00 AM");
            dataRow["Freight"] = 176.48;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10946;
            dataRow["CustomerID"] = "VAFFE";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/11/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/9/1996 12:00:00 AM");
            dataRow["Freight"] = 27.2;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10994;
            dataRow["CustomerID"] = "VAFFE";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/2/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/16/1996 12:00:00 AM");
            dataRow["Freight"] = 65.53;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10251;
            dataRow["CustomerID"] = "VICTE";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("8/8/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/5/1994 12:00:00 AM");
            dataRow["Freight"] = 41.34;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10334;
            dataRow["CustomerID"] = "VICTE";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("11/21/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/19/1994 12:00:00 AM");
            dataRow["Freight"] = 8.56;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10450;
            dataRow["CustomerID"] = "VICTE";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("3/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/19/1995 12:00:00 AM");
            dataRow["Freight"] = 7.23;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10459;
            dataRow["CustomerID"] = "VICTE";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/27/1995 12:00:00 AM");
            dataRow["Freight"] = 25.09;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10478;
            dataRow["CustomerID"] = "VICTE";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("4/18/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/2/1995 12:00:00 AM");
            dataRow["Freight"] = 4.81;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10546;
            dataRow["CustomerID"] = "VICTE";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("6/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/21/1995 12:00:00 AM");
            dataRow["Freight"] = 194.72;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10806;
            dataRow["CustomerID"] = "VICTE";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("1/31/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/28/1996 12:00:00 AM");
            dataRow["Freight"] = 22.11;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10814;
            dataRow["CustomerID"] = "VICTE";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/5/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/4/1996 12:00:00 AM");
            dataRow["Freight"] = 130.94;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10843;
            dataRow["CustomerID"] = "VICTE";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("2/21/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/20/1996 12:00:00 AM");
            dataRow["Freight"] = 9.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10850;
            dataRow["CustomerID"] = "VICTE";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("2/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["Freight"] = 49.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10248;
            dataRow["CustomerID"] = "VINET";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("8/4/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/1/1994 12:00:00 AM");
            dataRow["Freight"] = 32.38;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10274;
            dataRow["CustomerID"] = "VINET";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("9/6/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/4/1994 12:00:00 AM");
            dataRow["Freight"] = 6.01;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10295;
            dataRow["CustomerID"] = "VINET";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("10/3/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/31/1994 12:00:00 AM");
            dataRow["Freight"] = 1.15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10737;
            dataRow["CustomerID"] = "VINET";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("12/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/9/1996 12:00:00 AM");
            dataRow["Freight"] = 7.79;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10739;
            dataRow["CustomerID"] = "VINET";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("12/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/10/1996 12:00:00 AM");
            dataRow["Freight"] = 11.08;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10301;
            dataRow["CustomerID"] = "WANDK";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("10/10/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/7/1994 12:00:00 AM");
            dataRow["Freight"] = 45.08;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10312;
            dataRow["CustomerID"] = "WANDK";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("10/24/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/21/1994 12:00:00 AM");
            dataRow["Freight"] = 40.26;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10348;
            dataRow["CustomerID"] = "WANDK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("12/8/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/5/1995 12:00:00 AM");
            dataRow["Freight"] = 0.78;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10356;
            dataRow["CustomerID"] = "WANDK";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("12/19/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/16/1995 12:00:00 AM");
            dataRow["Freight"] = 36.71;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10513;
            dataRow["CustomerID"] = "WANDK";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/23/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/4/1995 12:00:00 AM");
            dataRow["Freight"] = 105.65;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10632;
            dataRow["CustomerID"] = "WANDK";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("9/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/12/1995 12:00:00 AM");
            dataRow["Freight"] = 41.38;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10640;
            dataRow["CustomerID"] = "WANDK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/19/1995 12:00:00 AM");
            dataRow["Freight"] = 23.55;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10651;
            dataRow["CustomerID"] = "WANDK";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("10/2/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/30/1995 12:00:00 AM");
            dataRow["Freight"] = 20.6;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10668;
            dataRow["CustomerID"] = "WANDK";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("10/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/13/1995 12:00:00 AM");
            dataRow["Freight"] = 47.22;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11046;
            dataRow["CustomerID"] = "WANDK";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/20/1996 12:00:00 AM");
            dataRow["Freight"] = 71.64;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10266;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("8/26/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/7/1994 12:00:00 AM");
            dataRow["Freight"] = 25.73;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10270;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("9/1/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/29/1994 12:00:00 AM");
            dataRow["Freight"] = 136.54;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10320;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("11/3/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/17/1994 12:00:00 AM");
            dataRow["Freight"] = 34.57;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10333;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("11/18/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/16/1994 12:00:00 AM");
            dataRow["Freight"] = 0.59;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10412;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("2/13/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/13/1995 12:00:00 AM");
            dataRow["Freight"] = 3.77;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10416;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("2/16/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/16/1995 12:00:00 AM");
            dataRow["Freight"] = 22.72;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10437;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("3/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1995 12:00:00 AM");
            dataRow["Freight"] = 19.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10455;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("3/27/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1995 12:00:00 AM");
            dataRow["Freight"] = 180.45;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10526;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("6/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/3/1995 12:00:00 AM");
            dataRow["Freight"] = 58.59;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10553;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("6/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("7/28/1995 12:00:00 AM");
            dataRow["Freight"] = 149.49;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10583;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("7/31/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/28/1995 12:00:00 AM");
            dataRow["Freight"] = 7.28;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10636;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("9/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/17/1995 12:00:00 AM");
            dataRow["Freight"] = 1.15;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10750;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("12/22/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/19/1996 12:00:00 AM");
            dataRow["Freight"] = 79.3;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10781;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("1/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/14/1996 12:00:00 AM");
            dataRow["Freight"] = 73.16;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11025;
            dataRow["CustomerID"] = "WARTH";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("5/15/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/12/1996 12:00:00 AM");
            dataRow["Freight"] = 29.17;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10256;
            dataRow["CustomerID"] = "WELLI";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("8/15/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/12/1994 12:00:00 AM");
            dataRow["Freight"] = 13.97;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10420;
            dataRow["CustomerID"] = "WELLI";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("2/21/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/21/1995 12:00:00 AM");
            dataRow["Freight"] = 44.12;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10585;
            dataRow["CustomerID"] = "WELLI";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("8/1/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("8/29/1995 12:00:00 AM");
            dataRow["Freight"] = 13.41;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10644;
            dataRow["CustomerID"] = "WELLI";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("9/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("10/23/1995 12:00:00 AM");
            dataRow["Freight"] = 0.14;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10803;
            dataRow["CustomerID"] = "WELLI";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("1/30/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/27/1996 12:00:00 AM");
            dataRow["Freight"] = 55.23;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10809;
            dataRow["CustomerID"] = "WELLI";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("2/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/29/1996 12:00:00 AM");
            dataRow["Freight"] = 4.87;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10900;
            dataRow["CustomerID"] = "WELLI";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("3/22/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/19/1996 12:00:00 AM");
            dataRow["Freight"] = 1.66;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10905;
            dataRow["CustomerID"] = "WELLI";
            dataRow["EmployeeID"] = 9;
            dataRow["OrderDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["Freight"] = 13.72;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10935;
            dataRow["CustomerID"] = "WELLI";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("4/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/6/1996 12:00:00 AM");
            dataRow["Freight"] = 47.59;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10269;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("8/31/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/14/1994 12:00:00 AM");
            dataRow["Freight"] = 4.56;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10344;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("12/2/1994 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/30/1994 12:00:00 AM");
            dataRow["Freight"] = 23.29;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10469;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("4/10/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/8/1995 12:00:00 AM");
            dataRow["Freight"] = 60.18;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10483;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("4/24/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/22/1995 12:00:00 AM");
            dataRow["Freight"] = 15.28;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10504;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/12/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/9/1995 12:00:00 AM");
            dataRow["Freight"] = 59.13;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10596;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("8/11/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/8/1995 12:00:00 AM");
            dataRow["Freight"] = 16.34;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10693;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("11/6/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/20/1995 12:00:00 AM");
            dataRow["Freight"] = 139.34;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10696;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("11/8/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/20/1995 12:00:00 AM");
            dataRow["Freight"] = 102.55;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10723;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("11/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/28/1995 12:00:00 AM");
            dataRow["Freight"] = 21.72;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10740;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("12/14/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("1/11/1996 12:00:00 AM");
            dataRow["Freight"] = 81.88;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10861;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/1/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("3/29/1996 12:00:00 AM");
            dataRow["Freight"] = 14.93;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10904;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/26/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/23/1996 12:00:00 AM");
            dataRow["Freight"] = 162.95;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11032;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/14/1996 12:00:00 AM");
            dataRow["Freight"] = 606.19;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11066;
            dataRow["CustomerID"] = "WHITC";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("5/31/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/28/1996 12:00:00 AM");
            dataRow["Freight"] = 44.72;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10615;
            dataRow["CustomerID"] = "WILMK";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("8/30/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/27/1995 12:00:00 AM");
            dataRow["Freight"] = 0.75;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10673;
            dataRow["CustomerID"] = "WILMK";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("10/19/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("11/16/1995 12:00:00 AM");
            dataRow["Freight"] = 22.76;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10695;
            dataRow["CustomerID"] = "WILMK";
            dataRow["EmployeeID"] = 7;
            dataRow["OrderDate"] = DateTime.Parse("11/7/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("12/19/1995 12:00:00 AM");
            dataRow["Freight"] = 16.72;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10873;
            dataRow["CustomerID"] = "WILMK";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/8/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/5/1996 12:00:00 AM");
            dataRow["Freight"] = 0.82;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10879;
            dataRow["CustomerID"] = "WILMK";
            dataRow["EmployeeID"] = 3;
            dataRow["OrderDate"] = DateTime.Parse("3/12/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/9/1996 12:00:00 AM");
            dataRow["Freight"] = 8.5;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10910;
            dataRow["CustomerID"] = "WILMK";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("3/28/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/25/1996 12:00:00 AM");
            dataRow["Freight"] = 38.11;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11005;
            dataRow["CustomerID"] = "WILMK";
            dataRow["EmployeeID"] = 2;
            dataRow["OrderDate"] = DateTime.Parse("5/7/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/4/1996 12:00:00 AM");
            dataRow["Freight"] = 0.75;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10374;
            dataRow["CustomerID"] = "WOLZA";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/5/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/2/1995 12:00:00 AM");
            dataRow["Freight"] = 3.94;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10611;
            dataRow["CustomerID"] = "WOLZA";
            dataRow["EmployeeID"] = 6;
            dataRow["OrderDate"] = DateTime.Parse("8/25/1995 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("9/22/1995 12:00:00 AM");
            dataRow["Freight"] = 80.65;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10792;
            dataRow["CustomerID"] = "WOLZA";
            dataRow["EmployeeID"] = 1;
            dataRow["OrderDate"] = DateTime.Parse("1/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("2/20/1996 12:00:00 AM");
            dataRow["Freight"] = 23.79;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10870;
            dataRow["CustomerID"] = "WOLZA";
            dataRow["EmployeeID"] = 5;
            dataRow["OrderDate"] = DateTime.Parse("3/6/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/3/1996 12:00:00 AM");
            dataRow["Freight"] = 12.04;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10906;
            dataRow["CustomerID"] = "WOLZA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("3/27/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("4/10/1996 12:00:00 AM");
            dataRow["Freight"] = 26.29;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 10998;
            dataRow["CustomerID"] = "WOLZA";
            dataRow["EmployeeID"] = 8;
            dataRow["OrderDate"] = DateTime.Parse("5/3/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("5/17/1996 12:00:00 AM");
            dataRow["Freight"] = 20.31;
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["OrderID"] = 11044;
            dataRow["CustomerID"] = "WOLZA";
            dataRow["EmployeeID"] = 4;
            dataRow["OrderDate"] = DateTime.Parse("5/23/1996 12:00:00 AM");
            dataRow["RequiredDate"] = DateTime.Parse("6/20/1996 12:00:00 AM");
            dataRow["Freight"] = 8.72;
            table.Rows.Add(dataRow);

            return table;
        }
    }
}
