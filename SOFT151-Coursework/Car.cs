using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT151_Coursework
{
    public class Car
    {
        // Object Properties:

        private int idNumber;
        private string make;
        private string model;
        private string registration;
        private string fuelType;
        private DateTime lastServiced;
        private string comments;

        // Constructor:

        public Car(int id, string carMake, string carModel, string carReg, string fuel, DateTime lastService, string commentsMade)
        {
            this.idNumber = id;
            this.make = carMake;
            this.model = carModel;
            this.registration = carReg;
            this.fuelType = fuel;
            this.lastServiced = lastService;
            this.comments = commentsMade;
        }

        // Setter Methods:

        public void SetId(int id)
        {
            this.idNumber = id;
        }
        public void SetMake(string carMake)
        {
            this.make = carMake;
        }
        public void SetModel(string carModel)
        {
            this.model = carModel;
        }
        public void SetRegistration(string carReg)
        {
            this.registration = carReg;
        }
        public void SetFuelType(string fuel)
        {
            this.fuelType = fuel;
        }
        public void SetDateLastServiced(DateTime lastService)
        {
            this.lastServiced = lastService;
        }
        public void SetComments(string commentsMade)
        {
            this.comments = commentsMade;
        }
       
        // Getter Methods:

        public int GetId()
        {
            return this.idNumber;
        }
        public string GetMake()
        {
            return this.make;
        }
        public string GetModel()
        {
            return this.model;
        }
        public string GetReg()
        {
            return this.registration;
        }
        public string GetFuelType()
        {
            return this.fuelType;
        }
        public DateTime GetDateLastServiced()
        {
            return this.lastServiced;
        }
        public string GetComments()
        {
            return this.comments;
        }
        
        // Extra Methods:

        public string PrintSummary() // Used to retrieve a summary of the car's information
        {
            return "Car make: " + make + " -- Car model: " + model + " -- (ID: " + idNumber + ")";
        }
    }
}
