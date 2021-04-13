using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class EmployeesDAO
    {
        public static List<EmployeesDTO> loadListEmployDAO()
        {
            List<EmployeesDTO> LstEmp = new List<EmployeesDTO>();
            string StrSelect = @"select * from tblEmployees";
            try
            {
                SqlConnection SqlConn = DataProvider_DAO.OpenConnect();
                SqlDataReader SqlSdr = DataProvider_DAO.SelectData(StrSelect, SqlConn);
                while(SqlSdr.Read())
                {
                    EmployeesDTO EmpTemp = new EmployeesDTO();
                    if(!SqlSdr.IsDBNull(0))
                    {
                        EmpTemp.StrID = SqlSdr["ID"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrID = "";
                    }
                    if(!SqlSdr.IsDBNull(1))
                    {
                        EmpTemp.StrFullName = SqlSdr["FullName"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrFullName = "";
                    }
                    if (!SqlSdr.IsDBNull(2))
                    {
                        EmpTemp.StrNumberPhone = SqlSdr["NumberPhone"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrNumberPhone = "";
                    }
                    if (!SqlSdr.IsDBNull(3))
                    {
                        EmpTemp.DTBirthDay = Convert.ToDateTime(SqlSdr["BirthDay"]);
                    }
                    else
                    {
                        EmpTemp.DTBirthDay = DateTime.Now;
                    }
                    if (!SqlSdr.IsDBNull(4))
                    {
                        EmpTemp.StrGender = SqlSdr["Gender"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrGender = "";
                    }
                    if (!SqlSdr.IsDBNull(5))
                    {
                        EmpTemp.StrEmail = SqlSdr["Email"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrEmail = "";
                    }
                    if (!SqlSdr.IsDBNull(6))
                    {
                        EmpTemp.StrPassword = SqlSdr["Password"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrPassword= "";
                    }
                    if (!SqlSdr.IsDBNull(7))
                    {
                        EmpTemp.StrIDCard= SqlSdr["IDCard"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrIDCard = "";
                    }
                    if (!SqlSdr.IsDBNull(8))
                    {
                        EmpTemp.DecSalary = Convert.ToDecimal(SqlSdr["Salary"].ToString());
                    }
                    else
                    {
                        EmpTemp.DecSalary = 0;
                    }
                    if (!SqlSdr.IsDBNull(9))
                    {
                        EmpTemp.StrEmployTypeID = SqlSdr["EmployOfTypeID"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrEmployTypeID = "";
                    }
                    if (!SqlSdr.IsDBNull(10))
                    {
                        EmpTemp.BStatus = Convert.ToBoolean(SqlSdr["Status"]);
                    }
                    else
                    {
                        EmpTemp.BStatus = false;
                    }
                    LstEmp.Add(EmpTemp);
                }
                SqlSdr.Close();
                SqlConn.Close();
                return LstEmp;
            }
            catch
            {
                return null;
            }
        }
    }
}
