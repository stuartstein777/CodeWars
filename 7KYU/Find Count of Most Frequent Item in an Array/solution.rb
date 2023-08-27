def most_frequent_item_count(collection)
  collection.length == 0 ? 0 : collection.group_by(&:itself).transform_values(&:count).values.max
end
