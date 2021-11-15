//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace My_hometask_2
//{
//    class Iron : Devices, SwitchOn
//    {
//        private void IronsClothes() {
//            Console.WriteLine("Ironing your clothes ");
//        }
//        public int getPower(int amper, int volt)
//        {
//            int result = 0;
//            result = amper * volt;
//            return result;
//        }
//        private void IsSwitchedOff() { }
//        private void IsSwitchedOn() { }

//        public override void Work()
//        {
//            UsesElectricity();
//            IronsClothes();
//            IsSwitchedOff();
//            IsSwitchedOn();
//            Console.WriteLine(getPower(5, 7));
//        }
//    }
//}
