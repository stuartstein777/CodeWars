package kata

import (
	"sort"
	"strings"
)

func InArray(array1 []string, array2 []string) []string {
	aInB := make(map[string]interface{})

	for _, a := range array1 {
		for _, b := range array2 {
			if strings.Contains(b, a) {
				if _, ok := aInB[a]; !ok {
					aInB[a] = nil
				}
			}
		}
	}

	res := []string{}

	for k, _ := range aInB {
		res = append(res, k)
	}
	sort.Strings(res)
	return res
}
