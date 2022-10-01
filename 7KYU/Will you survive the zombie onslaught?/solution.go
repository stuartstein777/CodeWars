package kata

import (
	"fmt"
)

func Zombie_shootout(zombies, initial_range, ammo int) string {

	zombies_that_can_be_shot := initial_range * 2

	if zombies_that_can_be_shot > ammo {
		if ammo < zombies {
			return fmt.Sprintf("You shot %d zombies before being eaten: ran out of ammo.", ammo)
		}
	} else {
		if zombies_that_can_be_shot < zombies {
			return fmt.Sprintf("You shot %d zombies before being eaten: overwhelmed.", zombies_that_can_be_shot)
		}
	}
	return fmt.Sprintf("You shot all %d zombies.", zombies)
}
