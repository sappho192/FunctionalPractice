﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPracticeCSharp
{
    namespace Functor { 
        public interface IFunction1<A1, B>
        {
            B Call(A1 in1);
        }
    }
}
