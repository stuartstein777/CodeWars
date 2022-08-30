defmodule Negator do
  def make_negative(num) do
    if num < 0, do: num, else: -num
  end
end
