using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEmployee
{
    public class EmptyQualification: Exception
    {
        public EmptyQualification() : base("EMPTY QUALIFICATION-QUALIFICATION CAN'T BE EMPTY.") { }
    }
    public class InvalidQualification : Exception
    {
        public InvalidQualification() : base("INVALID QUALIFICATION-PLEASE ENTER QUALIFICATION ONLY AS: BCA, BE, BSC, BCom, MCom OR CA.") { }
    }
    class Employee
    {
        private int _employeeID;
        private string _qualification;
        private string _department;
        public Employee(int employeeID, string qualification)
        {
            this._employeeID = employeeID;
            if (qualification.Equals("BE") || qualification.Equals("BCA") || qualification.Equals("BSC"))
            {
                this._department = "IT Department";
                Console.WriteLine("EMPLOYEE ADDED UNDER IT DEPARTMENT");
            }
            else if (qualification.Equals("BCom") || qualification.Equals("MCom") || qualification.Equals("CA"))
            {
                this._department = "Accounts Department";
                Console.WriteLine("EMPLOYEE ADDED UNDER ACCOUNTS DEPARTMENT");
            }
            else if (Qualification == "")
            {
                throw (new EmptyQualification());
            }
            else
            {
                throw (new InvalidQualification());
            }
            this._qualification = Qualification;
        }
        public string Qualification
        {
            get
            {
                return this._qualification;
            }

        }
        public string Department
        {
            get
            {
                return this._department;
            }

        }

    }
}
