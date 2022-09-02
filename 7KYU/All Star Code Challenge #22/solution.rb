def to_time(seconds)
    hours = (seconds / 3600).floor
    minutes = ((seconds - (hours * 3600)) / 60).floor
    hours.to_s + " hour(s) and " + minutes.to_s + " minute(s)"
end