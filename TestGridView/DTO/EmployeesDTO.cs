using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeesDTO
    {
        string _StrID;
        string _StrFullName;
        string _StrNumberPhone;
        DateTime _DTBirthDay;
        string _StrGender;
        string _StrEmail;
        string _StrPassword;
        string _StrIDCard;
        decimal _DecSalary;
        string _StrEmployTypeID;
        bool _BStatus;

        public string StrID { get => _StrID; set => _StrID = value; }
        public string StrFullName { get => _StrFullName; set => _StrFullName = value; }
        public string StrNumberPhone { get => _StrNumberPhone; set => _StrNumberPhone = value; }
        public DateTime DTBirthDay { get => _DTBirthDay; set => _DTBirthDay = value; }
        public string StrGender { get => _StrGender; set => _StrGender = value; }
        public string StrEmail { get => _StrEmail; set => _StrEmail = value; }
        public string StrPassword { get => _StrPassword; set => _StrPassword = value; }
        public string StrIDCard { get => _StrIDCard; set => _StrIDCard = value; }
        public decimal DecSalary { get => _DecSalary; set => _DecSalary = value; }
        public string StrEmployTypeID { get => _StrEmployTypeID; set => _StrEmployTypeID = value; }
        public bool BStatus { get => _BStatus; set => _BStatus = value; }
    }
}
