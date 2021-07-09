using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada_Case_Study
{
    
    public class Rover
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public Compass compass { get; set; }
        public int plateauUpperRightX { get; set; }
        public int plateauUpperRightY { get; set; }
        public Rover(int posX,int posY, int plateauUpperRightX, int plateauUpperRightY, Compass compass)
        {
            this.posX = posX;
            this.posY = posY;
            this.plateauUpperRightX = plateauUpperRightX;
            this.plateauUpperRightY = plateauUpperRightY;
            this.compass = compass;
        }
        public bool Move()
        {
            return compass.sayNewPositionForRover(this);
        }
        public void Spin(Turn turn)
        {
            compass.setDirection(turn);
        }
        public override string ToString()
        {
            return Convert.ToString(posX) + " " + Convert.ToString(posY) + " " + compass.getDirection().ToString();
        }
    }
}
