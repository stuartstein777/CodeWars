fn xo(s: &'static str) -> bool {
  println!("{}", s);
  let exes = s.chars().fold(0, |acc, x| if x == 'x' || x == 'X' {acc + 1} else {acc});
  let ohs = s.chars().fold(0, |acc, x| if x == 'o' || x == 'O' {acc + 1} else {acc});
  return exes == ohs;
}