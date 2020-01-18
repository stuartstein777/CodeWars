defmodule Parsers do
  def ensure_question(s) do 
    case String.ends_with?(s, "?")  do
      true -> s
      false -> s <> "?"
    end
  end
end

