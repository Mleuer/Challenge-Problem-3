using System;

namespace Challenge_Problem_3.Util
{
   public enum UserInput
    {
        W = 'w',
        A = 'a',
        S = 's',
        D = 'd',
        Space = '⎵'
    }

   public static class UserInputFactory
   {
       public static UserInput createFromChar(char c)
       {
           switch (c)
           {
               case 'W':
                   return UserInput.W;
               case 'A': 
                   return UserInput.A;
               case 'S':
                   return UserInput.S;
               case 'D':
                   return UserInput.D;
               case '⎵':
                   return UserInput.Space;
               default:
                   throw new ArgumentException("Argument must be one of: W, A, S, D, or ⎵");
           }
       }
   }
}