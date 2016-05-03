$(document).ready(function () {
    $('#addCountLink').click(function () {
        var count = $("#count");
        if (count.text() == "10")
        {
            alert("10 is the maximum count!");
            return;
        }

        $.ajax({
            url: "Home/AddCount",
            type: "POST",
            dataType: "json",
            success: function (data) {
                count.text(data);
            },
            error: function (request, error) {
                var a = error;
            }
        });
    });
})