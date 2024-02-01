function solve(word, templ) {
 
    'use strict';
    const wordLow = word.toLowerCase();
    const hasWord = templ
    .toLowerCase()
    .split(' ')
    .includes(wordLow);
if (hasWord)
{
   console.log(word);
   }
   
   else 
   {
       
   console.log(`${word} not found!`);
   }
   
}
   
   
   solve('python','JavaScript is the best  programming language of javascript');