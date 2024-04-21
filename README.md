# Technical Report: Implementation of a Hotel Reservation System in C#/.NET

## 1. Introduction:
The purpose of this technical report is to outline the development process of a Hotel Reservation System implemented in C# using the .NET framework. The system is designed to facilitate hotel bookings by managing guest information, suite details, and reservations.

## 2. System Components:

### 2.1. Person Class (Person.cs):
The Person class represents a guest staying at the hotel. It contains properties for the guest's name and age. This class is essential for capturing guest information during the reservation process.

### 2.2. Suite Class (Suite.cs):
The Suite class represents a hotel suite available for booking. It contains properties for the suite number and daily rate. This class allows the system to manage and display available suites to the guests.

### 2.3. Reservation Class (Reservation.cs):
The Reservation class facilitates the booking process by associating a guest with a suite for a specific duration. It contains properties for the guest, suite, start date, and end date of the reservation. Additionally, it provides methods to calculate the number of days of the reservation and the total price, applying a 10% discount for reservations longer than 10 days.

## 3. Implementation:
The implementation follows object-oriented principles, with each class encapsulating its data and providing methods for manipulation. The system logic is divided into separate classes to ensure modularity and maintainability.

## 4. Testing:
A simple console application (Program.cs) is provided to demonstrate the functionality of the system. It creates instances of Person, Suite, and Reservation classes, simulating a booking scenario. The application displays reservation details, including guest information, suite details, duration of stay, and total price.

## 5. Conclusion:
The Hotel Reservation System implemented in C#/.NET provides a robust solution for managing hotel bookings efficiently. It leverages object-oriented programming concepts to create reusable and maintainable code. The system's modular design allows for easy expansion and customization to meet specific business requirements.

## 6. Future Enhancements:
- Integration with a database for persistent storage of guest information and reservations.
- Implementation of user interfaces for a more user-friendly booking experience.
- Addition of features such as room service requests and payment processing.

Overall, the system serves as a foundation for developing a comprehensive hotel management application, catering to the needs of both guests and hotel staff.
