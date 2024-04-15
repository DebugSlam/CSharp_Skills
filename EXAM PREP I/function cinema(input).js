function cinema(input) 
{
    'use strict';

    let numberOfMovies = input.shift()
    
    let moviesArray = []
    
    for (let i = 1; i <= numberOfMovies; i++) {
            
            moviesArray.push(input.shift()) 
        
    }
    
    
    
    while(input.length > 0)
    {   
        const command = input.shift()
    
        if (command == 'Sell')

        {
            console.log(`${moviesArray.shift()} ticket sold!`);
        }

       else if (command.includes('Add')) 
  
        {   
            const [, movie] = command.split('Add ');
            
            moviesArray.push(movie)
            
            
        }

        else if (command.includes('Swap'))
            {       
            const splitedCommand = command.split(' ')
            const startIndex = splitedCommand[1] 
            const endIndex = splitedCommand[2]
            const movieNameStartIndex = moviesArray[startIndex]  

            const movieNameEndIndex = moviesArray[endIndex]
            
            moviesArray[startIndex] = movieNameEndIndex
            moviesArray[endIndex] = movieNameStartIndex
            
            console.log("Swapped!")

            }

        
        else if (command ==  'End')
        {   
            if(moviesArray.length == 0){

                console.log("The box office is empty")
            }
            else
            {console.log(`Tickets left: ${moviesArray.join(', ' )}`)
            break}
        }
        
        
    }

}

cinema(['5', 'The Matrix', 'The Godfather', 'The Shawshank Redemption', 'The Dark Knight', 'Inception', 'Add The Lord of the Rings', 'Swap 1 4', 'End'])