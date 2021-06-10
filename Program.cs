using System;

namespace Kaffemaskine1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create array of appliances implementing interface
            IAppliance[] appliances = new IAppliance[] { new CoffeeMaker(true, "Nespresso", 600, 4), new ExtremeCoffeeMaker(true, "extreme edition", 800, 100) };

            //loop through array
            for (int i = 0; i < appliances.Length; i++)
            {
                Console.WriteLine($"using appliance: {appliances[i].Name}" +
                    $"\n the appliance is: {appliances[i].OnOff}");

                if(appliances[i] is IProcessMachine)
                {
                    ((IProcessMachine)appliances[i]).AddWater();
                    ((IProcessMachine)appliances[i]).ProcessContent();
                }
            }
        }
    }
}
