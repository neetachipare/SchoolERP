angular.module('ERP').controller('MenuSubMenuController', MenuSubMenuController);
function MenuSubMenuController($scope, Service) {

    var form = $(".m-form m-form--fit m-form--label-align-right");

    $scope.UserCredentialModel = {};
    $scope.ParamUserLogin = {};
    $scope.selectedid = 0;
    $scope.btnUpdate = false;
    $scope.btnSave = true;
    $scope.IsVisible = false;
    $scope.DuplicateMsg = "";
    var nodeids = [];
 
    $scope.Initialize = function () {
       
        $scope.DuplicateMsg = "";
        $scope.Role = "";
        $scope.data = [];
      
        Service.Post("MenuSubMenu/GetRoleData").then(function (result) {
             
            $scope.RoleData = result.data;
            console.log(result.data);
        })
    }
    $scope.Cancel = function () {
    
        $('#m_tree_3').jstree("refresh");
        $scope.IsVisible = false;
        $scope.Initialize();
        $scope.msg = "";
        $scope.btnSave = false;
        $scope.btnUpdate = false;
        $scope.Role = "";
        $scope.DuplicateMsg = "";
    }
    

    $scope.Show = function () {
       
        $scope.IsVisible = true;
        $scope.btnUpdate = false;
        $scope.Role = "";
        $scope.RoleId = "";
        $scope.DuplicateMsg = "";
        nodeids = [];
        $scope.btnSave = true; 
        alert("hello4")
        //$('#m_tree_3').jstree("open_all");
       

        $scope.msg = "";

        Service.Post("MenuSubMenu/GetMenuSubMenuDemo").then(function (result) {
            $scope.ParamUserLogin.Name = result.data.ModuleName
            $scope.ParamUserLogin.state = result.data.state
            debugger;
            $('#m_tree_3').jstree({
                core: {
                    data: result.data,

                    check_callback: false
                },
                checkbox: {
                    keep_slected_style: true,
                    three_state: true,

                    whole_node: false,  // to avoid checking the box just clicking the node 
                    tie_selection: false // for checking without selecting and selecting without checking
                },
                plugins: ['checkbox']
            }).bind("loaded.jstree", function (event, data) {
                // you get two params - event & data - check the core docs for a detailed description
                $(this).jstree("open_all");
                $(this).jstree("deselect_all") ;
            })    

            //var nodeids = [4,1,3];
            // var tree = $("#m_tree_3");
            //// IE
            //tree.jstree(true).check_node(nodeids);
            //// Chrome or Firefox
            //tree.on("loaded.jstree", function (e, data) {
            //    tree.jstree(true).check_node(nodeids);
            //}).jstree();



        })
        $scope.Initialize();
       
    }
   
    $scope.postdata = function (Role) {
        debugger;
        var selectedData = [];
        var selectedIndexes;
        $scope.DuplicateMsg = "";
        debugger;
        if (Role != "") {
            selectedIndexes = $("#m_tree_3").jstree("get_checked", true);

            jQuery.each(selectedIndexes, function (index, value) {
                $scope.selectedid = $scope.selectedid + ',' + selectedIndexes[index].id;

            });

            selectedIndexes = $("#m_tree_3").jstree("get_undetermined", true);

            jQuery.each(selectedIndexes, function (index, value) {
                $scope.selectedid = $scope.selectedid + ',' + selectedIndexes[index].id;
            });


            var data = {
                Role: Role,
                selectedid: $scope.selectedid

            };

            Service.Post("MenuSubMenu/GetDuplicateRole", JSON.stringify(data), $scope.UserCredentialModel).then(function (result) {

                debugger;

              
                if (result.data == true) {
                    $scope.DuplicateMsg = "Duplicate Role Not Allowed.";
                }
                else {
                    Service.Post("MenuSubMenu/SaveMenuSubMenu", JSON.stringify(data)).then(function (response) {


                        $('#m_tree_3').jstree("refresh");
                        $scope.IsVisible = false;
                        $scope.Initialize();
                        $scope.msg = "Record Saved Sucessfully";
                        $scope.btnSave = false;
                        $scope.btnUpdate = false;
                        $scope.Role = "";
                        $scope.RoleId = "";

                    });
                }

            })


        }
        else
        {
            alert("Please Enter Role");
        }
        
    }

    $scope.GetSingleMenuSubMenu = function (RoleId, Role) {
        $scope.Cancel();
       
        $scope.btnSave = false;
        $scope.IsVisible = true;
      
        $scope.btnUpdate = true;
        
        $scope.Role = Role;
      
        $scope.RoleId = RoleId;
        var data = {
            RoleId: RoleId,
            Role:Role

        };
    
        $scope.btnSave = false;
        alert("hello2")
        Service.Post("MenuSubMenu/GetMenuSubMenuDemo").then(function (result) {
            $scope.ParamUserLogin.Name = result.data.ModuleName
            $scope.ParamUserLogin.state = result.data.state
            //debugger;
           $('#m_tree_3').jstree({
            core: {
                data: result.data,

                check_callback: false
            },
            checkbox: {
                keep_slected_style: false,
                three_state: false,

                whole_node: false,  // to avoid checking the box just clicking the node 
                tie_selection: false // for checking without selecting and selecting without checking
            },
            plugins: ['checkbox']
            }).bind("loaded.jstree", function (event, data) {
                // you get two params - event & data - check the core docs for a detailed description
                $(this).jstree("open_all");
                $(this).jstree("deselect_all");
            })    
           $scope.selectedid = 0;

           Service.Post("MenuSubMenu/GetSingleMenuSubMenu", JSON.stringify(data), $scope.UserCredentialModel).then(function (result) {
             
               //debugger;
               $scope.selectedid = result.data;
               var ids = $scope.selectedid;
               var nodeids = [];

               var string = ids.split(','); // <- split
               for (var i = 0; i < string.length; i++) {
                   nodeids.push(string[i]);
               }

               console.log(nodeids)

               var tree = $("#m_tree_3");
               // IE
               tree.jstree(true).check_node(nodeids);
               // Chrome or Firefox
               tree.on("loaded.jstree", function (e, data) {
                   tree.jstree(true).check_node(nodeids);
                   
               }).jstree();
           })
          
          
            


        })
        
    }


    $scope.UpdateTreeData = function (Role, RoleId) {
        $scope.DuplicateMsg = "";
        debugger;
        var selectedData = [];
        var selectedIndexes = "";
        $scope.selectedidNew = "0";
        $scope.selectedidUncheck = "0";
        $scope.selectedidAll = "0";
       
        var result = "";
        if (Role != "") {


            selectedIndexes = $("#m_tree_3").jstree("get_checked", true);

            jQuery.each(selectedIndexes, function (index, value) {
                if ($scope.selectedid.includes(selectedIndexes[index].id)) {





                }
                else {
                    $scope.selectedidNew = $scope.selectedidNew + ',' + selectedIndexes[index].id;

                }
                $scope.selectedidAll = $scope.selectedidAll + ',' + selectedIndexes[index].id;



            });

            for (var s = 0; s < $scope.selectedid.length; s++) {
                debugger;
                if ($scope.selectedidAll.includes($scope.selectedid[s])) {

                }
                else {
                    $scope.selectedidUncheck = $scope.selectedidUncheck + ',' + $scope.selectedid[s];
                }
            }



            selectedIndexes = $("#m_tree_3").jstree("get_undetermined", true);

            jQuery.each(selectedIndexes, function (index, value) {
                if ($scope.selectedid.includes(selectedIndexes[index].id)) {

                }
                else {
                    $scope.selectedidNew = $scope.selectedidNew + ',' + selectedIndexes[index].id;
                }

                $scope.selectedidAll = $scope.selectedidAll + ',' + selectedIndexes[index].id;
            });



            var data = {
                RoleId: RoleId,
                Role: Role,
                selectedid: $scope.selectedidNew,
                Unselectedid: $scope.selectedidUncheck

            };

            Service.Post("MenuSubMenu/UpdateMenuSubMenu", JSON.stringify(data)).then(function (response) {



                $('#m_tree_3').jstree("refresh");
                $scope.IsVisible = false;
                $scope.Initialize();
                $scope.msg = "Record Updated Sucessfully";
                $scope.btnSave = false;
                $scope.btnUpdate = false;
                $scope.Role = "";
                $scope.RoleId = "";

            });
        }
        else {
            alert("Please Enter Role");
        }

        }
  
}