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
            try
            {
                HomeAppliances homeAppliances = new HomeAppliances(
                    new Device[]
                    {
                  new Device(110, true, DeviceType.Iron),
                  new Device(20, true, DeviceType.Refrigerator),
                  new Device(100, true, DeviceType.Microwave),
                  new Device(250, true, DeviceType.Conditioner),
                  new Device(1000, true, DeviceType.TVSet),
                  new Device(675, false, DeviceType.Computer),
                  new Device(675, false, DeviceType.Battery),
                    });
                homeAppliances.GetArrayLength(homeAppliances.Devices);
                homeAppliances.SortByPower(homeAppliances.Devices);
                homeAppliances.SortBySwitchedOn(homeAppliances.Devices);
                homeAppliances.OutOfCategory(homeAppliances.Devices);
            }
            catch (NullPowerException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NonElectroDeviceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OutOfCategoryException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


