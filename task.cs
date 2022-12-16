public class task {
    
    int master_id;
    way[] ways;
    uav[] uavs; 

    public smth() {
        seed_uav_resource s = new seed_uav_resource();
        uav uav_inst = new uav(s);
        uav_inst.uav_resourse.resource_consumption = 10;
    }
}