using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiasScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewsScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmasScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] logansScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] marksScores = new int[] { 0, 50, 35, 17, 60 };
int[] beckysScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericsScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorsScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Mark", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];
string currentStudentLetterGrade;

// Header for the application
Console.WriteLine("Student\t\tGrade\n");

foreach (string student in studentNames)
{
    string currentStudent = student;

    if (student == "Sophia")
        studentScores = sophiasScores;

    else if (student == "Andrew")
        studentScores = andrewsScores;

    else if (student == "Emma")
        studentScores = emmasScores;

    else if (student == "Logan")
        studentScores = logansScores;

    else if (student == "Mark")
        studentScores = marksScores;

    else if (student == "Becky")
        studentScores = beckysScores;

    else if (student == "Chris")
        studentScores = chrisScores;

    else if (student == "Eric")
        studentScores = ericsScores;

    else if (student == "Gregor")
        studentScores = gregorsScores;

    else continue;

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments++;
        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else
        {
            sumAssignmentScores += score / 10;
        }

    }

    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

