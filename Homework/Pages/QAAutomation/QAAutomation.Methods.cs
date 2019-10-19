namespace Homework.Pages
{
    
    public partial class QAAutomation
    {
        
        public void Navigate()
        {
            Navigate("https://www.softuni.bg");
            Trainings.Click();
            QAModule.Click();
            QAAutomationCourse.Click();
        }
    }
}
