﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class IncorrectMovieYearFormat : FormatException
    {
        public IncorrectMovieYearFormat() 
            : base ("Incorrect Year format")
        {
        }

        public IncorrectMovieYearFormat(string message, params object[] args)
            :base(String.Format(message, args))
        {
        }
    }
    
}
