defmodule Garden do
  def rain_amount(mm) do
    if mm < 40 do
     "You need to give your plant #{40-mm}mm of water"
    else
     "Your plant has had more than enough water for today!"
    end
  end
end
