const int score(const char* str) {
  int score = 0;
  
  for(int i = 0; str[i] != '\0'; i++) {
    score += str[i]-64;
  }
  return score;
}

const char *battle (const char *group_1, const char *group_2)
{
  int g1_score = score(group_1);
  int g2_score = score(group_2);
  
  if(g1_score > g2_score) {
    return group_1;
  } else if (g1_score < g2_score) {
    return group_2;
  } else {
    return  "Tie!";
  }
}