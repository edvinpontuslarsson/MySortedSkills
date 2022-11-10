using System;

namespace MySkills
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] skills = {
                "Postman",
                "Jest",
                "JUnit",
                "Git",
                "Docker",
                "MongoDB",
                "SQL",
                ".NET",
                "Node.js",
                "React",
                "CSS",
                "HTML",
                "YAML",
                "Linux",
                "REST",
                "Test-driven development",
                "Integrationstestning",
                "Scrum",
                "Continuous Integration"
            };

            Array.Sort(skills, (a, b) => String.Compare(a, b));

            Console.WriteLine(String.Join(", ", skills));
        }
    }
}
