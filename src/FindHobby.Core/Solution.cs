using System;

namespace FindHobby.Core
{
    /*
     Consider a special family of Painters and Writers. This family has the following rules:

     Everybody has two children.
     The first child of an Painter is an Painter and the second child is a Writer.
     The first child of a Writer is a Writer and the second child is an Painter.
     All generations of Writers and Painters start with an Painter.
      
     We can represent the situation using this diagram:

                 P
            /         \
           P           W
         /   \        /  \
        P     W      W    P
       / \   / \    / \   / \
      P   W W   P  W   P P   W

    Given the level and position of a person in the ancestor tree above, find the hobby of the person.
    Note: in this tree first child is considered as left child, second - as right.

    Example

    For level = 3 and pos = 3, the output should be
    solution(level, pos) = "Writer".



     */
    public static class Solution
    {
        public static Hobby Find(int level, int pos)
        {
            return Hobby.Painter;
        }
    }
}
