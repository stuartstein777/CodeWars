package kata

func WrapPresent(h, w, l int) int {
	hwa := h * w
	hla := h * l
	wla := w * l

	if hwa >= hla && hwa >= wla {
		return l*4 + h*2 + w*2 + 20
	} else if hla >= hwa && hla >= wla {
		return w*4 + h*2 + l*2 + 20
	} else {
		return h*4 + w*2 + l*2 + 20
	}
}
