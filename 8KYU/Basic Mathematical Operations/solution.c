int basic_op(char op, int a, int b) {
  switch(op)
  {
    case '+':
      return a + b;
    case '-':
      return a -b;
    case '*':
      return a*b;
    case '/':
      return a / b;
  }
}