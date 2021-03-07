using System;
namespace Application
{
    public class StudentSleep
    {
        private int hours; // כמות שעות השינה
        private int grade; // שכבה
        private int num; // מספר מקבילה

        public StudentSleep(int hours, int grade, int num)
        {
            this.hours = hours;
            this.grade = grade;
            this.num = num;
        }

        public int GetHours() { return hours; }
        public int GetGrade() { return grade; }
        public int GetNum() { return num; }

        public bool IsGoodSleep()
        {
            return (8 <= hours) && (hours <= 10);
        }
    }
}
