using My_hometask_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace My_hometask_2
{
    class Program
    {
        static void Main(string[] args)
        {
         Device[] listOfDevices = new Device[6];
                        

            listOfDevices[0] = new Device(25, true,  DeviceType.Iron);
            listOfDevices[1] = new Device(150, true, DeviceType.Refrigerator);
            listOfDevices[2] = new Device(100, true, DeviceType.Microwave);
            listOfDevices[3] = new Device(250, true, DeviceType.Conditioner);
            listOfDevices[4] = new Device(100, true, DeviceType.TVSet);
            listOfDevices[5] = new Device(65, false, DeviceType.Computer);

         var sortedListOfDevices = listOfDevices.OrderByDescending(Device => Device.getPower());

           

           foreach (var item in sortedListOfDevices)
            {
                
                Console.WriteLine(item);
            }
             

           /* for (int i = 0; i < listOfDevices.Length; i++)
            {
                Console.WriteLine(listOfDevices[i]);
            }*/

           
                 // var objTV = new Device(200, true);


           // var devices = new List<Device> {
           // new Device{DeviceType=DeviceType.Conditioner, SwitchOn = true, UsagePower = 250  },
           // new Device{DeviceType=DeviceType.Iron, SwitchOn = false, UsagePower = 50  },
           // new Device{DeviceType=DeviceType.TVSet, SwitchOn = true, UsagePower = 150  },
           // new Device{DeviceType=DeviceType.Refrigerator, SwitchOn = true, UsagePower = 450  }
           // };

           //var sortedDevices =  devices.OrderBy(device => device.UsagePower).ToList();
           // foreach (var device in sortedDevices)
           // {
           //     Console.WriteLine(device.DeviceType);
           // }
           // var findDevices = devices.Where(device => device.UsagePower > 49 && device.UsagePower < 100);

        }
    }
}




