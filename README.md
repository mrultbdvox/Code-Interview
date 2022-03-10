# Introduction 
Coding Interview Exercise to be worked with an existing developer.  This exercise should be evaluated not only based on finding a solution, but also based on how well they collaborated with the interviewer.

# Test Overview
Consider a special family of Painters and Writers. This family has the following rules:

Everybody has two children.
The first child of an Painter is an Painter and the second child is a Writer.
The first child of a Writer is a Writer and the second child is an Painter.
All generations of Writers and Painters start with an Painter.
 
We can represent the situation using this diagram:
```
            P
       /         \
      P           W
    /   \        /  \
   P     W      W    P
  / \   / \    / \   / \
 P   W W   P  W   P P   W

 ```
 
Given the level and position of a person in the ancestor tree above, find the hobby of the person.
Note: in this tree first child is considered as left child, second - as right.

## Example

For level = 3 and pos = 3, the output should be
solution(level, pos) = "Writer".

# Getting Started

There are 3 projects in the solution located at src/FindHobby.sln
- FindHobby.Console:  This project allows you to run the application on the commmand line to evaluate results
- FindHobby.Core:  This is where the bulk of the work should be done.
- FindHobby.Tests:  A Test library provided with test cases to evaluate solution 

# Steps
1. Open the Solution class at FindHobby/FindHobby.Core/Solution.cs
2. Solve such that the above conditions are true
3. You can use the provided command line tool to evaluate process by running it as FindHobby.Console.exe [level] [position]
4. You can also use the provided tests to evaluate progress, however, you will need to set these up.  I've only provided working test cases.
