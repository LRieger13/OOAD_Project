class Course
{
    public Course(string id, string title, int creditHours, string description, string prerequisiteCourse)
    {
        this.CourseID = id;
        this.CourseTitle = title;
        this.CreditHours = creditHours;
        this.Description = description;
        this.PrerequisiteCourse = prerequisiteCourse;
    }


    public string CourseID;
    public string CourseTitle;
    public int CreditHours;
    public string Description;
    public string PrerequisiteCourse;
}
