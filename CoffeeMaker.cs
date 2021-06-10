using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine1
{
    class CoffeeMaker : Appliance, IProcessMachine
    {
        //fields
        private int filtersize;

        //properties
        public int FilterSize
        {
            get { return filtersize; }
            set { filtersize = value; }
        }

        //constructor
        public CoffeeMaker(bool onOff, string name, int containerSize, int filtersize) : base(onOff, name, containerSize)
        {
            this.OnOff = OnOff;
            this.Name = name;
            this.ContainerSize = containerSize;
            this.filtersize = filtersize;
        }

        //add water to the container
        public void AddWater()
        {
            Console.WriteLine("adding water to container");
        }

        //run the coffee machine
        public void ProcessContent()
        {
            Console.WriteLine("making hot coffee!");
        }
    }
}
