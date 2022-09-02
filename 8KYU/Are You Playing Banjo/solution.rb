def are_you_playing_banjo(name)
    name.downcase.start_with?("r") ? name + " plays banjo" : name + " does not play banjo"
end