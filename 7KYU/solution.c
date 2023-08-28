//  do not allocate memory for a result
//  assign chars to the provided *flown

void fly_by(const char *lamps, const char *drone, char *flown) {
    int i = 0;
    for(i = 0; lamps[i] != '\0'; i++) {
      flown[i] = lamps[i];
    }
    
    for(int j = 0; drone[j] != '\0'; j++) {
      flown[j] = 'o';
    }
    flown[i] = '\0';
}