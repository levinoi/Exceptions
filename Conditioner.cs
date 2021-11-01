//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace My_hometask_2
//{
//    class Conditioner : Devices, SwitchOn
//    {
//        public override void Work()
//        {
//            UsesElectricity();

//            IsSwitchOn();
//            IsSwitchOff();
//            Heating();
//            Console.WriteLine(getPower(15, 10));
//        }
//        public int getPower(int amper, int volt)
//        {
//            int result = 0;
//            result = amper * volt;
//            return result;
//        }

//        private void IsSwitchOff() { }
//        private void IsSwitchOn() { }
//        private void Heating() {
//            Console.WriteLine("Air conditioner");
//        }

//    }
//}
