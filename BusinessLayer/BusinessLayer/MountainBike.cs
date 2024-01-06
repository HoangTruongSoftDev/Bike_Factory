using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class MountainBike : Bike
    {
        private double heightFromGround;
        private EnumSuspension suspension;
        private EnumStyle mountainBikeStyle;

        public MountainBike() : base()
        {
            this.HeightFromGround = 0.00;
            this.Suspension = EnumSuspension.Undefined;
            this.MountainBikeStyle = EnumStyle.Undefined;
        }
        public MountainBike(long serialNumber, string model, string make, EnumColor color, double speed, Date date, double heightFromGround, EnumSuspension suspension, EnumStyle mountainBikeStyle, string insurance) : base(serialNumber, make, model, color, speed, date, insurance)
        {
            this.HeightFromGround = heightFromGround;
            this.Suspension = suspension;
            this.MountainBikeStyle = mountainBikeStyle;
        }
        public double HeightFromGround
        {
            get { return this.heightFromGround; }
            set { this.heightFromGround = value; }
        }
        public EnumSuspension Suspension
        {
            get { return this.suspension; }
            set { this.suspension = value; }
        }
        public EnumStyle MountainBikeStyle
        {
            get { return this.mountainBikeStyle; }
            set { this.mountainBikeStyle = value; }
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
            return $"{base.ToString()}Height From Ground: {this.HeightFromGround}m \nSuspension: {this.Suspension} \nStyle: {this.MountainBikeStyle}\n\n";
        }
    }
}
