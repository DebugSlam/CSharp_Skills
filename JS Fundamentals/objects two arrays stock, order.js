function solve(stock, order) {
    'use strict';

    let storeStock = {}
    for (let i = 0; i < stock.length; i++)
    {
        if (i % 2 == 0)
        {
            const stockName = stock[i];
        const stockQuantity = Number(stock[i + 1]); // Convert quantity to a number
        
        if (!storeStock[stockName]) {
            storeStock[stockName] = 0
        }
        storeStock[stockName] += stockQuantity
        }
     }

     for (let i = 0; i < order.length; i++)
    {
        if (i % 2 == 0)
        {
         const orderName = order[i];
        const orderQuantity = Number(order[i + 1]); // Convert quantity to a number

    
        if (!storeStock[orderName]) {
            storeStock[orderName] = 0;
        }
        storeStock[orderName] += orderQuantity

        }
     }


     for (const productName in storeStock) {
        console.log(`${productName} -> ${storeStock[productName]}`)
    }

}

solve(['Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'], 
['Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30'] )