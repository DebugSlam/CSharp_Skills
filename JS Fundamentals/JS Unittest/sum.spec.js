import { sum } from './sum.js'
import { expect } from 'chai'

describe( 'The funct SUM', () => {

    
    it('should return singel element if given such', () => {
        //Arrange
        const inputArray1 = [904] 
        
        //Act
        const result = sum(inputArray1)

        //Assert
        expect(result).to.equals(inputArray1[0])
    }
    )
    
    it('should return 0 if an empty array is given', () => {
        //Arrange
        const inputArray = []

        //Act
        const result = sum(inputArray)

        //Assert
        expect(result).to.equals(0)

    })
}

)