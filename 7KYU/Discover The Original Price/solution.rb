def discover_original_price(discounted_price, sale_percentage)
  (discounted_price / (1 - sale_percentage / 100.0)).round(2)
end