using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ExemploUm
{
    public DateTime ToDateTime(string value)
    {
        var data = value.Split("-");
        return new DateTime(data[0], data[1], data[2]);
    }

    public DateTime ToDateTime(this string value)
    {
        var data = value.Split("-");
        return new DateTime(data[0], data[1], data[2]);
    }

    public void Testes()
    {
        var dataString = "2021-01-01";
        var dataTimeValue = extensions.ToDateTime(dataString);
        var dataTimeValueTwo = dataString.ToDateTime();
    }
}

public class ExemploDois
{
    public class Course
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Url { get; set; }
        public int DurationInMinutes { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; } = DateTime.UtcNow;
        public bool Active { get; set; } = true;
        public bool Free { get; set; } = false;
        public bool Featured { get; set; } = false;
        public Guid AuthorId { get; set; }
        public Guid CategoryId { get; set; }
        public string Tags { get; set; }
    }

    public class CourseCardViewModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public int DurationInMinutes { get; set; }
    }

    public static class CourseExtension
    {
        public static CourseCardViewModel ToCard(this Course course)
        {
            return new CourseCardViewModel(course);
        }
    }

    public void Teste()
    {
        var course = new Course();
        course.ToCard();
    }

}

public class ExemploTres
{
    public static class StringExtension
    {
        public static string ToUrl(this string value) => Regex.Replace(value, @"\s+", "-").ToLower();
    }

    public void Teste(){
        var valor = "curso de fundamentos";
        valor.ToUrl();
    }
}
