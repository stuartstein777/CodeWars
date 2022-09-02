def oddOne(arr)
    ix = arr.index { |x| x.odd? }
    ix == nil ? -1 : ix
