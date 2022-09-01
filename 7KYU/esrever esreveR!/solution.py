def esrever(str):
  if len(str) == 0:
      return ""
  but_last = str[:-1]
  reversed_string = ""
  for i in but_last.split(' '):
    reversed_string = i[::-1] + " " + reversed_string
  return reversed_string[:-1] + str[-1]
