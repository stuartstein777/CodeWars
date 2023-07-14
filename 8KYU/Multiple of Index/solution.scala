def multipleOfIndex(xs: Seq[Int]): Seq[Int] = {
  xs.zipWithIndex.collect {
  case (x,i) if (i == 0 && x == 0) || (i > 0 && x % i == 0) => x
  }
}  
