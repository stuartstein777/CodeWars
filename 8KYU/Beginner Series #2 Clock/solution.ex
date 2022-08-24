defmodule Kata do
  def past(h, m, s) do
      s * 1000 + m * 60000 + h * 3600000
  end
end
