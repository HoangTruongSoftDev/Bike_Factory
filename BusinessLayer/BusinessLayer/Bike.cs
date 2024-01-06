using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace BusinessLayer
{
    [Serializable]
    [XmlInclude(typeof(MountainBike))]
    [XmlInclude(typeof(RoadBike))]


    public abstract class Bike : Object
    {
        private long serialNumber;
        private string make;
        private string model;
        private EnumColor color;
        private double speed;
        private Date date;
        private string insurance;

        public Bike()
        {
            this.SerialNumber = 0;
            this.Make = "Undefined";
            this.Model = "Undefined";
            this.Color = EnumColor.Undefined;
            this.Speed = 0.00;
            this.Date = new Date();
            this.Insurance = "Undefined";
        }
        public Bike(long serialNumber, string make, string model, EnumColor color, double speed, Date date, string insurance)
        {
            this.SerialNumber = serialNumber;
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.Speed = speed;
            this.Date = date;
            this.Insurance = insurance;
        }
        public long SerialNumber
        {
            get { return this.serialNumber; }
            set { this.serialNumber = value; }
        }
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public EnumColor Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public double Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        public Date Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public string Insurance
        {
            get { return this.insurance; }
            set { this.insurance = value; }
        }
        public virtual double GetMaxSpeed()
        {
            return 20.00;
        }
        public abstract void SpeedUp(double newSpeed);
        public override string ToString()
        {
            return $"Serial number: {this.SerialNumber} \nMake by: {this.Make} \nModel: {this.Model} \nColor: {this.Color} \nSpeed: {this.Speed} km/h \nDate: {this.Date} \nInsurance: {this.Insurance} \n";
        }
    }
}
