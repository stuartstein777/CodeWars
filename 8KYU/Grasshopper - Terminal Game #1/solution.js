function Hero (name) {
    return {name: (name === undefined || name === null) ? "Hero" : name,
			position: '00',
			health: 100,
			damage: 5,
			experience: 0};
}