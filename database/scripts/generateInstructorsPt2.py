from faker import Faker
import random

fake = Faker()

# Assuming departments list is available as 'departments'
departments = [
    "Department of Accounting",
    "Department of Anthropology",
    "Department of Architecture",
    "Department of Biochemistry",
    "Department of Biology",
    "Department of Business Administration",
    "Department of Chemical Engineering",
    "Department of Chemistry",
    "Department of Civil Engineering",
    "Department of Computer Science",
    "Department of Economics",
    "Department of Electrical Engineering",
    "Department of English",
    "Department of Environmental Science",
    "Department of Finance",
    "Department of Graphic Design",
    "Department of History",
    "Department of Information Technology",
    "Department of International Relations",
    "Department of Journalism",
    "Department of Marketing",
    "Department of Mathematics",
    "Department of Mechanical Engineering",
    "Department of Medicine",
    "Department of Music",
    "Department of Nursing",
    "Department of Philosophy",
    "Department of Physics",
    "Department of Political Science",
    "Department of Psychology",
    "Department of Public Health",
    "Department of Sociology",
    "Department of Software Engineering",
    "Department of Statistics",
    "Department of Theatre",
    "Department of Veterinary Science",
    "Department of Visual Arts"
]

ranks = ["Assistant Professor", "Associate Professor", "Professor"]

universities = [
    "University of Alberta", "Concordia University of Edmonton",
    "Mount Royal University", "The King's University", "University of Calgary"
]

# Mapping from department to faculty
departmentFacultyMapping = {
    "Department of Accounting and Finance": "Faculty of Business",
    "Department of Allied Health and Human Performance": "Faculty of Health Sciences",
    "Department of Anthropology, Economics and Political Science": "Faculty of Arts and Social Sciences",
    "Department of Arts and Cultural Management": "Faculty of Arts",
    "Department of Studio Arts": "Faculty of Arts",
    "Department of Physical Sciences": "Faculty of Science",
    "Department of Communication": "Faculty of Communication",
    "Department of Biological Sciences": "Faculty of Science",
    "Department of Botany": "Faculty of Science",
    "Department of Business": "Faculty of Business",
    "Department of Chemistry": "Faculty of Science",
    "Department of Chinese": "Faculty of Humanities",
    "Department of Chemical Engineering": "Faculty of Engineering",
    "Department of Classics": "Faculty of Humanities",
    "Department of Computing": "Faculty of Computing",
    "Department of Communication Skills": "Faculty of Communication",
    "Department of Comparative Literature": "Faculty of Humanities",
    "Department of Cooperative Education": "Faculty of Health Sciences",
    "Department of Corrections": "Faculty of Social Sciences",
    "Department of Counseling": "Faculty of Education",
    "Department of Creative Writing": "Faculty of Arts",
    "Department of Child and Youth Care": "Faculty of Health Sciences",
    "Department of Design": "Faculty of Arts",
    "Department of Disability Management and Work Performance": "Faculty of Health Sciences",
    "Department of Disability Studies": "Faculty of Health Sciences",
    "Department of Earth and Atmospheric Sciences": "Faculty of Science",
    "Department of Early Childhood Care and Support": "Faculty of Education",
    "Department of Early Childhood Development": "Faculty of Education",
    "Department of Emergency Crisis Response": "Faculty of Social Sciences",
    "Department of Engineering, Computer": "Faculty of Engineering",
    "Department of Engineering": "Faculty of Engineering",
    "Department of English": "Faculty of Arts",
    "Department of English for Academic Purposes": "Faculty of Arts",
    "Department of Environmental Studies": "Faculty of Environmental Studies",
    "Department of Environmental Occupational Physiology and Therapy": "Faculty of Health Sciences",
    "Department of Earth and Resource Development Work": "Faculty of Environmental Studies",
    "Department of Exploration Studies": "Faculty of Science",
    "Department of Finance": "Faculty of Business",
    "Department of Foundations": "Faculty of Education",
    "Department of French": "Faculty of Humanities",
    "Department of Gender Studies": "Faculty of Social Sciences",
    "Department of German": "Faculty of Humanities",
    "Department of Greek": "Faculty of Humanities",
    "Department of Health and Physical Readiness": "Faculty of Health Sciences",
    "Department of Health Education": "Faculty of Health Sciences",
    "Department of History": "Faculty of Humanities",
    "Department of Health Sciences": "Faculty of Health Sciences",
    "Department of Health Studies": "Faculty of Health Sciences",
    "Department of Human Resource Management": "Faculty of Business",
    "Department of Health Systems Administration": "Faculty of Health Sciences",
    "Department of Humanities": "Faculty of Humanities",
    "Department of Indigenous Studies": "Faculty of Humanities",
    "Department of Information Management": "Faculty of Information Technology",
    "Department of Insect Studies": "Faculty of Science",
    "Department of Insurance": "Faculty of Business",
    "Department of Interdisciplinary Studies": "Faculty of Arts",
    "Department of International Business": "Faculty of Business",
    "Department of Interior Design": "Faculty of Arts",
    "Department of Japanese": "Faculty of Humanities",
    "Department of Latin": "Faculty of Humanities",
    "Department of Legal Studies": "Faculty of Law",
    "Department of Linguistics": "Faculty of Humanities",
    "Department of Marketing": "Faculty of Business",
    "Department of Mathematics": "Faculty of Science",
    "Department of Management": "Faculty of Business",
    "Department of Management Systems": "Faculty of Business",
    "Department of Music Therapy Studies": "Faculty of Arts",
    "Department of Music": "Faculty of Arts",
    "Department of Nursing": "Faculty of Health Sciences",
    "Department of Office Assistant Studies": "Faculty of Business",
    "Department of Office Administration": "Faculty of Business",
    "Department of Office Administration and Legal Studies": "Faculty of Business",
    "Department of Office Administration and Medical Studies": "Faculty of Business",
    "Department of Occupational Health": "Faculty of Health Sciences",
    "Department of Out-of-School Care": "Faculty of Education",
    "Department of Organizational Behavior": "Faculty of Business",
    "Department of Public Administration and Business": "Faculty of Business",
    "Department of Physical Activity": "Faculty of Health Sciences",
    "Department of Psychiatric Nursing": "Faculty of Nursing",
    "Department of Physical Education": "Faculty of Education",
    "Department of Philosophy": "Faculty of Humanities",
    "Department of Physical Sciences": "Faculty of Science",
    "Department of Physical Education and Sport Development": "Faculty of Education",
    "Department of Physics": "Faculty of Science",
    "Department of Property Management": "Faculty of Business",
    "Department of Political Science": "Faculty of Social Sciences",
    "Department of Public Relations": "Faculty of Communication",
    "Department of Professional Writing": "Faculty of Arts",
    "Department of Police and Security": "Faculty of Social Sciences",
    "Department of Psychology": "Faculty of Social Sciences",
    "Department of Science": "Faculty of Science",
    "Department of Supply Chain Management": "Faculty of Business",
    "Department of Sociology": "Faculty of Social Sciences",
    "Department of Social Studies": "Faculty of Social Sciences",
    "Department of Social Work": "Faculty of Social Sciences",
    "Department of Spanish": "Faculty of Humanities",
    "Department of Statistics": "Faculty of Science",
    "Department of Sustainability": "Faculty of Environmental Studies",
    "Department of Special Needs Educational Assistant": "Faculty of Education",
    "Department of Theatre": "Faculty of Arts",
    "Department of Therapist Assistant": "Faculty of Health Sciences",
    "Department of Theatre Production": "Faculty of Arts",
    "Department of Travel and Tourism": "Faculty of Business",
    "Department of Urban Wellness": "Faculty of Health Sciences",
    "Department of Work Integrated Learning": "Faculty of Business",
    "Department of Writing": "Faculty of Humanities",
    "Department of Zoology": "Faculty of Science",
    "Department of Economics": "Faculty of Arts and Social Sciences",
    "Department of Education": "Faculty of Education", 
    "Department of Genetics": "Faculty of Science", 
    "Department of Music Systems": "Faculty of Arts", 
    "Department of Physical Education, Recreation, and Leisure Studies": "Faculty of Health Sciences", 
    "Department of Physical Education and Sport Studies": "Faculty of Health Sciences",
}

def generateInstructors(departmentFacultyMapping, universities):
    instructors = []
    for university in universities:
        for department, faculty in departmentFacultyMapping.items():
            # Ensure one chair per department
            chairAssigned = False
            for i in range(random.randint(15, 30)):
                instructorId = f"{i:05}"
                firstName = fake.first_name()
                lastName = fake.last_name()
                age = random.randint(25, 70)
                gender = random.choice(['Male', 'Female'])
                rank = "Chair" if not chairAssigned else random.choice(ranks) # One chair per dept
                chairAssigned = True if rank == "Chair" else chairAssigned
                instructors.append((instructorId, firstName, lastName, rank, age, gender, faculty, university))
    return instructors

def saveToFile(data, filename):
    with open(filename, 'w') as file:
        for entry in data:
            entry = [str(e).replace("'", "''") for e in entry]
            insertStatement = f"INSERT INTO instructor (instructorID, firstName, lastName, rank, age, gender, faculty, university) VALUES ('{entry[0]}', '{entry[1]}', '{entry[2]}', '{entry[3]}', {entry[4]}, '{entry[5]}', '{entry[6]}', '{entry[7]}');\n"
            file.write(insertStatement)

# Generate and save instructors data
instructorsData = generateInstructors(departmentFacultyMapping, universities)
saveToFile(instructorsData, 'instructors_data.sql')
