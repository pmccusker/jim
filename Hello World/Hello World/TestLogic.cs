﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    public class TestLogic
    {
        public int go(int iCount)
        {
            int iRet = 0;
            for (int i = 0; i < iCount; i++)
            {
                //Break the test
                if (i == 10) continue;

                iRet += i;
            }

            return iRet;
        }
    }
}
