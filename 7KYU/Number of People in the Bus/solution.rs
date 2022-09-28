fn number(bus_stops:&[(i32,i32)]) -> i32 {
    let mut bus: i32 = 0;
    
    for i in bus_stops {
        bus = bus + i.0 - i.1;
    }
    return bus;
}