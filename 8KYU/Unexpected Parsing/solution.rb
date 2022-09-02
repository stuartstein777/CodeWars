def get_status(is_busy)
    s = Hash.new
    is_busy ? {"status" => "busy"} : {"status" => "available"}
end