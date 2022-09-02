def mag_number(info)
    weapons = {"PT92" => 17, "M4A1" => 30, "M16A2" => 30, "PSG1" => 5}
    shots_fired = info[1] * 3
    bullets_per_mag = weapons[info[0]]
    (shots_fired / bullets_per_mag.to_f).ceil()
end