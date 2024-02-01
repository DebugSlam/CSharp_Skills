function solve(towns) {
    'use strict';

    let arrTowns = []

    for (const townRow of towns)
    {
        const splitData = townRow.split(" | ")
        arrTowns.push({
            name: splitData[0],
            latitude:  splitData[1],
            longitude:  splitData[2]
        })
    }


    arrTowns.forEach(town => {
        console.log(`{ town: '${town.name}', latitude: '${Number(town.latitude).toFixed(2)}', longitude: '${Number(town.longitude).toFixed(2)}' }`);
    });

}

solve(['Sofia | 42.696552 | 23.32601', 'Beijing | 39.913818 | 116.363625']);