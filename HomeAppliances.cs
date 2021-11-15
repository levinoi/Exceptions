using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_hometask_2
{
    class HomeAppliances
    {
        private Device[] devices;
        public Device[] Devices => devices;
        public HomeAppliances(Device[] devices)
        {
            this.devices = devices;
        }
        public void SortByPower(Device[] devices)
        {
            var sortedListOfDevices = devices.OrderByDescending(Device => Device.getPower());
            foreach (var item in sortedListOfDevices)
            {
                if (item.getPower() == 0)
                {
                    throw new NullPowerException("Usage power cannot be equal to 0 ");
                }
                Console.WriteLine(item);
            }
        }
        public void SortBySwitchedOn(Device[] devices)
        {
            var sortedListOfDevices1 = devices.OrderBy(Device => Device.IsSwitched());
            foreach (var item in sortedListOfDevices1)
            {
                if (item.IsSwitched() == false)
                {
                    throw new NonElectroDeviceException(" It is not an electricity device ");
                }
                Console.WriteLine(item);
            }
        }
        public void GetArrayLength(Device[] devices)
        {
            if (devices.Length < 10)
            {
                throw new OutOfRangeException("The array is out of range");
            }
        }
        public void OutOfCategory(Device[] devices)
        {
            var sortedListOfDevices2 = devices.OrderBy(Device => Device.NameOfDeviceType());
            foreach (var item in sortedListOfDevices2)
            {
                if (item.NameOfDeviceType() == "Battery")
                {
                    throw new OutOfCategoryException("Choosen device is out of your category");
                }
            }
        }
    }
}

