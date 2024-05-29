# Control Flow

## If/Else

- You have a condition. If that condition is true, the statement is evaluated
- Else, if the condition is false, the else statement is evaluated

```csharp
if (condition) someStatement
else if (anotherCondition) anotherStatement
else yetAnotherstatement
```

- If you have 1 line of code, you may or may not include the statements within curly braces. However, if you have multiple statements, they need to be enclosed in curly braces

```csharp
if (condition) someStatement;
else if (anotherCondition) {
    anotherStatement;
}
else {
    firstStatement;
    secondStatement;
    thirdStatement;
}
```

## Nested If Statements

- Note that it's not good to have nested if-else statements, since it makes the code difficult for others to read

```csharp
if (condition) {
    if (anotherCondition)
        ...
    else
        ...
}
```

## Switch Statements

```csharp
switch(role)
{
    case Role.Admin:
        ...
        break;
    case Role.Moderator:
        ...
        break;
    default:
        ...
        break;
}
```

- Note that you can combine two switches with the same statement by doing
  ```csharp
  case Role.Admin:
  case Role.Moderator:
    ...
    break;
  ```

## Exercises

### Exercise 1

Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)

- [Solution 1](https://github.com/jayjanodia/Csharp-Tutorial/blob/master/3.%20Control%20Flow/Solution1.cs)

### Exercise 2

Write a program which takes two numbers from the console and displays the maximum of the two.

- [Solution 2](https://github.com/jayjanodia/Csharp-Tutorial/blob/master/3.%20Control%20Flow/Solution2.cs)

### Exercise 3

Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

- [Solution 3](https://github.com/jayjanodia/Csharp-Tutorial/blob/master/3.%20Control%20Flow/Solution3.cs)

### Exercise 4

Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

- [Solution 4](https://github.com/jayjanodia/Csharp-Tutorial/blob/master/3.%20Control%20Flow/Solution4.cs)
