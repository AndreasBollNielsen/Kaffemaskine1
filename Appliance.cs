using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine1
{
    class Appliance : IAppliance
    {
        private bool onOff;
        private string name;
        private int containerSize;

        public Appliance(bool onOff, string name, int containerSize)
        {
            this.onOff = onOff;
            this.name = name;
            this.containerSize = containerSize;
        }

        public int ContainerSize
        {
            get { return containerSize; }
            set { containerSize = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool OnOff
        {
            get { return onOff; }
            set { onOff = value; }
        }

    }
}
