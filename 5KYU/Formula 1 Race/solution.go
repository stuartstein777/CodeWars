package kata

import (
	"fmt"
	"strconv"
	"strings"
)

type RaceIncident struct {
	Pilot    int
	Incident string
}

func PrintPositions(positions []int) {
	fmt.Println(fmt.Sprint(positions))
}

func Overtake(positions *[]int, overtakingDriver int) {
	for i := 0; i < 20; i++ {
		if (*positions)[i] == overtakingDriver {
			(*positions)[i], (*positions)[i-1] = (*positions)[i-1], (*positions)[i]
			break
		}
	}
}

func RetireDriver(positions *[]int, retiringDriver int) {
	for i := 0; i < 20; i++ {
		if (*positions)[i] == retiringDriver {
			for j := i; j < 19; j++ {
				(*positions)[j] = (*positions)[j+1]
			}
			(*positions)[19] = 0
			break
		}
	}
}

func RaceIncidents(events string) []RaceIncident {
	split := strings.Split(events, " ")
	var incidents []RaceIncident

	for i := 0; i < len(split); i += 2 {
		pilot, _ := strconv.Atoi(split[i])
		incident := RaceIncident{
			Pilot:    pilot,
			Incident: split[i+1],
		}

		incidents = append(incidents, incident)
	}

	return incidents
}

func GetPilotFinalPosition(positions []int, pilot int) int {
	for i := 0; i < 20; i++ {
		if positions[i] == pilot {
			return i + 1
		}
	}
	return -1
}

func ChampionRank(champion int, events string) int {

	if events == "" {
		return champion
	}

	positions := []int{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
	incidents := RaceIncidents(events)

	for _, i := range incidents {
		if i.Incident == "O" {
			Overtake(&positions, i.Pilot)
		} else if i.Incident == "I" {
			RetireDriver(&positions, i.Pilot)
		}
	}

	return GetPilotFinalPosition(positions, champion)
}
