package kata

func PickGrains(grains <-chan string) (good int, bad int) {
	// TODO: your implementation goes here

	for {
		value, ok := <-grains

		if !ok {
			// Channel is closed, exit the loop
			break
		}

		if value == "good" {
			good += 1
		} else if value == "bad" {
			bad += 1
		}
	}

	return good, bad
}
