class spraying_sowing_uav_resource : i_uav_resourse { //Полезная нагрузка конкретного дрона
    int resource_consumption;

    public orientation orientation { get; set; }
    public activation activation_type { get ; set; }
    public purpose purpose { get; set; }
    public float mass { get; set; }
    public int battery_consumption { get ; set; }
    public scope scope { get; set; }
    public int range { get; set; }
}