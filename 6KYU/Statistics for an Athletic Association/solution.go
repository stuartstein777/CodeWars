package kata

import (
	"fmt"
	"sort"
	"strconv"
	"strings"
)

func ParseTimes(time string) int {
	t := strings.Split(time, "|")
	h, _ := strconv.Atoi(t[0])
	m, _ := strconv.Atoi(t[1])
	s, _ := strconv.Atoi(t[2])

	return h*3600 + m*60 + s
}

func SecondsToTime(seconds int) string {
	hrs := seconds / 3600
	seconds = seconds % 3600
	mins := seconds / 60
	seconds = seconds % 60

	return fmt.Sprintf("%02d|%02d|%02d", hrs, mins, seconds)
}

func CalculateMedian(timesInSeconds []int) int {
	sort.Ints(timesInSeconds)
	l := len(timesInSeconds)
	if l%2 == 0 {
		return (timesInSeconds[l/2] + timesInSeconds[(l/2)-1]) / 2
	} else {
		return timesInSeconds[l/2]
	}
}

func Stati(times string) string {
	if times == "" {
		return ""
	}
	times = strings.ReplaceAll(times, " ", "")
	individualTimes := strings.Split(times, ",")
	timesInSeconds := []int{}
	slowestTime := -1
	longestTime := -1
	totalTime := 0
	timesCount := 0
	for _, time := range individualTimes {
		timeInSeconds := ParseTimes(time)
		timesInSeconds = append(timesInSeconds, timeInSeconds)
		totalTime += timeInSeconds
		timesCount += 1

		if timeInSeconds > longestTime || longestTime == -1 {
			longestTime = timeInSeconds
		}

		if timeInSeconds < slowestTime || slowestTime == -1 {
			slowestTime = timeInSeconds
		}
	}

	rnge := longestTime - slowestTime
	average := totalTime / timesCount
	median := CalculateMedian(timesInSeconds)
	return "Range: " + SecondsToTime(rnge) + " Average: " + SecondsToTime(average) + " Median: " + SecondsToTime(median)
}
