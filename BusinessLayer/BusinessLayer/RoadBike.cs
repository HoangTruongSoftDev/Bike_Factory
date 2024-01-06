using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class RoadBike : Bike
    {
        private double seatHeight;
        private EnumStyle roadBikeStyle;



        public RoadBike() : base()
        {

            this.SeatHeight = 0.00;
            this.RoadBikeStyle = EnumStyle.Undefined;

        }

        public RoadBike(long serialNumber, string model, string make, EnumColor color, double speed, Date date, string insurance, double seatHeight, EnumStyle roadBikeStyle) : base(serialNumber, make, model, color, speed, date, insurance)
        {
            this.SeatHeight = seatHeight;
            this.RoadBikeStyle = roadBikeStyle;

        }
        public double SeatHeight
        {
            get { return this.seatHeight; }
            set { this.seatHeight = value; }
        }
        public EnumStyle RoadBikeStyle
        {
            get { return this.roadBikeStyle; }
            set { this.roadBikeStyle = value; }
        }
        public override double GetMaxSpeed()
        {
            return 40.00;
        }

        public override void SpeedUp(double newSpeed)
        {

            if (base.Speed + newSpeed < GetMaxSpeed())
            {

                base.Speed += newSpeed;
            }
            else
            {
                base.Speed = GetMaxSpeed();
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}SeatHeight: {this.SeatHeight}m \nStyle: {this.RoadBikeStyle}\n\n";
        }
    }
}
