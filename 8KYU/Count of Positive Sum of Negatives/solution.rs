fn count_positives_sum_negatives(input: Vec<i32>) -> Vec<i32> {
    if input.len() == 0 {
        return vec![];
    } else {
        let mut pos = 0;
        let mut neg_sum = 0;
        
        for x in input {
            if x > 0 {
                pos = pos + 1;
            } else {
                neg_sum = neg_sum + x;
            }
        }
        return vec![pos, neg_sum];
    }
}