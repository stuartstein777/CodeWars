def get_grade(a, b, c):
    mean = (a + b + c) / 3
  
    if mean >= 90:
        return "A"    
    if mean >= 80:
        return "B"
    if mean >= 70:
        return "C";
    if mean >= 60:
        return "D";
    return "F"
    