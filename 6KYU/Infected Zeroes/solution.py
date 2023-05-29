from collections import deque

def infected_zeroes(arr):
    n = len(arr)
    distances = [float('inf')] * n

    queue = deque()
    for i in range(n):
        if arr[i] == 0:
            distances[i] = 0
            queue.append(i)

    while queue:
        index = queue.popleft()
        for neighbor in [index-1, index+1]:
            if 0 <= neighbor < n and distances[neighbor] > distances[index] + 1:
                distances[neighbor] = distances[index] + 1
                queue.append(neighbor)

    return max(distances)