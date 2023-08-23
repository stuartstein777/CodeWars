def printer_error(code)
	code.chars
      .select {|c| "nopqrstuvwxyz".include?(c)}
      .length.to_s + "/" + code.length.to_s
end