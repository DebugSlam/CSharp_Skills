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

       
        if (command.includes('onDate'))
        {   
            const [movieNameD, movieDate] = command.split(' onDate ');
            if (movieLibrary[movieNameD]) {
                movieLibrary[movieNameD].date = movieDate;
           
        }
    
        }      

        if (command.includes('directedBy'))
        {   
            const [movieNameD, movieDirector] = command.split(' directedBy ');
            if (movieLibrary[movieNameD]) {
                movieLibrary[movieNameD].director = movieDirector;
            }

        }
        
    }

    for (const movieName in movieLibrary) {
        const { director, date } = movieLibrary[movieName];
        
        if(director && date && movieName){
console.log(`{"name":"${movieName}","director":"${director}","date":"${date}"}`)
        }
    }
}

solve([ 'addMovie Fast and Furious', 'addMovie Godfather', 'Inception directedBy Christopher Nolan', 'Godfather directedBy Francis Ford Coppola', 'Godfather onDate 29.07.2018', 'Fast and Furious onDate 30.07.2018', 'Batman onDate 01.08.2018', 'Fast and Furious directedBy Rob Cohen' ]);