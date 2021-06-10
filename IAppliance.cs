namespace Kaffemaskine1
{
    interface IAppliance
    {
        int ContainerSize { get; set; }
        string Name { get; set; }
        bool OnOff { get; set; }
    }
}