package kata

import (
	"crypto/md5"
	"fmt"
	"io"
)

func PassHash(str string) string {
	h := md5.New()
	io.WriteString(h, str)
	return fmt.Sprintf("%x", h.Sum(nil))
}
