defmodule Alarm do
  def set_alarm(employed, vacation) do
    employed && !vacation
  end
end
