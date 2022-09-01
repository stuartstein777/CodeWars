module Solution
  export areaOrPerimeter
  function areaOrPerimeter(l, w)
    if(l == w)
      return l*w;
    end
    return 2*l + 2*w;
  end
end