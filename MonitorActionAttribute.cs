using System;

namespace Monitor
{
    public class MonitorActionAttribute : Attribute
    {
        public string Name { get; }

        public MonitorActionAttribute(string Name)
        {
            this.Name = Name;
        }
    }
}
