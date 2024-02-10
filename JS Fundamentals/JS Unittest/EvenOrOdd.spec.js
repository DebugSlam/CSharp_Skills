import { isOddOrEven } from './EvenOrOdd.js'
import { expect } from 'chai'

describe( 'The funct isOddOrEven', () => {

    
    it('should return undefined if the input is not string', () => {

         //Arrange & //Act
         const nanResult = isOddOrEven(NaN)

         const undefinedResult = isOddOrEven(undefined)
         const nullResult = isOddOrEven(null)
         const objectResult = isOddOrEven({})
         const numberResult = isOddOrEven(32)
         const floatingResult = isOddOrEven(0.154)
         const arrayResult = isOddOrEven([1, 2, 3])
 
         //Assert
         expect(nanResult).to.be.undefined
         expect(undefinedResult).to.be.undefined
         expect(numberResult).to.be.undefined
         expect(objectResult).to.be.undefined 
         expect(floatingResult).to.be.undefined
         expect(nullResult).to.be.undefined
         expect(arrayResult).to.be.undefined

        })

        it('should return even if the input is empty', () => {

            //Arrange 
            const evenResult = isOddOrEven('')
   
            //Act


            //Assert
            expect(evenResult).to.equals('even')
   
           })

           it('should return odd if the input is one char', () => {

            //Arrange 
            const evenResult = isOddOrEven('I')
   
            //Act


            //Assert
            expect(evenResult).to.equals('odd')
   
           })

           it('should return even if the input is even legth', () => {

            //Arrange 
            const evenResult = isOddOrEven('Ka1!na')
   
            //Act


            //Assert
            expect(evenResult).to.equals('even')
   
           })

})