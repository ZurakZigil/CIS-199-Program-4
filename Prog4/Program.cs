/*
Grading ID: W9957
Program#: 4
Due Date: 4/24/2018 11:59.00
Course Section: 199-01

Description:
A program that utilizes classes and methods to validate package information and then presents it

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    public class GroundPackage
    {
        //The Club
        private uint _originZip;        //original zip/shipping zip
        private uint _destinationZip;   //destination zip/delivery zip
        private double _length;         //the packages length
        private double _width;          //the packages width
        private double _height;         //the packages height
        private double _weight;         //the packages weight
        private uint _zoneDistance;     //the calcualted difference between zips

        //The Door
        //allows submission of values into the class
        public GroundPackage(uint originZip, uint destinationZip, double length, double width, double height, double weight) 
        {
            OriginZip = originZip;
            DestinationZip = destinationZip;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        //validates the destination zip
        //Has to be positive and less than 5 digits
        //returns origin zip
        public uint OriginZip 
        {
            get => _originZip;
            set
            {
                if (value >= 0 && value <= 99999)
                    _originZip = value;
                else
                    _originZip = 40202;
            }
        }

        //validates the destination zip
        //Has to be positive and less than 5 digits
        //returns destination zip
        public uint DestinationZip
        {
            get => _destinationZip;
            set
            {
                if (value >= 0 && value <= 99999)
                    _destinationZip = value;
                else
                    _destinationZip = 40202;
            }
        }

        //validates the Length
        //Has to be positive 
        //returns double length
        public double Length
        {
            get => _length;
            set
            {
                if (value > 0)
                    _length = value;
                else
                    _length = 1.0;
            }
        }

        //validates the width
        //Has to be positive 
        //returns double width
        public double Width
        {
            get => _width;
            set
            {
                if (value > 0)
                    _width = value;
                else
                    _width = 1.0;
            }
        }

        //validates the Height
        //Has to be positive 
        //returns uint height
        public double Height
        {
            get => _height;
            set
            {
                if (value > 0)
                    _height = value;
                else
                    _height = 1.0;
            }
        }

        //validates the weight
        //Has to be positive 
        //returns uint weight
        public double Weight
        {
            get => _weight;
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    _weight = 1.0;
            }
        }

        //creates the zone distance
        //requires original zip and destination zip
        //returns uint zone distance
        public uint ZoneDistance
        {
            get
            {
                if(_originZip - _destinationZip > 0)
                {
                    _zoneDistance = (_originZip - _destinationZip)/ 10000;
                    return _zoneDistance; 
                }
                else
                {
                    _zoneDistance = (_destinationZip - _originZip) / 10000;
                    return _zoneDistance;
                }
            }
        }

        //all values have to be posiive and _zoneDistance required
        //reurns double shipping cost
        public double CalcCost()
        {
            double shippingCost = 0.20 * (_length + _width + _height) + 0.5 * (_zoneDistance +1)*(_weight);
            return shippingCost;
        }

        //an overriding ToString conversion
        //pre-consdition: requires all _destinationZip,_length,_width,_height,_weight
        //post-condition: submits a string thats a list of the pre-condition
        public override string ToString()
        {
            string newString = $"Shipping Zip: {_originZip}{Environment.NewLine}" +
                $"Delivery Zip: {_destinationZip}{Environment.NewLine}" +
                $"Length: { _length}{Environment.NewLine}" +
                $"Width: { _width}{Environment.NewLine}" +
                $"Height: { _height}{Environment.NewLine}" +
                $"Weight: { _weight}{Environment.NewLine}";
            return newString;
        }
    }
}
