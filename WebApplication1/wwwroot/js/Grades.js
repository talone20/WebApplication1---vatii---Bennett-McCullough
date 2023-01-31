

$("#btnSend").click(function () {
    /*This calculates the final grade based on given weights*/
    finalGrade = ($("#Assignments").val() * .5) + ($("#Group").val() * .1) + ($("#Quizzes").val() * .1) + ($("#Midterm").val() * .1) + ($("#Final").val() * .1) + ($("#Intex").val() * .1);

    /*A letter grade is then determined based on the final grade*/
    letterGrade = "";
    if (finalGrade >= 90) {
        letterGrade = "A";
    }
    else if (finalGrade >= 80 ){
        letterGrade = "B";
    }
    else if (finalGrade >= 70) {
        letterGrade = "C";
    }
    else  {
        letterGrade = "F";
    }
    /*document.getElementById("letterGrade").innerText = letterGrade;*/

    /*Here I output the Calculated values into the bottom of the submitted form*/
    $("#letterGrade").text(letterGrade);
    $("#numberGrade").text(finalGrade);

    /*Finally, I fade out my photo for cool effect*/
    $("#saber").fadeOut("slow");
})