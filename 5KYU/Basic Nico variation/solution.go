package kata

import (
	"fmt"
	"sort"
	"strings"
)

func SortString(str string) string {
	runes := []rune(str)
	sort.Slice(runes, func(i, j int) bool {
		return runes[i] < runes[j]
	})
	return string(runes)
}

func GetKey(key string) []int {
	sortedKey := SortString(key)
	keyArr := []int{}
	for _, c := range key {
		idx := strings.Index(sortedKey, string(c))
		keyArr = append(keyArr, idx+1)
	}
	return keyArr
}

func PadString(str string, keyLength int, padChar rune) string {
	if len(str)%keyLength == 0 {
		return str
	}
	length := len(str) + (keyLength - len(str)%keyLength)

	if len(str) >= length {
		return str
	}
	padding := strings.Repeat(string(padChar), length-len(str))
	return str + padding
}

func GetUnsortedKeyIdx(key []int, n int) int {
	l := len(key)
	for i := 0; i < l; i++ {
		if key[i] == n {
			return i
		}
	}
	return -1
}

func Encode(s string, key []int) string {
	// need to pad s to a multiple of the length the key
	s = PadString(s, len(key), ' ')

	sortedKey := make([]int, len(key))
	copy(sortedKey, key)

	// Sort the copied array
	sort.Ints(sortedKey)

	fmt.Println(fmt.Sprint(key))
	// split s into chunks of length of key
	chunks := []string{}
	for i := 0; i < len(s); i += len(key) {
		start := i
		end := i + len(key)
		chunks = append(chunks, s[start:end])
	}

	fmt.Println(fmt.Sprint(chunks))

	// for each chunk, encode it
	// Key
	// 2 3 1 5 4 	key
	// s e c r e	chunk
	//
	// 1 2 3 4 5	sorted-key
	// c s e e r	chunk[index-of-n-in-key]
	encoded := ""

	for _, chunk := range chunks {
		for i := 0; i < len(key); i++ {
			encoded += string(chunk[GetUnsortedKeyIdx(key, sortedKey[i])])
		}
	}

	return encoded
}

func Nico(key, message string) string {
	return Encode(message, GetKey(key))
}
