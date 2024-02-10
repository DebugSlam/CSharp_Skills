import { isSymmetric} from './isSymmetric.js'
import { expect } from 'chai'

describe( 'The funct isSymmetric', () => {

    
    it('should return true if single element is given', () => {
        //Arrange
        const inputArray1 = [904] 
        
        //Act
        const result = isSymmetric(inputArray1)

        //Assert
        expect(result).to.be.true
    }
    )

    it('should return true if symetric array is given', () => {
        //Arrange
        const inputArray1 = [904, 303, 23, 303, 904] 
        
        //Act
        const result = isSymmetric(inputArray1)

        //Assert
        expect(result).to.equals(true)
    }
    )

    it('should return true if empty element is given', () => {
        //Arrange
        const inputArray1 = [] 
        
        //Act
        const result = isSymmetric(inputArray1)

        //Assert
        expect(result).to.be.true
    }
    )
    
    it('should return false if non symetric array is given', () => {
        //Arrange
        const inputArray = [3, 4, 5, 6]

        //Act
        const result = isSymmetric(inputArray)

        //Assert
        expect(result).to.be.false

    })

    it('should return false if symetric array with lokalike values is given', () => {
        //Arrange
        const inputArray = ['3', '4', '5', 4, 3]

        //Act
        const result = isSymmetric(inputArray)

        //Assert
        expect(result).to.be.false

    })

    it('should return false if non array is given', () => {
        //Arrange & //Act
        const nanResult = isSymmetric(NaN)

        const undefinedResult = isSymmetric(undefined)
        const nullResult = isSymmetric(null)
        const objectResult = isSymmetric({})
        const stringResult = isSymmetric('test')
        const numberResult = isSymmetric(32)

        //Assert
        expect(nanResult).to.be.false
        expect(undefinedResult).to.be.false
        expect(nullResult).to.be.false
        expect(objectResult).to.be.false
        expect(stringResult).to.be.false
        expect(nullResult).to.be.false
        


    })
}

)