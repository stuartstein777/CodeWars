function countTheAnimals(animals) {
	var sum = 0;
	for (let s of Object.values(animals)) {
		sum += parseInt(s, 2);
	}
	return sum;
}

// Second solution
function countTheAnimals(animals) {
	var total = 0;
	for (var i = 0, keys = Object.keys(animals), ii = keys.length; i < ii; i++) {
		total += parseInt(animals[keys[i]], 2);
	}    
	return total;  
}