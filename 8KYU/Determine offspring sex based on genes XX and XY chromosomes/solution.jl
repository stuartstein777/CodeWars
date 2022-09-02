module Solution
  export chromosomeCheck
  function chromosomeCheck(sperm)
    if sperm == "XY"
      return "Congratulations! You\'re going to have a son."
    else
      return "Congratulations! You\'re going to have a daughter."
    end
  end
end