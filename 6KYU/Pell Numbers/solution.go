package kata

import (
	"math/big"
)

func Pell(n int) *big.Int {

	if n <= 2 {
		return big.NewInt(int64(n))
	}

	a := big.NewInt(1)
	b := big.NewInt(2)

	for i := 3; i <= n; i++ {
		c := big.NewInt(2)
		c.Add(c.Mul(c, b), a)
		a = b
		b = c
	}

	return b

}
