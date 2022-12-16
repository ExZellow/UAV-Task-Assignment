public interface i_uav_resourse { //Полезная нагрузка дрона (общие свойства для каждого из типов полезной нагрузки дронов)
    orientation orientation { get; set; }
    activation activation_type { get; set; }
    purpose purpose { get; set; } //тип миссии
    float mass { get; set; }
    int battery_consumption { get; set; }
    int range { get; set; }

}