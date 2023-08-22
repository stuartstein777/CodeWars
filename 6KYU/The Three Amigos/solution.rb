def get_range(arr)
    arr.max - arr.min
  end
  
def all_same_parity(arr)
arr.all? { |x| x.even? } or arr.all? { |x| x.odd? }
end

def partition_with_step(arr, partition_size, step)
result = []

(0..(arr.length - partition_size)).step(step) do |i|
    partition = arr[i, partition_size]
    result << partition
end

result
end

def three_amigos(numbers)
partition_with_step(numbers, 3, 1)
        .select{|part| all_same_parity(part)}
        .min_by {|part| get_range(part) }  or []
end