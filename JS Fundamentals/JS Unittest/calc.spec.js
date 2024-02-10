import { createCalculator  } from "./calc.js"; 
import { expect } from "chai";

describe ('The Funct CALC', () => {

    it('should return 0  if no operations are executed', () =>{
        //Arrange
        const calculator = createCalculator()
        
        //Act
        const result = calculator.get()
        
        //Assert
        expect(result).to.equals(0)
    })

    it('should return negative number if only substracting are executed', () =>{

        //Arrange
        const calculator = createCalculator()
        
        //Act
        calculator.subtract(3)
        calculator.subtract(3)
        calculator.subtract(3)
        const result = calculator.get()
        
        //Assert
        expect(result).to.equals(-9)

        
    })

    it('should return positive number if only adding are executed', () =>{

        //Arrange
        const calculator = createCalculator()
        
        //Act
        calculator.add(3)
        calculator.add(4)
        calculator.add(100)
        const result = calculator.get()
        
        //Assert
        expect(result).to.equals(107)
    })

    it('should handle values as strings', () =>{

        //Arrange
        const calculator = createCalculator()
        
        //Act
        calculator.add('3')
        calculator.add('4')
        calculator.add('100')
        const result = calculator.get()
        
        //Assert
        expect(result).to.equals(107)
    })

    it('should handle a mix of operations', () =>{

         //Arrange
         const calculator = createCalculator()
        
         //Act
         calculator.add('4')
         calculator.subtract('4')
         calculator.add('100')
         const result = calculator.get()
         
         //Assert
         expect(result).to.equals(100)
    })
})