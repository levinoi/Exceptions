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
                Console.WriteLine(item);
            }
        }
    }
}
