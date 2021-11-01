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
            HomeAppliances homeAppliances = new HomeAppliances(
                new Device[]
                {
                  new Device(25, true, DeviceType.Iron),
                  new Device(150, true, DeviceType.Refrigerator),
                  new Device(100, true, DeviceType.Microwave),
                  new Device(250, true, DeviceType.Conditioner),
                  new Device(1000, true, DeviceType.TVSet),
                  new Device(650, false, DeviceType.Computer),
        });
            homeAppliances.SortByPower(homeAppliances.Devices);
        }
    }
}

