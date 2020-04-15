class CourseListTest
{
    public static void Main(string[] args)
    {
        GetCourseByCourseIDTestWhenCourseExists();
        GetCourseByCourseIDTestWhenCourseDoesNotExist();
    }


    public static void GetCourseByCourseIDTestWhenCourseExists()
    {

        CourseList myCourseList = new CourseList();
        Course myCourse = myCourseList.GetCourseByCourseID("CIS 400");
        if (myCourse.CourseID != "CIS 400")
            System.Console.WriteLine("ERROR - GetCourseByCourseIDTestWhenCourseExists(): Returned CourseID Not equal (CIS 400)");
    }

    public static void GetCourseByCourseIDTestWhenCourseDoesNotExist()
    {

        CourseList myCourseList = new CourseList();
        Course myCourse = myCourseList.GetCourseByCourseID("CIS 101");
        if (myCourse != null)
            System.Console.WriteLine("ERROR - GetCourseByCourseIDTestWhenCourseDoesNotExist(): should have returned null");
    }
}


