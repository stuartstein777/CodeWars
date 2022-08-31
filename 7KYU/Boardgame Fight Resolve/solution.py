
resolver = {
  'aS' : 'a',
  'As' : 'A',
  'sA' : 'A',
  'Sa' : 'a',
  'pS' : 'S',
  'Ps' : 's',
  'sP' : 's',
  'Sp' : 's',
  'pK' : 'p',
  'Pk' : 'P',
  'Kp' : 'p',
  'kP' : 'P',
  'kA' : 'k',
  'Ka' : 'K',
  'Ak' : 'k',
  'aK' : 'K'}

def is_illegal(defender, attacker):
    return (defender.isupper() and attacker.isupper()) or (defender.islower() and attacker.islower())

def fight_resolve(defender, attacker):
    print(defender + ' ' + attacker)
    if is_illegal(defender, attacker):
        return -1
    key = defender + attacker
    if key in resolver:
        return resolver[key]
    return attacker
