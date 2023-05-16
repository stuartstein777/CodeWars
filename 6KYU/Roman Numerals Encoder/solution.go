package kata

import "strings"

type DecimalToRoman struct {
	decimal int
	roman   string
}

func Solution(dec int) string {
	numerals := []DecimalToRoman{
		{1000, "M"},
		{900, "CM"},
		{500, "D"},
		{400, "CD"},
		{100, "C"},
		{90, "XC"},
		{50, "L"},
		{40, "XL"},
		{10, "X"},
		{9, "IX"},
		{5, "V"},
		{4, "IV"},
		{1, "I"}}

	romanNumerals := ""
	for _, kv := range numerals {
		q := dec / kv.decimal
		romanNumerals += strings.Repeat(kv.roman, q)
		dec -= kv.decimal * q
	}

	return romanNumerals
}
