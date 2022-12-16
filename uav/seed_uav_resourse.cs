public class seed_uav_resource : i_uav_resourse { //Полезная нагрузка конкретного дрона
    int resource_consumption;

    public orientation orientation { get; set; }
    public activation activation_type { get ; set; }
    purpose[] i_uav_resourse.purpose { get; set; }
    public float mass { get; set; }
    public int battery_consumption { get ; set; }
    public int range { get; set; }
    
}