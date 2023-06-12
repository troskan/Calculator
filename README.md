Acceptance Tests for Calculator Application
============================================

Test 1: Addition Operation
--------------------------
Steps:
1. Start the application.
2. Choose the option '1' for Addition.
3. Enter the first number as 10.
4. Enter the second number as 20.
5. Observe the result displayed.

Expected Result:
- The system should display "Result: 30".


Test 2: Subtraction Operation with Negative Result
---------------------------------------------------
Steps:
1. Start the application.
2. Choose the option '2' for Subtraction.
3. Enter the first number as 5.
4. Enter the second number as 10.
5. Observe the result displayed.

Expected Result:
- The system should display "Result: -5".


Test 3: Division by Zero
------------------------
Steps:
1. Start the application.
2. Choose the option '4' for Division.
3. Enter the first number as 5.
4. Enter the second number as 0.
5. Observe the result displayed.

Expected Result:
- The system should display "Cannot divide by zero."


Test 4: Multiplication Operation
--------------------------------
Steps:
1. Start the application.
2. Choose the option '3' for Multiplication.
3. Enter the first number as 3.
4. Enter the second number as 7.
5. Observe the result displayed.

Expected Result:
- The system should display "Result: 21".


Test 5: Displaying Calculations History
---------------------------------------
Steps:
1. Start the application.
2. Perform a few calculations (at least 2).
3. Choose the option '5' to Show all calculations.
4. Observe the list of calculations displayed.

Expected Result:
- The system should display a list of calculations with details including ID, values used, operation, result, and date of calculation.
