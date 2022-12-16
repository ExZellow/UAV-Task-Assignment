public class uav { //Дрон
    public int[] coordinates = new int[2];
    public int index;
    public float max_flight_time;
    public float flight_time;
    public flight_speed flight_speed;
    public float mass;
    public i_uav_resourse uav_resourse; //Тип ресурса дрона
    public float diameter;
    public string sphere;

    public uav(i_uav_resource res_type) {
        uav_resourse = res_type;
    }

}