def who_took_the_car_key(message)
    message.map{|i| i.to_i(2).chr}.join
end