function solve(sentence) {
    'use strict';
    const words = sentence.split(' ').map(word => word.toLowerCase());

    const uniqueWords = [];
    const wordCounts = [];

    words.forEach(word => {
        const index = uniqueWords.indexOf(word);
        if (index !== -1) {
            wordCounts[index]++;
        } else {
            uniqueWords.push(word);
            wordCounts.push(1);
        }
    });

    // Filter words with odd occurrences
    const oddOccurrences = uniqueWords.filter((wd, index) => wordCounts[index] % 2 !== 0);

    console.log(oddOccurrences.join(' '));
        
}

solve('Java C# Php PHP Java PhP 3 C# 3 1 5 C#')