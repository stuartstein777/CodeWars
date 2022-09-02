def solution(s)
    s.split('').reduce(""){|acc, i| if i == i.capitalize then acc + " " + i else acc + i end}
end