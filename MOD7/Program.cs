using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MOD7
{
    class Course
    {
        public String kode { get; set; }
        public String nama { get; set; }
    }

    internal class KuliahMahasiswa1302223012
    {
        class CourseData
        {
            public List<Course> courses { get; set; }
        }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\SEMESTER 4\\PRAK KPL\\tp7_1_1302223012.json");
            CourseData dataJson = JsonSerializer.Deserialize<CourseData>(jsonString);

            int i = 1;
            foreach (var course in dataJson.courses)
            {
                Console.WriteLine($"MK {i} {course.kode} - {course.nama}");
                i++;
            }
        }
    }

}