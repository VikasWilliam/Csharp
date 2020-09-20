var currentList = {};

function createShoppingList() {
    console.log("clicked");
    currentList.name = $("#ShoppingListName").val();
    currentList.items = new Array();
    console.log(currentList.name);

    //web service call

    $("#ShoppingListTitle").html(currentList.name);
    $("#ShoppingListItem").empty();

    $("#createListDiv").hide();
    $("#shoppingListDiv").show();

}
function addItem() {
    console.log("button Clicked");
    var newItem = {};
     newItem.name = $("#newItemName").val();
     currentList.items.push(newItem);
     console.info(currentList);

   
     drawItems();

}
function drawItems() {

    var $list = $("#ShoppingListItem").empty();

    for (var i = 0; i < currentList.items.length; i++) {
        var currentItem = currentList.items[i];
        var $li = $("<li>").html(currentItem.name).attr("id", "item_" + i);
        var $del = $("<button onclick='deleteItem(" + i + ")'>D</button>").appendTo($li);
        var $chk = $("<button onclick='checkItem(" + i + ")'>C</button>").appendTo($li);

        $li.appendTo($list);
        var $cls = $("#newItemName").val('');
    }
}
function deleteItem(index) {

    currentList.items.splice(index, 1);
    drawItems();
}
function checkItem(index) {

    if ($("#item_" + index).hasClass("checked"))
    {
        $("#item_" + index).removeClass()
    }
    else {

        $("#item_" + index).addClass("checked")
    }
    console.log($("#item_" + index))
}

$(document).ready(function () {

    console.info("ready");

});