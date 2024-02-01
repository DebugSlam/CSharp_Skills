function solve(number)
{
// Convert the number to a string
let numberStr = number.toString();
let sumOdd = 0;
let sumEven = 0;
// Iterate through each digit
for (let i = 0; i < numberStr.length; i++) {
    let digit = parseInt(numberStr[i], 10); // Convert the digit back to a number if needed
    
    if (digit % 2 === 0)
    {
        sumEven += digit;

    }
    else

    {
        sumOdd += digit;

    }
    }
    console.log(` Odd sum = ${sumOdd}, Even sum = ${sumEven}`);
}

solve (1000435);
