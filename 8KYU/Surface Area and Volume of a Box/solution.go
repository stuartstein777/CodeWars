package kata

func GetSize(w, h, d int) [2]int {
	return [2]int{d*w*2 + w*h*2 + d*h*2, w * d * h}
}
