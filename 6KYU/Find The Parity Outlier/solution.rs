fn find_outlier(values: &[i32]) -> i32 {
    
  let first_even: bool = values[0] % 2 == 0;
  let second_even: bool = values[1] % 2 == 0;
  let third_even: bool = values[2] % 2 == 0;
  let mut looking_for_even = false;

  if first_even == second_even && first_even == third_even {
    looking_for_even = !first_even;
  } else {
    if (first_even == second_even) && (first_even != third_even) {
      return values[2];
    } else if (first_even != second_even) && (first_even == third_even) {
      return values[1];
    }  else if (first_even != second_even) && (first_even != third_even) {
      return values[0];
    }
  }

 for i in values {
    if looking_for_even && i % 2 == 0 {
      return *i;
    } else if !looking_for_even && i % 2 != 0 {
      return *i;
    }
  }
  return 0;
}