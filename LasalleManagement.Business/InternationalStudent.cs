using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasalleManagement.Business
{
    public class InternationalStudent : Student
    {
        private string _homeCountry = "";

        public string HomeCountry
        {
            get { return _homeCountry; }
            set { _homeCountry = value; }
        }

        public string AllInternationalStudentFields
        {
            get
            {
                return $"{_id}, {_name}, {_email}, {_homeCountry}";
            }
        }
    }
}
