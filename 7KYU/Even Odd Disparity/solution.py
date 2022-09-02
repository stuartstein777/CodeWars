def solve(arr):
    even_count = len([a for a in arr if isinstance(a, int) and a % 2 == 0])
    odd_count = len([a for a in arr if isinstance(a, int) and a % 2 != 0])
    return even_count - odd_count