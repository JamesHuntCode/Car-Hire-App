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

        // Array list used to store information about the companies cars:

        private List<Car> cars = new List<Car>();

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
        public void AddNewCar(Car newCar) { this.cars.Add(newCar); } // Method used to add a new car to the company's records

        // Getter Methods:

        public int GetId() { return this.idNumber; }
        public string GetName() { return this.name; }
        public string GetAddress() { return this.address; }
        public string GetPostcode() { return this.postcode; }
        public int GetNumberOfCars() { return this.cars.Count; }
        public List<Car> GetAllCars() { return this.cars; } // Method used to obtain a full list of all of the company's cars

        // Extra Methods:
        
        public void removeCar(Car car) // Method used to remove a specific car from the companies records
        {
            this.cars.Remove(car);
        }

        public string PrintSummary() // Used to retrieve a summary of the company's information
        {
            return "Company name: " + name + " <-----> (ID number: " + idNumber.ToString() + ")";
        }
    }
}
