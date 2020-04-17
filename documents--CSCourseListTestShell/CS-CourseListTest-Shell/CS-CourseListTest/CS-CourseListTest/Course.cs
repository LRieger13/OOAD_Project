class Course
{
    public string CourseID { get; private set; }
    public string CourseTitle { get; }
    public int CreditHours { get; }
    public string Description { get; }
    public string PrerequisiteCourse { get; }

    public Course() {
        this.CourseID = "unknown";
        this.CourseTitle = "unknown";
        this.CreditHours = 0;
        this.Description = "unknown";
        this.PrerequisiteCourse = "unknown";
    }
    public Course(string id, string title, int creditHours, string description, string prerequisiteCourse)
    {
        this.CourseID = id;
        this.CourseTitle = title;
        this.CreditHours = creditHours;
        this.Description = description;
        this.PrerequisiteCourse = prerequisiteCourse;
    }

    public string getCourseID() {
        return this.CourseID;
    }
    public void setCourseID(string id) {
        if (!string.IsNullOrEmpty(id)) {
            this.CourseID = id;
        }
        else {
            this.CourseID = "unknown";
        }
    }
    public string getCourseTitle(string title) {
        return title;
    }
    public int getCreditHours(int creditHours) {
        return creditHours;
    }
    public string getDescription(string description) {
        return description;
    }
    public string getPrerequisiteCourse(string prerequisiteCourse) {
        return prerequisiteCourse;
    }
}
