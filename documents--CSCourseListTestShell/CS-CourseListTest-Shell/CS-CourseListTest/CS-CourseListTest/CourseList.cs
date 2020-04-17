class CourseList
{
    public Course[] CourseArray = 
        { 
        new Course ("CIS 400", "OO Analysis & Design", 4, "Important class", "CIS 110") ,
        new Course ("CIS 150A" , "VB.NET Programming", 4, "Good Introduction to programming", "CIS 100") ,
        new Course ("CIS 150B", "C# Programming with labs", 4, "Follow-up to CIS 100", "CIS 100")
        };

    public Course GetCourseByCourseID(string CourseID)
    {
        // TODO - get course array compare user course id to see 
        // if they match
        Course[] classList = this.CourseArray;
        // loop here over course list looking for the ID that was passed in. 
        // IF the ID is not found look at Course LIst Test to decide what 'error' value to provide. 
        // Otherwise when you find a match with the parameter CourseID you will return the course from the object. 
        foreach (Course course in classList) {
            if (course.getCourseID() == CourseID) {
               return course;
            }        
        }
        return null;
    }
}
