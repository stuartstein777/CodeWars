package kata

import (
	"fmt"
	"strings"
)

func canEat(animal, eats string) bool {
	eating := map[string][]string{
		"fox":      {"chicken", "sheep"},
		"bug":      {"leaves"},
		"chicken":  {"bug"},
		"sheep":    {"grass"},
		"antelope": {"grass"},
		"big-fish": {"little-fish"},
		"bear":     {"big-fish", "bug", "chicken", "cow", "leaves", "sheep"},
		"cow":      {"grass"},
		"giraffe":  {"leaves"},
		"lion":     {"antelope", "cow"},
		"panda":    {"leaves"}}

	for _, food := range eating[animal] {
		if food == eats {
			return true
		}
	}
	return false

}

func RemoveItem(idx int, animals []string) []string {
	if idx == 0 {
		return animals[1:]
	} else {
		return append(animals[:idx], animals[idx+1:]...)
	}
}

func WhoEatsWho(zoo string) []string {
	fmt.Println(zoo)

	res := []string{zoo}

	zooItems := strings.Split(zoo, ",")

	for {
		somethingAte := false
		zooCnt := len(zooItems)
		for i := 0; i < zooCnt; i++ {
			animal := zooItems[i]
			if i > 0 {
				potentialFood := zooItems[i-1]
				if canEat(animal, potentialFood) {
					res = append(res, fmt.Sprintf("%s eats %s", animal, potentialFood))
					zooItems = RemoveItem(i-1, zooItems)
					fmt.Println(fmt.Sprintf("%s eats %s", animal, potentialFood))
					fmt.Println(fmt.Sprint(zooItems))
					somethingAte = true
					break
				}
			}
			if i < zooCnt-1 {
				potentialFood := zooItems[i+1]
				if canEat(animal, potentialFood) {
					res = append(res, fmt.Sprintf("%s eats %s", animal, potentialFood))
					zooItems = RemoveItem(i+1, zooItems)
					fmt.Println(fmt.Sprintf("%s eats %s", animal, potentialFood))
					fmt.Println(fmt.Sprint(zooItems))
					somethingAte = true
					break
				}
			}
		}

		if !somethingAte {
			res = append(res, strings.Join(zooItems, ","))
			break
		}
	}

	return res
}
