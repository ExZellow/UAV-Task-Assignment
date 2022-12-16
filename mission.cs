class mission {
    string json_file;
    byte[] map;
    uav[5] uavs;
    task[] tasks;
    
    
    void out_information_mission();

    void out_ways_robots();

    void out_information_task(int task_id);
}