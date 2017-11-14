using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT151_Coursework
{
    public class Company
    {
        // Object Properties:

        private int idNumber;
        private string name;
        private string address;
        private string postcode;
        private int numCars;

        // Array list used to store information about the companies cars:

        List<Car> cars = new List<Car>();

        // Constructor:

        public Company(int id, string companyName, string companyAddress, string companyPostcode)
        {
            this.idNumber = id;
            this.name = companyName;
            this.address = companyAddress;
            this.postcode = companyPostcode;
        }

        // Setter Methods:

        public void SetId(int id) { this.idNumber = id; }
        public void SetName(string companyName) { this.name = companyName; }
        public void SetAddress(string companyAddress) { this.address = companyAddress; }
        public void SetPostcode(string companyPostcode) { this.postcode = companyPostcode; }
        public void SetNumCars(int numberOfCars) { this.numCars = numberOfCars; }

        // Getter Methods:

        public int GetId() { return this.idNumber; }
        public string GetName() { return this.name; }
        public string GetAddress() { return this.address; }
        public string GetPostcode() { return this.postcode; }
        public int GetNumberOfCars() { return this.numCars; }

        // Extra Methods:

        public string PrintSummary()
        {
            return "Company name: " + name + " --  ID number: " + idNumber.ToString();
        }
    }
}
