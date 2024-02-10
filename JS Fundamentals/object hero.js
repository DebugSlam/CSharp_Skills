function solve(heroes) {
    'use strict';
    
    let heroesLibrary = {}

    for (const command of heroes) {   
        const [heroName, heroLevel, heroProperties] = command.split('/')
            .map(item => item.trim());
        
        const heroPropertiesArr = heroProperties.split(',')
            .map(property => property.trim());
        
        heroesLibrary[heroName] = {
            level: Number(heroLevel),
            properties: heroPropertiesArr
        };
    }
    
    const sortedHeroes = Object.keys(heroesLibrary).sort((a, b) => heroesLibrary[a].level - heroesLibrary[b].level);

    for (const heroName of sortedHeroes) {
        const { level, properties } = heroesLibrary[heroName]
        
        console.log(`Hero: ${heroName}`)
        console.log(`level => ${level}`)
        console.log(`Items => ${properties.join(', ')}`)
    }
}

solve(['Isacc / 25 / Apple', 'Derek / 12 / BarrelVest, DestructionSword', 'Hes / 1 / Desolator, Sentinel, Antara'])     