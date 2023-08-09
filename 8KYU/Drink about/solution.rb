def people_with_age_drink(old)
    if old < 14 then return 'drink toddy' end
    if old < 18 then return 'drink coke' end
    if old < 21 then return 'drink beer' end
    
    return 'drink whisky'
end