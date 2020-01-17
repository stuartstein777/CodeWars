let translations = {'ą' : 'a',
                    'ć' : 'c',
                    'ę' : 'e',
                    'ł' : 'l',
                    'ń' : 'n',
                    'ó' : 'o',
                    'ś' : 's',
                    'ź' : 'z',
                    'ż' : 'z'};
                    
function correctPolishLetters (string) {
  return string.replace(/[ąćęłńóśźż]/g, (c) => translations[c] || c);  
}

