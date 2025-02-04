# Unexpected Behavior with Implicit Conversion Operators and Arithmetic Operations in C#

This example demonstrates a potential issue when using implicit conversion operators in C# with arithmetic operations.  Implicit conversion operators allow for seamless type conversions, but can lead to unexpected results when combined with operations that expect a specific type.

The `Bug.cs` file shows a class `MyClass` with implicit conversions to and from `int`. The `Main` method demonstrates how adding an integer to a `MyClass` object unexpectedly performs integer arithmetic rather than maintaining a `MyClass` object.

The `BugSolution.cs` file provides a solution to handle the arithmetic operation appropriately, either by explicitly converting to an integer before arithmetic or by overloading the operators to handle custom class operations.