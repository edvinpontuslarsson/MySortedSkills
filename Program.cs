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
                "Integration testing",
                "Scrum",
                "Continuous Integration"
            };

            Array.Sort(skills, (a, b) => String.Compare(a, b));

            string sortedSkills = String.Join(", ", skills);

            Console.WriteLine(sortedSkills);
        }
    }
}
