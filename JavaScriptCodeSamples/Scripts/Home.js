function calculateProfit() {
    var revenue = document.getElementById("revenue").value;
    var operatingCost = document.getElementById("operatingCost").value;
    var profit = 0;
    if (revenue && operatingCost) {
        profit = revenue - operatingCost;
    }
    document.getElementById("profit").innerText = "Profit:" + " " + profit;
}

function numberOfDivs() {
    var numOfDivs = document.getElementsByTagName("div").length;
    alert(numOfDivs);
}

function numberOfAdditionalCosts() {
    var additionalCost = document.getElementsByName("additionalCost").length;
    alert(additionalCost);
}

function displayFeedbackSection() {
    var feedbackDiv = document.getElementById("feedbackSection");
    var feedbackSection =
        `<div class="container container-padding">
        <form>
        <div class="form-group">
        <label for="revenue">Email</label>
        <input type="email" class="form-control" id="email" placeholder="Email">
        </div>
        <div class="form-group">
        <label for="operationCost">Comment</label>
        <textarea class="form-control" id="comment" rows="5" cols="80"></textarea>
        </div>
        </form>
        </div>`;
    feedbackDiv.innerHTML = feedbackSection;
}

function clearCommentSection() {
    var feedbackDiv = document.getElementById("feedbackSection");
    feedbackDiv.innerHTML = "";
}