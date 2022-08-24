package kata

func Well(x []string) string {
	goodCount := 0

	for i := 0; i < len(x); i++ {
		if x[i] == "good" {
			goodCount = goodCount + 1
		}
	}

	if goodCount > 2 {
		return "I smell a series!"
	} else if goodCount > 0 && goodCount <= 2 {
		return "Publish!"
	} else {
		return "Fail!"
	}
}
