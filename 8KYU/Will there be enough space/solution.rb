def enough(cap, on, wait)
    on + wait <= cap ? 0 : wait - (cap - on)    
end    