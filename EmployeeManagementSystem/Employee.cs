using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    //Abstract Employee class
    abstract class Employee
    {
        #region Private variables
        protected int EmployeeID;
        protected string FirstName; 
        protected string LastName; 
        protected string StreetAddr;
        protected string City;
        protected string State;
        protected int Zip;
        protected DateTime DOB;
        //Console.WriteLine(thisDate.ToString("d"));           // Displays 3/15/2008
        protected DateTime HireDate;
        protected double PayRate;
        protected string Position;
        protected bool HasBenefit;
        #endregion

        #region Properties
        public int employeeID
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }

        public string firstName
        {
            get { return FirstName;  }
            set { FirstName = checkInput("first name", value); }
        }

        public string lastName
        {
            get { return LastName; }
            set { LastName = checkInput("last name", value); }
        }

        public string streetAddr
        {
            get { return StreetAddr; }
            set { StreetAddr = checkInput("street address", value); }
        }

        public string city
        {
            get { return City; }
            //Need to check if the value belongs to database
            set {City = value; }
        }

        public string state
        {
            get { return State; }
            //Need to check if the value belongs to database
            set { State = value; }
        }

        public int zip
        {
            //Need to check if the value belongs to database
            get { return Zip; }
            set { Zip = value; }
        }

        public DateTime dob
        {
            get { return DOB; }
            set { DOB = value; }
        }

        public DateTime hireDate
        {
            get { return HireDate; }
            set { HireDate = value; }
        }

        public double payRate
        {
            get { return PayRate;}
            set { PayRate = checkInput("pay rate", value) ;}
        }
        public string position
        {
            get {return Position; }
            set {Position = value; }
        }
        public bool hasBenefit
        {
            get {return HasBenefit; }
            set {HasBenefit = value; }
        }

        #endregion

        #region Constructors
        public Employee(){}

        public Employee(int employeeID, string firstName, string lastName, string streetAddr, string city, string state, int zip, DateTime dob, DateTime hireDate, double payRate, string position, bool hasBenefit)
        {
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.streetAddr = streetAddr;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.dob = dob;
            this.hireDate = hireDate;
            this.payRate = payRate;
            this.position = position;
            this.hasBenefit = hasBenefit;
        }

        #endregion

        #region Methods
        #region Check input exception overloading methods
        //check string value
        protected string checkInput(string inp, string val)
        {
            try
            {
                if (val.Length == 0)
                {
                    InputException ex = new InputException($"Missing {inp} value!", DateTime.Today);
                    throw ex;
                }
            }
            catch (InputException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return val;
        }

        //check integer exception
        protected int checkInput(string inp, int val)
        {
            try
            {
                if (val < 0)
                {
                    InputException ex = new InputException($"The {inp} need to be a positive number!", DateTime.Today);
                    throw ex;
                }
            }
            catch (InputException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return val;
        }

        //check double value
        protected double checkInput(string inp, double val)
        {
            try
            {
                if (val < 0.0)
                {
                    InputException ex = new InputException($"The {inp} need to be a positive number!", DateTime.Today);
                    throw ex;
                }
            }
            catch (InputException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return val;
        }
        #endregion

        ////Create a abstract method to be overridden by derived classes
        //public abstract void ShowImportantInfos();

        ////Create an virtual method for this base method
        //public virtual void PayRateIncreasePerYear()
        //{
        //    MessageBox.Show("Increasing Rate per year for the employee is 10%");
        //}

        //Override ToString() method to show on listBox
        public override string ToString()
        {
            return this.firstName + 
                " " + this.lastName;
        }

        //Create a virtual method with base actions, which will be overridden by derived classes
        public virtual string ShowInfos()
        {
            string result = "First Name: " + this.firstName + Environment.NewLine +
                "Last Name: " + this.lastName + Environment.NewLine +
                "Street Address: " + this.streetAddr + Environment.NewLine +
                "City: " + this.city + Environment.NewLine +
                "State: " + this.state + Environment.NewLine +
                "Zip code: " + this.zip + Environment.NewLine +
                "Date Of Birth: " + this.dob.ToString().Remove(this.dob.ToString().IndexOf(' ')) + Environment.NewLine +
                "Hiring Date: " + this.hireDate.ToString().Remove(this.hireDate.ToString().IndexOf(' ')) + Environment.NewLine +
                "PayRate: " + this.payRate + Environment.NewLine +
                "Position: " + this.position + Environment.NewLine +
                "Benefit: " + this.hasBenefit + Environment.NewLine;
            return result;
        }

        #endregion
    }
}
