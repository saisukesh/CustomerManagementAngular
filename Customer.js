function CustomerViewModel($scope, $http) {

    $scope.Customer = {
        "CustomerCode": "",
        "CustomerName": "",
        "CustomerAmount": "",
        "CustomerAmountColor": ""

    };
    $scope.Customers = {};

    $scope.$watch("Customers", function () {
        for (var x = 0; x < $scope.Customers.length; x++) {
            var cust = $scope.Customers[x];
            cust.CustomerAmountColor = $scope.getColor(cust.CustomerAmount);
        }
    });



    $scope.getColor = function (Amount) {
        if (Amount == 0) {
            return "";
        }
        else if (Amount > 100) {
            return "Blue";
        }
        else {
            return "Red";
        }
    }
    $scope.$watch("Customer.CustomerAmount", function () {
        $scope.Customer.CustomerAmountColor = $scope.getColor($scope.Customer.CustomerAmount);
    });

    $scope.Add = function () {
        //make a call to server to add data

        $http({ method: "POST", data: $scope.Customer, url: "/Api/Custo" }).
            success(function (data, status, headers, config) {
            $scope.Customers = data;
            //Load the collection of CUstomers
            $scope.Customer = {
                "CustomerCode": "",
                "CustomerName": "",
                "CustomerAmount": "",
                "CustomerAmountColor": ""
            };
        });
    }
    $scope.Update = function () {
        //make a call to server to add data

        $http({ method: "PUT", data: $scope.Customer, url: "/Api/Custo" }).
            success(function (data, status, headers, config) {
                $scope.Customers = data;
                //Load the collection of CUstomers
                $scope.Customer = {
                    "CustomerCode": "",
                    "CustomerName": "",
                    "CustomerAmount": "",
                    "CustomerAmountColor": ""
                };
            });
    }
    $scope.Delete = function () {
        //make a call to server to add data
        $http.defaults.headers["delete"] = {
            'Content-Type': 'application/json;charset=utf-8'
        };

        $http({ method: "DELETE", data: $scope.Customer, url: "/Api/Custo" }).
            success(function (data, status, headers, config) {
                $scope.Customers = data;
                //Load the collection of CUstomers
                $scope.Customer = {
                    "CustomerCode": "",
                    "CustomerName": "",
                    "CustomerAmount": "",
                    "CustomerAmountColor": ""
                };
            });
    }
    $scope.Load = function () {
        $http({ method: "GET", url: "/Api/Custo" }).
        success(function (data, status, headers, config) {
            $scope.Customers = data;
        });
        $scope.Load();
    }
    $scope.LoadByName = function () {
        
        $http({
            method: "GET", url: "/Api/Custo?CustomerName=" + $scope.Customer.CustomerName
        }).
        success(function (data, status, headers, config) {
            $scope.Customers = data;
        });
        $scope.Load();
    }
    $scope.LoadByCode = function (CustomerCode) {

        $http({
            method: "GET", url: "/Api/Custo?CustomerCode=" + CustomerCode
        }).
        success(function (data, status, headers, config) {
            $scope.Customers = data;
        });
        $scope.Load();
    }


}