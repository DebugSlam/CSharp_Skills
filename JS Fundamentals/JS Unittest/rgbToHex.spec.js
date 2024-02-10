import { rgbToHexColor } from "./rgbToHex.js"
import { expect } from "chai"


describe( 'The funct rgbToHex', () => {

    
    it('should return undefined if red is invalid', () => {
        //Arrange
        const invalid = -4 
        const valid = 0 
        const valid2 = 0
        
        //Act
        const result = rgbToHexColor(invalid, valid, valid)

        //Assert
        expect(result).to.be.undefined
    }
    )
    it('should return undefined if red is string', () => {
        //Arrange
        const invalid = "some" 
        const valid = 0 
        const valid2 = 0
        
        //Act
        const result = rgbToHexColor(invalid, valid, valid)

        //Assert
        expect(result).to.be.undefined
    }
    )

    it('should return undefined if red is to big', () => {
        //Arrange
        const invalid = 545
        const valid = 0 
        const valid2 = 0
        
        //Act
        const result = rgbToHexColor(invalid, valid, valid)

        //Assert
        expect(result).to.be.undefined
    }
    )


    it('should return undefined if blue is invalid', () => {
        //Arrange
        const invalid = -4 
        const valid = 0 
        
        //Act
        const result = rgbToHexColor(valid, invalid, valid)

        //Assert
        expect(result).to.be.undefined
    }
    )

    it('should return undefined if green is invalid', () => {
        //Arrange
        const invalid = -4 
        const valid = 0 
        
        //Act
        const result = rgbToHexColor(valid, valid, invalid)

        //Assert
        expect(result).to.be.undefined
    }
    )

    it('should return hex color if values are correct', () => {
        //Arrange
        const red = 234
        const green = 18 
        const blue = 54
        
        //Act
        const result = rgbToHexColor(red, green, green)

        //Assert
        expect(result).to.equals('#EA1212')
    }
    )

    it('EDGE max should return hex color if values are correct ', () => {
        //Arrange
        const red = 255
        const green = 255 
        const blue = 255
        
        //Act
        const result = rgbToHexColor(red, green, green)

        //Assert
        expect(result).to.equals('#FFFFFF')
    }
    )

    it('EDGE max should return hex color if values are correct ', () => {
        //Arrange
        const red = 0
        const green = 0 
        const blue = 0
        
        //Act
        const result = rgbToHexColor(red, green, green)

        //Assert
        expect(result).to.equals('#000000')
    }
    )
})
