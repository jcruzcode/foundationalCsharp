using System;

// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96};
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write Report Header to the console
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if ( currentStudent == "Sophia" )
        studentScores = sophiaScores;

    else if ( currentStudent == "Andrew" )
        studentScores = andrewScores;

    else if ( currentStudent == "Emma") 
        studentScores = emmaScores;

    else if ( currentStudent == "Logan") 
        studentScores = loganScores;

    else if ( currentStudent == "Becky")
        studentScores = beckyScores;

    else if ( currentStudent == "Chris")
        studentScores = chrisScores;
    else if ( currentStudent == "Eric" )
        studentScores = ericScores;
    else if ( currentStudent == "Gregor" )
        studentScores = gregorScores;
    else
        continue;

    // Initialize/reset the sum of the scored assignments, exams, and extra credit
    decimal sumAssignmentScores = 0;
    decimal sumExamScores = 0;
    decimal sumExtraCreditScores = 0;
    decimal extraCreditPoints = 0;

    // Initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;
    decimal currentStudentExamGrade = 0;
    decimal currentStudentExtraCreditGrade = 0;

    // Initialize/reset a counter for the number of assigments
    int gradedAssignments = 0;

     // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        if ( gradedAssignments > examAssignments - 1 )
        {
            // add the extra credit points to the sum
            // bonus points equal 10% of an exam score
            sumAssignmentScores +=  score * 0.1m;
            sumExtraCreditScores += score;
        }
        else
        {
             // add exam score to the sum
            sumAssignmentScores += score;
            sumExamScores += score;
        }
        // increment the assignment counter
        gradedAssignments++;
    }

    currentStudentGrade = sumAssignmentScores / examAssignments;
    currentStudentExamGrade = sumExamScores / examAssignments;
    currentStudentExtraCreditGrade = sumExtraCreditScores / ( studentScores.Length - examAssignments );
    extraCreditPoints = currentStudentGrade - currentStudentExamGrade;
    
    if ( currentStudentGrade >= 97 ) 
        currentStudentLetterGrade = "A+";

    else if ( currentStudentGrade >= 93 )
        currentStudentLetterGrade = "A";
    
    else if ( currentStudentGrade >= 90 )
        currentStudentLetterGrade = "A-";
    
    else if ( currentStudentGrade >= 87 )
        currentStudentLetterGrade = "B+";
    
    else if ( currentStudentGrade >= 83 )
        currentStudentLetterGrade = "B";

    else if ( currentStudentGrade >= 80 )
        currentStudentLetterGrade = "B-";
    
    else if ( currentStudentGrade >= 77 )
        currentStudentLetterGrade = "C+";

    else if ( currentStudentGrade >= 73 )
        currentStudentLetterGrade = "C";

    else if ( currentStudentGrade >= 70 )
        currentStudentLetterGrade = "C-";

    else if ( currentStudentGrade >= 67 )
        currentStudentLetterGrade = "D+";

    else if ( currentStudentGrade >= 63 )
        currentStudentLetterGrade = "D";

    else if ( currentStudentGrade >= 60 )
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamGrade}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditGrade} ({extraCreditPoints} pts)");

}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();