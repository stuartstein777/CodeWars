def nba_extrap(ppg, mpg)
    mpg == 0 ? 0 : ((48.to_f / mpg) * ppg).round(1)
end