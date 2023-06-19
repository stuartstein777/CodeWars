package kata

import (
	"sort"
	"strings"
)

type Entrant struct {
	Name   string
	Weight int
}

func ScoreName(name string) int {
	name = strings.ToLower(name)
	score := 0
	for _, c := range name {
		score += int(c) - 96
	}
	return score
}

func NthRank(st string, we []int, n int) string {
	if st == "" {
		return "No participants"
	}

	names := strings.Split(st, ",")

	if n > len(names) {
		return "Not enough participants"
	}

	entrants := []Entrant{}
	for idx, name := range names {
		nameScore := ScoreName(name)
		nameScore += len(name)
		nameScore *= we[idx]
		entrants = append(entrants, Entrant{name, nameScore})
	}

	sort.Slice(entrants, func(i, j int) bool {
		if entrants[i].Weight == entrants[j].Weight {
			return entrants[i].Name < entrants[j].Name
		}
		return entrants[i].Weight > entrants[j].Weight
	})

	return entrants[n-1].Name
}
