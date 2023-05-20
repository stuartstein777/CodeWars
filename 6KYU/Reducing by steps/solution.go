package kata

func Gcdi(a, b int) int {
	if a == 0 {
		if b < 0 {
			b = -b
		}
		return b
	}
	return Gcdi(b%a, a)
}

func Som(x, y int) int {
	return x + y
}

func Maxi(x, y int) int {
	if x > y {
		return x
	}
	return y
}

func Mini(x, y int) int {
	if x < y {
		return x
	}
	return y
}

func Lcmu(x, y int) int {
	gcd := Gcdi(x, y)
	if x < 0 {
		x = -x
	}
	if y < 0 {
		y = -y
	}
	a := (x * y) / gcd
	if a < 0 {
		a = -a
	}
	return a
}

type FParam func(int, int) int

func OperArray(f FParam, arr []int, init int) []int {
	l := len(arr)
	res := []int{}
	c := init
	for i := 0; i < l; i++ {
		a := f(c, arr[i])
		res = append(res, a)
		c = a
	}
	return res
}
