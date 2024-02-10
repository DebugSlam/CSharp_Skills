import { mathEnforcer } from "./MathEnforcer.js";
import { expect } from "chai";

describe( 'The object mathEnforcer', () => {

    describe( 'function add FIVE', () => {

        it('should return undefined if the input of addFive is not a numer (float, whole)', () => {

            //Arrange & //Act
           
            const stringResult = mathEnforcer.addFive('String')
            const undefinedResult = mathEnforcer.addFive(undefined)
            
            const numberAsStringResult = mathEnforcer.addFive('34')
           
            //const floatingResult = mathEnforcer.addFive(0.154)
            const arrayResult = mathEnforcer.addFive([1, 2, 3])
    
            //Assert
            
            expect(undefinedResult).to.be.undefined
            expect(numberAsStringResult).to.be.undefined
            
            expect(arrayResult).to.be.undefined
    
           })

           it('should return whole number if the input of addFive is numer (whole)', () => {

            //Arrange & //Act
            const numberResult = mathEnforcer.addFive(-6)
           
            //const floatingResult = mathEnforcer.addFive(0.154)
    
            //Assert
            
            expect(numberResult).to.equals(-1)
    
           })

           it('should return float number if the input of addFive is float numer', () => {

            //Arrange & //Act
            
            const floatingResult = mathEnforcer.addFive(1.000001)
    
            //Assert
            
            expect(floatingResult).to.closeTo(6.01, 0.01)
    
           })
    

    })

    describe( 'function substract 10', () => {

        it('should return undefined if the input of addFive is not a numer (float, whole)', () => {

            //Arrange & //Act
           
            const stringResult = mathEnforcer.subtractTen('String')
            const undefinedResult = mathEnforcer.subtractTen(undefined)
           
            const numberAsStringResult = mathEnforcer.subtractTen('34')
           
            //const floatingResult = mathEnforcer.addFive(0.154)
            const arrayResult = mathEnforcer.subtractTen([1, 2, 3])
    
            //Assert
            
            expect(undefinedResult).to.be.undefined
            expect(numberAsStringResult).to.be.undefined
           
            expect(arrayResult).to.be.undefined
    
           })

           it('should return whole number if the input of addFive is negativ numer (whole)', () => {

            //Arrange & //Act
            const numberResult = mathEnforcer.subtractTen(-5)
           
            //const floatingResult = mathEnforcer.addFive(0.154)
    
            //Assert
            
            expect(numberResult).to.equals(-15)
    
           })

           it('should return whole number if the input of addFive is numer (whole)', () => {

            //Arrange & //Act
            const numberResult = mathEnforcer.subtractTen(15)
           
            //const floatingResult = mathEnforcer.addFive(0.154)
    
            //Assert
            
            expect(numberResult).to.equals(5)
    
           })

           it('should return float number if the input of addFive is float numer', () => {

            //Arrange & //Act
            
            const floatingResult = mathEnforcer.subtractTen(10.54)
    
            //Assert
            
            expect(floatingResult).to.closeTo(0.54, 0.01)
    
           })
    

    })

    describe( 'function sum num1 and num2', () => {

        it('should return undefined if the input is not a numer (float, whole)', () => {

            //Arrange & //Act
           
            const stringResult = mathEnforcer.sum('String', 1)
            const undefinedResult = mathEnforcer.sum(undefined,1)
            
            const numberAsStringResult = mathEnforcer.sum(1,'34')
           
            //const floatingResult = mathEnforcer.addFive(0.154)
            const arrayResult = mathEnforcer.sum([1, 2, 3])
    
            //Assert
            
            expect(undefinedResult).to.be.undefined
            expect(numberAsStringResult).to.be.undefined
            
            expect(arrayResult).to.be.undefined
    
           })

           it('should return whole number if the input of sum are numbers (whole)', () => {

            //Arrange & //Act
            const numberResult = mathEnforcer.sum(-5,-5)
           
            //const floatingResult = mathEnforcer.addFive(0.154)
    
            //Assert
            
            expect(numberResult).to.equals(-10)
    
           })

           it('should return whole number if the input of sum are numbers (whole)', () => {

            //Arrange & //Act
            const numberResult = mathEnforcer.sum(5,222)
           
            //const floatingResult = mathEnforcer.addFive(0.154)
    
            //Assert
            
            expect(numberResult).to.equals(227)
    
           })

           it('should return float number if the input of sum is float numer', () => {

            //Arrange & //Act
            const num1 = 10.54
            const num2 = -10.54
            const floatingResult = mathEnforcer.sum(num1, num2)
    
            //Assert
            
            expect(floatingResult).to.equals(0)
    
           })
    

    })
    
})