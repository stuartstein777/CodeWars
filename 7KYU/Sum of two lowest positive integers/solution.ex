defmodule SmallSummer do
  def sum_two_smallest_numbers(numbers) do
    Enum.sum(Enum.slice(Enum.sort(numbers), 0, 2))
  end
end
