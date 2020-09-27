myapp.controller('employee-controller', function ($scope, employeeService) {

    //loads all Employees when page loads
    loadEmployees();

    function loadEmployees() {
        var EmployeeRecords = employeeService.getAllEmployees();
        EmployeeRecords.then(function (d) {
            //success
            $scope.Employees = d.data;
        },
            function () {
                alert("Error occured whuile...");
            });
    }
    //save employee data

    $scope.save = function () {
        //alert("I got clicked")
        var Employee = {
            EmpNo: $scope.EmpNo,
            EmpName: $scope.EmpName,
            Email: $scope.Email,
            DeptName: $scope.DeptName,
            Designation: $scope.Designation
        };
        var saverecords = employeeService.save(Employee);
        saverecords.then(function (d) {
            if (d.data.success === true) {
                loadEmployees();
                alert("Employee added successfully");
                $scope.resetSave();
            }
            else { alert("Employee not added."); }
        },
            function () {
                alert("Error occurred while adding employee.");
            });
    }




    //var yes = document.getElementById("btnFuck");
    //yes.addEventListener("click", save);

    $scope.update = function () {

        var Employee = {
            EmpId: $scope.UpdateEmpNo,
            EmpName: $scope.UpdateEmpName,
            Email: $scope.UpdateEmail,
            DeptName: $scope.UpdateDeptName,
            Designation: $scope.UpdateDesignation
        };
        console.log(Employee);
        var updateRecords = employeeService.update(Employee);
        updateRecords.then(function (d) {
            if (d.data.success === true) {
                loadEmployees();
                alert("Employee updated successfully");
                $scope.resetSave();
            }
            else {
                alert("Employee not updated successfully");
            }
        },
            function () {
                alert("An error Occured");
            });
    }


    //delete Employee record
    $scope.delete = function (UpdateEmpNo) {
        //alert("I Got clicked");
        var deleterecord = employeeService.delete($scope.UpdateEmpNo);
        deleterecord.then(function (d) {
            if (d.data.success === true) {
                loadEmployees();
                alert("Employee deleted succussfully");
            }
            else {
                alert("Employee not deleted.");
            }
        });
    }


    //get single record by ID
    $scope.getForUpdate = function (Employee) {
        console.log(Employee);
        $scope.UpdateEmpNo = Employee.EmpID;
        $scope.UpdateEmpName = Employee.EmpName;
        $scope.UpdateEmail = Employee.Email;
        $scope.UpdateDeptName = Employee.DeptName;
        $scope.UpdateDesignation = Employee.Designation;
    }

    //get data for delete confirmation
    $scope.getForDelete = function (Employee) {
        //alert("I Got clicked");
        $scope.UpdateEmpNo = Employee.EmpID;
        $scope.UpdateEmpName = Employee.EmpName; 
    }

    // reset controls after sae ovperatino
    $scope.resetSave = function () {
        $scope.EmpNo = '';
        $scope.EmpName = '';
        $scope.Email = '';
        $scope.DeptName = '';
        $scope.Designation = '';
        ///for update
        $scope.UpdateEmpNo = '';
        $scope.UpdateEmpName = '';
        $scope.UpdateEmail = '';
        $scope.UpdateDeptName = '';
        $scope.UpdateDesignation = '';
    }
});