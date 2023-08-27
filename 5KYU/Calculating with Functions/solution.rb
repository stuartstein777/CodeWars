def zero(op = nil)
  op.nil? ? 0 : op.call(0)
end

def one(op = nil)
  op.nil? ? 1 : op.call(1)
end

def two(op = nil)
  op.nil? ? 2 : op.call(2)
end

def three(op = nil)
  op.nil? ? 3 : op.call(3)
end

def four(op = nil)
  op.nil? ? 4 : op.call(4)
end

def five(op = nil)
  op.nil? ? 5 : op.call(5)
end

def six(op = nil)
  op.nil? ? 6 : op.call(6)
end

def seven(op = nil)
  op.nil? ? 7 : op.call(7)
end

def eight(op = nil)
  op.nil? ? 8 : op.call(8)
end

def nine(op = nil)
  op.nil? ? 9 : op.call(9)
end

def plus(b)
  lambda {|a| a + b}
end

def minus(b)
  lambda {|a| a - b}
end

def times(b)
  lambda {|a| a * b}
end

def divided_by(b)
  lambda {|a| a / b}
end