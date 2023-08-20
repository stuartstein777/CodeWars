def str_count(word, letter)
    cnt = 0
    for w in 0..word.length() do
      if word[w] == letter
        cnt=cnt+1
      end
    end
    return cnt
end
  