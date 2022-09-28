def number(bus_stops):
  bus = 0
  for i in bus_stops:
     bus = bus + i[0] - i[1]
  
  return bus