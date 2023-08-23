defmodule MaxMultiple do
  def max_multiple(divisor, bound) do
    bound - rem(bound, divisor)
  end
end