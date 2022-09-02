def check_the_bucket(bucket)
    bucket.any? {|x| x === "gold"}
end