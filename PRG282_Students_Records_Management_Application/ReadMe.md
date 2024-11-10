# Student Records Management System
## PRG 281 Group Project

**Team Members:**
- [Tshepang Kagiso Mashigo] (Models and Data Handlers)
- [Olethabo Hlongwane] (CRUD)
- [Hlamulo Madidibula] (CRUD)
- [Yandile Ngubane] (User Interface)

## Project Overview
The Student Records Management System is a Windows Forms application designed to manage student records at a tertiary institution. 
The system uses file-based storage with JSON serialization to maintain data persistence, 
and provides a secure interface for administrators to perform essential student management tasks.

### Key Components:
1. **Secure Authentication System**
   - Single administrator access point
   - Hardcoded credentials for demonstration
   - Session-based access control

2. **Student Management Interface**
   - Intuitive form design
   - Real-time data validation
   - Immediate feedback system

3. **Data Management**
   - JSON-based file storage
   - In-memory data caching
   - Automated report generation

## User Stories

### 1. Administrator Login
> "As an administrator, I want to securely log into the system so that I can manage student records."

**Flow:**
1. Administrator opens the application
2. Enters credentials (username: "lecturer", password: "bclecturer")
3. System validates credentials
4. Upon success, gains access to main menu
5. If invalid, receives error message

### 2. Adding New Students
> "As an administrator, I want to add new students to the system so that I can maintain up-to-date records."

**Flow:**
1. Clicks "Add Students" from menu
2. Enters student details:
   - Student ID (numeric only)
   - Name (alphabetic characters)
   - Age (16-100 range)
   - Course (predefined format)
3. System validates input
4. Confirms successful addition
5. Data persists to students.txt

### 3. Viewing Student Records
> "As an administrator, I want to view all student records so that I can access student information quickly."

**Flow:**
1. Selects "View Students" option
2. System loads data from students.txt
3. Displays records in DataGridView
4. Can scroll through all entries
5. Real-time data presentation

### 4. Updating Student Information
> "As an administrator, I want to update existing student records so that I can maintain accurate information."

**Flow:**
1. Chooses "Update Students"
2. Enters Student ID to search
3. Views current information
4. Modifies required fields
5. System validates changes
6. Confirms update success

### 5. Deleting Student Records
> "As an administrator, I want to remove student records so that I can maintain current enrollment status."

**Flow:**
1. Selects "Delete Students"
2. Views student list
3. Selects student to delete
4. Confirms deletion intent
5. System removes record
6. Updates display and file

### 6. Generating Reports
> "As an administrator, I want to generate summary reports so that I can analyze student statistics."

**Flow:**
1. Clicks "Generate Report"
2. System calculates:
   - Total student count
   - Average student age
3. Displays results
4. Saves to summary.txt

## Security Implementation Details

### 1. Input Sanitization
**Purpose**: Prevents malicious data entry and ensures data integrity

**Implementation**:
```
// Examples of implemented sanitization
- Student ID: Only accepts numeric values
- Name: Filters out special characters
- Age: Validates for realistic age ranges (e.g., 16-100)
- Course: Validates against predefined course formats
```

**Methods Used**:
- Input methods
- Data handler and model methods
- CRUD operations methods

### 2. Access Control Validation
**Purpose**: Ensures only authorized users can access specific system features

**Current Implementation**:
- Administrator credentials:
  - Username: "lecturer"
  - Password: "bclecturer"

### 3. Data Integrity Checks
**Purpose**: Ensures data remains accurate and consistent throughout operations

**Validation Points**:
1. **Pre-Save Checks**:
   - Required field validation
   - Data format verification
   - Duplicate ID prevention
   - Logical validation (e.g., age range)

2. **Post-Save Verification**:
   - File write confirmation
   - Data consistency checks
   - Checksum verification
   - Update confirmation

### 4. Protected File Operations
**Purpose**: Ensures secure and atomic file operations for data persistence

**Implementation Details**:
1. **File Access Protection**:
   ```
   - students.txt: Contains encrypted student records
   - summary.txt: Contains statistical data
   ```

2. **Operation Safety**:
   - File locking during writes
   - Backup creation before updates
   - Transaction-like updates
   - Error recovery mechanisms

3. **Data Encryption**:
   - JSON serialization with formatting
   - Basic data protection
   - Secure file handling

## Technical Implementation Notes

### Data Flow:
1. **User Input → Validation → Processing → Storage**
   - Input sanitization at form level
   - Business logic in model classes
   - Persistence through data handlers

2. **File Operations**
   - Read operations on startup
   - Write operations on changes
   - JSON formatting for readability

3. **Error Management**
   - Try-catch blocks for operations
   - User feedback mechanisms
   - Data recovery options

---
**Note**: This project in PRG 281.

**Version**: 1.0.0  
**Last Updated**: November 10, 2024

---
