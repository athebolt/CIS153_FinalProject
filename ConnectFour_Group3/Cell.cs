using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour_Group3
{
    public class Cell
    {
        private int xPos;
        private int yPos;
        private char val;

        public Cell()
        {

        }

        public Cell(int xPos, int yPos, char val)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.val = val;
        }

        public bool isEmpty()
        {
            if (val == ' ')
            {
                return true;
            }
            return false;
        }

        public int getXPos()
        {
            return xPos;
        }
        public int getYPos()
        {
            return yPos;
        }
        public char getVal()
        {
            return val;
        }

        public void setXPos(int xPos)
        {
            this.xPos = xPos;
        }
        public void setYPos(int yPos)
        {
            this.yPos = yPos;
        }
        public void setVal(char val)
        {
            this.val = val;
        }
    }
}
