using My_hometask_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_hometask_2
{
    public class Device : IDevice
    {
        private DeviceType DeviceType { get; set; }
        private bool SwitchOn { get; set; }
        private int UsagePower { get; set; }

        public Device( int usagePower, bool switchOn, DeviceType typeOfDevice)
        {
            this.UsagePower = usagePower;
            this.SwitchOn   = switchOn;
            this.DeviceType = typeOfDevice;
        }
        public void SortedList(Device[] listOfDevices)
        {
          var sortedListOfDevices = listOfDevices.OrderByDescending(Device => Device.getPower());
            foreach (var item in sortedListOfDevices)
                {
                    Console.WriteLine(item);
                }
             }

        public override string ToString()
        {
          return $"Usage power is {UsagePower}, is switched on {SwitchOn}, name of device is {DeviceType}";
        }  
        
        public int getPower()
        {
            return UsagePower;
        }

        public bool IsSwitched()
        {
           return SwitchOn;
        }

        public string NameOfDeviceType()
        {
            return DeviceType.ToString();
        }
    }

}
