function trianglePerimeter(triangle){
    console.log(triangle.a.x + "," + triangle.a.y);
    console.log(triangle.b.x + "," + triangle.b.y);
    console.log(triangle.c.x + "," + triangle.c.y);
    
    const ab = Math.sqrt(Math.abs(triangle.a.x - triangle.b.x) * Math.abs(triangle.a.x - triangle.b.x)
                       + Math.abs(triangle.a.y - triangle.b.y) * Math.abs(triangle.a.y - triangle.b.y));
    
    const bc = Math.sqrt(Math.abs(triangle.b.x - triangle.c.x) * Math.abs(triangle.b.x - triangle.c.x)
                       + Math.abs(triangle.b.y - triangle.c.y) * Math.abs(triangle.b.y - triangle.c.y));
    
    const ac = Math.sqrt(Math.abs(triangle.a.x - triangle.c.x) * Math.abs(triangle.a.x - triangle.c.x)
                       + Math.abs(triangle.a.y - triangle.c.y) * Math.abs(triangle.a.y - triangle.c.y));
    
    return ab + bc + ac;
  }