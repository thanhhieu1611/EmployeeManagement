using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    class Intern : Employee
    {
        #region Private variable
        private bool IsPaid;
        private DateTime BeginningTime;
        private DateTime EndTime;
        private string Major;
        private string School;
        #endregion

        #region Properties
        public bool isPaid
        {
            get { return IsPaid; }
            set { IsPaid = value; }
        }
        public DateTime beginningTime
        {
            get { return BeginningTime; }
            set { BeginningTime = value; }
        }
        public DateTime endTime
        {
            get { return EndTime; }
            set { EndTime = value; }
        }
        public string major
        {
            get { return Major; }
            set { Major = checkInput("major", value); }
        }
        public string school
        {
            get { return School; }
            set { School = checkInput("school", value); }
        }

        #endregion

        #region Constructors
        public Intern() { }

        public Intern(int employeeID, string firstName, string lastName, string streetAddr, string city, string state, int zip, DateTime dob, DateTime hireDate, double payRate, string position, bool hasBenefit, bool isPaid, DateTime beginningTime, DateTime endTime, string major, string school) : base(employeeID, firstName, lastName, streetAddr, city, state, zip, dob, hireDate, payRate, position, hasBenefit)
        {
            this.isPaid = isPaid;
            this.beginningTime = beginningTime;
            this.endTime = endTime;
            this.major = major;
            this.school = school;
        }
        #endregion

        #region Methods
        //Override abstract method
        public override string ShowInfos()
        {
            string baseResult = base.ShowInfos();
            baseResult += "Paid Working: " + this.isPaid + Environment.NewLine +
                "Beginning Time: " + this.beginningTime.ToString().Remove(this.beginningTime.ToString().IndexOf(' ')) + Environment.NewLine +
                "Ending Time: " + this.endTime.ToString().Remove(this.endTime.ToString().IndexOf(' ')) + Environment.NewLine +
                "Major: " + this.major + Environment.NewLine +
                "School: " + this.school + Environment.NewLine;
            return baseResult;
        }

        ////Override virtual method
        //public override void PayRateIncreasePerYear()
        //{
        //    MessageBox.Show("We do not have increasing pay rate policy for intern!");
        //}

        #endregion
    }
}
