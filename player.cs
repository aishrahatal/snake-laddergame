﻿using System;
using System.Collections.Generic;
using System.Text;

namespace snake_ladder
{
    class player 
 {
       public string name; // used in program.cs
       public int currentposition;
       public int previousposition;
       
  
  public player()		// constructor implementation. 
{
            name = "";
  currentposition = 0;		// initialization of variables.
  previousposition= 0;

}
        

public int Rolling_dice()        // Rollingdie function.
{
            Random random = new Random();
            return random.Next(1,7);  // using Random function.
}


}
}
�
