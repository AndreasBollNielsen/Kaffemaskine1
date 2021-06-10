using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine1
{
    class ExtremeCoffeeMaker : Appliance, IProcessMachine
    {
        private float temperature;

        public float Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        //constructors
        public ExtremeCoffeeMaker(bool onOff, string name, int containerSize,float temperature) : base(onOff, name, containerSize)
        {
            this.OnOff = OnOff;
            this.Name = name;
            this.ContainerSize = containerSize;
            this.temperature = temperature;
        }

        //adding water to container
        public void AddWater()
        {
            Console.WriteLine("adding water to container");
        }

        //run the coffe machine
        public void ProcessContent()
        {
            Console.WriteLine("run water through filter with coffeee beans, based on temperature");
        }
    }
}
