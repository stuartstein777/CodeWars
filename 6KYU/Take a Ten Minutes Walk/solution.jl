function isvalidwalk(walk)
    nesw = Dict('n' => 0, 'e' => 0, 's' => 0, 'w' => 0)
    
    for i in walk
        if haskey(nesw, i)
          nesw[i] = nesw[i]+1
        end
    end
    return length(walk) == 10 && nesw['n'] == nesw['s'] && nesw['e'] == nesw['w'];
end