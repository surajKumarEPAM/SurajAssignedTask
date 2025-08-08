using System;
using Reqnroll;

namespace FremeworkFile
{
    [Binding]
    public class DataTablePractStepDefinitions
    {
        Student student=new Student();
        [Given("We have students info")]
        public void GivenWeHaveStudentsInfo(DataTable dataTable)
        {
            /*
            foreach (var row in dataTable.Rows)
            {
                student.Age = Int32.Parse(row["Age"]);
                student.Name=row["Name"];
                student.RollNo = Int32.Parse(row["RollNo"]);
                Console.WriteLine($"Name: {student.Name} RollNo: {student.RollNo} Age: {student.Age}");
            }
            */

            List<Student> students = dataTable.CreateSet<Student>().ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name} RollNo: {student.RollNo} Age: {student.Age}");
            }

        }

        [Given("we have Employee info")]
        public void GivenWeHaveEmployeeInfo(DataTable dataTable)
        {
            //var dic = dataTable.Rows.ToDictionary(row => row["Name"], row => row["Ankesh"]);
            var dic = dataTable.Rows.ToDictionary(row => row[0], row => row[1]);
            var name=dic["Name"];
            var rollNo = dic["RollNo"];
            //var age = dic[Age];

            Console.WriteLine("Our value is ");
            //foreach (var student in dic)
            //{
            //    Console.WriteLine($"{student.Key} : {student.Value}");
            //}
        }


    }
}
