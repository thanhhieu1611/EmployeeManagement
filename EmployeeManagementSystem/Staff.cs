using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    class Staff : Employee
    {
        #region Private variable
        private string OfficeLocation;
        private string Dept;
        private double HoursAllowed;
        private double VacationDays;
        #endregion

        #region Properties
        public string officeLocation
        {
            get { return OfficeLocation; }
            set { OfficeLocation = checkInput("office location", value); }
        }
        public string dept
        {
            get { return Dept; }
            set { Dept = checkInput("dept", value); }
        }
        public double hoursAllowed
        {
            get { return HoursAllowed; }
            set { HoursAllowed = checkInput("hours allowed to work", value); }
        }
        public double vacationDays
        {
            get { return VacationDays; }
            set { VacationDays = checkInput("vacation days", value); }
        }

        #endregion

        #region Constructors
        public Staff() { }

        public Staff(int employeeID, string firstName, string lastName, string streetAddr, string city, string state, int zip, DateTime dob, DateTime hireDate, double payRate, string position, bool hasBenefit, string officeLocation, string dept, double hoursAllowed, double vacationDays) : base(employeeID, firstName, lastName, streetAddr, city, state, zip, dob, hireDate, payRate, position, hasBenefit)
        {
            this.officeLocation = officeLocation;
            this.dept = dept;
            this.hoursAllowed = hoursAllowed;
            this.vacationDays = vacationDays;
        }
        #endregion

        #region Methods
        //Override abstract method
        public override string ShowInfos()
        {
            string baseResult = base.ShowInfos();
            baseResult += "Office Location: " + this.officeLocation + Environment.NewLine +
                "Department: " + this.dept + Environment.NewLine +
                "Hours Allowed: " + this.hoursAllowed + Environment.NewLine +
                "Vacation days: " + this.vacationDays + Environment.NewLine;
            return baseResult;

        }



        #endregion
    }
}
