<!doctype html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Code Series : AngularJS 03/03</title>
    
</head>
<body ng-app="Issue-03-App">

    <div ng-controller="Test" ng-init="init()">
        
        <table ng-if="!isEditMode && !isNewMode">
            <thead>
                <tr>
                    <th>No</th>
                    <th>Code</th>
                    <th>Name</th>
                    <th>...</th>
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="d in Data">
                    <td>{{$index+1}}</td>
                    <td>{{d.code}}</td>
                    <td>{{d.name}}</td>
                    <td>
                        <button ng-click="edit_data(d.code)">Edit</button>
                        <button ng-click="delete_data(d.code)">Delete</button>
                    </td>                    
                </tr>
            </tbody>
            <tfoot>
                <tr>
                    <td colspan="4">
                        <button ng-click="new_data()">New</button>
                    </td>
                </tr>
            </tfoot>
        </table>        
        <div ng-if="isEditMode || isNewMode">
            <form>
                Code : <input type="text" ng-model="CurrentData.code" ng-readonly><br />
                Name : <input type="text" ng-model="CurrentData.name"><br />
                <button ng-click="cancel_data()">Cancel</button>
                <button ng-click="save_data()">Save</button>
                
            </form>
        </div>
        <span>
            <pre>{{ErrorMessage}}</pre>
        </span>
    </div>
   
    <script src="scripts/angular.js"></script>
    <script src="app/app.js"></script>

    <script>
        app.controller("Test", function($scope, $http){
            
            $scope.Data = [];
            $scope.ErrorMessage = "";
            $scope.isNewMode = false;
            $scope.isEditMode = false;
            //--------------------------------------------------------
            $scope.CurrentData = {
                code : "",
                name : ""
            }
            //--------------------------------------------------------
            $scope.init = function(){
                
                var url = "/issue-3/api/get_data.php";

                $scope.isNewMode = false;
                $scope.isEditMode = false;
                $scope.ErrorMessage = "";
                
                $http.get(url).error(function(response){
                    $scope.ErrorMessage = response.responseText;
                }).success(function(result){
                    $scope.Data = result;
                });
                
            }
            //--------------------------------------------------------
            $scope.delete_data = function(code){
                var url = "/issue-3/api/delete_data.php"
                
                $http.post(url, { code : code }).error(function(response){
                    $scope.ErrorMessage = response.responseText;
                }).success(function(result){                    
                    $scope.init();
                });
            }
            //--------------------------------------------------------
            $scope.cancel_data = function(){
                $scope.isEditMode = false;                
            }
            //--------------------------------------------------------
            $scope.new_data = function(){
                
                $scope.CurrentData = {
                    code : "",
                    name : ""
                }
                
                $scope.isNewMode = true;                
            }
            //--------------------------------------------------------
            $scope.save_data = function(){
                
                var url = "/issue-3/api/update_data.php";
                
                if($scope.isNewMode){
                    url = "/issue-3/api/add_data.php";
                }
                
                $http.post(url, $scope.CurrentData).error(function(response){
                    $scope.ErrorMessage = response.responseText;
                }).success(function(result){
                    if(result=="SUCCESS"){
                        $scope.isEditMode = false;
                        $scope.init();
                    }
                    $scope.ErrorMessage = result;
                });

            }
            //--------------------------------------------------------
//            $scope.update_data = function(){
//                
//                var url = "/issue-3/api/update_data.php";
//                
//                $http.post(url, $scope.CurrentData).error(function(response){
//                    $scope.ErrorMessage = response.responseText;
//                }).success(function(result){
//                    if(result=="SUCCESS"){
//                        $scope.init();
//                    }
//                    $scope.ErrorMessage = result;
//                });
//
//            }
            //--------------------------------------------------------      
            $scope.edit_data = function(code){
                $scope.isEditMode = true;
                
                var url = "/issue-3/api/find_data.php?code="+code;
                
                $http.get(url).error(function(response){
                    $scope.ErrorMessage = response.responseText;
                }).success(function(result){
                    $scope.isEditMode = true;
                    $scope.CurrentData = result;
                });                
            }
            //--------------------------------------------------------      
        });
    </script>
</body>
</html>
