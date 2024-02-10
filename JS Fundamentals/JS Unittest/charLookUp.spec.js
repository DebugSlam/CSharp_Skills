import { lookupChar } from "./charLookUp.js";
import { expect } from "chai";

describe('Funktion LookUp Char', () => {

    it('should return undefined if input parameter one is not a string', () => 
    {
        //Arrange & //Act
        const paramIndex = 3
        const nanResult = lookupChar(NaN, paramIndex)
        const undefinedResult = lookupChar(undefined, paramIndex)
        const nullResult = lookupChar(null, paramIndex)
        const objectResult = lookupChar({}, paramIndex)
        const numberResult = lookupChar(32, paramIndex)
        const floatingResult = lookupChar(0.154, paramIndex)
        const arrayResult = lookupChar([1, 2, 3], paramIndex)

        //Assert
        expect(nanResult).to.be.undefined
        expect(undefinedResult).to.be.undefined
        expect(numberResult).to.be.undefined
        expect(objectResult).to.be.undefined 
        expect(floatingResult).to.be.undefined
        expect(nullResult).to.be.undefined
        expect(arrayResult).to.be.undefined

    } 
    )

    it('should return undefined if input parameter TWO is not an integer', () => 
    {
        //Arrange & //Act
        const paramIndex1 = 'Test12$'
        const nanResult = lookupChar(paramIndex1, NaN)
        const undefinedResult = lookupChar(paramIndex1, undefined)
        const nullResult = lookupChar(paramIndex1, null)
        const objectResult = lookupChar(paramIndex1, {})
        const floatingResult = lookupChar(paramIndex1, 0.154)
        const arrayResult = lookupChar(paramIndex1, [1, 2, 3])

        //Assert
        expect(nanResult).to.be.undefined
        expect(undefinedResult).to.be.undefined
        expect(objectResult).to.be.undefined 
        expect(floatingResult).to.be.undefined
        expect(nullResult).to.be.undefined
        expect(arrayResult).to.be.undefined

    } 
    )

    it('should return incorrect Index if the string length is smaller than the index', () => 
    {
        //Arrange & //Act
        const paramIndex = 10
        const paramString  = 'Test12$'
        const result = lookupChar(paramString, paramIndex)
        //Assert
        expect(result).to.equals('Incorrect index')

    } 
    )

    it('should return incorrect Index if the index is negative number', () => 
    {
        //Arrange & //Act
        const paramIndex = -3
        const paramString  = 'Test12$'
        const result = lookupChar(paramString, paramIndex)
        //Assert
        expect(result).to.equals('Incorrect index')

    } 
    )

    it('should return Char at Index', () => 
    {
        //Arrange & //Act
        const paramIndex = 6
        const paramString  = 'Test12$'
        const result = lookupChar(paramString, paramIndex)
        //Assert
        expect(result).to.equals('$')

    } 
    )
})