public interface i_uav_resourse {
    orientation orientation { get; set; }
    activation activation_type { get; set; }
    purpose purpose { get; set; }
    float mass { get; set; }
    int battery_consumption { get; set; }
    int range { get; set; }

}