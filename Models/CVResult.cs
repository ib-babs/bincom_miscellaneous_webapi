namespace MiscellaneousApi.Models
{
    public class CVResult
    {
        public static CVItem GetCVItem()
        {
            CVItem MyCV = new()
            {
                Name = "Ibrahim Babatunde",
                Contacts = new() { { "Address", "Isale Gbari Afon" }, {"Email", "babatundeibrahim436@gmail.com"},
            {"Twitter", "https://x.com/BKhalilullahi"}, {"Portfolio", "https://ibrahim-portfolio-i8d3.onrender.com/"}, {"Github", "https://github.com/ib-babs"}, {"Phone", "+234 815 183 4708"} },
                Summary = "Dedicated and adaptable Software Engineer with 3+ years of experience with a robust background in fullstack development building scalable solutions and API with latest technologies in Python, JavaScript, SQL, and Web frameworks such as Flask and Django. Also a teacher who has successfully impacted substantial knowledge in over 300 pupils in primary level, junior Secondary level, as well as Senior Secondary level. Assisted 3 Software Engineering students from Nigeria and Ghana in their projects and assignments given to them in school, by simplifying the projects or the assignments and guide them throughout the proccess, of which expanded their knowledge and got them good grades.",
                Education = [
                     new(){
            {"School", "ALX Africa"}, {"Location", "Virtual"}, {"CertificateObtained", "Certificate in Software Engineering(Backend Specialist)"}, {"From - To", "JULY 2023 - JULY 2024"}
        },
                new(){
            {"School", "Lifegate College of Education"}, {"Location", "Afon"}, {"CertificateObtained", "Nigerian Certificate in Education"}, {"From - To", "DECEMBER 2018 - JANUARY 2021"}
        },
                new(){
            {"School", "Government Secondary School"}, {"Location", "Afon"}, {"CertificateObtained", "SSCE Certificates"}, {"From - To", "MAY 2012 - JULY 2017"}
        }
             ],
                Experience = [
                     new(){
            {"Title", "IT Seminar Talk Lead"},
            {"Seminar Location", "Davies Computer, Ilorin"},
            {"Location", "Lifegate College of Education"},
            {"Date", "December 2020"},
        },
                new(){
            {"Title", "Full-Stack Developer - Talk-IT"},
            {"Location", "ALX Foundation Project"},
            {"Date", "March 2024"},
        },
                new(){
            {"Title", "Lead Developer - Reetlearn API & Web App"},
            {"Location", "ALX Specialization Project"},
            {"Date", "July 2024"},
        },
                new(){
            {"Title", "Elementary Class Teacher"},
            {"Location", "NYSC Nursery, Primary and Secondary School, Afon"},
            {"Date", "April 2023 - Till Date"},
        }
             ],
                ExperienceRole = [
                 new(){
            {"IT Seminar Talk Lead", ["Led a student delegation of 30 college students during an IT seminar, representing peers and answering technical questions posed by the manager of Davies Computer",
            "Demonstrated strong communication skills and in-depth understanding of IT concepts, which resulted in each student score increased by 20% in the course."
            ]}
        },
        new(){
            {"Full-Stack Developer - Talk-IT", ["Designed and developed a social networking web application named Talk-IT, aimed at tech enthusiasts and programmers.",
            "Utilized Python (Flask) for backend development which cut down 30% of time needed for development with other frameworks.",
            "Ensured the application was responsive and user-friendly, while also focusing on performance optimization and security.",
            "Tested by 25+ users to share information."
            ]}
        },
        new(){
            {"Lead Developer - Reetlearn API & Web App", ["Developed Reetlearn, an online learning platform offering free programming courses, from backend API to frontend implementation which will cut down 99% amount of money require to learn programming",
            "Engineered the core API that powers the platform, handling user authentication, course management, and content delivery.",
            "Reviewed by ALX Software Engineering Technical staff and scored 194% out of 200%"
            ]}
        },
        new(){
            {"Elementary Class Teacher", ["Taught 35 JSS3 students for 3 months to their Mock exam.",
            "Created a timetable that considers individual differences among the puils in primary level of the school and thus make learning becoming easier and pleasure to the pupils",
            "Improvising the unavailable instructional materials to make learning attractive and attention catching in the eyes of the beholder (pupils) which expanding the knowlegde of the pupils beyond all-theortical teachings.",
            "Created a friendly class to accomodate all individual differences."
            ]}
        },
        ],
                Projects = new(){ {"Talk-IT Web Application", "Developed a social networking platform named Talk-IT, designed for tech enthusiasts and programmers to post, share, comment, like, and engage in discussions. Utilized Python (Flask) for backend development and JavaScript for dynamic front-end features, ensuring a smooth user experience."}, {"Reetlearn API & Web Application", "Created Reetlearn, an online learning platform offering free programming courses, including a comprehensive API and a fully functional web application. Engineered the Reetlearn API to handle core functionalities like user authentication, course management, and content delivery, ensuring a scalable and robust backend."}, {"Linux Simple Shell", "Collaborated with Musakalamz Ogunsola to co-develop a simple command-line interpreter (shell) in a Linux environment as part of the ALX Software Engineering Foundation program. Focused on core functionalities, including command execution, argument handling, and process management, using C. Gained hands-on experience with system-level programming and process control, further solidifying my skills in Linux and C."},
        {"AirBNB Clone v1 - v4", "As the name implies, AirBNB Clone is a project written to emulate original AirBNB features. It has 4 versions where each version is built on top of another until the fourth version.  AirBNB is an online Booking platform for the tourists and travellers for booking different apartments in various countries, having amenities that will make your staying a fun and fair one."}, {"Printf", "Printf project was written in C. Its sole purpose was to create from scratch, an exact C built-in printf function, that write to the standard output without using any built-in libraries except for small numbers of functions from stdlib, stdio, and stdargs. This function handles almost all built-in printf features including modifier, width, and format."}, {"Monty", "A mini interpreter written in C. It was intended to understand and interpret (two words in a line) customized objective-c code."}},
                Skills = ["HTML, CSS", "JavaScript", "JQuery", "Express.js", "Python", "Flask", "Django", "API Development and Integration", "MySQL", "Database Management", "Teamwork", "Communication"],
                Languages = ["English", "Yoruba"]
            };
            return MyCV;
        }
    }

}
