using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    class Manager : Employee
    {
        #region Private variable
        private string OfficeLocation;
        private string Dept;
        private string AdminAssist;
        private double VacationDays;
        private int ParkingSpot;
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
        public string adminAssist
        {
            get { return AdminAssist; }
            set { AdminAssist = checkInput("administrative assistant", value); }
        }
        public double vacationDays
        {
            get { return VacationDays; }
            set { VacationDays = checkInput("vacation days", value); }
        }
        public int parkingSpot
        {
            get { return ParkingSpot; }
            set { ParkingSpot = checkInput("parking spot", value); }
        }
        #endregion

        #region Constructors
        public Manager() { }

        public Manager(int employeeID, string firstName, string lastName, string streetAddr, string city, string state, int zip, DateTime dob, DateTime hireDate, double payRate, string position, bool hasBenefit, string officeLocation, string dept, string adminAssist, double vacationDays, int parkingSpot) : base(employeeID, firstName, lastName, streetAddr, city, state, zip, dob, hireDate, payRate, position, hasBenefit)
        {
            this.officeLocation = officeLocation;
            this.dept = dept;
            this.adminAssist = adminAssist;
            this.vacationDays = vacationDays;
            this.parkingSpot = parkingSpot;
        }
        #endregion

        #region Methods
        //Override abstract method
        public override string ShowInfos()
        {
            string baseResult = base.ShowInfos();
            baseResult += "Office Location: " + this.officeLocation + Environment.NewLine +
                "Department: " + this.dept + Environment.NewLine +
                "Admin-Assistant: " + this.adminAssist + Environment.NewLine +
                "Vacation days: " + this.vacationDays + Environment.NewLine +
                "Parking Spot: " + this.parkingSpot + Environment.NewLine;
            return baseResult;
        }

        #endregion
    }
}
