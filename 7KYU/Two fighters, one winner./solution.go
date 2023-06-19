package kata

func DeclareWinner(fighter1 Fighter, fighter2 Fighter, firstAttacker string) string {
	for {
		if firstAttacker == fighter1.Name {
			fighter2.Health -= fighter1.DamagePerAttack
			firstAttacker = fighter2.Name
			if fighter2.Health <= 0 {
				return fighter1.Name
			}
		} else {
			fighter1.Health -= fighter2.DamagePerAttack
			firstAttacker = fighter1.Name
			if fighter1.Health <= 0 {
				return fighter2.Name
			}
		}
	}
	return "-"
}
