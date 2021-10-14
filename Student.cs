using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildLab10_14
{
    class Student
    {
        public int StudentNum { get; set; }
        public string Name { get; set; }
        public string HomeTown { get; set; }
        public string FavFood { get; set; }
        public string FavColor { get; set; }

        public Student(int StudentNum, string Name, string HomeTown, string FavFood, string FavColor)
        {
            this.StudentNum = StudentNum;
            this.Name = Name;
            this.HomeTown = HomeTown;
            this.FavFood = FavFood;
            this.FavColor = FavColor;
        }

    }
}
