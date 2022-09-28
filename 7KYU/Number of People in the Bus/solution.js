var number = function(busStops){
    var bus = 0;
 
    for(var i = 0; i < busStops.length; i++) {
      bus = bus + busStops[i][0] - busStops[i][1];
    }
    return bus;
}