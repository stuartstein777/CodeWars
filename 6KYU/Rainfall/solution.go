package kata

import (
	"strconv"
	"strings"
)

func ParseRainfallEntry(rainfall string) float64 {
	rainfall = strings.Trim(rainfall, " ")
	rainfall = strings.Split(rainfall, " ")[1]
	rainfallf, _ := strconv.ParseFloat(rainfall, 64)
	return rainfallf
}

func RainfallEntries(town string, data string) ([]float64, float64, bool) {
	records := strings.Split(data, "\n")
	totalRainfall := 0.0
	monthlyRainfalls := make([]float64, 12)
	found := false
	for _, record := range records {
		if strings.HasPrefix(record, town+":") {
			found = true
			rainfall := strings.TrimPrefix(record, town+":")
			rainfallMonths := strings.Split(rainfall, ",")

			for idx, rainfallEntry := range rainfallMonths {
				rainfallForMonth := ParseRainfallEntry(rainfallEntry)
				monthlyRainfalls[idx] = rainfallForMonth
				totalRainfall += rainfallForMonth
			}

		}
	}

	return monthlyRainfalls, totalRainfall, found
}

func Mean(town string, data string) float64 {
	println(data)
	println(town)
	_, totalRainfall, found := RainfallEntries(town, data)

	if !found {
		return -1
	}

	return totalRainfall / 12
}

func Variance(town string, data string) float64 {
	monthlyRainfalls, _, found := RainfallEntries(town, data)

	if !found {
		return -1
	}
	mean := Mean(town, data)
	sum := 0.0
	for _, rainfall := range monthlyRainfalls {
		sum += (rainfall - mean) * (rainfall - mean)
	}
	return sum / 12
}
