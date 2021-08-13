using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Student
    {
        private int roll, java, sql, oracle, dotnet, html;
        private string name;
        public int Roll
        {
            get { return roll; }
            set { roll = value; }
        }
        public int Java
        {
            get { return java; }
            set { java = value; }
        }
        public int Sql
        {
            get { return sql; }
            set { sql = value; }
        }
        public int Oracle
        {
            get { return oracle; }
            set { oracle = value; }
        }
        public int Dotnet
        {
            get { return dotnet; }
            set { dotnet = value; }
        }
        public int Html
        {
            get { return html; }
            set { html = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Student(int roll,string name,int java,int sql,int dotnet,int html,int oracle)
        {
            this.roll = roll;
            this.name = name;
            this.java = java;
            this.sql = sql;
            this.dotnet = dotnet;
            this.html = html;
            this.oracle = oracle;
        }
        public Student()
        {
            roll = 10;
            name = "priya";
            java = 78;
            sql = 74;
            dotnet = 98;
            html = 84;
            oracle = 77;
        }
        public int Marks()
        {
            int marks = java + sql + dotnet + html + oracle;
            return marks;
        }
        public double Average()
        {
            int avg = Marks()/ 5;
            return avg;
        }
        public string Grade()
        {
            double avg1 = Average();
            if (avg1 >= 75)
                return "First Class";
            else if (avg1 >= 60)
                return "Second class";
            else if (avg1 >= 40)
                return "Third Class";
            else
                return "fail";

        }
        public string ShowDetails()
        {
            string oline = string.Format($"Roll no {roll} | Name {name} | Marks Java {java} | Marks sql {sql} | Marks html {html} | Marks oracle {oracle} | Total Marks = {Marks()} | Average = {Average()} | Grade = {Grade()} ");
            return oline;
        }
    }
}
