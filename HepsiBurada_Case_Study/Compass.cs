using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada_Case_Study
{
    public class Compass
    {
        Direction _direction;
        CompassLinkedList _compassLinkedList;
        public Compass(Direction direction)
        {
            _direction = direction;
            _compassLinkedList = new CompassLinkedList();
        }
        public bool sayNewPositionForRover(Rover rover) {

            int newPositionX = rover.posX + _direction.getX();
            int newPositionY = rover.posY  + _direction.getY();

            if (newPositionX > rover.plateauUpperRightX ||
                newPositionY > rover.plateauUpperRightY ||
                newPositionX < 0 ||
                newPositionY < 0)
            {
                Console.WriteLine("Commands are blocked. Can you try again?");
                return false;
            }
            rover.posX = newPositionX;
            rover.posY = newPositionY;
            return true;
        }
        public void setDirection(Turn turn) {
            _direction= _compassLinkedList.getDirection(_direction,turn);
        }
        public Direction getDirection()
        {
            return _direction;
        }
    }
}
