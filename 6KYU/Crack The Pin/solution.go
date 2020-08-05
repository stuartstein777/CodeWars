package kata
import (
        "fmt"
        "encoding/hex"
        "crypto/md5"
        "io"
)

func Crack(hash string) string {
  for i := 0; i <= 99999; i++ {
    pin := fmt.Sprintf("%05d", i)
    h := md5.New()
    io.WriteString(h, pin)
    hh := h.Sum(nil)
    if hex.EncodeToString(hh) == hash {
      return pin
    }
  }
  return ""
}