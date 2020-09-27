//Service to get data from employee mvc controller

myapp.service('employeeService', function ($http) {
    //alert("IGot called");
    this.getAllEmployees = function () {
        return $http.get("/Employee/GetEmployees");
    }
    var rootUrl = "/Employee/";
    this.save = function (Employee) {
        var request = $http({
            method: 'post',
            url: rootUrl+"Insert",
            data: Employee
        });
        return request;
    }
    //update

    this.update = function (Employee) {
        console.log(Employee);
        var updateRequest = $http({
            method: 'post',
            url: rootUrl + "Update",
            data: Employee
        });
        return updateRequest;
    }

    //delete record
    this.delete = function (UpdateEmpNo) {
        return $http.post('/Employee/Delete/' + UpdateEmpNo);
    }
});