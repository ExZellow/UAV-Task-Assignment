using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UAV_Task_assignment.uav
{
    internal class laser_3d_scanning_uav_resource : i_uav_resourse
    {
        orientation i_uav_resourse.orientation { get; set; }
        activation i_uav_resourse.activation_type { get; set; }
        purpose i_uav_resourse.purpose { get; set; }
        float i_uav_resourse.mass { get; set; }
        int i_uav_resourse.battery_consumption { get; set; }
        public scope scope { get; set; }
        int i_uav_resourse.range { get; set; }
    }
}
