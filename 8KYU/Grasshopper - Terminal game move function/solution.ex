defmodule GameMove do
  def move(pos, roll) do
    pos + 2 * roll
  end
end