def get_tens(num):
    if num < 10:
        return ""
    elif num < 20:
        return "on"
    elif num < 30:
        return "yirmi"
    elif num < 40:
        return "otuz"
    elif num < 50:
        return "kırk"
    elif num < 60:
        return "elli"
    elif num < 70:
        return "altmış"
    elif num < 80:
        return "yetmiş"
    elif num < 90:
        return "seksen"
    else:
        return "doksan"
        
    
def get_units(num):
    if num == 0:
        return "sıfır"
    elif num == 1:
        return "bir"
    elif num == 2:
        return "iki"
    elif num == 3:
        return "üç"
    elif num == 4:
        return "dört"
    elif num == 5:
        return "beş"
    elif num == 6:
        return "altı"
    elif num == 7:
        return "yedi"
    elif num == 8:
        return "sekiz"
    else:
        return "dokuz"
    
    
def get_turkish_number(num):
    print(num)
    if num < 10:
        return get_units(num % 10)
    else:
        if num % 10 == 0:
            return get_tens(num)
        else:
            return get_tens(num) + " " + get_units(num % 10)
    
    