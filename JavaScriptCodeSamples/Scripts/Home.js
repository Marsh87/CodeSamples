function calculateProfit() {
    var revenue = document.getElementById("revenue").val();
    var operatingCost = document.getElementById("operationCost").val();
    var profit = revenue - operatingCost;
    document.getElementById("profit").data = profit;
}

function numberOfDivs() {
    var numberOfDivs = document.getElementsByTagName("div").length;
    document.getElementById("output").data = numberOfDivs;
}

function  numberOfAdditionalCosts(parameters) {
    var additionalCost = document.getElementsByName("additionalCost").length;
}