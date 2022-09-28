fun people(busStops: Array<Pair<Int, Int>>) : Int {
    var bus = 0;
    for(i in busStops){
        bus = bus + i.first - i.second;
    }   
    return bus;
}