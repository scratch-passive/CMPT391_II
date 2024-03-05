from faker import Faker  # Fake mfs
import random

fake = Faker()

majors = [
    "Accounting",
    "Anthropology",
    "Architecture",
    "Biochemistry",
    "Biology",
    "Business Administration",
    "Chemical Engineering",
    "Chemistry",
    "Civil Engineering",
    "Computer Science",
    "Economics",
    "Electrical Engineering",
    "English",
    "Environmental Science",
    "Finance",
    "Graphic Design",
    "History",
    "Information Technology",
    "International Relations",
    "Journalism",
    "Marketing",
    "Mathematics",
    "Mechanical Engineering",
    "Medicine",
    "Music",
    "Nursing",
    "Philosophy",
    "Physics",
    "Political Science",
    "Psychology",
    "Public Health",
    "Sociology",
    "Software Engineering",
    "Statistics",
    "Theatre",
    "Veterinary Science",
    "Visual Arts"
]

universities = [
    "University of Alberta", "MacEwan University", "Concordia University of Edmonton",
    "Mount Royal University", "The King's University", "University of Calgary"
]

def generateAge():
    if random.random() < 0.75: # more youngins
        return random.randint(18, 25)
    else: 
        return random.randint(26, 50)

def generateStudents(numStudents):
    students = []
    for i in range(numStudents):
        studentID = f"{i:07}"
        firstName = fake.first_name()
        lastName = fake.last_name()
        major = random.choice(majors)
        age = generateAge()
        gender = random.choice(['Male', 'Female']) # wowwwwww
        university = random.choice(universities)
        students.append((studentID, firstName, lastName, major, age, gender, university))
    return students

def saveToFile(data, filename):
    with open(filename, 'w') as file:
        for entry in data:
            entry = [str(e).replace("'", "''") for e in entry]
            insertStatement = f"INSERT INTO student (studentID, firstName, lastName, major, age, gender, university) VALUES ('{entry[0]}', '{entry[1]}', '{entry[2]}', '{entry[3]}', {entry[4]}, '{entry[5]}', '{entry[6]}');\n"
            file.write(insertStatement)

studentsData = generateStudents(35329)

saveToFile(studentsData, 'students_data.sql')