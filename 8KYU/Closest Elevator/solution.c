const char* elevator(int left, int right, int call) {

    int left_dist = abs(call - left);
    int right_dist = abs(call - right);
  
    if(left_dist == right_dist)
        return "right";
    else if(left_dist < right_dist)
        return "left";
    return "right";
}