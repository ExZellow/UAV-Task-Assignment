using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UAV_Task_assignment.uav
{
    internal class videocamera_uav_resource : i_uav_resourse
    {
        public orientation orientation { get; set; }
        public activation activation_type { get; set; }
        public purpose purpose { get; set; }
        public float mass { get; set; }
        public int battery_consumption { get; set; }
        public scope scope { get; set; }
        public int range { get; set; }
    }
}
