using System;
namespace ADT_HW
{
    public class School
    {
        private string serialNumber; // School's serial number
        private string name; // School's name
        private string address; // School's address
        private int numOfTeachers; // Total number of teachers
        private Teacher[] teachers; // Array of the teachers


        public School(string serialNumber, string name, string address, int numOfTeachers, Teacher[] teachers)
        {
            this.serialNumber = serialNumber;
            this.name = name;
            this.address = address;
            this.numOfTeachers = numOfTeachers;
            this.teachers = teachers;
        }

        public int teachersBeforeYear(int year)
        {
            int counter = 0;

            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i].getBirthYear() < year)
                {
                    counter++;
                }
            }
            return counter;
        }

        public void addTeacher(Teacher newTeacher)
        {
            teachers[numOfTeachers - 1] = newTeacher;
            numOfTeachers++;
        }

        public void morePermanentOrTemp(string employer)
        {
            int countPermanent = 0;
            int countTemp = 0;

            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i].employerName() == employer)
                {
                    if (teachers[i].isPermanent())
                    {
                        countPermanent++;
                    }
                    else
                    {
                        countTemp++;
                    }
                }
            }

            if (countTemp < countPermanent)
            {
                Console.WriteLine("More permanent teachers for {0}", employer);
            }
            else
            {
                Console.WriteLine("More temporary teachers for {0}", employer);
            }
        }
    }
}
