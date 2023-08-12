defmodule ShortLongShort do
  def solution(a, b) do
    if String.length(a) < String.length(b) do
     "#{a}#{b}#{a}"
    else
     "#{b}#{a}#{b}"
    end
  end
end
