function rowSumOddNumbers(n) {
	const last = (n * n) + (n - 1);
	const start = last - (2 * (n - 1));
	return ((start + last) / 2) * n;
}