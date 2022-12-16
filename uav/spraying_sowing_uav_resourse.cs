<<<<<<<< HEAD:uav/spraying_sowing_uav_resourse.cs
class spraying_sowing_uav_resource : i_uav_resourse { //Полезная нагрузка конкретного дрона
========
public class seed_uav_resource : i_uav_resourse { //Полезная нагрузка конкретного дрона
>>>>>>>> d7a973dc75d4500b5b88be38473ba7abbbedafba:uav/seed_uav_resourse.cs
    int resource_consumption;

    public orientation orientation { get; set; }
    public activation activation_type { get ; set; }
    purpose[] i_uav_resourse.purpose { get; set; }
    public float mass { get; set; }
    public int battery_consumption { get ; set; }
    public scope scope { get; set; }
    public int range { get; set; }
    
}