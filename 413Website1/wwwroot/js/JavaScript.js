$("#btnSend").click(function () {
    let grade = (($("#assignment").val() * .50) + ($("#pg").val() * .10) + ($("#quiz").val() * .10) + ($("#midterm").val() * .10) + ($("#final").val() * .10) + ($("#intex").val() * .10));

    //Initialize grade code
    var letter = "A";
    if (grade >= 94) {
        letter = "A";
    } else if (grade >= 90) {
        letter = "A-";
    } else if (grade >= 87) {
        letter = "B+";
    } else if (grade >= 84) {
        letter = "B";
    } else if (grade >= 80) {
        letter = "B-";
    } else if (grade >= 77) {
        letter = "C+";
    } else if (grade >= 74) {
        letter = "C";
    } else if (grade >= 70) {
        letter = "C-";
    } else if (grade >= 67) {
        letter = "D+";
    } else if (grade >= 64) {
        letter = "D";
    } else if (grade >= 60) {
        letter = "D-";
    } else if (grade) {
        letter = "E";
    } else {
        alert("I'm not happy Bob")
    }

    //Display grade code and percentage
    $('#finalGrade').html("Grade: " + letter + " " + grade + "%");

});














