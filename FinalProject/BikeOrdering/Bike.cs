using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeOrdering
{
    public class Bike
    {
        private BikeColor color;
        private BasketColor basketColor;
        private LockType lockType;
        private BikeType type;
        private int count;
        private double price;

        public Bike(int color, int basketColor, int lockType, int type, int count)
        {
            this.color = (BikeColor)color;
            this.basketColor = (BasketColor)basketColor;
            this.lockType = (LockType)lockType;
            this.type = (BikeType)type;
            this.count = count;
        }

        public enum BikeColor
        {
            TiffanyBlue,
            黑色,
            橘色,
            黃色,
            銀色,
            綠色,
            藍色,
            紫色
        }

        public enum BasketColor
        {
            咖啡色,
            灰色
        }

        public enum LockType
        {
            一般鑰匙鎖,
            加50換密碼鎖,
            加300換機車大鎖
        }

        public enum BikeType
        {
            橫桿,
            斜桿
        }

        public double CountPrice()
        {
            switch (lockType)
            {
                case LockType.一般鑰匙鎖:
                    price = 2100.0 * this.count;
                    break;

                case LockType.加50換密碼鎖:
                    price = 2150.0 * this.count;
                    break;

                case LockType.加300換機車大鎖:
                    price = 2400.0 * this.count;
                    break;
            }
            return price;
        }

        public override string ToString()
        {
            string final = color + "的車身，" + basketColor + "的籃子，" + type;
            switch (lockType)
            {
                case LockType.一般鑰匙鎖:
                    final += "，加上免費贈送的鑰匙鎖";
                    break;

                case LockType.加50換密碼鎖:
                    final += "，加50元換成密碼鎖";
                    break;

                case LockType.加300換機車大鎖:
                    final += "，加300元換成機車大鎖";
                    break;
            }
            final += "  x" + count;
            return final;
        }
    }
}