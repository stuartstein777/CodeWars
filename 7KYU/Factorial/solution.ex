defmodule Factorial do
  def factorial(n) do
    case n do
      0 -> 1
      _ -> n * factorial(n-1)
    end
  end
end
