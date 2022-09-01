def no_odds( values )
    values.select(&:even?)
end