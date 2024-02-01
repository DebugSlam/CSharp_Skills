function solve(employee) {
    
    let arrEmployee = [];

    for (const employeeRow of employee)
    {
        arrEmployee.push({
            name: employeeRow,
            personalNumber: employeeRow.length    
        })
    }


arrEmployee.forEach(element => {
    
    console.log(`Name: ${element.name} -- Personal Number: ${element.personalNumber}`);

});


}

solve(['Silas Butler', 'Adnaan Buckley', 'Juan Peterson', 'Brendan Villarreal']);