class Kata {
    public static Integer findIt(List<Integer> list) {
        Integer x = list[0];
      
        for(Integer i = 1; i < list.size(); i++) {
          x ^= list[i];
        }
        
        return x;
    }
}