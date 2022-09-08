enum outcome {WOOHOO, CAR_DEAD};

enum outcome car_state (const char *road)
{
	  int total = 0;
    int length = strlen(road);
    for(int i = 0; i < length; i++)
    {
      if(road[i] != '_')
        total=total+1;
    }
    if(total <= 15)
      return WOOHOO;
    else
      return CAR_DEAD;
}