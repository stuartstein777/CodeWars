function zombie_shootout(zombies, range, ammo) {
    console.log("zombies: " + zombies);
    console.log("range: " + range);
    console.log("ammo: " + ammo);
    var zombiesThatCanBeShot = (range * 2);
    if(zombiesThatCanBeShot > ammo) {
      if(ammo < zombies) {
        return `You shot ${ammo} zombies before being eaten: ran out of ammo.`;
      }
    } else {
      if(zombiesThatCanBeShot < zombies)
        return `You shot ${zombiesThatCanBeShot} zombies before being eaten: overwhelmed.` 
    }
    return `You shot all ${zombies} zombies.`;
}