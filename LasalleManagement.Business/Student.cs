namespace LasalleManagement.Business
{
    public class Student
    {
        protected int _id;
        protected string _name = "";
        protected string _email = "";

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string AllStudentFields
        {
            get
            {
                return $"{_id}, {_name}, {_email}";
            }
        }
    }
}
