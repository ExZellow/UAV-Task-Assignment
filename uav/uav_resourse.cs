class uav_resource : i_uav_resourse {
    int resource_consumption;

    public orientation orientation { get; set; }
    public activation activation_type { get ; set; }
    public purpose purpose { get; set; }
    public float mass { get; set; }
    public int battery_consumption { get ; set; }
    public int range { get; set; }
}