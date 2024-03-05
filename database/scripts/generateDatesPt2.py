def generateDates(startYear, endYear):
    semesters = ["Fall", "Winter", "Spring"]
    dateList = []

    for year in range(startYear, endYear + 1):
        for semester in semesters:
            dateId = f"{semester[:2].upper()}{year}"
            dateList.append((dateId, semester, year))

    return dateList

def saveToFile(dateList, filename):
    with open(filename, 'w') as file:
        for dateEntry in dateList:
            insertStatement = f"INSERT INTO date (dateID, semester, year) VALUES ('{dateEntry[0]}', '{dateEntry[1]}', '{dateEntry[2]}');\n"
            file.write(insertStatement)

dateData = generateDates(2015, 2024)
saveToFile(dateData, 'dates_data.sql')
