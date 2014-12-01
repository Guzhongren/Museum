$(function () {
    $("#Func1").click(function () {
        $("#Tab1").slideToggle();
        $("#Tab2").css("display", 'none');
        $("#Tab3").css("display", 'none');
    });
    $("#Func2").click(function () {
        $("#Tab2").slideToggle();
        $("#Tab1").css("display", 'none');
        $("#Tab3").css("display", 'none');
    });
    $("#Func3").click(function () {
        $("#Tab3").slideToggle();
        $("#Tab1").css("display", 'none');
        $("#Tab2").css("display", 'none');
    });
});