function solve(commands) 
{
    'use strict';
   
    let movieLibrary = {}
     for (const command of commands)
    {
        if (command.includes('addMovie'))

        {
            const movieName = command.replace('addMovie ', '').trim()
            movieLibrary[movieName] = {};

        }

        if (command.includes('directedBy'))
        {   
            const [movieNameD, movieDirector] = command.split(' directedBy ');
            if (movieLibrary[movieNameD]) {
                movieLibrary[movieNameD].director = movieDirector;
            }

        }
        if (command.includes('onDate'))
        {   
            const [movieNameD, movieDate] = command.split(' onDate ');
            if (movieLibrary[movieNameD]) {
                movieLibrary[movieNameD].date = movieDate;
           
        }
    
        }      
        
    }

    for (const movieName in movieLibrary) {
        const { director, date } = movieLibrary[movieName];
        
        
console.log(`{"name":"${movieName}","date":"${date}","director":"${director}"}`)
        
    }
}

solve([ 'addMovie Fast and Furious', 'addMovie Godfather', 'Inception directedBy Christopher Nolan', 'Godfather directedBy Francis Ford Coppola', 'Godfather onDate 29.07.2018', 'Fast and Furious onDate 30.07.2018', 'Batman onDate 01.08.2018', 'Fast and Furious directedBy Rob Cohen' ]);