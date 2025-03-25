using AIMSRCollegeWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace AIMSRCollegeWebsite.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Details(string courseCode)
        {
            try
            {
                var courseDetails = GetCourseDetails(courseCode);
                return View(courseDetails);
            }
            catch (ArgumentException)
            {
                return NotFound(); // Returns a 404 page if course code is invalid
            }
        }

        private CourseDetailsViewModel GetCourseDetails(string courseCode)
        {
            return courseCode.ToUpper() switch
            {
                "BBA" => new CourseDetailsViewModel
                {
                    CourseCode = "BBA",
                    CourseName = "Bachelor of Business Administration",
                    CourseDescription = "A comprehensive program designed to develop future business leaders and entrepreneurs.",

                    OverviewTitle = "Why Choose BBA?",
                    OverviewDetailedDescription = "Our Bachelor of Business Administration program is designed to provide students with a comprehensive understanding of business principles, management strategies, and entrepreneurial skills.",
                    OverviewPoints = new List<string>
                {
                    "Comprehensive curriculum covering all key business domains",
                    "Practical learning through case studies and industry projects",
                    "Internship opportunities with leading corporations",
                    "Develop critical thinking and leadership skills"
                },

                    CourseDuration = "3 Years",
                    TotalFees = 90000,
                    DegreeType = "Bachelor's Degree",
                    CourseImage = "/images/bba.webp",
                    Curriculum = new List<SemesterCurriculum>
                {
                    new SemesterCurriculum
                    {
                        SemesterNumber = 1,
                        Subjects = new List<string>
                        {
                            "Principles of Management",
                            "Business Economics",
                            "Business Communication",
                            "Financial Accounting",
                            "Marketing Fundamentals"
                        }
                    }
                },
                    CareerProspects = new List<string>
                {
                    "Marketing Manager",
                    "Business Consultant",
                    "Sales Executive",
                    "Entrepreneur",
                    "Corporate Strategist"
                }
                },

                "BCA" => new CourseDetailsViewModel
                {
                    CourseCode = "BCA",
                    CourseName = "Bachelor of Computer Applications",
                    CourseDescription = "A dynamic program focusing on computer applications and software development.",

                    OverviewTitle = "Why Choose BCA?",
                    OverviewDetailedDescription = "Our Bachelor of Computer Applications program equips students with cutting-edge technological skills and comprehensive understanding of computer systems and software development.",
                    OverviewPoints = new List<string>
                {
                    "Comprehensive programming language training",
                    "Hands-on project development experience",
                    "Industry-relevant curriculum",
                    "Exposure to latest technologies and frameworks"
                },

                    CourseDuration = "3 Years",
                    TotalFees = 95000,
                    DegreeType = "Bachelor's Degree",
                    CourseImage = "/images/bca.webp",
                    Curriculum = new List<SemesterCurriculum>
                {
                    new SemesterCurriculum
                    {
                        SemesterNumber = 1,
                        Subjects = new List<string>
                        {
                            "Programming in C",
                            "Computer Fundamentals",
                            "Mathematics",
                            "Data Structures",
                            "Web Technologies"
                        }
                    }
                },
                    CareerProspects = new List<string>
                {
                    "Software Developer",
                    "Web Designer",
                    "System Analyst",
                    "IT Consultant",
                    "Database Administrator"
                }
                },

                "BSCIT" => new CourseDetailsViewModel
                {
                    CourseCode = "BSCIT",
                    CourseName = "Bachelor of Science in Information Technology",
                    CourseDescription = "A comprehensive program covering various aspects of information technology and computer science.",

                    OverviewTitle = "Why Choose B.Sc IT?",
                    OverviewDetailedDescription = "Our Bachelor of Science in Information Technology program provides a strong foundation in computer science, networking, and emerging technologies.",
                    OverviewPoints = new List<string>
                {
                    "Comprehensive IT and computer science curriculum",
                    "Practical lab sessions and project work",
                    "Industry-oriented training",
                    "Focus on emerging technologies"
                },

                    CourseDuration = "3 Years",
                    TotalFees = 85000,
                    DegreeType = "Bachelor's Degree",
                    CourseImage = "/images/bscit-course.jpg",
                    Curriculum = new List<SemesterCurriculum>
                {
                    new SemesterCurriculum
                    {
                        SemesterNumber = 1,
                        Subjects = new List<string>
                        {
                            "Computer Fundamentals",
                            "Programming in C++",
                            "Mathematics",
                            "Database Management Systems",
                            "Computer Networks"
                        }
                    }
                },
                    CareerProspects = new List<string>
                {
                    "Network Administrator",
                    "IT Support Specialist",
                    "System Engineer",
                    "Technical Consultant",
                    "Cloud Computing Specialist"
                }
                },

                "MBA" => new CourseDetailsViewModel
                {
                    CourseCode = "MBA",
                    CourseName = "Master of Business Administration",
                    CourseDescription = "An advanced program designed to develop strategic business leaders and managers.",

                    OverviewTitle = "Why Choose MBA?",
                    OverviewDetailedDescription = "Our Master of Business Administration program offers comprehensive management education with a focus on strategic thinking, leadership, and global business perspectives.",
                    OverviewPoints = new List<string>
                {
                    "Comprehensive management curriculum",
                    "Industry interaction and guest lectures",
                    "Live project opportunities",
                    "International business perspective"
                },

                    CourseDuration = "2 Years",
                    TotalFees = 150000,
                    DegreeType = "Master's Degree",
                    CourseImage = "/images/mba-course.jpg",
                    Curriculum = new List<SemesterCurriculum>
                {
                    new SemesterCurriculum
                    {
                        SemesterNumber = 1,
                        Subjects = new List<string>
                        {
                            "Organizational Behavior",
                            "Managerial Economics",
                            "Financial Management",
                            "Marketing Management",
                            "Business Strategy"
                        }
                    }
                },
                    CareerProspects = new List<string>
                {
                    "Business Manager",
                    "Project Manager",
                    "Marketing Director",
                    "Strategy Consultant",
                    "Entrepreneurial Leader"
                }
                },

                "MCA" => new CourseDetailsViewModel
                {
                    CourseCode = "MCA",
                    CourseName = "Master of Computer Applications",
                    CourseDescription = "An advanced program focusing on advanced computing and software development techniques.",

                    OverviewTitle = "Why Choose MCA?",
                    OverviewDetailedDescription = "Our Master of Computer Applications program provides in-depth knowledge of advanced computing technologies, software engineering, and innovative problem-solving approaches.",
                    OverviewPoints = new List<string>
                {
                    "Advanced programming techniques",
                    "Software development methodologies",
                    "Research and innovation focus",
                    "Industry-relevant skill development"
                },

                    CourseDuration = "2 Years",
                    TotalFees = 145000,
                    DegreeType = "Master's Degree",
                    CourseImage = "/images/mca-course.jpg",
                    Curriculum = new List<SemesterCurriculum>
                {
                    new SemesterCurriculum
                    {
                        SemesterNumber = 1,
                        Subjects = new List<string>
                        {
                            "Advanced Programming Concepts",
                            "Software Engineering",
                            "Computer Networks",
                            "Database Management Systems",
                            "Web Technologies"
                        }
                    }
                },
                    CareerProspects = new List<string>
                {
                    "Software Architect",
                    "Senior Software Developer",
                    "IT Project Manager",
                    "Systems Analyst",
                    "Technology Consultant"
                }
                },

                "MSCDS" => new CourseDetailsViewModel
                {
                    CourseCode = "MSCDS",
                    CourseName = "Master of Science in Data Science",
                    CourseDescription = "A cutting-edge program designed to create data science and analytics professionals.",

                    OverviewTitle = "Why Choose M.Sc Data Science?",
                    OverviewDetailedDescription = "Our Master of Science in Data Science program equips students with advanced analytical skills, machine learning techniques, and data-driven decision-making capabilities.",
                    OverviewPoints = new List<string>
                {
                    "Advanced statistical analysis",
                    "Machine learning and AI techniques",
                    "Big data technologies",
                    "Real-world data science projects"
                },

                    CourseDuration = "2 Years",
                    TotalFees = 155000,
                    DegreeType = "Master's Degree",
                    CourseImage = "/images/mscds-course.jpg",
                    Curriculum = new List<SemesterCurriculum>
                {
                    new SemesterCurriculum
                    {
                        SemesterNumber = 1,
                        Subjects = new List<string>
                        {
                            "Statistical Methods",
                            "Machine Learning Algorithms",
                            "Data Visualization",
                            "Python Programming for Data Science",
                            "Big Data Technologies"
                        }
                    }
                },
                    CareerProspects = new List<string>
                {
                    "Data Scientist",
                    "Machine Learning Engineer",
                    "Business Intelligence Analyst",
                    "Data Analytics Consultant",
                    "AI Research Specialist"
                }
                },

                _ => throw new ArgumentException("Invalid course code")
            };
        }
    }
}
