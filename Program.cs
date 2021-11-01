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
            listOfDevices[2] = new Device(101, true, DeviceType.Microwave);
            listOfDevices[3] = new Device(250, true, DeviceType.Conditioner);
            listOfDevices[4] = new Device(100, true, DeviceType.TVSet);
            listOfDevices[5] = new Device(65, false, DeviceType.Computer);

         var sortedListOfDevices = listOfDevices.OrderByDescending(Device => Device.getPower());

          foreach (var item in sortedListOfDevices)
            {
                
                Console.WriteLine(item);
            }
           
        }
    }
}




